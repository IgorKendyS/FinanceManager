using FinanceManager.App.Cadastros;
using FinanceManager.App.Infra;
using FinanceManager.App.Outros;
using Microsoft.Extensions.DependencyInjection;
using ReaLTaiizor.Forms;

// wpp 18981007529
namespace FinanceManager.App
{
    public partial class FormPrincipal : MaterialForm
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exibeformulario<CadastroUsuario>();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exibeformulario<RegisterCategory>();
        }

        private void metodoDePagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exibeformulario<RegisterPaymentMethod>();
        }

        private void registrarTransacaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exibeformulario<RegisterTransaction>();
        }

        private void graficosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exibeformulario<Reports>();
        }

        private void Exibeformulario<TFormlario>() where TFormlario : Form
        {
            // Check if a form of this type is already open among the MDI children
            var existingForm = this.MdiChildren.OfType<TFormlario>().FirstOrDefault();

            if (existingForm != null)
            {
                // If the form exists, bring it to the front
                existingForm.BringToFront();
            }
            else
            {
                // If it doesn't exist, create a new one using DI
                var newForm = ConfigureDI.ServicesProvider!.GetService<TFormlario>();
                if (newForm != null && !newForm.IsDisposed)
                {
                    newForm.MdiParent = this;
                    newForm.Show();
                }
            }
        }

    }
}