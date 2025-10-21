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
            metodoDePagamentoToolStripMenuItem = new ToolStripMenuItem();
            transaçõesToolStripMenuItem = new ToolStripMenuItem();
            registrarTransacaoToolStripMenuItem = new ToolStripMenuItem();
            relatoriosToolStripMenuItem = new ToolStripMenuItem();
            graficosToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem, transaçõesToolStripMenuItem, relatoriosToolStripMenuItem, sairToolStripMenuItem });
            menuStrip1.Location = new Point(3, 64);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(794, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { usuarioToolStripMenuItem, categoriaToolStripMenuItem, metodoDePagamentoToolStripMenuItem });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(71, 20);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // usuarioToolStripMenuItem
            // 
            usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            usuarioToolStripMenuItem.Size = new Size(196, 22);
            usuarioToolStripMenuItem.Text = "Usuário";
            usuarioToolStripMenuItem.Click += usuarioToolStripMenuItem_Click;
            // 
            // categoriaToolStripMenuItem
            // 
            categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            categoriaToolStripMenuItem.Size = new Size(196, 22);
            categoriaToolStripMenuItem.Text = "Categoria";
            categoriaToolStripMenuItem.Click += categoriaToolStripMenuItem_Click;
            // 
            // metodoDePagamentoToolStripMenuItem
            // 
            metodoDePagamentoToolStripMenuItem.Name = "metodoDePagamentoToolStripMenuItem";
            metodoDePagamentoToolStripMenuItem.Size = new Size(196, 22);
            metodoDePagamentoToolStripMenuItem.Text = "Método de Pagamento";
            metodoDePagamentoToolStripMenuItem.Click += metodoDePagamentoToolStripMenuItem_Click;
            // 
            // transaçõesToolStripMenuItem
            // 
            transaçõesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { registrarTransacaoToolStripMenuItem });
            transaçõesToolStripMenuItem.Name = "transaçõesToolStripMenuItem";
            transaçõesToolStripMenuItem.Size = new Size(76, 20);
            transaçõesToolStripMenuItem.Text = "Transações";
            // 
            // registrarTransacaoToolStripMenuItem
            // 
            registrarTransacaoToolStripMenuItem.Name = "registrarTransacaoToolStripMenuItem";
            registrarTransacaoToolStripMenuItem.Size = new Size(175, 22);
            registrarTransacaoToolStripMenuItem.Text = "Registrar Transação";
            registrarTransacaoToolStripMenuItem.Click += registrarTransacaoToolStripMenuItem_Click;
            // 
            // relatoriosToolStripMenuItem
            // 
            relatoriosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { graficosToolStripMenuItem });
            relatoriosToolStripMenuItem.Name = "relatoriosToolStripMenuItem";
            relatoriosToolStripMenuItem.Size = new Size(71, 20);
            relatoriosToolStripMenuItem.Text = "Relatórios";
            // 
            // graficosToolStripMenuItem
            // 
            graficosToolStripMenuItem.Name = "graficosToolStripMenuItem";
            graficosToolStripMenuItem.Size = new Size(180, 22);
            graficosToolStripMenuItem.Text = "Gráficos";
            graficosToolStripMenuItem.Click += graficosToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(38, 20);
            sairToolStripMenuItem.Text = "Sair";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gerenciador de Finanças";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem categoriaToolStripMenuItem;
        private ToolStripMenuItem metodoDePagamentoToolStripMenuItem;
        private ToolStripMenuItem transaçõesToolStripMenuItem;
        private ToolStripMenuItem registrarTransacaoToolStripMenuItem;
        private ToolStripMenuItem relatoriosToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem usuarioToolStripMenuItem;
        private ToolStripMenuItem graficosToolStripMenuItem;
    }
}
