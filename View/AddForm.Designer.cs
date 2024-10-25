namespace ТестовоеЗаданиеСлужбаДоставки.View
{
    partial class AddForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbWeight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDateOrder = new System.Windows.Forms.DateTimePicker();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.combDistrictName = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("v_Blambot Casual", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавить заказ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Вес";
            // 
            // tbWeight
            // 
            this.tbWeight.Location = new System.Drawing.Point(74, 68);
            this.tbWeight.Name = "tbWeight";
            this.tbWeight.Size = new System.Drawing.Size(191, 23);
            this.tbWeight.TabIndex = 2;
            this.tbWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbWeight_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Дата";
            // 
            // dtpDateOrder
            // 
            this.dtpDateOrder.Location = new System.Drawing.Point(74, 138);
            this.dtpDateOrder.Name = "dtpDateOrder";
            this.dtpDateOrder.Size = new System.Drawing.Size(191, 23);
            this.dtpDateOrder.TabIndex = 4;
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Location = new System.Drawing.Point(84, 186);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(94, 23);
            this.btnAddOrder.TabIndex = 5;
            this.btnAddOrder.Text = "Добавить";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Регион";
            // 
            // combDistrictName
            // 
            this.combDistrictName.FormattingEnabled = true;
            this.combDistrictName.Location = new System.Drawing.Point(74, 104);
            this.combDistrictName.Name = "combDistrictName";
            this.combDistrictName.Size = new System.Drawing.Size(191, 24);
            this.combDistrictName.TabIndex = 7;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(283, 234);
            this.Controls.Add(this.combDistrictName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.dtpDateOrder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbWeight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("v_Blambot Casual", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddForm";
            this.Text = "Добавить заказ";
            this.Load += new System.EventHandler(this.AddForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbWeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDateOrder;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox combDistrictName;
    }
}