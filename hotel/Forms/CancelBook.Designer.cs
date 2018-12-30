namespace hotel.Forms
{
    partial class CancelBook
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonCancelBook = new System.Windows.Forms.Button();
            this.searchButton1 = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.bookingViev = new System.Windows.Forms.DataGridView();
            this.clmFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSecondName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPassport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCheckIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCheckOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSumma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bookingViev)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(12, 325);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonBack.Size = new System.Drawing.Size(155, 55);
            this.buttonBack.TabIndex = 40;
            this.buttonBack.Text = "Вернуться назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            // 
            // buttonCancelBook
            // 
            this.buttonCancelBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancelBook.Location = new System.Drawing.Point(518, 325);
            this.buttonCancelBook.Name = "buttonCancelBook";
            this.buttonCancelBook.Size = new System.Drawing.Size(160, 55);
            this.buttonCancelBook.TabIndex = 39;
            this.buttonCancelBook.Text = "Отменить бронирование";
            this.buttonCancelBook.UseVisualStyleBackColor = true;
            this.buttonCancelBook.Click += new System.EventHandler(this.buttonCancelBook_Click);
            // 
            // searchButton1
            // 
            this.searchButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchButton1.Location = new System.Drawing.Point(562, 22);
            this.searchButton1.Margin = new System.Windows.Forms.Padding(0);
            this.searchButton1.Name = "searchButton1";
            this.searchButton1.Size = new System.Drawing.Size(116, 32);
            this.searchButton1.TabIndex = 38;
            this.searchButton1.Text = "Поиск";
            this.searchButton1.UseVisualStyleBackColor = true;
            this.searchButton1.Click += new System.EventHandler(this.searchButton1_Click);
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchBox.Location = new System.Drawing.Point(12, 24);
            this.searchBox.Margin = new System.Windows.Forms.Padding(0);
            this.searchBox.MaximumSize = new System.Drawing.Size(550, 30);
            this.searchBox.MinimumSize = new System.Drawing.Size(160, 30);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(532, 30);
            this.searchBox.TabIndex = 37;
            // 
            // bookingViev
            // 
            this.bookingViev.AllowUserToAddRows = false;
            this.bookingViev.AllowUserToDeleteRows = false;
            this.bookingViev.AllowUserToResizeColumns = false;
            this.bookingViev.AllowUserToResizeRows = false;
            this.bookingViev.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bookingViev.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bookingViev.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.bookingViev.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookingViev.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmFirstName,
            this.clmSecondName,
            this.clmPassport,
            this.clmCheckIn,
            this.clmCheckOut,
            this.clmSumma,
            this.clmId});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bookingViev.DefaultCellStyle = dataGridViewCellStyle6;
            this.bookingViev.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bookingViev.Location = new System.Drawing.Point(12, 73);
            this.bookingViev.Name = "bookingViev";
            this.bookingViev.ReadOnly = true;
            this.bookingViev.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bookingViev.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.bookingViev.RowHeadersVisible = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bookingViev.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.bookingViev.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bookingViev.Size = new System.Drawing.Size(666, 220);
            this.bookingViev.TabIndex = 36;
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
            // clmCheckIn
            // 
            this.clmCheckIn.DataPropertyName = "CheckIn";
            this.clmCheckIn.HeaderText = "Дата заезда";
            this.clmCheckIn.Name = "clmCheckIn";
            this.clmCheckIn.ReadOnly = true;
            // 
            // clmCheckOut
            // 
            this.clmCheckOut.DataPropertyName = "CheckOut";
            this.clmCheckOut.HeaderText = "Дата выезда";
            this.clmCheckOut.Name = "clmCheckOut";
            this.clmCheckOut.ReadOnly = true;
            // 
            // clmSumma
            // 
            this.clmSumma.DataPropertyName = "IdCard";
            this.clmSumma.HeaderText = "Сумма к оплате";
            this.clmSumma.Name = "clmSumma";
            this.clmSumma.ReadOnly = true;
            // 
            // clmId
            // 
            this.clmId.DataPropertyName = "IdCustomer";
            this.clmId.HeaderText = "ID";
            this.clmId.Name = "clmId";
            this.clmId.ReadOnly = true;
            this.clmId.Visible = false;
            // 
            // CancelBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 450);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonCancelBook);
            this.Controls.Add(this.searchButton1);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.bookingViev);
            this.Name = "CancelBook";
            this.Text = "CancelBook";
            ((System.ComponentModel.ISupportInitialize)(this.bookingViev)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonCancelBook;
        private System.Windows.Forms.Button searchButton1;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.DataGridView bookingViev;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSecondName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPassport;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCheckIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCheckOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSumma;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmId;
    }
}