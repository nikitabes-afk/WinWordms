namespace WinFormsApp1
{
    partial class Reg_Form
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
            Box_Login = new TextBox();
            Reg_Button = new Button();
            Box_Pass = new TextBox();
            SuspendLayout();
            // 
            // Box_Login
            // 
            Box_Login.Font = new Font("Times New Roman", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            Box_Login.Location = new Point(79, 90);
            Box_Login.Multiline = true;
            Box_Login.Name = "Box_Login";
            Box_Login.Size = new Size(296, 67);
            Box_Login.TabIndex = 0;
            // 
            // Reg_Button
            // 
            Reg_Button.Location = new Point(148, 272);
            Reg_Button.Name = "Reg_Button";
            Reg_Button.Size = new Size(159, 45);
            Reg_Button.TabIndex = 2;
            Reg_Button.Text = "Регистрация";
            Reg_Button.UseVisualStyleBackColor = true;
            Reg_Button.Click += Reg_Button_Click;
            // 
            // Box_Pass
            // 
            Box_Pass.Font = new Font("Times New Roman", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            Box_Pass.Location = new Point(79, 184);
            Box_Pass.Name = "Box_Pass";
            Box_Pass.Size = new Size(296, 57);
            Box_Pass.TabIndex = 3;
            Box_Pass.UseSystemPasswordChar = true;
            // 
            // Reg_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 375);
            Controls.Add(Box_Pass);
            Controls.Add(Reg_Button);
            Controls.Add(Box_Login);
            Name = "Reg_Form";
            Text = "Reg_Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Box_Login;
        private Button Reg_Button;
        private TextBox Box_Pass;
    }
}