namespace FinanceManager.App.Cadastros
{
    partial class RegisterCategory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtName = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtMLDescription = new ReaLTaiizor.Controls.MaterialMultiLineTextBoxEdit();
            cboType = new ReaLTaiizor.Controls.MaterialComboBox();
            tabPageCadastro.SuspendLayout();
            materialTabControl.SuspendLayout();
            SuspendLayout();
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(cboType);
            tabPageCadastro.Controls.Add(txtMLDescription);
            tabPageCadastro.Controls.Add(txtId);
            tabPageCadastro.Controls.Add(txtName);
            tabPageCadastro.Margin = new Padding(3, 5, 3, 5);
            tabPageCadastro.Padding = new Padding(3, 5, 3, 5);
            tabPageCadastro.Size = new Size(611, 336);
            tabPageCadastro.Controls.SetChildIndex(btnCancelar, 0);
            tabPageCadastro.Controls.SetChildIndex(btnSalvar, 0);
            tabPageCadastro.Controls.SetChildIndex(txtName, 0);
            tabPageCadastro.Controls.SetChildIndex(txtId, 0);
            tabPageCadastro.Controls.SetChildIndex(txtMLDescription, 0);
            tabPageCadastro.Controls.SetChildIndex(cboType, 0);
            // 
            // materialTabControl
            // 
            materialTabControl.Location = new Point(3, 113);
            materialTabControl.Margin = new Padding(3, 5, 3, 5);
            materialTabControl.Size = new Size(619, 371);
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(379, 283);
            btnCancelar.Margin = new Padding(6, 11, 6, 11);
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(521, 283);
            btnSalvar.Margin = new Padding(6, 11, 6, 11);
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(457, 532);
            btnEditar.Margin = new Padding(6, 11, 6, 11);
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(363, 532);
            btnNovo.Margin = new Padding(6, 11, 6, 11);
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(560, 532);
            btnExcluir.Margin = new Padding(6, 11, 6, 11);
            // 
            // txtName
            // 
            txtName.AnimateReadOnly = false;
            txtName.AutoCompleteMode = AutoCompleteMode.None;
            txtName.AutoCompleteSource = AutoCompleteSource.None;
            txtName.BackgroundImageLayout = ImageLayout.None;
            txtName.CharacterCasing = CharacterCasing.Normal;
            txtName.Depth = 0;
            txtName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtName.HideSelection = true;
            txtName.Hint = "Nome da Categoria";
            txtName.LeadingIcon = null;
            txtName.Location = new Point(7, 8);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.MaxLength = 32767;
            txtName.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtName.Name = "txtName";
            txtName.PasswordChar = '\0';
            txtName.PrefixSuffixText = null;
            txtName.ReadOnly = false;
            txtName.RightToLeft = RightToLeft.No;
            txtName.SelectedText = "";
            txtName.SelectionLength = 0;
            txtName.SelectionStart = 0;
            txtName.ShortcutsEnabled = true;
            txtName.Size = new Size(314, 48);
            txtName.TabIndex = 2;
            txtName.TabStop = false;
            txtName.TextAlign = HorizontalAlignment.Left;
            txtName.TrailingIcon = null;
            txtName.UseSystemPasswordChar = false;
            // 
            // txtId
            // 
            txtId.AnimateReadOnly = false;
            txtId.AutoCompleteMode = AutoCompleteMode.None;
            txtId.AutoCompleteSource = AutoCompleteSource.None;
            txtId.BackgroundImageLayout = ImageLayout.None;
            txtId.CharacterCasing = CharacterCasing.Normal;
            txtId.Depth = 0;
            txtId.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtId.HideSelection = true;
            txtId.Hint = "ID";
            txtId.LeadingIcon = null;
            txtId.Location = new Point(521, 8);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.MaxLength = 32767;
            txtId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtId.Name = "txtId";
            txtId.PasswordChar = '\0';
            txtId.PrefixSuffixText = null;
            txtId.ReadOnly = false;
            txtId.RightToLeft = RightToLeft.No;
            txtId.SelectedText = "";
            txtId.SelectionLength = 0;
            txtId.SelectionStart = 0;
            txtId.ShortcutsEnabled = true;
            txtId.Size = new Size(67, 48);
            txtId.TabIndex = 3;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // txtMLDescription
            // 
            txtMLDescription.AnimateReadOnly = false;
            txtMLDescription.BackgroundImageLayout = ImageLayout.None;
            txtMLDescription.CharacterCasing = CharacterCasing.Normal;
            txtMLDescription.Depth = 0;
            txtMLDescription.HideSelection = true;
            txtMLDescription.Hint = "Descrição (OPCIONAL)";
            txtMLDescription.Location = new Point(7, 80);
            txtMLDescription.Margin = new Padding(3, 4, 3, 4);
            txtMLDescription.MaxLength = 32767;
            txtMLDescription.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtMLDescription.Name = "txtMLDescription";
            txtMLDescription.PasswordChar = '\0';
            txtMLDescription.ReadOnly = false;
            txtMLDescription.ScrollBars = ScrollBars.None;
            txtMLDescription.SelectedText = "";
            txtMLDescription.SelectionLength = 0;
            txtMLDescription.SelectionStart = 0;
            txtMLDescription.ShortcutsEnabled = true;
            txtMLDescription.Size = new Size(582, 188);
            txtMLDescription.TabIndex = 4;
            txtMLDescription.TabStop = false;
            txtMLDescription.TextAlign = HorizontalAlignment.Left;
            txtMLDescription.UseSystemPasswordChar = false;
            // 
            // cboType
            // 
            cboType.AutoResize = false;
            cboType.BackColor = Color.FromArgb(255, 255, 255);
            cboType.Depth = 0;
            cboType.DrawMode = DrawMode.OwnerDrawVariable;
            cboType.DropDownHeight = 174;
            cboType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboType.DropDownWidth = 121;
            cboType.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboType.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboType.FormattingEnabled = true;
            cboType.IntegralHeight = false;
            cboType.ItemHeight = 43;
            cboType.Items.AddRange(new object[] { "Entrada", "Saída" });
            cboType.Location = new Point(328, 8);
            cboType.Margin = new Padding(3, 4, 3, 4);
            cboType.MaxDropDownItems = 4;
            cboType.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboType.Name = "cboType";
            cboType.Size = new Size(186, 49);
            cboType.StartIndex = 0;
            cboType.TabIndex = 5;
            // 
            // RegisterCategory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(625, 489);
            Location = new Point(0, 0);
            Margin = new Padding(3, 5, 3, 5);
            Name = "RegisterCategory";
            Padding = new Padding(3, 113, 3, 5);
            Text = "Cadastro Categoria";
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            materialTabControl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialComboBox cboType;
        private ReaLTaiizor.Controls.MaterialMultiLineTextBoxEdit txtMLDescription;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtName;
    }
}