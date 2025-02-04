using FinanceManager.App.Cadastros;
using FinanceManager.App.Infra;
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

        private void Exibeformulario<TFormlario>() where TFormlario : Form
        {
            var cad = ConfigureDI.ServicesProvider!.GetService<TFormlario>();
            if (cad != null && !cad.IsDisposed)
            {
                cad.MdiParent = this;
                cad.Show();
            }
        }
    }
}