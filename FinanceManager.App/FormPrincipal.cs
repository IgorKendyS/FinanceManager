using FinanceManager.App.Cadastros;
using FinanceManager.App.Infra;
using Microsoft.Extensions.DependencyInjection;
using ReaLTaiizor.Forms;

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
