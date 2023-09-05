namespace WinForms
{
    partial class LoginForm
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
            mainPanel = new Panel();
            Label_Reg = new LinkLabel();
            passField = new TextBox();
            pictureBox2 = new PictureBox();
            loginField = new TextBox();
            buttonEnter = new Button();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            closeButton = new Label();
            label1 = new Label();
            mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.FromArgb(215, 239, 241);
            mainPanel.Controls.Add(Label_Reg);
            mainPanel.Controls.Add(passField);
            mainPanel.Controls.Add(pictureBox2);
            mainPanel.Controls.Add(loginField);
            mainPanel.Controls.Add(buttonEnter);
            mainPanel.Controls.Add(pictureBox1);
            mainPanel.Controls.Add(panel2);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(489, 435);
            mainPanel.TabIndex = 0;
            mainPanel.MouseDown += mainPanel_MouseDown;
            mainPanel.MouseMove += mainPanel_MouseMove;
            // 
            // Label_Reg
            // 
            Label_Reg.AutoSize = true;
            Label_Reg.Location = new Point(228, 387);
            Label_Reg.Name = "Label_Reg";
            Label_Reg.Size = new Size(73, 20);
            Label_Reg.TabIndex = 10;
            Label_Reg.TabStop = true;
            Label_Reg.Text = "Label_reg";
            Label_Reg.TextAlign = ContentAlignment.TopCenter;
            Label_Reg.LinkClicked += Label_Reg_LinkClicked;
            // 
            // passField
            // 
            passField.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            passField.Location = new Point(102, 209);
            passField.Name = "passField";
            passField.Size = new Size(353, 56);
            passField.TabIndex = 8;
            passField.UseSystemPasswordChar = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(12, 209);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(64, 64);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            pictureBox2.MouseDown += mainPanel_MouseDown;
            pictureBox2.MouseMove += mainPanel_MouseMove;
            // 
            // loginField
            // 
            loginField.Font = new Font("Times New Roman", 22F, FontStyle.Regular, GraphicsUnit.Point);
            loginField.Location = new Point(102, 123);
            loginField.Multiline = true;
            loginField.Name = "loginField";
            loginField.Size = new Size(353, 64);
            loginField.TabIndex = 6;
            // 
            // buttonEnter
            // 
            buttonEnter.BackColor = Color.FromArgb(223, 245, 255);
            buttonEnter.Cursor = Cursors.Hand;
            buttonEnter.FlatAppearance.BorderSize = 0;
            buttonEnter.FlatAppearance.MouseDownBackColor = Color.FromArgb(85, 101, 108);
            buttonEnter.FlatAppearance.MouseOverBackColor = Color.FromArgb(85, 101, 108);
            buttonEnter.FlatStyle = FlatStyle.Flat;
            buttonEnter.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEnter.ForeColor = Color.FromArgb(45, 101, 125);
            buttonEnter.Location = new Point(113, 318);
            buttonEnter.Name = "buttonEnter";
            buttonEnter.Size = new Size(303, 53);
            buttonEnter.TabIndex = 5;
            buttonEnter.Text = "ВОЙТИ";
            buttonEnter.UseVisualStyleBackColor = false;
            buttonEnter.Click += buttonEnter_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 123);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += mainPanel_MouseDown;
            pictureBox1.MouseMove += mainPanel_MouseMove;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(131, 149, 151);
            panel2.Controls.Add(closeButton);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(489, 93);
            panel2.TabIndex = 0;
            // 
            // closeButton
            // 
            closeButton.AutoSize = true;
            closeButton.Cursor = Cursors.Hand;
            closeButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            closeButton.ForeColor = Color.White;
            closeButton.Location = new Point(457, 0);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(32, 41);
            closeButton.TabIndex = 1;
            closeButton.Text = "x";
            closeButton.Click += closeButton_Click;
            closeButton.MouseLeave += closeButton_MouseLeave;
            closeButton.MouseHover += closeButton_MouseHover;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Ink Free", 35.9999962F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(489, 93);
            label1.TabIndex = 0;
            label1.Text = "Авторизация";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.MouseDown += mainPanel_MouseDown;
            label1.MouseMove += mainPanel_MouseMove;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 435);
            Controls.Add(mainPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            Text = "LoginForm";
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainPanel;
        private Panel panel2;
        private Label label1;
        private Label closeButton;
        private PictureBox pictureBox1;
        private Button buttonEnter;
        private TextBox loginField;
        private TextBox passField;
        private PictureBox pictureBox2;
        private LinkLabel Label_Reg;
    }
}