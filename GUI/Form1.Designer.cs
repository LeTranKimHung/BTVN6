namespace GUI
{
    partial class Form1
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
            this.dgvqlsv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.grbttsv = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblavatar = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbldtb = new System.Windows.Forms.Label();
            this.lblkhoa = new System.Windows.Forms.Label();
            this.lblhoten = new System.Windows.Forms.Label();
            this.lblmssv = new System.Windows.Forms.Label();
            this.cbdangki = new System.Windows.Forms.CheckBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvqlsv)).BeginInit();
            this.grbttsv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvqlsv
            // 
            this.dgvqlsv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvqlsv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvqlsv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvqlsv.Location = new System.Drawing.Point(421, 103);
            this.dgvqlsv.Name = "dgvqlsv";
            this.dgvqlsv.RowHeadersWidth = 51;
            this.dgvqlsv.RowTemplate.Height = 24;
            this.dgvqlsv.Size = new System.Drawing.Size(582, 412);
            this.dgvqlsv.TabIndex = 0;
            this.dgvqlsv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvqlsv_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(378, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản Lý Sinh Viên";
            // 
            // grbttsv
            // 
            this.grbttsv.Controls.Add(this.button3);
            this.grbttsv.Controls.Add(this.button2);
            this.grbttsv.Controls.Add(this.button1);
            this.grbttsv.Controls.Add(this.pictureBox1);
            this.grbttsv.Controls.Add(this.lblavatar);
            this.grbttsv.Controls.Add(this.comboBox1);
            this.grbttsv.Controls.Add(this.textBox3);
            this.grbttsv.Controls.Add(this.textBox2);
            this.grbttsv.Controls.Add(this.textBox1);
            this.grbttsv.Controls.Add(this.lbldtb);
            this.grbttsv.Controls.Add(this.lblkhoa);
            this.grbttsv.Controls.Add(this.lblhoten);
            this.grbttsv.Controls.Add(this.lblmssv);
            this.grbttsv.Location = new System.Drawing.Point(31, 103);
            this.grbttsv.Name = "grbttsv";
            this.grbttsv.Size = new System.Drawing.Size(384, 412);
            this.grbttsv.TabIndex = 2;
            this.grbttsv.TabStop = false;
            this.grbttsv.Text = "Thông Tin Sinh Viên";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(86, 184);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 110);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // lblavatar
            // 
            this.lblavatar.AutoSize = true;
            this.lblavatar.Location = new System.Drawing.Point(28, 184);
            this.lblavatar.Name = "lblavatar";
            this.lblavatar.Size = new System.Drawing.Size(46, 16);
            this.lblavatar.TabIndex = 8;
            this.lblavatar.Text = "Avatar";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(86, 125);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(267, 24);
            this.comboBox1.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(86, 307);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(267, 22);
            this.textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(86, 85);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(267, 22);
            this.textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(86, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(267, 22);
            this.textBox1.TabIndex = 4;
            // 
            // lbldtb
            // 
            this.lbldtb.AutoSize = true;
            this.lbldtb.Location = new System.Drawing.Point(31, 310);
            this.lbldtb.Name = "lbldtb";
            this.lbldtb.Size = new System.Drawing.Size(35, 16);
            this.lbldtb.TabIndex = 3;
            this.lbldtb.Text = "DTB";
            // 
            // lblkhoa
            // 
            this.lblkhoa.AutoSize = true;
            this.lblkhoa.Location = new System.Drawing.Point(28, 125);
            this.lblkhoa.Name = "lblkhoa";
            this.lblkhoa.Size = new System.Drawing.Size(38, 16);
            this.lblkhoa.TabIndex = 2;
            this.lblkhoa.Text = "Khoa";
            // 
            // lblhoten
            // 
            this.lblhoten.AutoSize = true;
            this.lblhoten.Location = new System.Drawing.Point(28, 85);
            this.lblhoten.Name = "lblhoten";
            this.lblhoten.Size = new System.Drawing.Size(52, 16);
            this.lblhoten.TabIndex = 1;
            this.lblhoten.Text = "Họ Tên";
            // 
            // lblmssv
            // 
            this.lblmssv.AutoSize = true;
            this.lblmssv.Location = new System.Drawing.Point(28, 48);
            this.lblmssv.Name = "lblmssv";
            this.lblmssv.Size = new System.Drawing.Size(45, 16);
            this.lblmssv.TabIndex = 0;
            this.lblmssv.Text = "MSSV";
            // 
            // cbdangki
            // 
            this.cbdangki.AutoSize = true;
            this.cbdangki.Location = new System.Drawing.Point(800, 77);
            this.cbdangki.Name = "cbdangki";
            this.cbdangki.Size = new System.Drawing.Size(166, 20);
            this.cbdangki.TabIndex = 3;
            this.cbdangki.Text = "Chưa ĐK chuyên ngành";
            this.cbdangki.UseVisualStyleBackColor = true;
            this.cbdangki.CheckedChanged += new System.EventHandler(this.cbdangki_CheckedChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "MSSV";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "TÊN";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "KHOA";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "DTB";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "CHUYÊN NGÀNH";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(86, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(184, 360);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(278, 360);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Sửa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 527);
            this.Controls.Add(this.cbdangki);
            this.Controls.Add(this.grbttsv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvqlsv);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvqlsv)).EndInit();
            this.grbttsv.ResumeLayout(false);
            this.grbttsv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvqlsv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbttsv;
        private System.Windows.Forms.Label lbldtb;
        private System.Windows.Forms.Label lblkhoa;
        private System.Windows.Forms.Label lblhoten;
        private System.Windows.Forms.Label lblmssv;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblavatar;
        private System.Windows.Forms.CheckBox cbdangki;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

