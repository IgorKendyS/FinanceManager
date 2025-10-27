using FinanceManager.App.Base;
using FinanceManager.App.Models;
using FinanceManager.Domain.Base;
using FinanceManager.Domain.Entities;
using FinanceManager.Service.Validators;
using System.Diagnostics;

namespace FinanceManager.App.Cadastros
{
    public partial class CadastroUsuario : CadastroBase
    {
        private readonly IBaseService<User> _userService;

        private List<UserModel>? users;

        public CadastroUsuario(IBaseService<User> userService)
        {
            _userService = userService;
            InitializeComponent();
        }

        private void PreencheObjeto(User user)
        {
            user.Name = txtNome.Text;
            user.Email = txtEmail.Text;
            user.PasswordHash = txtSenha.Text;
            user.Phone = txtTelefone.Text;

            if (user.Id == 0)
            {
                user.Created = DateTime.Now;
                user.LastLogin = DateTime.Now;
            }
        }
        

        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao)
                {
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        var user = _userService.GetById<User>(id);
                        PreencheObjeto(user);
                        user = _userService.Update<User, User, UserValidator>(user);
                    }
                }
                else
                {
                    var user = new User();
                    PreencheObjeto(user);
                    Debug.WriteLine(user);
                    _userService.Add<User, User, UserValidator>(user);
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
                _userService.Delete(id);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Finance Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            users = _userService.Get<UserModel>().ToList();
            dataGridViewConsulta.DataSource = users;
            dataGridViewConsulta.Columns["PasswordHash"]!.Visible = false;
            dataGridViewConsulta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtNome.Text = linha?.Cells["Name"].Value.ToString();
            txtEmail.Text = linha?.Cells["Email"].Value.ToString();
            txtTelefone.Text = linha?.Cells["Phone"].Value.ToString();
            txtSenha.Text = linha?.Cells["PasswordHash"].Value.ToString();

            txtDataCadastro.Text = DateTime.TryParse(linha?.Cells["Created"].Value.ToString(), out var dataC)
                ? dataC.ToString("g")
                : "";

            txtDataUltimoLogin.Text = DateTime.TryParse(linha?.Cells["LastLogin"].Value.ToString(), out var dataL)
                ? dataL.ToString("g")
                : "";
        }
    }
}