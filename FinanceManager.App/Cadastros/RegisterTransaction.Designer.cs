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
            txtDescription = new ReaLTaiizor.Controls.MaterialMultiLineTextBoxEdit();
            txtIdUser = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cboPaymentMethod = new ReaLTaiizor.Controls.MaterialComboBox();
            cboCategory = new ReaLTaiizor.Controls.MaterialComboBox();
            txtTransactionDate = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtValue = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtCategoryId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tabPageCadastro.SuspendLayout();
            materialTabControl.SuspendLayout();
            SuspendLayout();
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(txtId);
            tabPageCadastro.Controls.Add(txtValue);
            tabPageCadastro.Controls.Add(txtTransactionDate);
            tabPageCadastro.Controls.Add(cboCategory);
            tabPageCadastro.Controls.Add(cboPaymentMethod);
            tabPageCadastro.Controls.Add(txtCategoryId);
            tabPageCadastro.Controls.Add(txtIdUser);
            tabPageCadastro.Controls.Add(txtDescription);
            tabPageCadastro.Location = new Point(4, 31);
            tabPageCadastro.Size = new Size(525, 274);
            tabPageCadastro.Controls.SetChildIndex(txtDescription, 0);
            tabPageCadastro.Controls.SetChildIndex(txtIdUser, 0);
            tabPageCadastro.Controls.SetChildIndex(txtCategoryId, 0);
            tabPageCadastro.Controls.SetChildIndex(cboPaymentMethod, 0);
            tabPageCadastro.Controls.SetChildIndex(cboCategory, 0);
            tabPageCadastro.Controls.SetChildIndex(txtTransactionDate, 0);
            tabPageCadastro.Controls.SetChildIndex(txtValue, 0);
            tabPageCadastro.Controls.SetChildIndex(btnCancelar, 0);
            tabPageCadastro.Controls.SetChildIndex(btnSalvar, 0);
            tabPageCadastro.Controls.SetChildIndex(txtId, 0);
            // 
            // materialTabControl
            // 
            materialTabControl.Size = new Size(533, 309);
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(330, 222);
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(434, 222);
            // 
            // txtDescription
            // 
            txtDescription.AnimateReadOnly = false;
            txtDescription.BackgroundImageLayout = ImageLayout.None;
            txtDescription.CharacterCasing = CharacterCasing.Normal;
            txtDescription.Depth = 0;
            txtDescription.HideSelection = true;
            txtDescription.Hint = "Desrição (opcional)";
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
            cboPaymentMethod.Location = new Point(145, 6);
            cboPaymentMethod.MaxDropDownItems = 4;
            cboPaymentMethod.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboPaymentMethod.Name = "cboPaymentMethod";
            cboPaymentMethod.Size = new Size(143, 49);
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
            cboCategory.Hint = "Categoria";
            cboCategory.IntegralHeight = false;
            cboCategory.ItemHeight = 43;
            cboCategory.Location = new Point(254, 147);
            cboCategory.MaxDropDownItems = 4;
            cboCategory.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(256, 49);
            cboCategory.StartIndex = 0;
            cboCategory.TabIndex = 9;
            // 
            // txtTransactionDate
            // 
            txtTransactionDate.AllowPromptAsInput = true;
            txtTransactionDate.AnimateReadOnly = false;
            txtTransactionDate.AsciiOnly = false;
            txtTransactionDate.BackgroundImageLayout = ImageLayout.None;
            txtTransactionDate.BeepOnError = false;
            txtTransactionDate.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtTransactionDate.Depth = 0;
            txtTransactionDate.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTransactionDate.HidePromptOnLeave = false;
            txtTransactionDate.HideSelection = true;
            txtTransactionDate.Hint = "Data de Transação";
            txtTransactionDate.InsertKeyMode = InsertKeyMode.Default;
            txtTransactionDate.LeadingIcon = null;
            txtTransactionDate.Location = new Point(294, 6);
            txtTransactionDate.Mask = "00/00/0000";
            txtTransactionDate.MaxLength = 32767;
            txtTransactionDate.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtTransactionDate.Name = "txtTransactionDate";
            txtTransactionDate.PasswordChar = '\0';
            txtTransactionDate.PrefixSuffixText = null;
            txtTransactionDate.PromptChar = '_';
            txtTransactionDate.ReadOnly = false;
            txtTransactionDate.RejectInputOnFirstFailure = false;
            txtTransactionDate.ResetOnPrompt = true;
            txtTransactionDate.ResetOnSpace = true;
            txtTransactionDate.RightToLeft = RightToLeft.No;
            txtTransactionDate.SelectedText = "";
            txtTransactionDate.SelectionLength = 0;
            txtTransactionDate.SelectionStart = 0;
            txtTransactionDate.ShortcutsEnabled = true;
            txtTransactionDate.Size = new Size(132, 48);
            txtTransactionDate.SkipLiterals = true;
            txtTransactionDate.TabIndex = 10;
            txtTransactionDate.TabStop = false;
            txtTransactionDate.Text = "  /  /";
            txtTransactionDate.TextAlign = HorizontalAlignment.Left;
            txtTransactionDate.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtTransactionDate.TrailingIcon = null;
            txtTransactionDate.UseSystemPasswordChar = false;
            txtTransactionDate.ValidatingType = null;
            // 
            // txtValue
            // 
            txtValue.AllowPromptAsInput = true;
            txtValue.AnimateReadOnly = false;
            txtValue.AsciiOnly = false;
            txtValue.BackgroundImageLayout = ImageLayout.None;
            txtValue.BeepOnError = false;
            txtValue.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtValue.Depth = 0;
            txtValue.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtValue.HidePromptOnLeave = false;
            txtValue.HideSelection = true;
            txtValue.Hint = "Valor";
            txtValue.InsertKeyMode = InsertKeyMode.Default;
            txtValue.LeadingIcon = null;
            txtValue.Location = new Point(6, 6);
            txtValue.Mask = "";
            txtValue.MaxLength = 32767;
            txtValue.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtValue.Name = "txtValue";
            txtValue.PasswordChar = '\0';
            txtValue.PrefixSuffixText = null;
            txtValue.PromptChar = '_';
            txtValue.ReadOnly = false;
            txtValue.RejectInputOnFirstFailure = false;
            txtValue.ResetOnPrompt = true;
            txtValue.ResetOnSpace = true;
            txtValue.RightToLeft = RightToLeft.No;
            txtValue.SelectedText = "";
            txtValue.SelectionLength = 0;
            txtValue.SelectionStart = 0;
            txtValue.ShortcutsEnabled = true;
            txtValue.Size = new Size(133, 48);
            txtValue.SkipLiterals = true;
            txtValue.TabIndex = 11;
            txtValue.TabStop = false;
            txtValue.TextAlign = HorizontalAlignment.Left;
            txtValue.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtValue.TrailingIcon = null;
            txtValue.UseSystemPasswordChar = false;
            txtValue.ValidatingType = null;
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
            txtCategoryId.ReadOnly = true;
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
            txtId.Location = new Point(434, 6);
            txtId.MaxLength = 32767;
            txtId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtId.Name = "txtId";
            txtId.PasswordChar = '\0';
            txtId.PrefixSuffixText = null;
            txtId.ReadOnly = true;
            txtId.RightToLeft = RightToLeft.No;
            txtId.SelectedText = "";
            txtId.SelectionLength = 0;
            txtId.SelectionStart = 0;
            txtId.ShortcutsEnabled = true;
            txtId.Size = new Size(76, 48);
            txtId.TabIndex = 12;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // RegisterTransaction
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(539, 376);
            Location = new Point(0, 0);
            Name = "RegisterTransaction";
            Text = "Registro de Transação";
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            materialTabControl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ReaLTaiizor.Controls.MaterialMultiLineTextBoxEdit txtDescription;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtIdUser;
        private ReaLTaiizor.Controls.MaterialComboBox cboPaymentMethod;
        private ReaLTaiizor.Controls.MaterialComboBox cboCategory;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtValue;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtTransactionDate;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCategoryId;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
    }
}