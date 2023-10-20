namespace SiTandurApp
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
            lblHalamanLogin = new Label();
            tbEmailLogin = new TextBox();
            button1 = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // lblHalamanLogin
            // 
            lblHalamanLogin.AutoSize = true;
            lblHalamanLogin.BackColor = Color.Transparent;
            lblHalamanLogin.Font = new Font("Tahoma", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblHalamanLogin.ForeColor = SystemColors.ButtonHighlight;
            lblHalamanLogin.Location = new Point(51, 62);
            lblHalamanLogin.Name = "lblHalamanLogin";
            lblHalamanLogin.Size = new Size(217, 33);
            lblHalamanLogin.TabIndex = 0;
            lblHalamanLogin.Text = "Halaman Login";
            lblHalamanLogin.Click += label1_Click;
            // 
            // tbEmailLogin
            // 
            tbEmailLogin.BorderStyle = BorderStyle.FixedSingle;
            tbEmailLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbEmailLogin.Location = new Point(69, 116);
            tbEmailLogin.Name = "tbEmailLogin";
            tbEmailLogin.Size = new Size(179, 29);
            tbEmailLogin.TabIndex = 1;
            tbEmailLogin.Text = "Email";
            tbEmailLogin.TextChanged += tbEmailLogin_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(119, 213);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(69, 160);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(179, 29);
            textBox1.TabIndex = 4;
            textBox1.Text = "Password";
            textBox1.UseSystemPasswordChar = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.MicrosoftTeams_image__3_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(308, 287);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(tbEmailLogin);
            Controls.Add(lblHalamanLogin);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHalamanLogin;
        private TextBox tbEmailLogin;
        private Button button1;
        private TextBox textBox1;
    }
}