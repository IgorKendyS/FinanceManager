using FinanceManager.App.Base;
using FinanceManager.App.Models;
using FinanceManager.Domain.Base;
using FinanceManager.Domain.Entities;
using FinanceManager.Service.Validators;
using Microsoft.VisualBasic.ApplicationServices;

namespace FinanceManager.App.Cadastros
{
    public partial class RegisterCategory : CadastroBase
    {
        private readonly IBaseService<Category> _categoryService;

        private List<Category>? categories;
        public RegisterCategory(IBaseService<Category> categoryService)
        {
            _categoryService = categoryService;
            InitializeComponent();
        }

        private void PreencheObjeto(Category category)
        {
            category.Name = txtName.Text;
            category.Type = cboType.Text;
            category.Description = txtMLDescription.Text;
        }

        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao)
                {
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        var category = _categoryService.GetById<Category>(id);
                        PreencheObjeto(category);
                        category = _categoryService.Update<Category, Category, CategoryValidator>(category);
                    }
                }
                else
                {
                    var category = new Category();
                    PreencheObjeto(category);
                    _categoryService.Add<Category, Category, CategoryValidator>(category);
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
                _categoryService.Delete(id);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Finance Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            categories = _categoryService.Get<CategoryModel>().ToList();
            dataGridViewConsulta.DataSource = categories;
            dataGridViewConsulta.Columns["PasswordHash"]!.Visible = false;
            dataGridViewConsulta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtName.Text = linha?.Cells["Name"].Value.ToString();
            txtMLDescription.Text = linha?.Cells["Description"].Value.ToString();
        }
    }
}
