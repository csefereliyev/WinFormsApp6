namespace WinFormsApp6
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            listBox1 = new ListBox();
            groupBox1 = new GroupBox();
            button4 = new Button();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            maskedTextBox3 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            maskedTextBox1 = new MaskedTextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            button1 = new Button();
            maskedTextBox7 = new MaskedTextBox();
            maskedTextBox6 = new MaskedTextBox();
            maskedTextBox5 = new MaskedTextBox();
            maskedTextBox4 = new MaskedTextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            button2 = new Button();
            button3 = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label11 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(12, 484);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(934, 129);
            listBox1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(maskedTextBox3);
            groupBox1.Controls.Add(maskedTextBox2);
            groupBox1.Controls.Add(maskedTextBox1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBox1.Location = new Point(12, 173);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(469, 296);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Travel Information";
            // 
            // button4
            // 
            button4.BackColor = SystemColors.MenuHighlight;
            button4.Cursor = Cursors.Hand;
            button4.Font = new Font("Arial Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button4.Location = new Point(382, 34);
            button4.Name = "button4";
            button4.Size = new Size(87, 87);
            button4.TabIndex = 19;
            button4.Text = "<\r\n>";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI", 12F);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Baku", "Istanbul", "Berlin", "Moscow", "Taskent", "Kiev" });
            comboBox2.Location = new Point(114, 92);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(259, 29);
            comboBox2.TabIndex = 11;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 12F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Baku", "Istanbul", "Berlin", "Moscow", "Taskent", "Kiev" });
            comboBox1.Location = new Point(114, 48);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(259, 29);
            comboBox1.TabIndex = 10;
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Font = new Font("Segoe UI", 12F);
            maskedTextBox3.Location = new Point(114, 233);
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(259, 29);
            maskedTextBox3.TabIndex = 9;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Font = new Font("Segoe UI", 12F);
            maskedTextBox2.Location = new Point(114, 186);
            maskedTextBox2.Mask = "00:00";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(259, 29);
            maskedTextBox2.TabIndex = 8;
            maskedTextBox2.ValidatingType = typeof(DateTime);
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Font = new Font("Segoe UI", 12F);
            maskedTextBox1.Location = new Point(114, 141);
            maskedTextBox1.Mask = "00/00/0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(259, 29);
            maskedTextBox1.TabIndex = 7;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(6, 231);
            label5.Name = "label5";
            label5.Size = new Size(50, 30);
            label5.TabIndex = 4;
            label5.Text = "Yer:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(6, 186);
            label4.Name = "label4";
            label4.Size = new Size(61, 30);
            label4.TabIndex = 3;
            label4.Text = "Saat:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(6, 96);
            label3.Name = "label3";
            label3.Size = new Size(87, 30);
            label3.TabIndex = 2;
            label3.Text = "Haraya:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(6, 141);
            label2.Name = "label2";
            label2.Size = new Size(66, 30);
            label2.TabIndex = 1;
            label2.Text = "Tarix:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(6, 51);
            label1.Name = "label1";
            label1.Size = new Size(102, 30);
            label1.TabIndex = 0;
            label1.Text = "Haradan:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(maskedTextBox7);
            groupBox2.Controls.Add(maskedTextBox6);
            groupBox2.Controls.Add(maskedTextBox5);
            groupBox2.Controls.Add(maskedTextBox4);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label10);
            groupBox2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBox2.Location = new Point(503, 173);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(443, 296);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Person Information";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuHighlight;
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(141, 231);
            button1.Name = "button1";
            button1.Size = new Size(296, 46);
            button1.TabIndex = 16;
            button1.Text = "Bilet al";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // maskedTextBox7
            // 
            maskedTextBox7.Font = new Font("Segoe UI", 12F);
            maskedTextBox7.Location = new Point(141, 187);
            maskedTextBox7.Mask = "(999) 000-0000";
            maskedTextBox7.Name = "maskedTextBox7";
            maskedTextBox7.Size = new Size(296, 29);
            maskedTextBox7.TabIndex = 15;
            // 
            // maskedTextBox6
            // 
            maskedTextBox6.Font = new Font("Segoe UI", 12F);
            maskedTextBox6.Location = new Point(141, 141);
            maskedTextBox6.Name = "maskedTextBox6";
            maskedTextBox6.Size = new Size(296, 29);
            maskedTextBox6.TabIndex = 14;
            // 
            // maskedTextBox5
            // 
            maskedTextBox5.Font = new Font("Segoe UI", 12F);
            maskedTextBox5.Location = new Point(141, 100);
            maskedTextBox5.Name = "maskedTextBox5";
            maskedTextBox5.Size = new Size(296, 29);
            maskedTextBox5.TabIndex = 13;
            // 
            // maskedTextBox4
            // 
            maskedTextBox4.Font = new Font("Segoe UI", 12F);
            maskedTextBox4.Location = new Point(141, 55);
            maskedTextBox4.Name = "maskedTextBox4";
            maskedTextBox4.Size = new Size(296, 29);
            maskedTextBox4.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(6, 231);
            label6.Name = "label6";
            label6.Size = new Size(0, 30);
            label6.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(6, 186);
            label7.Name = "label7";
            label7.Size = new Size(91, 30);
            label7.TabIndex = 3;
            label7.Text = "Telefon:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(6, 96);
            label8.Name = "label8";
            label8.Size = new Size(54, 30);
            label8.TabIndex = 2;
            label8.Text = "FIN:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(6, 141);
            label9.Name = "label9";
            label9.Size = new Size(72, 30);
            label9.TabIndex = 1;
            label9.Text = "Email:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label10.ForeColor = SystemColors.ActiveCaptionText;
            label10.Location = new Point(6, 51);
            label10.Name = "label10";
            label10.Size = new Size(138, 30);
            label10.TabIndex = 0;
            label10.Text = "Ad ve soyad:";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.MenuHighlight;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button2.Location = new Point(12, 624);
            button2.Name = "button2";
            button2.Size = new Size(296, 46);
            button2.TabIndex = 17;
            button2.Text = "Bilet sil";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.MenuHighlight;
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button3.Location = new Point(650, 624);
            button3.Name = "button3";
            button3.Size = new Size(296, 46);
            button3.TabIndex = 18;
            button3.Text = "Exit";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(label11);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(958, 143);
            panel1.TabIndex = 19;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(840, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 90);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(20, 25);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 90);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Georgia", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label11.Location = new Point(372, 47);
            label11.Name = "label11";
            label11.Size = new Size(180, 43);
            label11.TabIndex = 2;
            label11.Text = "C-Travel";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(958, 689);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private GroupBox groupBox1;
        private Label label1;
        private MaskedTextBox maskedTextBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private MaskedTextBox maskedTextBox3;
        private MaskedTextBox maskedTextBox2;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private GroupBox groupBox2;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button button1;
        private MaskedTextBox maskedTextBox7;
        private MaskedTextBox maskedTextBox6;
        private MaskedTextBox maskedTextBox5;
        private MaskedTextBox maskedTextBox4;
        private Button button2;
        private Button button3;
        private Button button4;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label11;
        private PictureBox pictureBox2;
    }
}
