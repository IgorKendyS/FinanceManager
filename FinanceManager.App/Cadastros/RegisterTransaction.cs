using FinanceManager.App.Base;
using FinanceManager.Domain.Base;
using FinanceManager.Domain.Entities;
using FinanceManager.Service.Validators;
using System.Globalization;

namespace FinanceManager.App.Cadastros
{
    public partial class RegisterTransaction : CadastroBase
    {
        private readonly IBaseService<Transaction> _transactionService;
        private readonly IBaseService<Category> _categoryService;
        private readonly IBaseService<PaymentMethod> _paymentMethodService;
        private readonly IBaseService<User> _userService;
        public RegisterTransaction(IBaseService<Transaction> transactionService,
                                    IBaseService<Category> categoryService,
                                    IBaseService<PaymentMethod> paymentMethodService,
                                    IBaseService<User> userService)
        {
            _transactionService = transactionService;
            _categoryService = categoryService;
            _paymentMethodService = paymentMethodService;
            _userService = userService;

            InitializeComponent();
            CarregarCombo();
            Novo();
        }

        private void CarregarCombo()
        {
            var paymentMethod = _paymentMethodService.Get<PaymentMethod>().ToList();
            cboPaymentMethod.ValueMember = "Id";
            cboPaymentMethod.DisplayMember = "Name";
            cboPaymentMethod.DataSource = paymentMethod;

            cboPaymentMethod.SelectedIndexChanged += CboPaymentMethod_SelectedIndexChanged;

            var categorias = _categoryService.Get<Category>().ToList();

            // Adicionar a opção vazia como primeiro item
            categorias.Insert(0, new Category { Id = 0, Name = "" });

            cboCategory.ValueMember = "Id";
            cboCategory.DisplayMember = "Name";
            cboCategory.DataSource = categorias;

            cboCategory.SelectedIndexChanged += CboCategory_SelectedIndexChanged;
        }

        private void CboPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPaymentMethod.SelectedValue != null && int.TryParse(cboPaymentMethod.SelectedValue.ToString(), out int paymentMethodId) && paymentMethodId >= 0)
            {
                txtIdUser.Text = paymentMethodId.ToString();
            }
            else
            {
                txtIdUser.Text = "";
            }
        }

        private void CboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCategory.SelectedValue != null && int.TryParse(cboCategory.SelectedValue.ToString(), out int categoryId) && categoryId > 0)
            {
                txtCategoryId.Text = categoryId.ToString();
            }
            else
            {
                txtCategoryId.Text = "";
            }
        }

        private void PreencheObjeto(Transaction transaction)
        {
            if(int.TryParse(txtIdUser.Text, out var userId))
            {
                transaction.UserId = userId;
            }

            if (decimal.TryParse(txtValue.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out var value))
            {
                transaction.Amount = value;
            }

            if (int.TryParse(cboPaymentMethod.SelectedValue?.ToString(), out var paymentMethodId))
            {
                transaction.PaymentMethodId = paymentMethodId;
            }

            if (DateTime.TryParse(txtTransactionDate.Text, out var transactionDate))
            {
                transaction.Date = transactionDate;
            }

            transaction.Description = txtDescription.Text;

            if (int.TryParse(txtCategoryId.Text, out var categoryId))
            {
                transaction.CategoryId = categoryId;
            }
        }

        protected override void Novo()
        {
            base.Novo();
            txtIdUser.Text = "";
            txtCategoryId.Text = "";
            txtValue.Text = "";
            txtTransactionDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtDescription.Text = "";
        }

        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao && int.TryParse(txtIdUser.Text, out var id))
                {
                    var transaction = _transactionService.GetById<Transaction>(id);
                    PreencheObjeto(transaction);
                    _transactionService.Update<Transaction, Transaction, TransactionValidator>(transaction);
                }
                else
                {
                    var transaction = new Transaction();
                    PreencheObjeto(transaction);

                    _transactionService.Add<Transaction, Transaction, TransactionValidator>(transaction);
                }
                materialTabControl.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Finance Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void Deletar(int id)
        {
            try
            {
                _transactionService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Finance Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string GetUserById(int userId)
        {
            var user = _userService.GetById<User>(userId);
            return user?.Name ?? "Desconhecido";
        }

        private string GetCategoryById(int categoryId)
        {
            var category = _categoryService.GetById<Category>(categoryId);
            return category?.Name ?? "Sem categoria";
        }

        private string GetPaymentMethodName(int paymentMethodId)
        {
            return paymentMethodId switch
            {
                0 => "Crédito",
                1 => "Débito",
                2 => "Dinheiro",
                _ => "Desconhecido"
            };
        }

        protected override void CarregaGrid()
        {
            try
            {
                var transactions = _transactionService.Get<Transaction>().ToList();

                var transactionsDisplay = transactions.Select(t => new
                {
                    t.Id,
                    UserName = GetUserById(t.UserId),
                    Amount = t.Amount.ToString("F2", CultureInfo.InvariantCulture),
                    PaymentMethod = GetPaymentMethodName(t.PaymentMethodId ?? -1),
                    CategoryName = GetCategoryById(t.CategoryId),
                    t.Date,
                    t.Description
                }).ToList();

                dataGridViewConsulta.DataSource = transactionsDisplay;

                if (dataGridViewConsulta.Columns["Description"] != null)
                {
                    dataGridViewConsulta.Columns["Description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar grid: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            if (linha == null) return;

            txtId.Text = linha.Cells["Id"].Value?.ToString();
            txtIdUser.Text = linha.Cells["UserId"].Value?.ToString();

            if (linha.Cells["Amount"].Value != null && decimal.TryParse(linha.Cells["Amount"].Value.ToString(), NumberStyles.Any, CultureInfo.InvariantCulture, out decimal amount))
            {
                txtValue.Text = amount.ToString("F2", CultureInfo.InvariantCulture);
            }
            else
            {
                txtValue.Text = "0.00";
            }

            txtTransactionDate.Text = linha.Cells["Date"].Value?.ToString();
            txtDescription.Text = linha.Cells["Description"].Value?.ToString();

            if (linha.Cells["PaymentMethod"].Value != null)
            {
                string paymentMethodName = linha.Cells["PaymentMethod"].Value.ToString();
                cboPaymentMethod.SelectedIndex = cboPaymentMethod.Items.IndexOf(paymentMethodName);
            }


            if (linha.Cells["CategoryId"].Value != null && int.TryParse(linha.Cells["CategoryId"].Value.ToString(), out int categoryId))
            {
                cboCategory.SelectedValue = categoryId;
                txtCategoryId.Text = categoryId > 0 ? categoryId.ToString() : "";
            }
            else
            {
                cboCategory.SelectedIndex = 0;
                txtCategoryId.Text = "";
            }
        }

    }
}
