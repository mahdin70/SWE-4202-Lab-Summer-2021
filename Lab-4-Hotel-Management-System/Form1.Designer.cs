namespace Lab_4
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_RentQuantity = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Avail = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_SRefrigerator = new System.Windows.Forms.TextBox();
            this.tb_SQuantity = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tb_DName = new System.Windows.Forms.TextBox();
            this.tb_DTV = new System.Windows.Forms.TextBox();
            this.tb_DRefrigerator = new System.Windows.Forms.TextBox();
            this.tb_DQuantity = new System.Windows.Forms.TextBox();
            this.tb_SName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.tb_STV = new System.Windows.Forms.TextBox();
            this.cb_singleac = new System.Windows.Forms.ComboBox();
            this.cb_gamingsetup = new System.Windows.Forms.ComboBox();
            this.cb_doubleac = new System.Windows.Forms.ComboBox();
            this.cb_DoubleExtraTV = new System.Windows.Forms.ComboBox();
            this.cb_DoubleBreakfast = new System.Windows.Forms.ComboBox();
            this.cb_RentName = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(96, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Single Room";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddSingleRoomOnClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(419, 347);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 26);
            this.button2.TabIndex = 1;
            this.button2.Text = "Add Double Room";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.AddDoubleRoomOnClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(634, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Room Package";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(681, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Quantity";
            // 
            // tb_RentQuantity
            // 
            this.tb_RentQuantity.Location = new System.Drawing.Point(742, 97);
            this.tb_RentQuantity.Name = "tb_RentQuantity";
            this.tb_RentQuantity.Size = new System.Drawing.Size(100, 22);
            this.tb_RentQuantity.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(742, 137);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Rent";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.RentRoomOnClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(634, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Room Name";
            // 
            // tb_Avail
            // 
            this.tb_Avail.Location = new System.Drawing.Point(742, 226);
            this.tb_Avail.Name = "tb_Avail";
            this.tb_Avail.Size = new System.Drawing.Size(126, 22);
            this.tb_Avail.TabIndex = 8;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(742, 266);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(126, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Show Availability";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.ShowAvailabilityOnClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Single Room";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(369, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "Double Room";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "TV";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Refrigerator";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Quantity";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 227);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 16);
            this.label10.TabIndex = 17;
            this.label10.Text = "Air Condition";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 264);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 16);
            this.label11.TabIndex = 18;
            this.label11.Text = "Gaming Setup";
            // 
            // tb_SRefrigerator
            // 
            this.tb_SRefrigerator.Location = new System.Drawing.Point(125, 146);
            this.tb_SRefrigerator.Name = "tb_SRefrigerator";
            this.tb_SRefrigerator.Size = new System.Drawing.Size(100, 22);
            this.tb_SRefrigerator.TabIndex = 21;
            // 
            // tb_SQuantity
            // 
            this.tb_SQuantity.Location = new System.Drawing.Point(125, 185);
            this.tb_SQuantity.Name = "tb_SQuantity";
            this.tb_SQuantity.Size = new System.Drawing.Size(100, 22);
            this.tb_SQuantity.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(340, 77);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 16);
            this.label12.TabIndex = 25;
            this.label12.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(340, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 16);
            this.label6.TabIndex = 26;
            this.label6.Text = "TV";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(340, 154);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 16);
            this.label13.TabIndex = 27;
            this.label13.Text = "Refrigerator";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(340, 191);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 16);
            this.label14.TabIndex = 28;
            this.label14.Text = "Quantity";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(16, 71);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 16);
            this.label15.TabIndex = 29;
            this.label15.Text = "Name";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(340, 230);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 16);
            this.label16.TabIndex = 31;
            this.label16.Text = "Air Condition";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(340, 267);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(58, 16);
            this.label17.TabIndex = 32;
            this.label17.Text = "Extra TV";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(340, 302);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(64, 16);
            this.label18.TabIndex = 33;
            this.label18.Text = "Breakfast";
            // 
            // tb_DName
            // 
            this.tb_DName.Location = new System.Drawing.Point(448, 77);
            this.tb_DName.Name = "tb_DName";
            this.tb_DName.Size = new System.Drawing.Size(100, 22);
            this.tb_DName.TabIndex = 34;
            // 
            // tb_DTV
            // 
            this.tb_DTV.Location = new System.Drawing.Point(448, 115);
            this.tb_DTV.Name = "tb_DTV";
            this.tb_DTV.Size = new System.Drawing.Size(100, 22);
            this.tb_DTV.TabIndex = 35;
            // 
            // tb_DRefrigerator
            // 
            this.tb_DRefrigerator.Location = new System.Drawing.Point(448, 151);
            this.tb_DRefrigerator.Name = "tb_DRefrigerator";
            this.tb_DRefrigerator.Size = new System.Drawing.Size(100, 22);
            this.tb_DRefrigerator.TabIndex = 36;
            // 
            // tb_DQuantity
            // 
            this.tb_DQuantity.Location = new System.Drawing.Point(448, 188);
            this.tb_DQuantity.Name = "tb_DQuantity";
            this.tb_DQuantity.Size = new System.Drawing.Size(100, 22);
            this.tb_DQuantity.TabIndex = 37;
            // 
            // tb_SName
            // 
            this.tb_SName.Location = new System.Drawing.Point(125, 70);
            this.tb_SName.Name = "tb_SName";
            this.tb_SName.Size = new System.Drawing.Size(100, 22);
            this.tb_SName.TabIndex = 41;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(278, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(5, 400);
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox2.Location = new System.Drawing.Point(581, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(5, 400);
            this.pictureBox2.TabIndex = 43;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox3.Location = new System.Drawing.Point(-1, 393);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(900, 5);
            this.pictureBox3.TabIndex = 44;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox4.Location = new System.Drawing.Point(581, 191);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(318, 5);
            this.pictureBox4.TabIndex = 45;
            this.pictureBox4.TabStop = false;
            // 
            // tb_STV
            // 
            this.tb_STV.Location = new System.Drawing.Point(125, 108);
            this.tb_STV.Name = "tb_STV";
            this.tb_STV.Size = new System.Drawing.Size(100, 22);
            this.tb_STV.TabIndex = 20;
            // 
            // cb_singleac
            // 
            this.cb_singleac.AllowDrop = true;
            this.cb_singleac.FormattingEnabled = true;
            this.cb_singleac.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cb_singleac.Location = new System.Drawing.Point(125, 224);
            this.cb_singleac.Name = "cb_singleac";
            this.cb_singleac.Size = new System.Drawing.Size(100, 24);
            this.cb_singleac.TabIndex = 47;
            // 
            // cb_gamingsetup
            // 
            this.cb_gamingsetup.AllowDrop = true;
            this.cb_gamingsetup.FormattingEnabled = true;
            this.cb_gamingsetup.Items.AddRange(new object[] {
            "Yes ",
            "No"});
            this.cb_gamingsetup.Location = new System.Drawing.Point(125, 261);
            this.cb_gamingsetup.Name = "cb_gamingsetup";
            this.cb_gamingsetup.Size = new System.Drawing.Size(100, 24);
            this.cb_gamingsetup.TabIndex = 48;
            // 
            // cb_doubleac
            // 
            this.cb_doubleac.AllowDrop = true;
            this.cb_doubleac.FormattingEnabled = true;
            this.cb_doubleac.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cb_doubleac.Location = new System.Drawing.Point(448, 226);
            this.cb_doubleac.Name = "cb_doubleac";
            this.cb_doubleac.Size = new System.Drawing.Size(100, 24);
            this.cb_doubleac.TabIndex = 49;
            // 
            // cb_DoubleExtraTV
            // 
            this.cb_DoubleExtraTV.AllowDrop = true;
            this.cb_DoubleExtraTV.FormattingEnabled = true;
            this.cb_DoubleExtraTV.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cb_DoubleExtraTV.Location = new System.Drawing.Point(448, 264);
            this.cb_DoubleExtraTV.Name = "cb_DoubleExtraTV";
            this.cb_DoubleExtraTV.Size = new System.Drawing.Size(100, 24);
            this.cb_DoubleExtraTV.TabIndex = 50;
            // 
            // cb_DoubleBreakfast
            // 
            this.cb_DoubleBreakfast.AllowDrop = true;
            this.cb_DoubleBreakfast.FormattingEnabled = true;
            this.cb_DoubleBreakfast.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cb_DoubleBreakfast.Location = new System.Drawing.Point(448, 299);
            this.cb_DoubleBreakfast.Name = "cb_DoubleBreakfast";
            this.cb_DoubleBreakfast.Size = new System.Drawing.Size(100, 24);
            this.cb_DoubleBreakfast.TabIndex = 51;
            // 
            // cb_RentName
            // 
            this.cb_RentName.AllowDrop = true;
            this.cb_RentName.FormattingEnabled = true;
            this.cb_RentName.Items.AddRange(new object[] {
            "Single",
            "Double"});
            this.cb_RentName.Location = new System.Drawing.Point(742, 57);
            this.cb_RentName.Name = "cb_RentName";
            this.cb_RentName.Size = new System.Drawing.Size(100, 24);
            this.cb_RentName.TabIndex = 52;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 399);
            this.Controls.Add(this.cb_RentName);
            this.Controls.Add(this.cb_DoubleBreakfast);
            this.Controls.Add(this.cb_DoubleExtraTV);
            this.Controls.Add(this.cb_doubleac);
            this.Controls.Add(this.cb_gamingsetup);
            this.Controls.Add(this.cb_singleac);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tb_SName);
            this.Controls.Add(this.tb_DQuantity);
            this.Controls.Add(this.tb_DRefrigerator);
            this.Controls.Add(this.tb_DTV);
            this.Controls.Add(this.tb_DName);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tb_SQuantity);
            this.Controls.Add(this.tb_SRefrigerator);
            this.Controls.Add(this.tb_STV);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.tb_Avail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tb_RentQuantity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Hotel Management System";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_RentQuantity;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_Avail;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_SRefrigerator;
        private System.Windows.Forms.TextBox tb_SQuantity;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tb_DName;
        private System.Windows.Forms.TextBox tb_DTV;
        private System.Windows.Forms.TextBox tb_DRefrigerator;
        private System.Windows.Forms.TextBox tb_DQuantity;
        private System.Windows.Forms.TextBox tb_SName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox tb_STV;
        private System.Windows.Forms.ComboBox cb_singleac;
        private System.Windows.Forms.ComboBox cb_gamingsetup;
        private System.Windows.Forms.ComboBox cb_doubleac;
        private System.Windows.Forms.ComboBox cb_DoubleExtraTV;
        private System.Windows.Forms.ComboBox cb_DoubleBreakfast;
        private System.Windows.Forms.ComboBox cb_RentName;
    }
}

