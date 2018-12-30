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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.search = new System.Windows.Forms.Button();
            this.addClient = new System.Windows.Forms.Button();
            this.deleteCustomer = new System.Windows.Forms.Button();
            this.buttonBook = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.clmFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSecondName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPassport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCardNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmIdCard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addCard = new System.Windows.Forms.Button();
            this.UpdateCard = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.dateCheckIn = new System.Windows.Forms.DateTimePicker();
            this.dateCheckOut = new System.Windows.Forms.DateTimePicker();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.availableRoomGrid = new System.Windows.Forms.DataGridView();
            this.availableRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmIdd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numericCapacity = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.availableRoomGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCapacity)).BeginInit();
            this.SuspendLayout();
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.search.Location = new System.Drawing.Point(739, 53);
            this.search.Margin = new System.Windows.Forms.Padding(0);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(116, 32);
            this.search.TabIndex = 0;
            this.search.Text = "Поиск";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // addClient
            // 
            this.addClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addClient.Location = new System.Drawing.Point(12, 50);
            this.addClient.Name = "addClient";
            this.addClient.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addClient.Size = new System.Drawing.Size(155, 53);
            this.addClient.TabIndex = 1;
            this.addClient.Text = "Добавить клиента";
            this.addClient.UseVisualStyleBackColor = true;
            this.addClient.Click += new System.EventHandler(this.addClient_Click);
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
            this.buttonBook.Click += new System.EventHandler(this.buttonBook_Click);
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
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmFirstName,
            this.clmSecondName,
            this.clmPassport,
            this.clmCardNumber,
            this.clmDiscount,
            this.clmId,
            this.clmIdCard});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView2.Location = new System.Drawing.Point(194, 92);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(661, 214);
            this.dataGridView2.TabIndex = 25;
            // 
            // clmFirstName
            // 
            this.clmFirstName.DataPropertyName = "FirstName";
            this.clmFirstName.HeaderText = "Имя";
            this.clmFirstName.Name = "clmFirstName";
            this.clmFirstName.ReadOnly = true;
            // 
            // clmSecondName
            // 
            this.clmSecondName.DataPropertyName = "SecondName";
            this.clmSecondName.HeaderText = "Фамилия";
            this.clmSecondName.Name = "clmSecondName";
            this.clmSecondName.ReadOnly = true;
            // 
            // clmPassport
            // 
            this.clmPassport.DataPropertyName = "PassportInformation";
            this.clmPassport.HeaderText = "Паспортные данные";
            this.clmPassport.Name = "clmPassport";
            this.clmPassport.ReadOnly = true;
            // 
            // clmCardNumber
            // 
            this.clmCardNumber.DataPropertyName = "NumberCard";
            this.clmCardNumber.HeaderText = "Номер карты";
            this.clmCardNumber.Name = "clmCardNumber";
            this.clmCardNumber.ReadOnly = true;
            // 
            // clmDiscount
            // 
            this.clmDiscount.DataPropertyName = "Discount";
            this.clmDiscount.HeaderText = "Скидка";
            this.clmDiscount.Name = "clmDiscount";
            this.clmDiscount.ReadOnly = true;
            // 
            // clmId
            // 
            this.clmId.DataPropertyName = "IdCustomer";
            this.clmId.HeaderText = "ID";
            this.clmId.Name = "clmId";
            this.clmId.ReadOnly = true;
            this.clmId.Visible = false;
            // 
            // clmIdCard
            // 
            this.clmIdCard.DataPropertyName = "IdCard";
            this.clmIdCard.HeaderText = "IDCard";
            this.clmIdCard.Name = "clmIdCard";
            this.clmIdCard.ReadOnly = true;
            this.clmIdCard.Visible = false;
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
            this.button11.Location = new System.Drawing.Point(8, 476);
            this.button11.Name = "button11";
            this.button11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button11.Size = new System.Drawing.Size(155, 55);
            this.button11.TabIndex = 28;
            this.button11.Text = "Вернуться назад";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Эконом",
            "Стандарт",
            "Полулюкс",
            "Люкс",
            "Президентский номер"});
            this.comboBox1.Location = new System.Drawing.Point(391, 435);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 28);
            this.comboBox1.TabIndex = 58;
            this.comboBox1.Text = "Выберите категорию";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            this.dateCheckIn.ValueChanged += new System.EventHandler(this.dateCheckIn_ValueChanged);
            // 
            // dateCheckOut
            // 
            this.dateCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateCheckOut.Location = new System.Drawing.Point(391, 365);
            this.dateCheckOut.Name = "dateCheckOut";
            this.dateCheckOut.Size = new System.Drawing.Size(200, 26);
            this.dateCheckOut.TabIndex = 53;
            this.dateCheckOut.ValueChanged += new System.EventHandler(this.dateCheckOut_ValueChanged);
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
            this.groupBox1.Location = new System.Drawing.Point(5, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 537);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            // 
            // availableRoomGrid
            // 
            this.availableRoomGrid.AllowUserToAddRows = false;
            this.availableRoomGrid.AllowUserToDeleteRows = false;
            this.availableRoomGrid.AllowUserToResizeColumns = false;
            this.availableRoomGrid.AllowUserToResizeRows = false;
            this.availableRoomGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.availableRoomGrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.availableRoomGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.availableRoomGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.availableRoomGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.availableRoom,
            this.clmIdd});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.availableRoomGrid.DefaultCellStyle = dataGridViewCellStyle4;
            this.availableRoomGrid.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.availableRoomGrid.Location = new System.Drawing.Point(625, 330);
            this.availableRoomGrid.Name = "availableRoomGrid";
            this.availableRoomGrid.ReadOnly = true;
            this.availableRoomGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.availableRoomGrid.RowHeadersVisible = false;
            this.availableRoomGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.availableRoomGrid.Size = new System.Drawing.Size(230, 133);
            this.availableRoomGrid.TabIndex = 62;
            // 
            // availableRoom
            // 
            this.availableRoom.DataPropertyName = "Room";
            this.availableRoom.HeaderText = "Доступные номера";
            this.availableRoom.Name = "availableRoom";
            this.availableRoom.ReadOnly = true;
            // 
            // clmIdd
            // 
            this.clmIdd.DataPropertyName = "IdRoom";
            this.clmIdd.HeaderText = "id";
            this.clmIdd.Name = "clmIdd";
            this.clmIdd.ReadOnly = true;
            this.clmIdd.Visible = false;
            // 
            // numericCapacity
            // 
            this.numericCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericCapacity.Location = new System.Drawing.Point(391, 399);
            this.numericCapacity.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericCapacity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericCapacity.Name = "numericCapacity";
            this.numericCapacity.Size = new System.Drawing.Size(200, 26);
            this.numericCapacity.TabIndex = 63;
            this.numericCapacity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericCapacity.ValueChanged += new System.EventHandler(this.numericCapacity_ValueChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.numericCapacity);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.dateCheckIn);
            this.Controls.Add(this.dateCheckOut);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.UpdateCard);
            this.Controls.Add(this.addCard);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.buttonBook);
            this.Controls.Add(this.deleteCustomer);
            this.Controls.Add(this.addClient);
            this.Controls.Add(this.search);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.availableRoomGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.availableRoomGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCapacity)).EndInit();
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
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button addClient;
        private System.Windows.Forms.Button deleteCustomer;
        private System.Windows.Forms.Button buttonBook;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button addCard;
        private System.Windows.Forms.Button UpdateCard;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.DateTimePicker dateCheckIn;
        private System.Windows.Forms.DateTimePicker dateCheckOut;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView availableRoomGrid;
        private System.Windows.Forms.NumericUpDown numericCapacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSecondName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPassport;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCardNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIdCard;
        private System.Windows.Forms.DataGridViewTextBoxColumn availableRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIdd;
    }
}