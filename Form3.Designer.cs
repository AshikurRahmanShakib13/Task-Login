namespace LoginTask
{
    partial class Form3
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
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            nameTB = new TextBox();
            idTB = new TextBox();
            passwordTB = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.BlueViolet;
            panel1.Location = new Point(20, 113);
            panel1.Name = "panel1";
            panel1.Size = new Size(467, 2);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.BlueViolet;
            panel2.Location = new Point(20, 229);
            panel2.Name = "panel2";
            panel2.Size = new Size(467, 2);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // panel3
            // 
            panel3.BackColor = Color.BlueViolet;
            panel3.Location = new Point(20, 348);
            panel3.Name = "panel3";
            panel3.Size = new Size(477, 2);
            panel3.TabIndex = 1;
            // 
            // nameTB
            // 
            nameTB.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            nameTB.Location = new Point(122, 75);
            nameTB.Name = "nameTB";
            nameTB.Size = new Size(360, 32);
            nameTB.TabIndex = 2;
            nameTB.TextChanged += textBox1_TextChanged;
            // 
            // idTB
            // 
            idTB.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            idTB.Location = new Point(122, 194);
            idTB.Name = "idTB";
            idTB.Size = new Size(360, 29);
            idTB.TabIndex = 3;
            // 
            // passwordTB
            // 
            passwordTB.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            passwordTB.Location = new Point(137, 313);
            passwordTB.Name = "passwordTB";
            passwordTB.Size = new Size(360, 29);
            passwordTB.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(33, 77);
            label1.Name = "label1";
            label1.Size = new Size(77, 25);
            label1.TabIndex = 5;
            label1.Text = "Name -";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(33, 198);
            label2.Name = "label2";
            label2.Size = new Size(45, 25);
            label2.TabIndex = 6;
            label2.Text = "ID -";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(20, 317);
            label3.Name = "label3";
            label3.Size = new Size(110, 25);
            label3.TabIndex = 7;
            label3.Text = "Password -";
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.BlueViolet;
            button1.Location = new Point(201, 403);
            button1.Name = "button1";
            button1.Size = new Size(135, 53);
            button1.TabIndex = 8;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(554, 513);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(passwordTB);
            Controls.Add(idTB);
            Controls.Add(nameTB);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private TextBox nameTB;
        private TextBox idTB;
        private TextBox passwordTB;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
    }
}