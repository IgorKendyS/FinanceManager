namespace FinanceManager.App.Cadastros
{
    partial class CadastroUsuario
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
            txtNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtEmail = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtSenha = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtDataCadastro = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtDataUltimoLogin = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtTelefone = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            tabPageCadastro.SuspendLayout();
            materialTabControl.SuspendLayout();
            SuspendLayout();
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(txtTelefone);
            tabPageCadastro.Controls.Add(txtDataUltimoLogin);
            tabPageCadastro.Controls.Add(txtDataCadastro);
            tabPageCadastro.Controls.Add(txtSenha);
            tabPageCadastro.Controls.Add(txtEmail);
            tabPageCadastro.Controls.Add(txtId);
            tabPageCadastro.Controls.Add(txtNome);
            tabPageCadastro.Margin = new Padding(3, 4, 3, 4);
            tabPageCadastro.Padding = new Padding(3, 4, 3, 4);
            tabPageCadastro.Size = new Size(527, 347);
            tabPageCadastro.Controls.SetChildIndex(txtNome, 0);
            tabPageCadastro.Controls.SetChildIndex(txtId, 0);
            tabPageCadastro.Controls.SetChildIndex(txtEmail, 0);
            tabPageCadastro.Controls.SetChildIndex(txtSenha, 0);
            tabPageCadastro.Controls.SetChildIndex(txtDataCadastro, 0);
            tabPageCadastro.Controls.SetChildIndex(txtDataUltimoLogin, 0);
            tabPageCadastro.Controls.SetChildIndex(btnCancelar, 0);
            tabPageCadastro.Controls.SetChildIndex(btnSalvar, 0);
            tabPageCadastro.Controls.SetChildIndex(txtTelefone, 0);
            // 
            // materialTabControl
            // 
            materialTabControl.Location = new Point(3, 85);
            materialTabControl.Margin = new Padding(3, 4, 3, 4);
            materialTabControl.Size = new Size(535, 382);
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(317, 281);
            btnCancelar.Margin = new Padding(5, 8, 5, 8);
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(436, 281);
            btnSalvar.Margin = new Padding(5, 8, 5, 8);
            // 
            // txtNome
            // 
            txtNome.AnimateReadOnly = false;
            txtNome.AutoCompleteMode = AutoCompleteMode.None;
            txtNome.AutoCompleteSource = AutoCompleteSource.None;
            txtNome.BackgroundImageLayout = ImageLayout.None;
            txtNome.CharacterCasing = CharacterCasing.Normal;
            txtNome.Depth = 0;
            txtNome.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNome.HideSelection = true;
            txtNome.Hint = "Nome";
            txtNome.LeadingIcon = null;
            txtNome.Location = new Point(6, 6);
            txtNome.MaxLength = 32767;
            txtNome.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtNome.Name = "txtNome";
            txtNome.PasswordChar = '\0';
            txtNome.PrefixSuffixText = null;
            txtNome.ReadOnly = false;
            txtNome.RightToLeft = RightToLeft.No;
            txtNome.SelectedText = "";
            txtNome.SelectionLength = 0;
            txtNome.SelectionStart = 0;
            txtNome.ShortcutsEnabled = true;
            txtNome.Size = new Size(419, 48);
            txtNome.TabIndex = 2;
            txtNome.TabStop = false;
            txtNome.TextAlign = HorizontalAlignment.Left;
            txtNome.TrailingIcon = null;
            txtNome.UseSystemPasswordChar = false;
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
            txtId.Location = new Point(433, 6);
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
            txtId.TabIndex = 3;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // txtEmail
            // 
            txtEmail.AnimateReadOnly = false;
            txtEmail.AutoCompleteMode = AutoCompleteMode.None;
            txtEmail.AutoCompleteSource = AutoCompleteSource.None;
            txtEmail.BackgroundImageLayout = ImageLayout.None;
            txtEmail.CharacterCasing = CharacterCasing.Normal;
            txtEmail.Depth = 0;
            txtEmail.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEmail.HideSelection = true;
            txtEmail.Hint = "Email";
            txtEmail.LeadingIcon = null;
            txtEmail.Location = new Point(3, 60);
            txtEmail.MaxLength = 32767;
            txtEmail.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtEmail.Name = "txtEmail";
            txtEmail.PasswordChar = '\0';
            txtEmail.PrefixSuffixText = null;
            txtEmail.ReadOnly = false;
            txtEmail.RightToLeft = RightToLeft.No;
            txtEmail.SelectedText = "";
            txtEmail.SelectionLength = 0;
            txtEmail.SelectionStart = 0;
            txtEmail.ShortcutsEnabled = true;
            txtEmail.Size = new Size(506, 48);
            txtEmail.TabIndex = 4;
            txtEmail.TabStop = false;
            txtEmail.TextAlign = HorizontalAlignment.Left;
            txtEmail.TrailingIcon = null;
            txtEmail.UseSystemPasswordChar = false;
            // 
            // txtSenha
            // 
            txtSenha.AnimateReadOnly = false;
            txtSenha.AutoCompleteMode = AutoCompleteMode.None;
            txtSenha.AutoCompleteSource = AutoCompleteSource.None;
            txtSenha.BackgroundImageLayout = ImageLayout.None;
            txtSenha.CharacterCasing = CharacterCasing.Normal;
            txtSenha.Depth = 0;
            txtSenha.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSenha.HideSelection = true;
            txtSenha.Hint = "Senha";
            txtSenha.LeadingIcon = null;
            txtSenha.Location = new Point(3, 168);
            txtSenha.MaxLength = 32767;
            txtSenha.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '●';
            txtSenha.PrefixSuffixText = null;
            txtSenha.ReadOnly = false;
            txtSenha.RightToLeft = RightToLeft.No;
            txtSenha.SelectedText = "";
            txtSenha.SelectionLength = 0;
            txtSenha.SelectionStart = 0;
            txtSenha.ShortcutsEnabled = true;
            txtSenha.Size = new Size(506, 48);
            txtSenha.TabIndex = 6;
            txtSenha.TabStop = false;
            txtSenha.TextAlign = HorizontalAlignment.Left;
            txtSenha.TrailingIcon = null;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // txtDataCadastro
            // 
            txtDataCadastro.AllowPromptAsInput = true;
            txtDataCadastro.AnimateReadOnly = false;
            txtDataCadastro.AsciiOnly = false;
            txtDataCadastro.BackgroundImageLayout = ImageLayout.None;
            txtDataCadastro.BeepOnError = false;
            txtDataCadastro.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtDataCadastro.Depth = 0;
            txtDataCadastro.Enabled = false;
            txtDataCadastro.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDataCadastro.HidePromptOnLeave = false;
            txtDataCadastro.HideSelection = true;
            txtDataCadastro.Hint = "Data de Cadastro";
            txtDataCadastro.InsertKeyMode = InsertKeyMode.Default;
            txtDataCadastro.LeadingIcon = null;
            txtDataCadastro.Location = new Point(6, 222);
            txtDataCadastro.Mask = "00/00/0000";
            txtDataCadastro.MaxLength = 32767;
            txtDataCadastro.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDataCadastro.Name = "txtDataCadastro";
            txtDataCadastro.PasswordChar = '\0';
            txtDataCadastro.PrefixSuffixText = null;
            txtDataCadastro.PromptChar = '_';
            txtDataCadastro.ReadOnly = false;
            txtDataCadastro.RejectInputOnFirstFailure = false;
            txtDataCadastro.ResetOnPrompt = true;
            txtDataCadastro.ResetOnSpace = true;
            txtDataCadastro.RightToLeft = RightToLeft.No;
            txtDataCadastro.SelectedText = "";
            txtDataCadastro.SelectionLength = 0;
            txtDataCadastro.SelectionStart = 0;
            txtDataCadastro.ShortcutsEnabled = true;
            txtDataCadastro.Size = new Size(250, 48);
            txtDataCadastro.SkipLiterals = true;
            txtDataCadastro.TabIndex = 9;
            txtDataCadastro.TabStop = false;
            txtDataCadastro.Text = "  /  /";
            txtDataCadastro.TextAlign = HorizontalAlignment.Left;
            txtDataCadastro.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtDataCadastro.TrailingIcon = null;
            txtDataCadastro.UseSystemPasswordChar = false;
            txtDataCadastro.ValidatingType = null;
            // 
            // txtDataUltimoLogin
            // 
            txtDataUltimoLogin.AllowPromptAsInput = true;
            txtDataUltimoLogin.AnimateReadOnly = false;
            txtDataUltimoLogin.AsciiOnly = false;
            txtDataUltimoLogin.BackgroundImageLayout = ImageLayout.None;
            txtDataUltimoLogin.BeepOnError = false;
            txtDataUltimoLogin.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtDataUltimoLogin.Depth = 0;
            txtDataUltimoLogin.Enabled = false;
            txtDataUltimoLogin.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDataUltimoLogin.HidePromptOnLeave = false;
            txtDataUltimoLogin.HideSelection = true;
            txtDataUltimoLogin.Hint = "Último Login";
            txtDataUltimoLogin.InsertKeyMode = InsertKeyMode.Default;
            txtDataUltimoLogin.LeadingIcon = null;
            txtDataUltimoLogin.Location = new Point(262, 222);
            txtDataUltimoLogin.Mask = "00/00/0000";
            txtDataUltimoLogin.MaxLength = 32767;
            txtDataUltimoLogin.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDataUltimoLogin.Name = "txtDataUltimoLogin";
            txtDataUltimoLogin.PasswordChar = '\0';
            txtDataUltimoLogin.PrefixSuffixText = null;
            txtDataUltimoLogin.PromptChar = '_';
            txtDataUltimoLogin.ReadOnly = false;
            txtDataUltimoLogin.RejectInputOnFirstFailure = false;
            txtDataUltimoLogin.ResetOnPrompt = true;
            txtDataUltimoLogin.ResetOnSpace = true;
            txtDataUltimoLogin.RightToLeft = RightToLeft.No;
            txtDataUltimoLogin.SelectedText = "";
            txtDataUltimoLogin.SelectionLength = 0;
            txtDataUltimoLogin.SelectionStart = 0;
            txtDataUltimoLogin.ShortcutsEnabled = true;
            txtDataUltimoLogin.Size = new Size(250, 48);
            txtDataUltimoLogin.SkipLiterals = true;
            txtDataUltimoLogin.TabIndex = 10;
            txtDataUltimoLogin.TabStop = false;
            txtDataUltimoLogin.Text = "  /  /";
            txtDataUltimoLogin.TextAlign = HorizontalAlignment.Left;
            txtDataUltimoLogin.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtDataUltimoLogin.TrailingIcon = null;
            txtDataUltimoLogin.UseSystemPasswordChar = false;
            txtDataUltimoLogin.ValidatingType = null;
            // 
            // txtTelefone
            // 
            txtTelefone.AllowPromptAsInput = true;
            txtTelefone.AnimateReadOnly = false;
            txtTelefone.AsciiOnly = false;
            txtTelefone.BackgroundImageLayout = ImageLayout.None;
            txtTelefone.BeepOnError = false;
            txtTelefone.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtTelefone.Depth = 0;
            txtTelefone.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTelefone.HidePromptOnLeave = false;
            txtTelefone.HideSelection = true;
            txtTelefone.Hint = "Telefone";
            txtTelefone.InsertKeyMode = InsertKeyMode.Default;
            txtTelefone.LeadingIcon = null;
            txtTelefone.Location = new Point(6, 114);
            txtTelefone.Mask = "(00) 00000-0000";
            txtTelefone.MaxLength = 32767;
            txtTelefone.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtTelefone.Name = "txtTelefone";
            txtTelefone.PasswordChar = '\0';
            txtTelefone.PrefixSuffixText = null;
            txtTelefone.PromptChar = '_';
            txtTelefone.ReadOnly = false;
            txtTelefone.RejectInputOnFirstFailure = false;
            txtTelefone.ResetOnPrompt = true;
            txtTelefone.ResetOnSpace = true;
            txtTelefone.RightToLeft = RightToLeft.No;
            txtTelefone.SelectedText = "";
            txtTelefone.SelectionLength = 0;
            txtTelefone.SelectionStart = 0;
            txtTelefone.ShortcutsEnabled = true;
            txtTelefone.Size = new Size(503, 48);
            txtTelefone.SkipLiterals = true;
            txtTelefone.TabIndex = 5;
            txtTelefone.TabStop = false;
            txtTelefone.Text = "(  )      -";
            txtTelefone.TextAlign = HorizontalAlignment.Left;
            txtTelefone.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtTelefone.TrailingIcon = null;
            txtTelefone.UseSystemPasswordChar = false;
            txtTelefone.ValidatingType = null;
            // 
            // CadastroUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 471);
            Location = new Point(0, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CadastroUsuario";
            Padding = new Padding(3, 85, 3, 4);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Usuários";
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            materialTabControl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtSenha;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtEmail;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNome;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtDataCadastro;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtDataUltimoLogin;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtTelefone;
    }
}