namespace FinanceManager.App.Cadastros
{
    partial class RegisterTransaction
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
            txtAmount = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtDate = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtDescription = new ReaLTaiizor.Controls.MaterialMultiLineTextBoxEdit();
            txtIdUser = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtCategoryId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cboPaymentMethod = new ReaLTaiizor.Controls.MaterialComboBox();
            cboCategory = new ReaLTaiizor.Controls.MaterialComboBox();
            tabPageCadastro.SuspendLayout();
            materialTabControl.SuspendLayout();
            SuspendLayout();
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(cboCategory);
            tabPageCadastro.Controls.Add(cboPaymentMethod);
            tabPageCadastro.Controls.Add(txtCategoryId);
            tabPageCadastro.Controls.Add(txtIdUser);
            tabPageCadastro.Controls.Add(txtDescription);
            tabPageCadastro.Controls.Add(txtDate);
            tabPageCadastro.Controls.Add(txtAmount);
            tabPageCadastro.Size = new Size(517, 285);
            tabPageCadastro.Controls.SetChildIndex(btnCancelar, 0);
            tabPageCadastro.Controls.SetChildIndex(btnSalvar, 0);
            tabPageCadastro.Controls.SetChildIndex(txtAmount, 0);
            tabPageCadastro.Controls.SetChildIndex(txtDate, 0);
            tabPageCadastro.Controls.SetChildIndex(txtDescription, 0);
            tabPageCadastro.Controls.SetChildIndex(txtIdUser, 0);
            tabPageCadastro.Controls.SetChildIndex(txtCategoryId, 0);
            tabPageCadastro.Controls.SetChildIndex(cboPaymentMethod, 0);
            tabPageCadastro.Controls.SetChildIndex(cboCategory, 0);
            // 
            // materialTabControl
            // 
            materialTabControl.Size = new Size(525, 320);
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(330, 222);
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(434, 222);
            // 
            // txtAmount
            // 
            txtAmount.AnimateReadOnly = false;
            txtAmount.AutoCompleteMode = AutoCompleteMode.None;
            txtAmount.AutoCompleteSource = AutoCompleteSource.None;
            txtAmount.BackgroundImageLayout = ImageLayout.None;
            txtAmount.CharacterCasing = CharacterCasing.Normal;
            txtAmount.Depth = 0;
            txtAmount.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtAmount.HideSelection = true;
            txtAmount.Hint = "Valor";
            txtAmount.LeadingIcon = null;
            txtAmount.Location = new Point(6, 6);
            txtAmount.MaxLength = 32767;
            txtAmount.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtAmount.Name = "txtAmount";
            txtAmount.PasswordChar = '\0';
            txtAmount.PrefixSuffixText = null;
            txtAmount.ReadOnly = false;
            txtAmount.RightToLeft = RightToLeft.No;
            txtAmount.SelectedText = "";
            txtAmount.SelectionLength = 0;
            txtAmount.SelectionStart = 0;
            txtAmount.ShortcutsEnabled = true;
            txtAmount.Size = new Size(133, 48);
            txtAmount.TabIndex = 2;
            txtAmount.TabStop = false;
            txtAmount.TextAlign = HorizontalAlignment.Left;
            txtAmount.TrailingIcon = null;
            txtAmount.UseSystemPasswordChar = false;
            // 
            // txtDate
            // 
            txtDate.AnimateReadOnly = false;
            txtDate.AutoCompleteMode = AutoCompleteMode.None;
            txtDate.AutoCompleteSource = AutoCompleteSource.None;
            txtDate.BackgroundImageLayout = ImageLayout.None;
            txtDate.CharacterCasing = CharacterCasing.Normal;
            txtDate.Depth = 0;
            txtDate.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDate.HideSelection = true;
            txtDate.Hint = "Data da transação";
            txtDate.LeadingIcon = null;
            txtDate.Location = new Point(346, 6);
            txtDate.MaxLength = 32767;
            txtDate.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDate.Name = "txtDate";
            txtDate.PasswordChar = '\0';
            txtDate.PrefixSuffixText = null;
            txtDate.ReadOnly = false;
            txtDate.RightToLeft = RightToLeft.No;
            txtDate.SelectedText = "";
            txtDate.SelectionLength = 0;
            txtDate.SelectionStart = 0;
            txtDate.ShortcutsEnabled = true;
            txtDate.Size = new Size(166, 48);
            txtDate.TabIndex = 3;
            txtDate.TabStop = false;
            txtDate.TextAlign = HorizontalAlignment.Left;
            txtDate.TrailingIcon = null;
            txtDate.UseSystemPasswordChar = false;
            // 
            // txtDescription
            // 
            txtDescription.AnimateReadOnly = false;
            txtDescription.BackgroundImageLayout = ImageLayout.None;
            txtDescription.CharacterCasing = CharacterCasing.Normal;
            txtDescription.Depth = 0;
            txtDescription.HideSelection = true;
            txtDescription.Location = new Point(6, 61);
            txtDescription.MaxLength = 32767;
            txtDescription.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDescription.Name = "txtDescription";
            txtDescription.PasswordChar = '\0';
            txtDescription.ReadOnly = false;
            txtDescription.ScrollBars = ScrollBars.None;
            txtDescription.SelectedText = "";
            txtDescription.SelectionLength = 0;
            txtDescription.SelectionStart = 0;
            txtDescription.ShortcutsEnabled = true;
            txtDescription.Size = new Size(504, 81);
            txtDescription.TabIndex = 4;
            txtDescription.TabStop = false;
            txtDescription.TextAlign = HorizontalAlignment.Left;
            txtDescription.UseSystemPasswordChar = false;
            // 
            // txtIdUser
            // 
            txtIdUser.AnimateReadOnly = false;
            txtIdUser.AutoCompleteMode = AutoCompleteMode.None;
            txtIdUser.AutoCompleteSource = AutoCompleteSource.None;
            txtIdUser.BackgroundImageLayout = ImageLayout.None;
            txtIdUser.CharacterCasing = CharacterCasing.Normal;
            txtIdUser.Depth = 0;
            txtIdUser.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtIdUser.HideSelection = true;
            txtIdUser.Hint = "Id Usuário";
            txtIdUser.LeadingIcon = null;
            txtIdUser.Location = new Point(6, 148);
            txtIdUser.MaxLength = 32767;
            txtIdUser.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtIdUser.Name = "txtIdUser";
            txtIdUser.PasswordChar = '\0';
            txtIdUser.PrefixSuffixText = null;
            txtIdUser.ReadOnly = false;
            txtIdUser.RightToLeft = RightToLeft.No;
            txtIdUser.SelectedText = "";
            txtIdUser.SelectionLength = 0;
            txtIdUser.SelectionStart = 0;
            txtIdUser.ShortcutsEnabled = true;
            txtIdUser.Size = new Size(107, 48);
            txtIdUser.TabIndex = 5;
            txtIdUser.TabStop = false;
            txtIdUser.TextAlign = HorizontalAlignment.Left;
            txtIdUser.TrailingIcon = null;
            txtIdUser.UseSystemPasswordChar = false;
            // 
            // txtCategoryId
            // 
            txtCategoryId.AnimateReadOnly = false;
            txtCategoryId.AutoCompleteMode = AutoCompleteMode.None;
            txtCategoryId.AutoCompleteSource = AutoCompleteSource.None;
            txtCategoryId.BackgroundImageLayout = ImageLayout.None;
            txtCategoryId.CharacterCasing = CharacterCasing.Normal;
            txtCategoryId.Depth = 0;
            txtCategoryId.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCategoryId.HideSelection = true;
            txtCategoryId.Hint = "Id Catergoria";
            txtCategoryId.LeadingIcon = null;
            txtCategoryId.Location = new Point(119, 148);
            txtCategoryId.MaxLength = 32767;
            txtCategoryId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtCategoryId.Name = "txtCategoryId";
            txtCategoryId.PasswordChar = '\0';
            txtCategoryId.PrefixSuffixText = null;
            txtCategoryId.ReadOnly = false;
            txtCategoryId.RightToLeft = RightToLeft.No;
            txtCategoryId.SelectedText = "";
            txtCategoryId.SelectionLength = 0;
            txtCategoryId.SelectionStart = 0;
            txtCategoryId.ShortcutsEnabled = true;
            txtCategoryId.Size = new Size(129, 48);
            txtCategoryId.TabIndex = 6;
            txtCategoryId.TabStop = false;
            txtCategoryId.TextAlign = HorizontalAlignment.Left;
            txtCategoryId.TrailingIcon = null;
            txtCategoryId.UseSystemPasswordChar = false;
            // 
            // cboPaymentMethod
            // 
            cboPaymentMethod.AutoResize = false;
            cboPaymentMethod.BackColor = Color.FromArgb(255, 255, 255);
            cboPaymentMethod.Depth = 0;
            cboPaymentMethod.DrawMode = DrawMode.OwnerDrawVariable;
            cboPaymentMethod.DropDownHeight = 174;
            cboPaymentMethod.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPaymentMethod.DropDownWidth = 121;
            cboPaymentMethod.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboPaymentMethod.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboPaymentMethod.FormattingEnabled = true;
            cboPaymentMethod.IntegralHeight = false;
            cboPaymentMethod.ItemHeight = 43;
            cboPaymentMethod.Items.AddRange(new object[] { "Crédito", "Débito", "Dinheiro" });
            cboPaymentMethod.Location = new Point(145, 6);
            cboPaymentMethod.MaxDropDownItems = 4;
            cboPaymentMethod.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboPaymentMethod.Name = "cboPaymentMethod";
            cboPaymentMethod.Size = new Size(195, 49);
            cboPaymentMethod.StartIndex = 0;
            cboPaymentMethod.TabIndex = 8;
            // 
            // cboCategory
            // 
            cboCategory.AutoResize = false;
            cboCategory.BackColor = Color.FromArgb(255, 255, 255);
            cboCategory.Depth = 0;
            cboCategory.DrawMode = DrawMode.OwnerDrawVariable;
            cboCategory.DropDownHeight = 174;
            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategory.DropDownWidth = 121;
            cboCategory.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboCategory.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboCategory.FormattingEnabled = true;
            cboCategory.IntegralHeight = false;
            cboCategory.ItemHeight = 43;
            cboCategory.Location = new Point(254, 147);
            cboCategory.MaxDropDownItems = 4;
            cboCategory.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(195, 49);
            cboCategory.StartIndex = 0;
            cboCategory.TabIndex = 9;
            // 
            // RegisterTransaction
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 387);
            Location = new Point(0, 0);
            Name = "RegisterTransaction";
            Text = "Registro de Transação";
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            materialTabControl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtDate;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtAmount;
        private ReaLTaiizor.Controls.MaterialMultiLineTextBoxEdit txtDescription;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCategoryId;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtIdUser;
        private ReaLTaiizor.Controls.MaterialComboBox cboPaymentMethod;
        private ReaLTaiizor.Controls.MaterialComboBox cboCategory;
    }
}