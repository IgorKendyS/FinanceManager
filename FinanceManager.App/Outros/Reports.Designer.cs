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
            mySqlCommand1 = new MySqlConnector.MySqlCommand();
            webViewReport = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)webViewReport).BeginInit();
            SuspendLayout();
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CommandTimeout = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.Transaction = null;
            mySqlCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // webViewReport
            // 
            webViewReport.AllowExternalDrop = true;
            webViewReport.CreationProperties = null;
            webViewReport.DefaultBackgroundColor = Color.White;
            webViewReport.Dock = DockStyle.Fill;
            webViewReport.Location = new Point(3, 64);
            webViewReport.Name = "webViewReport";
            webViewReport.Size = new Size(794, 383);
            webViewReport.TabIndex = 0;
            webViewReport.ZoomFactor = 1D;
            // 
            // Reports
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(webViewReport);
            Name = "Reports";
            Text = "Reports";
            ((System.ComponentModel.ISupportInitialize)webViewReport).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MySqlConnector.MySqlCommand mySqlCommand1;
        private Microsoft.Web.WebView2.WinForms.WebView2 webViewReport;
    }
}