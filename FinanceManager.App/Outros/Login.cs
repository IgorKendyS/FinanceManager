using FinanceManager.Domain.Base;
using FinanceManager.Domain.Entities;
using FinanceManager.Service.Validators;
using ReaLTaiizor.Forms;
using System.Security.Cryptography;
using System.Text;

namespace FinanceManager.App.Outros
{
    public partial class Login : MaterialForm
    {
        private readonly IBaseService<User> _userService;

        public Login(IBaseService<User> userService)
        {
            _userService = userService;
            InitializeComponent();
#if DEBUG
            txtLogin.Text = @"admin@gmail.com";
            txtSenha.Text = @"admin";
#endif
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            var user = ObterUsuario(txtLogin.Text, txtSenha.Text);

            if (user == null)
            {
                MessageBox.Show("Usuário e/ou senha inválido(s)!", "Finance Manager", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLogin.Focus();
            }
            else
            {
                user.LastLogin = DateTime.Now;
                _userService.Update<User, User, UserValidator>(user);
                FormPrincipal.User = user;
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private User? ObterUsuario(string login, string senha)
        {
            ChecaExistenciaDeUsuariosCadastrados();

            var user = _userService.Get<User>().FirstOrDefault(x => x.Email == login);
            if (user == null)
            {
                return null;
            }

            // TODO: Use a more secure password hashing and salting mechanism
            var passwordHash = ComputeSha256Hash(senha);

            return user.PasswordHash != passwordHash ? null : user;
        }

        private void ChecaExistenciaDeUsuariosCadastrados()
        {
            var users = _userService.Get<User>().ToList();
            if (!users.Any())
            {
                var user = new User
                {
                    Created = DateTime.Now,
                    LastLogin = DateTime.Now,
                    Name = "Administrador",
                    Email = "admin@gmail.com",
                    PasswordHash = ComputeSha256Hash("admin")
                };
                _userService.Add<User, User, UserValidator>(user);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private static string ComputeSha256Hash(string rawData)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
