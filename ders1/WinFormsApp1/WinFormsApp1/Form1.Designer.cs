namespace WinFormsApp1
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
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            listBox1 = new ListBox();
            label3 = new Label();
            textBox1 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            button4 = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            comboBox1 = new ComboBox();
            button5 = new Button();
            textBox4 = new TextBox();
            button6 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 39);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 0;
            label1.Text = "Bilal";
            label1.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 74);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 1;
            label2.Text = "KASAP";
            label2.Visible = false;
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(82, 112);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Göster";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(46, 282);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(243, 144);
            listBox1.TabIndex = 3;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 193);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 4;
            label3.Text = "Adı Soyadı:";
            label3.Click += label3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(136, 190);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(153, 27);
            textBox1.TabIndex = 5;
            // 
            // button2
            // 
            button2.Location = new Point(195, 232);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 6;
            button2.Text = "Ekle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(46, 442);
            button3.Name = "button3";
            button3.Size = new Size(114, 29);
            button3.TabIndex = 7;
            button3.Text = "Satır Temizle";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(406, 39);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(200, 20);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Sivas Cumhuriyet Üniversitesi";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(493, 74);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(113, 20);
            linkLabel2.TabIndex = 9;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Hesap Makinesi";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // button4
            // 
            button4.Location = new Point(512, 112);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 10;
            button4.Text = "Sıfırla";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(363, 197);
            label4.Name = "label4";
            label4.Size = new Size(35, 20);
            label4.TabIndex = 11;
            label4.Text = "Adı:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(363, 236);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 12;
            label5.Text = "Soyadı:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(363, 282);
            label6.Name = "label6";
            label6.Size = new Size(80, 20);
            label6.TabIndex = 13;
            label6.Text = "Mezuniyet:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(469, 197);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(149, 27);
            textBox2.TabIndex = 14;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(469, 238);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(149, 27);
            textBox3.TabIndex = 15;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "İlkokul", "Ortaokul", "Lise" });
            comboBox1.Location = new Point(467, 279);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 16;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button5
            // 
            button5.Location = new Point(524, 325);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 17;
            button5.Text = "Listeye Ekle";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(361, 369);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 18;
            // 
            // button6
            // 
            button6.Location = new Point(361, 412);
            button6.Name = "button6";
            button6.Size = new Size(125, 29);
            button6.TabIndex = 19;
            button6.Text = "Mezuniyet Ekle";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 545);
            Controls.Add(button6);
            Controls.Add(textBox4);
            Controls.Add(button5);
            Controls.Add(comboBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button4);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private ListBox listBox1;
        private Label label3;
        private TextBox textBox1;
        private Button button2;
        private Button button3;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private Button button4;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox2;
        private TextBox textBox3;
        private ComboBox comboBox1;
        private Button button5;
        private TextBox textBox4;
        private Button button6;
    }
}
