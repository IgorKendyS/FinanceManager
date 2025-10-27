using FinanceManager.App.Base;
using FinanceManager.App.Models;
using FinanceManager.Domain.Base;
using FinanceManager.Domain.Entities;
using FinanceManager.Service.Validators;
using Microsoft.EntityFrameworkCore;

namespace FinanceManager.App.Cadastros
{
    public partial class RegisterPaymentMethod : CadastroBase
    {
        private readonly IBaseService<PaymentMethod> _paymentMethodService;
        private List<PaymentMethodModel>? paymentMethods;

        public RegisterPaymentMethod(IBaseService<PaymentMethod> paymentMethodService)
        {
            _paymentMethodService = paymentMethodService;
            InitializeComponent();
            cboType.SelectedIndexChanged += CboType_SelectedIndexChanged;
            txtLimit.Visible = false;
        }

        private void CboType_SelectedIndexChanged(object? sender, EventArgs e)
        {
            txtLimit.Visible = cboType.SelectedItem?.ToString() == "Crédito";
        }

        private void PreencheObjeto(PaymentMethod paymentMethod)
        {
            paymentMethod.Name = txtName.Text;
            paymentMethod.Type = cboType.SelectedItem?.ToString() ?? "";

            // TODO: Replace with the ID of the currently logged-in user
            paymentMethod.UserId = 1; 

            if (paymentMethod.Type == "Crédito" && decimal.TryParse(txtLimit.Text, out var limit))
                paymentMethod.CardLimit = limit;
            else
                paymentMethod.CardLimit = null;
        }

        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao && int.TryParse(txtId.Text, out var id))
                {
                    var paymentMethod = _paymentMethodService.GetById<PaymentMethod>(id);
                    PreencheObjeto(paymentMethod);
                    _paymentMethodService.Update<PaymentMethod, PaymentMethod, PaymentMethodValidator>(paymentMethod);
                }
                else
                {
                    var paymentMethod = new PaymentMethod();
                    PreencheObjeto(paymentMethod);
                    _paymentMethodService.Add<PaymentMethod, PaymentMethod, PaymentMethodValidator>(paymentMethod);
                }

                materialTabControl.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Finance Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void Deletar(int id)
        {
            try
            {
                _paymentMethodService.Delete(id);
            }
            catch (DbUpdateException)
            {
                MessageBox.Show("Não é possível excluir este método de pagamento, pois ele já está sendo utilizado em transações.", "Erro de Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Finance Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            paymentMethods = _paymentMethodService.Get<PaymentMethodModel>().ToList();
            dataGridViewConsulta.DataSource = paymentMethods;
            dataGridViewConsulta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtName.Text = linha?.Cells["Name"].Value.ToString();
            cboType.SelectedItem = linha?.Cells["Type"].Value.ToString();

            if (cboType.SelectedItem?.ToString() == "Crédito")
            {
                txtLimit.Text = linha?.Cells["CardLimit"].Value?.ToString() ?? "0";
                txtLimit.Visible = true;

            }
            else
            {
                txtLimit.Visible = false;
            }
        }
    }
}
