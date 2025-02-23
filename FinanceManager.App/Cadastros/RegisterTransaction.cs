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

        public RegisterTransaction(IBaseService<Transaction> transactionService,
                                    IBaseService<Category> categoryService)
        {
            _transactionService = transactionService;
            _categoryService = categoryService;

            InitializeComponent();
            CarregarCombo();
            Novo();
        }

        private void CarregarCombo()
        {
            cboPaymentMethod.Items.Add("Crédito");
            cboPaymentMethod.Items.Add("Débito");
            cboPaymentMethod.Items.Add("Dinheiro");

            cboCategory.ValueMember = "Id";
            cboCategory.DisplayMember = "Name";
            cboCategory.DataSource = _categoryService.Get<Category>().ToList();
        }

        private void PreencheObjeto(Transaction transaction)
        {
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

            if (int.TryParse(cboCategory.SelectedValue?.ToString(), out var categoryId))
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
    }
}
