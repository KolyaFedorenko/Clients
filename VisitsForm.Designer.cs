
namespace Clients
{
    partial class VisitsForm
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
            this.visitsView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.visitsView)).BeginInit();
            this.SuspendLayout();
            // 
            // visitsView
            // 
            this.visitsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.visitsView.Location = new System.Drawing.Point(12, 12);
            this.visitsView.Name = "visitsView";
            this.visitsView.Size = new System.Drawing.Size(374, 158);
            this.visitsView.TabIndex = 0;
            // 
            // VisitsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 182);
            this.Controls.Add(this.visitsView);
            this.Name = "VisitsForm";
            this.Text = "VisitsForm";
            this.Load += new System.EventHandler(this.VisitsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.visitsView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView visitsView;
    }
}