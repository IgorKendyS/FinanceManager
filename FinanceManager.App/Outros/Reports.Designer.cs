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
            formsPlot1 = new ScottPlot.FormsPlot();
            mtcReports = new ReaLTaiizor.Controls.MaterialTabControl();
            tpd = new TabPage();
            materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
            tabPage2 = new TabPage();
            formsPlot2 = new ScottPlot.FormsPlot();
            materialLabel2 = new ReaLTaiizor.Controls.MaterialLabel();
            mtcReports.SuspendLayout();
            tpd.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // formsPlot1
            // 
            formsPlot1.Location = new Point(50, 71);
            formsPlot1.Margin = new Padding(4, 3, 4, 3);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(666, 268);
            formsPlot1.TabIndex = 0;
            formsPlot1.Load += formsPlot1_Load;
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
            tpd.Controls.Add(materialLabel1);
            tpd.Controls.Add(formsPlot1);
            tpd.Location = new Point(4, 24);
            tpd.Name = "tpd";
            tpd.Padding = new Padding(3);
            tpd.Size = new Size(786, 355);
            tpd.TabIndex = 0;
            tpd.Text = "Gastos Diários";
            tpd.UseVisualStyleBackColor = true;
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
            tabPage2.Controls.Add(formsPlot2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(786, 355);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Gastos Mensais";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // formsPlot2
            // 
            formsPlot2.Location = new Point(51, 71);
            formsPlot2.Margin = new Padding(4, 3, 4, 3);
            formsPlot2.Name = "formsPlot2";
            formsPlot2.Size = new Size(666, 268);
            formsPlot2.TabIndex = 0;
            formsPlot2.Load += formsPlot2_Load;
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
            ResumeLayout(false);
        }

        #endregion
        private ScottPlot.FormsPlot formsPlot1;
        private ReaLTaiizor.Controls.MaterialTabControl mtcReports;
        private TabPage tpd;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel1;
        private TabPage tabPage2;
        private ScottPlot.FormsPlot formsPlot2;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel2;
    }
}