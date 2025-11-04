namespace FinanceManager.App.Cadastros
{
    partial class RegisterPaymentMethod
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
            txtLimit = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cboType = new ReaLTaiizor.Controls.MaterialComboBox();
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtUserId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tabPageCadastro.SuspendLayout();
            materialTabControl.SuspendLayout();
            SuspendLayout();
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(txtUserId);
            tabPageCadastro.Controls.Add(txtId);
            tabPageCadastro.Controls.Add(cboType);
            tabPageCadastro.Controls.Add(txtLimit);
            tabPageCadastro.Controls.Add(txtName);
            tabPageCadastro.Size = new Size(523, 348);
            tabPageCadastro.Controls.SetChildIndex(btnCancelar, 0);
            tabPageCadastro.Controls.SetChildIndex(btnSalvar, 0);
            tabPageCadastro.Controls.SetChildIndex(txtName, 0);
            tabPageCadastro.Controls.SetChildIndex(txtLimit, 0);
            tabPageCadastro.Controls.SetChildIndex(cboType, 0);
            tabPageCadastro.Controls.SetChildIndex(txtId, 0);
            tabPageCadastro.Controls.SetChildIndex(txtUserId, 0);
            // 
            // materialTabControl
            // 
            materialTabControl.Size = new Size(531, 383);
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
            txtName.Hint = "Nome";
            txtName.LeadingIcon = null;
            txtName.Location = new Point(6, 6);
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
            txtName.Size = new Size(419, 48);
            txtName.TabIndex = 2;
            txtName.TabStop = false;
            txtName.TextAlign = HorizontalAlignment.Left;
            txtName.TrailingIcon = null;
            txtName.UseSystemPasswordChar = false;
            // 
            // txtLimit
            // 
            txtLimit.AnimateReadOnly = false;
            txtLimit.AutoCompleteMode = AutoCompleteMode.None;
            txtLimit.AutoCompleteSource = AutoCompleteSource.None;
            txtLimit.BackgroundImageLayout = ImageLayout.None;
            txtLimit.CharacterCasing = CharacterCasing.Normal;
            txtLimit.Depth = 0;
            txtLimit.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtLimit.HideSelection = true;
            txtLimit.Hint = "Limite";
            txtLimit.LeadingIcon = null;
            txtLimit.Location = new Point(181, 60);
            txtLimit.MaxLength = 32767;
            txtLimit.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtLimit.Name = "txtLimit";
            txtLimit.PasswordChar = '\0';
            txtLimit.PrefixSuffixText = null;
            txtLimit.ReadOnly = false;
            txtLimit.RightToLeft = RightToLeft.No;
            txtLimit.SelectedText = "";
            txtLimit.SelectionLength = 0;
            txtLimit.SelectionStart = 0;
            txtLimit.ShortcutsEnabled = true;
            txtLimit.Size = new Size(198, 48);
            txtLimit.TabIndex = 3;
            txtLimit.TabStop = false;
            txtLimit.TextAlign = HorizontalAlignment.Left;
            txtLimit.TrailingIcon = null;
            txtLimit.UseSystemPasswordChar = false;
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
            cboType.Items.AddRange(new object[] { "PIX/Dinheiro", "Crédito", "Débito" });
            cboType.Location = new Point(6, 60);
            cboType.MaxDropDownItems = 4;
            cboType.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboType.Name = "cboType";
            cboType.Size = new Size(169, 49);
            cboType.StartIndex = 0;
            cboType.TabIndex = 4;
            // 
            // txtId
            // 
            txtId.AnimateReadOnly = false;
            txtId.AutoCompleteMode = AutoCompleteMode.None;
            txtId.AutoCompleteSource = AutoCompleteSource.None;
            txtId.BackgroundImageLayout = ImageLayout.None;
            txtId.CharacterCasing = CharacterCasing.Normal;
            txtId.Depth = 0;
            txtId.Enabled = false;
            txtId.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtId.HideSelection = true;
            txtId.Hint = "ID";
            txtId.LeadingIcon = null;
            txtId.Location = new Point(442, 6);
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
            txtId.Size = new Size(67, 48);
            txtId.TabIndex = 5;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // txtUserId
            // 
            txtUserId.AnimateReadOnly = false;
            txtUserId.AutoCompleteMode = AutoCompleteMode.None;
            txtUserId.AutoCompleteSource = AutoCompleteSource.None;
            txtUserId.BackgroundImageLayout = ImageLayout.None;
            txtUserId.CharacterCasing = CharacterCasing.Normal;
            txtUserId.Depth = 0;
            txtUserId.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtUserId.HideSelection = true;
            txtUserId.Hint = "ID Usuário";
            txtUserId.LeadingIcon = null;
            txtUserId.Location = new Point(385, 60);
            txtUserId.MaxLength = 32767;
            txtUserId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtUserId.Name = "txtUserId";
            txtUserId.PasswordChar = '\0';
            txtUserId.PrefixSuffixText = null;
            txtUserId.ReadOnly = false;
            txtUserId.RightToLeft = RightToLeft.No;
            txtUserId.SelectedText = "";
            txtUserId.SelectionLength = 0;
            txtUserId.SelectionStart = 0;
            txtUserId.ShortcutsEnabled = true;
            txtUserId.Size = new Size(124, 48);
            txtUserId.TabIndex = 6;
            txtUserId.TabStop = false;
            txtUserId.TextAlign = HorizontalAlignment.Left;
            txtUserId.TrailingIcon = null;
            txtUserId.UseSystemPasswordChar = false;
            txtUserId.Visible = false;
            // 
            // RegisterPaymentMethod
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(537, 450);
            Location = new Point(0, 0);
            Name = "RegisterPaymentMethod";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro Método de Pagamento";
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            materialTabControl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtName;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialComboBox cboType;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtLimit;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtUserId;
    }
}