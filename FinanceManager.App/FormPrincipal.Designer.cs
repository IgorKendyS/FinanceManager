﻿namespace FinanceManager.App
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
            registrarTransaçãoToolStripMenuItem = new ToolStripMenuItem();
            relatóriosToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem, transaçõesToolStripMenuItem, relatóriosToolStripMenuItem, sairToolStripMenuItem });
            menuStrip1.Location = new Point(3, 64);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(794, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { usuarioToolStripMenuItem, categoriaToolStripMenuItem, métodoDePagamentoToolStripMenuItem });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(71, 20);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // usuarioToolStripMenuItem
            // 
            usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            usuarioToolStripMenuItem.Size = new Size(196, 22);
            usuarioToolStripMenuItem.Text = "Usuário";
            usuarioToolStripMenuItem.Click += usuárioToolStripMenuItem_Click;
            // 
            // categoriaToolStripMenuItem
            // 
            categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            categoriaToolStripMenuItem.Size = new Size(196, 22);
            categoriaToolStripMenuItem.Text = "Categoria";
            // 
            // métodoDePagamentoToolStripMenuItem
            // 
            métodoDePagamentoToolStripMenuItem.Name = "métodoDePagamentoToolStripMenuItem";
            métodoDePagamentoToolStripMenuItem.Size = new Size(196, 22);
            métodoDePagamentoToolStripMenuItem.Text = "Método de Pagamento";
            // 
            // transaçõesToolStripMenuItem
            // 
            transaçõesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { registrarTransaçãoToolStripMenuItem });
            transaçõesToolStripMenuItem.Name = "transaçõesToolStripMenuItem";
            transaçõesToolStripMenuItem.Size = new Size(76, 20);
            transaçõesToolStripMenuItem.Text = "Transações";
            // 
            // registrarTransaçãoToolStripMenuItem
            // 
            registrarTransaçãoToolStripMenuItem.Name = "registrarTransaçãoToolStripMenuItem";
            registrarTransaçãoToolStripMenuItem.Size = new Size(175, 22);
            registrarTransaçãoToolStripMenuItem.Text = "Registrar Transação";
            // 
            // relatóriosToolStripMenuItem
            // 
            relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            relatóriosToolStripMenuItem.Size = new Size(71, 20);
            relatóriosToolStripMenuItem.Text = "Relatórios";
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
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FormPrincipal";
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
        private ToolStripMenuItem registrarTransaçãoToolStripMenuItem;
        private ToolStripMenuItem relatóriosToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem usuarioToolStripMenuItem;
    }
}
