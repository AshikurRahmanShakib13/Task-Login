namespace LoginTask
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
            pictureBox1 = new PictureBox();
            LogIn = new Label();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            panel3 = new Panel();
            panel4 = new Panel();
            button1 = new Button();
            label2 = new Label();
            txtUserName = new TextBox();
            txtpassword = new TextBox();
            button2 = new Button();
            New_Account = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._427719548_411628084710249_8843175523765859002_n;
            pictureBox1.Location = new Point(100, 59);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(84, 81);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // LogIn
            // 
            LogIn.AutoSize = true;
            LogIn.Font = new Font("Constantia", 24F, FontStyle.Bold, GraphicsUnit.Point);
            LogIn.ForeColor = Color.BlueViolet;
            LogIn.Location = new Point(85, 159);
            LogIn.Name = "LogIn";
            LogIn.Size = new Size(112, 39);
            LogIn.TabIndex = 1;
            LogIn.Text = "Log In";
            LogIn.Click += LogIn_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icone_de_cadenas_de_securite_violet;
            pictureBox2.Location = new Point(24, 278);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(28, 26);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.Location = new Point(24, 259);
            panel1.Name = "panel1";
            panel1.Size = new Size(236, 1);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Location = new Point(24, 306);
            panel2.Name = "panel2";
            panel2.Size = new Size(236, 1);
            panel2.TabIndex = 4;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources._9094119;
            pictureBox3.Location = new Point(24, 227);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(28, 26);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.BlueViolet;
            panel3.Location = new Point(24, 263);
            panel3.Name = "panel3";
            panel3.Size = new Size(236, 1);
            panel3.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.BackColor = Color.BlueViolet;
            panel4.Location = new Point(24, 310);
            panel4.Name = "panel4";
            panel4.Size = new Size(236, 1);
            panel4.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.BlueViolet;
            button1.Font = new Font("Book Antiqua", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(24, 340);
            button1.Name = "button1";
            button1.Size = new Size(236, 40);
            button1.TabIndex = 5;
            button1.Text = "Log In";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.BlueViolet;
            label2.Location = new Point(121, 393);
            label2.Name = "label2";
            label2.Size = new Size(39, 21);
            label2.TabIndex = 7;
            label2.Text = "Exit";
            label2.Click += label2_Click;
            // 
            // txtUserName
            // 
            txtUserName.BorderStyle = BorderStyle.None;
            txtUserName.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtUserName.ForeColor = Color.BlueViolet;
            txtUserName.Location = new Point(60, 228);
            txtUserName.Multiline = true;
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(200, 29);
            txtUserName.TabIndex = 8;
            txtUserName.TextChanged += txtUserName_TextChanged;
            // 
            // txtpassword
            // 
            txtpassword.BorderStyle = BorderStyle.None;
            txtpassword.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtpassword.ForeColor = Color.BlueViolet;
            txtpassword.Location = new Point(58, 278);
            txtpassword.Multiline = true;
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(200, 29);
            txtpassword.TabIndex = 9;
            // 
            // button2
            // 
            button2.Location = new Point(294, 444);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 10;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // New_Account
            // 
            New_Account.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            New_Account.ForeColor = Color.BlueViolet;
            New_Account.Location = new Point(71, 433);
            New_Account.Name = "New_Account";
            New_Account.Size = new Size(148, 34);
            New_Account.TabIndex = 11;
            New_Account.Text = "New Account";
            New_Account.UseVisualStyleBackColor = true;
            New_Account.Click += New_Account_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(292, 508);
            Controls.Add(New_Account);
            Controls.Add(button2);
            Controls.Add(txtpassword);
            Controls.Add(txtUserName);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(LogIn);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label LogIn;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox3;
        private Panel panel3;
        private Panel panel4;
        private Button button1;
        private Label label2;
        private TextBox txtUserName;
        private TextBox txtpassword;
        private Button button2;
        private Button New_Account;
    }
}