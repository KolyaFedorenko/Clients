﻿
namespace Clients
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.clientsView = new System.Windows.Forms.DataGridView();
            this.comboRows = new System.Windows.Forms.ComboBox();
            this.nextPage = new System.Windows.Forms.Button();
            this.prevPage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nameSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lastNameSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.patronymicSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.emailSearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.phoneSearch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rowsCount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.maxRowsCount = new System.Windows.Forms.Label();
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
            this.comboRows.Location = new System.Drawing.Point(290, 545);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(951, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Поиск по имени";
            // 
            // nameSearch
            // 
            this.nameSearch.Location = new System.Drawing.Point(902, 73);
            this.nameSearch.Name = "nameSearch";
            this.nameSearch.Size = new System.Drawing.Size(180, 20);
            this.nameSearch.TabIndex = 5;
            this.nameSearch.TextChanged += new System.EventHandler(this.nameSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(951, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Поиск по фамилии";
            // 
            // lastNameSearch
            // 
            this.lastNameSearch.Location = new System.Drawing.Point(902, 25);
            this.lastNameSearch.Name = "lastNameSearch";
            this.lastNameSearch.Size = new System.Drawing.Size(180, 20);
            this.lastNameSearch.TabIndex = 7;
            this.lastNameSearch.TextChanged += new System.EventHandler(this.lastNameSearch_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(951, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Поиск по отчеству";
            // 
            // patronymicSearch
            // 
            this.patronymicSearch.Location = new System.Drawing.Point(902, 123);
            this.patronymicSearch.Name = "patronymicSearch";
            this.patronymicSearch.Size = new System.Drawing.Size(180, 20);
            this.patronymicSearch.TabIndex = 9;
            this.patronymicSearch.TextChanged += new System.EventHandler(this.patronymicSearch_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(951, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Поиск по email";
            // 
            // emailSearch
            // 
            this.emailSearch.Location = new System.Drawing.Point(902, 190);
            this.emailSearch.Name = "emailSearch";
            this.emailSearch.Size = new System.Drawing.Size(180, 20);
            this.emailSearch.TabIndex = 11;
            this.emailSearch.TextChanged += new System.EventHandler(this.emailSearch_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(925, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Поиск по номеру телефона";
            // 
            // phoneSearch
            // 
            this.phoneSearch.Location = new System.Drawing.Point(902, 239);
            this.phoneSearch.Name = "phoneSearch";
            this.phoneSearch.Size = new System.Drawing.Size(180, 20);
            this.phoneSearch.TabIndex = 13;
            this.phoneSearch.TextChanged += new System.EventHandler(this.phoneSearch_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(287, 597);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Показано записей: ";
            // 
            // rowsCount
            // 
            this.rowsCount.AutoSize = true;
            this.rowsCount.Location = new System.Drawing.Point(391, 597);
            this.rowsCount.Name = "rowsCount";
            this.rowsCount.Size = new System.Drawing.Size(13, 13);
            this.rowsCount.TabIndex = 15;
            this.rowsCount.Text = "?";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(422, 597);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "из";
            // 
            // maxRowsCount
            // 
            this.maxRowsCount.AutoSize = true;
            this.maxRowsCount.Location = new System.Drawing.Point(449, 597);
            this.maxRowsCount.Name = "maxRowsCount";
            this.maxRowsCount.Size = new System.Drawing.Size(13, 13);
            this.maxRowsCount.TabIndex = 17;
            this.maxRowsCount.Text = "?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 635);
            this.Controls.Add(this.maxRowsCount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rowsCount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.phoneSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.emailSearch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.patronymicSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lastNameSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prevPage);
            this.Controls.Add(this.nextPage);
            this.Controls.Add(this.comboRows);
            this.Controls.Add(this.clientsView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Mordochka";
            ((System.ComponentModel.ISupportInitialize)(this.clientsView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView clientsView;
        private System.Windows.Forms.ComboBox comboRows;
        private System.Windows.Forms.Button nextPage;
        private System.Windows.Forms.Button prevPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lastNameSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox patronymicSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox emailSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox phoneSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label rowsCount;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label maxRowsCount;
    }
}

