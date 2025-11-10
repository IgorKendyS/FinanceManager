// FinanceManager.App\Outros\Reports.Designer.cs
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
            tabPage2 = new TabPage();
            formsPlot2 = new ScottPlot.WinForms.FormsPlot();
            tbpCategory = new TabPage();
            formsPlot3 = new ScottPlot.WinForms.FormsPlot();
            fileSystemWatcher1 = new FileSystemWatcher();
            mtcReports.SuspendLayout();
            tpd.SuspendLayout();
            tabPage2.SuspendLayout();
            tbpCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // mtcReports
            // 
            mtcReports.Controls.Add(tpd);
            mtcReports.Controls.Add(tabPage2);
            mtcReports.Controls.Add(tbpCategory);
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
            tpd.Controls.Add(formsPlot1);
            tpd.Location = new Point(4, 24);
            tpd.Name = "tpd";
            tpd.Padding = new Padding(3);
            tpd.Size = new Size(786, 355);
            tpd.TabIndex = 0;
            tpd.Text = "Diários";
            tpd.UseVisualStyleBackColor = true;
            // 
            // formsPlot1
            // 
            formsPlot1.Dock = DockStyle.Fill;
            formsPlot1.DisplayScale = 1F;
            formsPlot1.Location = new Point(3, 3);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(780, 349);
            formsPlot1.TabIndex = 2;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(formsPlot2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(786, 355);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Mensais";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // formsPlot2
            // 
            formsPlot2.Dock = DockStyle.Fill;
            formsPlot2.DisplayScale = 1F;
            formsPlot2.Location = new Point(3, 3);
            formsPlot2.Name = "formsPlot2";
            formsPlot2.Size = new Size(780, 349);
            formsPlot2.TabIndex = 0;
            // 
            // tbpCategory
            // 
            tbpCategory.Controls.Add(formsPlot3);
            tbpCategory.Location = new Point(4, 24);
            tbpCategory.Name = "tbpCategory";
            tbpCategory.Padding = new Padding(3);
            tbpCategory.Size = new Size(786, 355);
            tbpCategory.TabIndex = 2;
            tbpCategory.Text = "Por Categoria";
            tbpCategory.UseVisualStyleBackColor = true;
            // 
            // formsPlot3
            // 
            formsPlot3.Dock = DockStyle.Fill;
            formsPlot3.DisplayScale = 1F;
            formsPlot3.Location = new Point(3, 3);
            formsPlot3.Name = "formsPlot3";
            formsPlot3.Size = new Size(780, 349);
            formsPlot3.TabIndex = 0;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
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
            tabPage2.ResumeLayout(false);
            tbpCategory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ReaLTaiizor.Controls.MaterialTabControl mtcReports;
        private TabPage tpd;
        private TabPage tabPage2;
        private TabPage tbpCategory;
        private FileSystemWatcher fileSystemWatcher1;
        private ScottPlot.WinForms.FormsPlot formsPlot1;
        private ScottPlot.WinForms.FormsPlot formsPlot2;
        private ScottPlot.WinForms.FormsPlot formsPlot3;
    }
}