
namespace WindowsFormsApp2
{
    partial class FormRegistr
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
            this.ToRegistr_button = new System.Windows.Forms.Button();
            this.Password_textBox = new System.Windows.Forms.TextBox();
            this.Login_textBox = new System.Windows.Forms.TextBox();
            this.Vvodlogina_lable = new System.Windows.Forms.Label();
            this.Vvodparol_lable = new System.Windows.Forms.Label();
            this.Povtorparol_lable = new System.Windows.Forms.Label();
            this.RepeatPassword_textBox = new System.Windows.Forms.TextBox();
            this.warning_label = new System.Windows.Forms.Label();
            this.ReturnToLogIn_button = new System.Windows.Forms.Button();
            this.IsAccount_label = new System.Windows.Forms.Label();
            this.RegistrData_groupBox = new System.Windows.Forms.GroupBox();
            this.RegistrData_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToRegistr_button
            // 
            this.ToRegistr_button.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToRegistr_button.Location = new System.Drawing.Point(38, 233);
            this.ToRegistr_button.Margin = new System.Windows.Forms.Padding(2);
            this.ToRegistr_button.Name = "ToRegistr_button";
            this.ToRegistr_button.Size = new System.Drawing.Size(130, 28);
            this.ToRegistr_button.TabIndex = 4;
            this.ToRegistr_button.Text = "Зарегистрироваться";
            this.ToRegistr_button.UseVisualStyleBackColor = true;
            this.ToRegistr_button.Click += new System.EventHandler(this.ToRegistr_button_Click);
            // 
            // Password_textBox
            // 
            this.Password_textBox.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password_textBox.Location = new System.Drawing.Point(38, 93);
            this.Password_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.Password_textBox.Multiline = true;
            this.Password_textBox.Name = "Password_textBox";
            this.Password_textBox.PasswordChar = '•';
            this.Password_textBox.Size = new System.Drawing.Size(130, 29);
            this.Password_textBox.TabIndex = 5;
            this.Password_textBox.TextChanged += new System.EventHandler(this.Password_textBox_TextChanged);
            // 
            // Login_textBox
            // 
            this.Login_textBox.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login_textBox.Location = new System.Drawing.Point(38, 36);
            this.Login_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.Login_textBox.Multiline = true;
            this.Login_textBox.Name = "Login_textBox";
            this.Login_textBox.Size = new System.Drawing.Size(130, 28);
            this.Login_textBox.TabIndex = 6;
            // 
            // Vvodlogina_lable
            // 
            this.Vvodlogina_lable.AutoSize = true;
            this.Vvodlogina_lable.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Vvodlogina_lable.Location = new System.Drawing.Point(35, 20);
            this.Vvodlogina_lable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Vvodlogina_lable.Name = "Vvodlogina_lable";
            this.Vvodlogina_lable.Size = new System.Drawing.Size(103, 15);
            this.Vvodlogina_lable.TabIndex = 9;
            this.Vvodlogina_lable.Text = "Придумайте логин";
            // 
            // Vvodparol_lable
            // 
            this.Vvodparol_lable.AutoSize = true;
            this.Vvodparol_lable.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Vvodparol_lable.Location = new System.Drawing.Point(35, 78);
            this.Vvodparol_lable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Vvodparol_lable.Name = "Vvodparol_lable";
            this.Vvodparol_lable.Size = new System.Drawing.Size(109, 15);
            this.Vvodparol_lable.TabIndex = 10;
            this.Vvodparol_lable.Text = "Придумайте пароль";
            // 
            // Povtorparol_lable
            // 
            this.Povtorparol_lable.AutoSize = true;
            this.Povtorparol_lable.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Povtorparol_lable.Location = new System.Drawing.Point(35, 141);
            this.Povtorparol_lable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Povtorparol_lable.Name = "Povtorparol_lable";
            this.Povtorparol_lable.Size = new System.Drawing.Size(103, 15);
            this.Povtorparol_lable.TabIndex = 11;
            this.Povtorparol_lable.Text = "Повторите пароль";
            // 
            // RepeatPassword_textBox
            // 
            this.RepeatPassword_textBox.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RepeatPassword_textBox.Location = new System.Drawing.Point(38, 158);
            this.RepeatPassword_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.RepeatPassword_textBox.Multiline = true;
            this.RepeatPassword_textBox.Name = "RepeatPassword_textBox";
            this.RepeatPassword_textBox.PasswordChar = '•';
            this.RepeatPassword_textBox.Size = new System.Drawing.Size(130, 30);
            this.RepeatPassword_textBox.TabIndex = 12;
            this.RepeatPassword_textBox.TextChanged += new System.EventHandler(this.RepeatPassword_textBox_TextChanged);
            // 
            // warning_label
            // 
            this.warning_label.AutoSize = true;
            this.warning_label.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.warning_label.ForeColor = System.Drawing.Color.IndianRed;
            this.warning_label.Location = new System.Drawing.Point(10, 209);
            this.warning_label.Name = "warning_label";
            this.warning_label.Size = new System.Drawing.Size(43, 15);
            this.warning_label.TabIndex = 13;
            this.warning_label.Text = "label1";
            this.warning_label.Visible = false;
            // 
            // ReturnToLogIn_button
            // 
            this.ReturnToLogIn_button.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReturnToLogIn_button.Location = new System.Drawing.Point(88, 340);
            this.ReturnToLogIn_button.Name = "ReturnToLogIn_button";
            this.ReturnToLogIn_button.Size = new System.Drawing.Size(130, 28);
            this.ReturnToLogIn_button.TabIndex = 14;
            this.ReturnToLogIn_button.Text = "Войти";
            this.ReturnToLogIn_button.UseVisualStyleBackColor = true;
            this.ReturnToLogIn_button.Click += new System.EventHandler(this.ReturnToLogIn_button_Click);
            // 
            // IsAccount_label
            // 
            this.IsAccount_label.AutoSize = true;
            this.IsAccount_label.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IsAccount_label.Location = new System.Drawing.Point(85, 322);
            this.IsAccount_label.Name = "IsAccount_label";
            this.IsAccount_label.Size = new System.Drawing.Size(133, 15);
            this.IsAccount_label.TabIndex = 15;
            this.IsAccount_label.Text = "Есть аккаунт? Войдите";
            // 
            // RegistrData_groupBox
            // 
            this.RegistrData_groupBox.Controls.Add(this.Login_textBox);
            this.RegistrData_groupBox.Controls.Add(this.ToRegistr_button);
            this.RegistrData_groupBox.Controls.Add(this.Password_textBox);
            this.RegistrData_groupBox.Controls.Add(this.warning_label);
            this.RegistrData_groupBox.Controls.Add(this.Vvodlogina_lable);
            this.RegistrData_groupBox.Controls.Add(this.RepeatPassword_textBox);
            this.RegistrData_groupBox.Controls.Add(this.Vvodparol_lable);
            this.RegistrData_groupBox.Controls.Add(this.Povtorparol_lable);
            this.RegistrData_groupBox.Location = new System.Drawing.Point(50, 26);
            this.RegistrData_groupBox.Name = "RegistrData_groupBox";
            this.RegistrData_groupBox.Size = new System.Drawing.Size(206, 284);
            this.RegistrData_groupBox.TabIndex = 16;
            this.RegistrData_groupBox.TabStop = false;
            // 
            // FormRegistr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 396);
            this.Controls.Add(this.RegistrData_groupBox);
            this.Controls.Add(this.IsAccount_label);
            this.Controls.Add(this.ReturnToLogIn_button);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormRegistr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.RegistrData_groupBox.ResumeLayout(false);
            this.RegistrData_groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ToRegistr_button;
        private System.Windows.Forms.TextBox Password_textBox;
        private System.Windows.Forms.TextBox Login_textBox;
        private System.Windows.Forms.Label Vvodlogina_lable;
        private System.Windows.Forms.Label Vvodparol_lable;
        private System.Windows.Forms.Label Povtorparol_lable;
        private System.Windows.Forms.TextBox RepeatPassword_textBox;
        private System.Windows.Forms.Label warning_label;
        private System.Windows.Forms.Button ReturnToLogIn_button;
        private System.Windows.Forms.Label IsAccount_label;
        private System.Windows.Forms.GroupBox RegistrData_groupBox;
    }
}