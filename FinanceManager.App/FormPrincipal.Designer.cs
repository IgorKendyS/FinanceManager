namespace FinanceManager.App
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            usuarioToolStripMenuItem = new ToolStripMenuItem();
            categoriaToolStripMenuItem = new ToolStripMenuItem();
            métodoDePagamentoToolStripMenuItem = new ToolStripMenuItem();
            transaçõesToolStripMenuItem = new ToolStripMenuItem();
            registrarTransacaoToolStripMenuItem = new ToolStripMenuItem();
            relatoriosToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem, transaçõesToolStripMenuItem, relatoriosToolStripMenuItem, sairToolStripMenuItem });
            menuStrip1.Location = new Point(3, 85);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(908, 30);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { usuarioToolStripMenuItem, categoriaToolStripMenuItem, métodoDePagamentoToolStripMenuItem });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(88, 24);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // usuarioToolStripMenuItem
            // 
            usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            usuarioToolStripMenuItem.Size = new Size(245, 26);
            usuarioToolStripMenuItem.Text = "Usuário";
            usuarioToolStripMenuItem.Click += usuarioToolStripMenuItem_Click;
            // 
            // categoriaToolStripMenuItem
            // 
            categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            categoriaToolStripMenuItem.Size = new Size(245, 26);
            categoriaToolStripMenuItem.Text = "Categoria";
            // 
            // métodoDePagamentoToolStripMenuItem
            // 
            métodoDePagamentoToolStripMenuItem.Name = "métodoDePagamentoToolStripMenuItem";
            métodoDePagamentoToolStripMenuItem.Size = new Size(245, 26);
            métodoDePagamentoToolStripMenuItem.Text = "Método de Pagamento";
            // 
            // transaçõesToolStripMenuItem
            // 
            transaçõesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { registrarTransacaoToolStripMenuItem });
            transaçõesToolStripMenuItem.Name = "transaçõesToolStripMenuItem";
            transaçõesToolStripMenuItem.Size = new Size(95, 24);
            transaçõesToolStripMenuItem.Text = "Transações";
            // 
            // registrarTransacaoToolStripMenuItem
            // 
            registrarTransacaoToolStripMenuItem.Name = "registrarTransacaoToolStripMenuItem";
            registrarTransacaoToolStripMenuItem.Size = new Size(224, 26);
            registrarTransacaoToolStripMenuItem.Text = "Registrar Transação";
            // 
            // relatoriosToolStripMenuItem
            // 
            relatoriosToolStripMenuItem.Name = "relatoriosToolStripMenuItem";
            relatoriosToolStripMenuItem.Size = new Size(90, 24);
            relatoriosToolStripMenuItem.Text = "Relatórios";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(48, 24);
            sairToolStripMenuItem.Text = "Sair";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormPrincipal";
            Padding = new Padding(3, 85, 3, 4);
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem usuárioToolStripMenuItem;
        private ToolStripMenuItem categoriaToolStripMenuItem;
        private ToolStripMenuItem métodoDePagamentoToolStripMenuItem;
        private ToolStripMenuItem transaçõesToolStripMenuItem;
        private ToolStripMenuItem registrarTransacaoToolStripMenuItem;
        private ToolStripMenuItem relatoriosToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem usuarioToolStripMenuItem;
    }
}
