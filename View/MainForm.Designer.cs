namespace ТестовоеЗаданиеСлужбаДоставки
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNewOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.сохраннитьТаблицуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSaveTXT = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSaveXLSX = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chbConsiderDate = new System.Windows.Forms.CheckBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.dtpAfter = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpBefor = new System.Windows.Forms.DateTimePicker();
            this.combDistrictFilter = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.rbDescending = new System.Windows.Forms.RadioButton();
            this.rbAscending = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.combSortOptions = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("v_Blambot Casual", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.tsmiInfo});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNewOrder,
            this.сохраннитьТаблицуToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // tsmiNewOrder
            // 
            this.tsmiNewOrder.Name = "tsmiNewOrder";
            this.tsmiNewOrder.Size = new System.Drawing.Size(194, 22);
            this.tsmiNewOrder.Text = "Новый заказ";
            this.tsmiNewOrder.Click += new System.EventHandler(this.tsmiNewOrder_Click);
            // 
            // сохраннитьТаблицуToolStripMenuItem
            // 
            this.сохраннитьТаблицуToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSaveTXT,
            this.tsmiSaveXLSX});
            this.сохраннитьТаблицуToolStripMenuItem.Name = "сохраннитьТаблицуToolStripMenuItem";
            this.сохраннитьТаблицуToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.сохраннитьТаблицуToolStripMenuItem.Text = "Сохраннить таблицу";
            // 
            // tsmiSaveTXT
            // 
            this.tsmiSaveTXT.Name = "tsmiSaveTXT";
            this.tsmiSaveTXT.Size = new System.Drawing.Size(180, 22);
            this.tsmiSaveTXT.Text = ".txt";
            this.tsmiSaveTXT.Click += new System.EventHandler(this.tsmiSaveTXT_Click);
            // 
            // tsmiSaveXLSX
            // 
            this.tsmiSaveXLSX.Name = "tsmiSaveXLSX";
            this.tsmiSaveXLSX.Size = new System.Drawing.Size(180, 22);
            this.tsmiSaveXLSX.Text = ".xlsx";
            this.tsmiSaveXLSX.Click += new System.EventHandler(this.tsmiSaveXLSX_Click);
            // 
            // tsmiInfo
            // 
            this.tsmiInfo.Name = "tsmiInfo";
            this.tsmiInfo.Size = new System.Drawing.Size(96, 20);
            this.tsmiInfo.Text = "О программе";
            this.tsmiInfo.Click += new System.EventHandler(this.tsmiInfo_Click);
            // 
            // dgvOrders
            // 
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AllowUserToDeleteRows = false;
            this.dgvOrders.AllowUserToOrderColumns = true;
            this.dgvOrders.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.ColumnHeadersVisible = false;
            this.dgvOrders.Location = new System.Drawing.Point(9, 6);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.Size = new System.Drawing.Size(779, 403);
            this.dgvOrders.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvOrders);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 193);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 421);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 169);
            this.panel2.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chbConsiderDate);
            this.groupBox2.Controls.Add(this.btnFilter);
            this.groupBox2.Controls.Add(this.dtpAfter);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dtpBefor);
            this.groupBox2.Controls.Add(this.combDistrictFilter);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("v_Blambot Casual", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(282, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(506, 129);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Фильтрация";
            // 
            // chbConsiderDate
            // 
            this.chbConsiderDate.AutoSize = true;
            this.chbConsiderDate.Checked = true;
            this.chbConsiderDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbConsiderDate.Location = new System.Drawing.Point(9, 100);
            this.chbConsiderDate.Name = "chbConsiderDate";
            this.chbConsiderDate.Size = new System.Drawing.Size(151, 20);
            this.chbConsiderDate.TabIndex = 7;
            this.chbConsiderDate.Text = "Не учитывать дату";
            this.chbConsiderDate.UseVisualStyleBackColor = true;
            this.chbConsiderDate.CheckedChanged += new System.EventHandler(this.chbConsiderDate_CheckedChanged);
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(382, 100);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(106, 23);
            this.btnFilter.TabIndex = 6;
            this.btnFilter.Text = "Фильтровать";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // dtpAfter
            // 
            this.dtpAfter.Enabled = false;
            this.dtpAfter.Location = new System.Drawing.Point(325, 64);
            this.dtpAfter.Name = "dtpAfter";
            this.dtpAfter.Size = new System.Drawing.Size(164, 23);
            this.dtpAfter.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(298, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "по";
            // 
            // dtpBefor
            // 
            this.dtpBefor.Enabled = false;
            this.dtpBefor.Location = new System.Drawing.Point(127, 63);
            this.dtpBefor.Name = "dtpBefor";
            this.dtpBefor.Size = new System.Drawing.Size(164, 23);
            this.dtpBefor.TabIndex = 3;
            // 
            // combDistrictFilter
            // 
            this.combDistrictFilter.FormattingEnabled = true;
            this.combDistrictFilter.Items.AddRange(new object[] {
            "Не имеет значения"});
            this.combDistrictFilter.Location = new System.Drawing.Point(119, 29);
            this.combDistrictFilter.Name = "combDistrictFilter";
            this.combDistrictFilter.Size = new System.Drawing.Size(146, 24);
            this.combDistrictFilter.TabIndex = 2;
            this.combDistrictFilter.Text = "Не имеет значения";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Дата доставки с";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Район доставки";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSort);
            this.groupBox1.Controls.Add(this.rbDescending);
            this.groupBox1.Controls.Add(this.rbAscending);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.combSortOptions);
            this.groupBox1.Font = new System.Drawing.Font("v_Blambot Casual", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(9, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 130);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сортировка";
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(142, 101);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(119, 23);
            this.btnSort.TabIndex = 4;
            this.btnSort.Text = "Сортировать";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // rbDescending
            // 
            this.rbDescending.AutoSize = true;
            this.rbDescending.Location = new System.Drawing.Point(142, 64);
            this.rbDescending.Name = "rbDescending";
            this.rbDescending.Size = new System.Drawing.Size(102, 20);
            this.rbDescending.TabIndex = 3;
            this.rbDescending.Text = "По убыванию";
            this.rbDescending.UseVisualStyleBackColor = true;
            // 
            // rbAscending
            // 
            this.rbAscending.AutoSize = true;
            this.rbAscending.Checked = true;
            this.rbAscending.Location = new System.Drawing.Point(10, 64);
            this.rbAscending.Name = "rbAscending";
            this.rbAscending.Size = new System.Drawing.Size(126, 20);
            this.rbAscending.TabIndex = 2;
            this.rbAscending.TabStop = true;
            this.rbAscending.Text = "По возрастанию";
            this.rbAscending.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Сортировать по";
            // 
            // combSortOptions
            // 
            this.combSortOptions.FormattingEnabled = true;
            this.combSortOptions.Items.AddRange(new object[] {
            "Нет",
            "По весу",
            "По району",
            "По дате"});
            this.combSortOptions.Location = new System.Drawing.Point(124, 29);
            this.combSortOptions.Name = "combSortOptions";
            this.combSortOptions.Size = new System.Drawing.Size(121, 24);
            this.combSortOptions.TabIndex = 0;
            this.combSortOptions.Text = "Нет";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("v_Blambot Casual", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Параметры сортировки и фильтрации";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(800, 614);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("v_Blambot Casual", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Управление заказами";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiInfo;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbDescending;
        private System.Windows.Forms.RadioButton rbAscending;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combSortOptions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox combDistrictFilter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.DateTimePicker dtpAfter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpBefor;
        private System.Windows.Forms.ToolStripMenuItem tsmiNewOrder;
        private System.Windows.Forms.ToolStripMenuItem сохраннитьТаблицуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaveTXT;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaveXLSX;
        private System.Windows.Forms.CheckBox chbConsiderDate;
    }
}

