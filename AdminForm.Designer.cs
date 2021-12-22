
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.countVisitSort = new System.Windows.Forms.Button();
            this.lastVisitSort = new System.Windows.Forms.Button();
            this.lastNameSort = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.resetFilter = new System.Windows.Forms.Button();
            this.femaleFilter = new System.Windows.Forms.Button();
            this.maleFilter = new System.Windows.Forms.Button();
            this.addClient = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.deleteClient = new System.Windows.Forms.Button();
            this.editClient = new System.Windows.Forms.Button();
            this.clientVisits = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.visitsLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.clientsView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // clientsView
            // 
            this.clientsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientsView.Location = new System.Drawing.Point(0, 0);
            this.clientsView.Name = "clientsView";
            this.clientsView.Size = new System.Drawing.Size(885, 523);
            this.clientsView.TabIndex = 0;
            this.clientsView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clientsView_CellContentClick);
            this.clientsView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clientsView_CellContentClick);
            // 
            // comboRows
            // 
            this.comboRows.FormattingEnabled = true;
            this.comboRows.Location = new System.Drawing.Point(6, 19);
            this.comboRows.Name = "comboRows";
            this.comboRows.Size = new System.Drawing.Size(188, 21);
            this.comboRows.TabIndex = 1;
            this.comboRows.SelectedIndexChanged += new System.EventHandler(this.comboRows_SelectedIndexChanged);
            // 
            // nextPage
            // 
            this.nextPage.Location = new System.Drawing.Point(138, 19);
            this.nextPage.Name = "nextPage";
            this.nextPage.Size = new System.Drawing.Size(125, 74);
            this.nextPage.TabIndex = 2;
            this.nextPage.Text = "Следующая страница";
            this.nextPage.UseVisualStyleBackColor = true;
            this.nextPage.Click += new System.EventHandler(this.nextPage_Click);
            // 
            // prevPage
            // 
            this.prevPage.Location = new System.Drawing.Point(6, 19);
            this.prevPage.Name = "prevPage";
            this.prevPage.Size = new System.Drawing.Size(126, 75);
            this.prevPage.TabIndex = 3;
            this.prevPage.Text = "Предыдущая страница";
            this.prevPage.UseVisualStyleBackColor = true;
            this.prevPage.Click += new System.EventHandler(this.prevPage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Поиск по имени";
            // 
            // nameSearch
            // 
            this.nameSearch.Location = new System.Drawing.Point(16, 76);
            this.nameSearch.Name = "nameSearch";
            this.nameSearch.Size = new System.Drawing.Size(180, 20);
            this.nameSearch.TabIndex = 5;
            this.nameSearch.TextChanged += new System.EventHandler(this.nameSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Поиск по фамилии";
            // 
            // lastNameSearch
            // 
            this.lastNameSearch.Location = new System.Drawing.Point(16, 28);
            this.lastNameSearch.Name = "lastNameSearch";
            this.lastNameSearch.Size = new System.Drawing.Size(180, 20);
            this.lastNameSearch.TabIndex = 7;
            this.lastNameSearch.TextChanged += new System.EventHandler(this.lastNameSearch_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Поиск по отчеству";
            // 
            // patronymicSearch
            // 
            this.patronymicSearch.Location = new System.Drawing.Point(16, 126);
            this.patronymicSearch.Name = "patronymicSearch";
            this.patronymicSearch.Size = new System.Drawing.Size(180, 20);
            this.patronymicSearch.TabIndex = 9;
            this.patronymicSearch.TextChanged += new System.EventHandler(this.patronymicSearch_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Поиск по email";
            // 
            // emailSearch
            // 
            this.emailSearch.Location = new System.Drawing.Point(16, 175);
            this.emailSearch.Name = "emailSearch";
            this.emailSearch.Size = new System.Drawing.Size(180, 20);
            this.emailSearch.TabIndex = 11;
            this.emailSearch.TextChanged += new System.EventHandler(this.emailSearch_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Поиск по номеру телефона";
            // 
            // phoneSearch
            // 
            this.phoneSearch.Location = new System.Drawing.Point(16, 224);
            this.phoneSearch.Name = "phoneSearch";
            this.phoneSearch.Size = new System.Drawing.Size(180, 20);
            this.phoneSearch.TabIndex = 13;
            this.phoneSearch.TextChanged += new System.EventHandler(this.phoneSearch_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Показано записей: ";
            // 
            // rowsCount
            // 
            this.rowsCount.AutoSize = true;
            this.rowsCount.Location = new System.Drawing.Point(111, 56);
            this.rowsCount.Name = "rowsCount";
            this.rowsCount.Size = new System.Drawing.Size(13, 13);
            this.rowsCount.TabIndex = 15;
            this.rowsCount.Text = "?";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(140, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "из";
            // 
            // maxRowsCount
            // 
            this.maxRowsCount.AutoSize = true;
            this.maxRowsCount.Location = new System.Drawing.Point(165, 56);
            this.maxRowsCount.Name = "maxRowsCount";
            this.maxRowsCount.Size = new System.Drawing.Size(13, 13);
            this.maxRowsCount.TabIndex = 17;
            this.maxRowsCount.Text = "?";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lastNameSearch);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nameSearch);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.patronymicSearch);
            this.groupBox1.Controls.Add(this.phoneSearch);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.emailSearch);
            this.groupBox1.Location = new System.Drawing.Point(891, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 261);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.countVisitSort);
            this.groupBox2.Controls.Add(this.lastVisitSort);
            this.groupBox2.Controls.Add(this.lastNameSort);
            this.groupBox2.Location = new System.Drawing.Point(891, 267);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(208, 172);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Сортировка";
            // 
            // countVisitSort
            // 
            this.countVisitSort.Location = new System.Drawing.Point(6, 117);
            this.countVisitSort.Name = "countVisitSort";
            this.countVisitSort.Size = new System.Drawing.Size(190, 43);
            this.countVisitSort.TabIndex = 23;
            this.countVisitSort.Text = "По количеству посещений";
            this.countVisitSort.UseVisualStyleBackColor = true;
            // 
            // lastVisitSort
            // 
            this.lastVisitSort.Location = new System.Drawing.Point(6, 68);
            this.lastVisitSort.Name = "lastVisitSort";
            this.lastVisitSort.Size = new System.Drawing.Size(190, 43);
            this.lastVisitSort.TabIndex = 22;
            this.lastVisitSort.Text = "По дате последнего посещения";
            this.lastVisitSort.UseVisualStyleBackColor = true;
            // 
            // lastNameSort
            // 
            this.lastNameSort.Location = new System.Drawing.Point(6, 19);
            this.lastNameSort.Name = "lastNameSort";
            this.lastNameSort.Size = new System.Drawing.Size(190, 43);
            this.lastNameSort.TabIndex = 21;
            this.lastNameSort.Text = "По фамилии";
            this.lastNameSort.UseVisualStyleBackColor = true;
            this.lastNameSort.Click += new System.EventHandler(this.lastNameSort_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.resetFilter);
            this.groupBox3.Controls.Add(this.femaleFilter);
            this.groupBox3.Controls.Add(this.maleFilter);
            this.groupBox3.Location = new System.Drawing.Point(891, 445);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(210, 78);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Фильтрация по полу";
            // 
            // resetFilter
            // 
            this.resetFilter.Location = new System.Drawing.Point(141, 19);
            this.resetFilter.Name = "resetFilter";
            this.resetFilter.Size = new System.Drawing.Size(63, 53);
            this.resetFilter.TabIndex = 26;
            this.resetFilter.Text = "Все";
            this.resetFilter.UseVisualStyleBackColor = true;
            this.resetFilter.Click += new System.EventHandler(this.resetFilter_Click);
            // 
            // femaleFilter
            // 
            this.femaleFilter.Location = new System.Drawing.Point(73, 19);
            this.femaleFilter.Name = "femaleFilter";
            this.femaleFilter.Size = new System.Drawing.Size(63, 53);
            this.femaleFilter.TabIndex = 25;
            this.femaleFilter.Text = "Ж";
            this.femaleFilter.UseVisualStyleBackColor = true;
            this.femaleFilter.Click += new System.EventHandler(this.femaleFilter_Click);
            // 
            // maleFilter
            // 
            this.maleFilter.Location = new System.Drawing.Point(6, 19);
            this.maleFilter.Name = "maleFilter";
            this.maleFilter.Size = new System.Drawing.Size(63, 53);
            this.maleFilter.TabIndex = 24;
            this.maleFilter.Text = "М";
            this.maleFilter.UseVisualStyleBackColor = true;
            this.maleFilter.Click += new System.EventHandler(this.maleFilter_Click);
            // 
            // addClient
            // 
            this.addClient.Location = new System.Drawing.Point(6, 19);
            this.addClient.Name = "addClient";
            this.addClient.Size = new System.Drawing.Size(198, 37);
            this.addClient.TabIndex = 22;
            this.addClient.Text = "Добавить";
            this.addClient.UseVisualStyleBackColor = true;
            this.addClient.Click += new System.EventHandler(this.addClient_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.deleteClient);
            this.groupBox4.Controls.Add(this.editClient);
            this.groupBox4.Controls.Add(this.addClient);
            this.groupBox4.Location = new System.Drawing.Point(891, 529);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(210, 106);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Действия с клиентами";
            // 
            // deleteClient
            // 
            this.deleteClient.Location = new System.Drawing.Point(110, 62);
            this.deleteClient.Name = "deleteClient";
            this.deleteClient.Size = new System.Drawing.Size(94, 37);
            this.deleteClient.TabIndex = 24;
            this.deleteClient.Text = "Удалить";
            this.deleteClient.UseVisualStyleBackColor = true;
            this.deleteClient.Click += new System.EventHandler(this.deleteClient_Click);
            // 
            // editClient
            // 
            this.editClient.Location = new System.Drawing.Point(6, 62);
            this.editClient.Name = "editClient";
            this.editClient.Size = new System.Drawing.Size(94, 37);
            this.editClient.TabIndex = 23;
            this.editClient.Text = "Редактировать";
            this.editClient.UseVisualStyleBackColor = true;
            this.editClient.Click += new System.EventHandler(this.editClient_Click);
            // 
            // clientVisits
            // 
            this.clientVisits.Location = new System.Drawing.Point(6, 16);
            this.clientVisits.Name = "clientVisits";
            this.clientVisits.Size = new System.Drawing.Size(184, 49);
            this.clientVisits.TabIndex = 24;
            this.clientVisits.Text = "Посещения";
            this.clientVisits.UseVisualStyleBackColor = true;
            this.clientVisits.Click += new System.EventHandler(this.clientVisits_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.visitsLabel);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.clientVisits);
            this.groupBox5.Location = new System.Drawing.Point(689, 529);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(196, 106);
            this.groupBox5.TabIndex = 25;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Посещения клиентов";
            // 
            // visitsLabel
            // 
            this.visitsLabel.AutoSize = true;
            this.visitsLabel.Location = new System.Drawing.Point(168, 77);
            this.visitsLabel.Name = "visitsLabel";
            this.visitsLabel.Size = new System.Drawing.Size(13, 13);
            this.visitsLabel.TabIndex = 28;
            this.visitsLabel.Text = "?";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Посещения данного клиента:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.prevPage);
            this.groupBox6.Controls.Add(this.nextPage);
            this.groupBox6.Location = new System.Drawing.Point(12, 535);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(269, 100);
            this.groupBox6.TabIndex = 26;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Навигация";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.comboRows);
            this.groupBox7.Controls.Add(this.label6);
            this.groupBox7.Controls.Add(this.rowsCount);
            this.groupBox7.Controls.Add(this.label8);
            this.groupBox7.Controls.Add(this.maxRowsCount);
            this.groupBox7.Location = new System.Drawing.Point(287, 535);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(200, 100);
            this.groupBox7.TabIndex = 27;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Отображение записей";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 647);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.clientsView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Mordochka";
            ((System.ComponentModel.ISupportInitialize)(this.clientsView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button lastNameSort;
        private System.Windows.Forms.Button countVisitSort;
        private System.Windows.Forms.Button lastVisitSort;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button resetFilter;
        private System.Windows.Forms.Button femaleFilter;
        private System.Windows.Forms.Button maleFilter;
        private System.Windows.Forms.Button addClient;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button editClient;
        private System.Windows.Forms.Button deleteClient;
        private System.Windows.Forms.Button clientVisits;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        public System.Windows.Forms.DataGridView clientsView;
        private System.Windows.Forms.Label visitsLabel;
        private System.Windows.Forms.Label label7;
    }
}

