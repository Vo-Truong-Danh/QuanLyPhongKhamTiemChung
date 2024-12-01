namespace GUI
{
    partial class frmKetQuaTiemChungBN
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
            this.rpViewerKetQuaTiemChungBN = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // rpViewerKetQuaTiemChungBN
            // 
            this.rpViewerKetQuaTiemChungBN.ActiveViewIndex = -1;
            this.rpViewerKetQuaTiemChungBN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rpViewerKetQuaTiemChungBN.Cursor = System.Windows.Forms.Cursors.Default;
            this.rpViewerKetQuaTiemChungBN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpViewerKetQuaTiemChungBN.Location = new System.Drawing.Point(0, 0);
            this.rpViewerKetQuaTiemChungBN.Name = "rpViewerKetQuaTiemChungBN";
            this.rpViewerKetQuaTiemChungBN.Size = new System.Drawing.Size(1546, 794);
            this.rpViewerKetQuaTiemChungBN.TabIndex = 0;
            this.rpViewerKetQuaTiemChungBN.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmKetQuaTiemChungBN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1546, 794);
            this.Controls.Add(this.rpViewerKetQuaTiemChungBN);
            this.Name = "frmKetQuaTiemChungBN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmKetQuaTiemChungBN";
            this.Load += new System.EventHandler(this.frmKetQuaTiemChungBN_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rpViewerKetQuaTiemChungBN;
    }
}