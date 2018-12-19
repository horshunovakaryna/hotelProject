namespace hotel.Forms
{
    partial class Form2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button_5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.deleteCustomer = new System.Windows.Forms.Button();
            this.buttonBook = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.addCard = new System.Windows.Forms.Button();
            this.UpdateCard = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textCapacity = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.dateCheckIn = new System.Windows.Forms.DateTimePicker();
            this.dateCheckOut = new System.Windows.Forms.DateTimePicker();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.availableRoomGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.availableRoomGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // button_5
            // 
            this.button_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_5.Location = new System.Drawing.Point(739, 53);
            this.button_5.Margin = new System.Windows.Forms.Padding(0);
            this.button_5.Name = "button_5";
            this.button_5.Size = new System.Drawing.Size(116, 32);
            this.button_5.TabIndex = 0;
            this.button_5.Text = "Поиск";
            this.button_5.UseVisualStyleBackColor = true;
            this.button_5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(12, 50);
            this.button6.Name = "button6";
            this.button6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button6.Size = new System.Drawing.Size(155, 53);
            this.button6.TabIndex = 1;
            this.button6.Text = "Добавить клиента";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // deleteCustomer
            // 
            this.deleteCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteCustomer.Location = new System.Drawing.Point(12, 115);
            this.deleteCustomer.Name = "deleteCustomer";
            this.deleteCustomer.Size = new System.Drawing.Size(155, 53);
            this.deleteCustomer.TabIndex = 2;
            this.deleteCustomer.Text = "Удалить клиента";
            this.deleteCustomer.UseVisualStyleBackColor = true;
            this.deleteCustomer.Click += new System.EventHandler(this.deleteCustomer_Click);
            // 
            // buttonBook
            // 
            this.buttonBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBook.Location = new System.Drawing.Point(510, 488);
            this.buttonBook.Name = "buttonBook";
            this.buttonBook.Size = new System.Drawing.Size(160, 55);
            this.buttonBook.TabIndex = 3;
            this.buttonBook.Text = "Забронировать";
            this.buttonBook.UseVisualStyleBackColor = true;
            this.buttonBook.Click += new System.EventHandler(this.button8_Click);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(194, 55);
            this.textBox3.Margin = new System.Windows.Forms.Padding(0);
            this.textBox3.MaximumSize = new System.Drawing.Size(550, 30);
            this.textBox3.MinimumSize = new System.Drawing.Size(160, 30);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(532, 26);
            this.textBox3.TabIndex = 4;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label26.Location = new System.Drawing.Point(12, 15);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(95, 20);
            this.label26.TabIndex = 16;
            this.label26.Text = "Сотрудник:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label27.Location = new System.Drawing.Point(113, 15);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(60, 20);
            this.label27.TabIndex = 17;
            this.label27.Text = "label27";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView2.Location = new System.Drawing.Point(194, 92);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(661, 214);
            this.dataGridView2.TabIndex = 25;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // addCard
            // 
            this.addCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addCard.Location = new System.Drawing.Point(12, 183);
            this.addCard.Name = "addCard";
            this.addCard.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addCard.Size = new System.Drawing.Size(155, 53);
            this.addCard.TabIndex = 26;
            this.addCard.Text = "Добавить карту";
            this.addCard.UseVisualStyleBackColor = true;
            this.addCard.Click += new System.EventHandler(this.addCard_Click);
            // 
            // UpdateCard
            // 
            this.UpdateCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdateCard.Location = new System.Drawing.Point(12, 253);
            this.UpdateCard.Name = "UpdateCard";
            this.UpdateCard.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UpdateCard.Size = new System.Drawing.Size(155, 53);
            this.UpdateCard.TabIndex = 27;
            this.UpdateCard.Text = "Изменить данные карты";
            this.UpdateCard.UseVisualStyleBackColor = true;
            this.UpdateCard.Click += new System.EventHandler(this.UpdateCard_Click);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button11.Location = new System.Drawing.Point(6, 450);
            this.button11.Name = "button11";
            this.button11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button11.Size = new System.Drawing.Size(155, 55);
            this.button11.TabIndex = 28;
            this.button11.Text = "Вернуться назад";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(391, 435);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 28);
            this.comboBox1.TabIndex = 58;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textCapacity
            // 
            this.textCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textCapacity.Location = new System.Drawing.Point(391, 400);
            this.textCapacity.Name = "textCapacity";
            this.textCapacity.Size = new System.Drawing.Size(200, 26);
            this.textCapacity.TabIndex = 57;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label35.Location = new System.Drawing.Point(194, 435);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(89, 20);
            this.label35.TabIndex = 56;
            this.label35.Text = "Категория";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label34.Location = new System.Drawing.Point(194, 400);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(155, 20);
            this.label34.TabIndex = 55;
            this.label34.Text = "Количество гостей";
            // 
            // dateCheckIn
            // 
            this.dateCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateCheckIn.Location = new System.Drawing.Point(391, 330);
            this.dateCheckIn.Name = "dateCheckIn";
            this.dateCheckIn.Size = new System.Drawing.Size(200, 26);
            this.dateCheckIn.TabIndex = 54;
            // 
            // dateCheckOut
            // 
            this.dateCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateCheckOut.Location = new System.Drawing.Point(391, 365);
            this.dateCheckOut.Name = "dateCheckOut";
            this.dateCheckOut.Size = new System.Drawing.Size(200, 26);
            this.dateCheckOut.TabIndex = 53;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label21.Location = new System.Drawing.Point(194, 365);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(109, 20);
            this.label21.TabIndex = 52;
            this.label21.Text = "Дата выезда";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label20.Location = new System.Drawing.Point(194, 330);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(106, 20);
            this.label20.TabIndex = 51;
            this.label20.Text = "Дата заезда";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox1.Controls.Add(this.button11);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(5, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 511);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            // 
            // availableRoomGrid
            // 
            this.availableRoomGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.availableRoomGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.availableRoomGrid.Location = new System.Drawing.Point(625, 330);
            this.availableRoomGrid.Name = "availableRoomGrid";
            this.availableRoomGrid.RowHeadersVisible = false;
            this.availableRoomGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.availableRoomGrid.Size = new System.Drawing.Size(230, 133);
            this.availableRoomGrid.TabIndex = 62;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textCapacity);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.dateCheckIn);
            this.Controls.Add(this.dateCheckOut);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.UpdateCard);
            this.Controls.Add(this.addCard);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.buttonBook);
            this.Controls.Add(this.deleteCustomer);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button_5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.availableRoomGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.availableRoomGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button_5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button deleteCustomer;
        private System.Windows.Forms.Button buttonBook;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button addCard;
        private System.Windows.Forms.Button UpdateCard;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textCapacity;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.DateTimePicker dateCheckIn;
        private System.Windows.Forms.DateTimePicker dateCheckOut;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView availableRoomGrid;
    }
}