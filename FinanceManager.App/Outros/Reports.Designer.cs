namespace FinanceManager.App.Outros
{
    partial class Reports
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
            mtcReports = new ReaLTaiizor.Controls.MaterialTabControl();
            tpd = new TabPage();
            formsPlot1 = new ScottPlot.WinForms.FormsPlot();
            materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
            tabPage2 = new TabPage();
            materialLabel2 = new ReaLTaiizor.Controls.MaterialLabel();
            fileSystemWatcher1 = new FileSystemWatcher();
            panel1 = new Panel();
            mtcReports.SuspendLayout();
            tpd.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // mtcReports
            // 
            mtcReports.Controls.Add(tpd);
            mtcReports.Controls.Add(tabPage2);
            mtcReports.Depth = 0;
            mtcReports.Dock = DockStyle.Fill;
            mtcReports.Location = new Point(3, 64);
            mtcReports.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            mtcReports.Multiline = true;
            mtcReports.Name = "mtcReports";
            mtcReports.SelectedIndex = 0;
            mtcReports.Size = new Size(794, 383);
            mtcReports.TabIndex = 1;
            // 
            // tpd
            // 
            tpd.Controls.Add(panel1);
            tpd.Controls.Add(materialLabel1);
            tpd.Location = new Point(4, 24);
            tpd.Name = "tpd";
            tpd.Padding = new Padding(3);
            tpd.Size = new Size(786, 355);
            tpd.TabIndex = 0;
            tpd.Text = "Gastos Diários";
            tpd.UseVisualStyleBackColor = true;
            // 
            // formsPlot1
            // 
            formsPlot1.DisplayScale = 1F;
            formsPlot1.Location = new Point(52, 21);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(478, 239);
            formsPlot1.TabIndex = 2;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(325, 34);
            materialLabel1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(105, 19);
            materialLabel1.TabIndex = 1;
            materialLabel1.Text = "Gastos Diários";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(materialLabel2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(786, 355);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Gastos Mensais";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(325, 36);
            materialLabel2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(115, 19);
            materialLabel2.TabIndex = 2;
            materialLabel2.Text = "Gastos Mensais";
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // panel1
            // 
            panel1.Controls.Add(formsPlot1);
            panel1.Location = new Point(94, 70);
            panel1.Name = "panel1";
            panel1.Size = new Size(581, 279);
            panel1.TabIndex = 3;
            // 
            // Reports
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mtcReports);
            DrawerTabControl = mtcReports;
            Name = "Reports";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Relatórios";
            mtcReports.ResumeLayout(false);
            tpd.ResumeLayout(false);
            tpd.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ReaLTaiizor.Controls.MaterialTabControl mtcReports;
        private TabPage tpd;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel1;
        private TabPage tabPage2;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel2;
        private FileSystemWatcher fileSystemWatcher1;
        private ScottPlot.WinForms.FormsPlot formsPlot1;
        private Panel panel1;
    }
}