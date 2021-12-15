
namespace Clients
{
    partial class AdminForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.clientsView = new System.Windows.Forms.DataGridView();
            this.comboRows = new System.Windows.Forms.ComboBox();
            this.nextPage = new System.Windows.Forms.Button();
            this.prevPage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.clientsView)).BeginInit();
            this.SuspendLayout();
            // 
            // clientsView
            // 
            this.clientsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientsView.Location = new System.Drawing.Point(0, 0);
            this.clientsView.Name = "clientsView";
            this.clientsView.Size = new System.Drawing.Size(885, 523);
            this.clientsView.TabIndex = 0;
            // 
            // comboRows
            // 
            this.comboRows.FormattingEnabled = true;
            this.comboRows.Location = new System.Drawing.Point(914, 42);
            this.comboRows.Name = "comboRows";
            this.comboRows.Size = new System.Drawing.Size(151, 21);
            this.comboRows.TabIndex = 1;
            this.comboRows.SelectedIndexChanged += new System.EventHandler(this.comboRows_SelectedIndexChanged);
            // 
            // nextPage
            // 
            this.nextPage.Location = new System.Drawing.Point(149, 545);
            this.nextPage.Name = "nextPage";
            this.nextPage.Size = new System.Drawing.Size(121, 65);
            this.nextPage.TabIndex = 2;
            this.nextPage.Text = "Следующая страница";
            this.nextPage.UseVisualStyleBackColor = true;
            this.nextPage.Click += new System.EventHandler(this.nextPage_Click);
            // 
            // prevPage
            // 
            this.prevPage.Location = new System.Drawing.Point(12, 545);
            this.prevPage.Name = "prevPage";
            this.prevPage.Size = new System.Drawing.Size(121, 65);
            this.prevPage.TabIndex = 3;
            this.prevPage.Text = "Предыдущая страница";
            this.prevPage.UseVisualStyleBackColor = true;
            this.prevPage.Click += new System.EventHandler(this.prevPage_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 635);
            this.Controls.Add(this.prevPage);
            this.Controls.Add(this.nextPage);
            this.Controls.Add(this.comboRows);
            this.Controls.Add(this.clientsView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.clientsView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView clientsView;
        private System.Windows.Forms.ComboBox comboRows;
        private System.Windows.Forms.Button nextPage;
        private System.Windows.Forms.Button prevPage;
    }
}

