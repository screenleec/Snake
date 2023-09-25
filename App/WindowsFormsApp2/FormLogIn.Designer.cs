
namespace WindowsFormsApp2
{
    partial class FormLogIn
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Vhod_button1 = new System.Windows.Forms.Button();
            this.login_textBox1 = new System.Windows.Forms.TextBox();
            this.Parol_textBox1 = new System.Windows.Forms.TextBox();
            this.login_label1 = new System.Windows.Forms.Label();
            this.Parol_label1 = new System.Windows.Forms.Label();
            this.Registracia_label1 = new System.Windows.Forms.Label();
            this.Registracia_button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Vhod_button1
            // 
            this.Vhod_button1.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Vhod_button1.Location = new System.Drawing.Point(42, 130);
            this.Vhod_button1.Margin = new System.Windows.Forms.Padding(2);
            this.Vhod_button1.Name = "Vhod_button1";
            this.Vhod_button1.Size = new System.Drawing.Size(71, 30);
            this.Vhod_button1.TabIndex = 0;
            this.Vhod_button1.Text = "Вход";
            this.Vhod_button1.UseVisualStyleBackColor = true;
            this.Vhod_button1.Click += new System.EventHandler(this.Vhod_button1_Click);
            // 
            // login_textBox1
            // 
            this.login_textBox1.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_textBox1.Location = new System.Drawing.Point(17, 40);
            this.login_textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.login_textBox1.Multiline = true;
            this.login_textBox1.Name = "login_textBox1";
            this.login_textBox1.Size = new System.Drawing.Size(129, 28);
            this.login_textBox1.TabIndex = 1;
            // 
            // Parol_textBox1
            // 
            this.Parol_textBox1.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Parol_textBox1.Location = new System.Drawing.Point(17, 89);
            this.Parol_textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.Parol_textBox1.Multiline = true;
            this.Parol_textBox1.Name = "Parol_textBox1";
            this.Parol_textBox1.PasswordChar = '•';
            this.Parol_textBox1.Size = new System.Drawing.Size(129, 28);
            this.Parol_textBox1.TabIndex = 2;
            // 
            // login_label1
            // 
            this.login_label1.AutoSize = true;
            this.login_label1.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_label1.Location = new System.Drawing.Point(20, 25);
            this.login_label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.login_label1.Name = "login_label1";
            this.login_label1.Size = new System.Drawing.Size(37, 15);
            this.login_label1.TabIndex = 3;
            this.login_label1.Text = "Логин";
            // 
            // Parol_label1
            // 
            this.Parol_label1.AutoSize = true;
            this.Parol_label1.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Parol_label1.Location = new System.Drawing.Point(21, 74);
            this.Parol_label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Parol_label1.Name = "Parol_label1";
            this.Parol_label1.Size = new System.Drawing.Size(43, 15);
            this.Parol_label1.TabIndex = 4;
            this.Parol_label1.Text = "Пароль";
            // 
            // Registracia_label1
            // 
            this.Registracia_label1.AutoSize = true;
            this.Registracia_label1.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Registracia_label1.Location = new System.Drawing.Point(167, 255);
            this.Registracia_label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Registracia_label1.Name = "Registracia_label1";
            this.Registracia_label1.Size = new System.Drawing.Size(265, 15);
            this.Registracia_label1.TabIndex = 5;
            this.Registracia_label1.Text = "Если у Вас нет аккаунта, зарегистрируйтесь ";
            // 
            // Registracia_button1
            // 
            this.Registracia_button1.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Registracia_button1.Location = new System.Drawing.Point(234, 277);
            this.Registracia_button1.Margin = new System.Windows.Forms.Padding(2);
            this.Registracia_button1.Name = "Registracia_button1";
            this.Registracia_button1.Size = new System.Drawing.Size(129, 25);
            this.Registracia_button1.TabIndex = 6;
            this.Registracia_button1.Text = "Зарегистрироваться";
            this.Registracia_button1.UseVisualStyleBackColor = true;
            this.Registracia_button1.Click += new System.EventHandler(this.Registracia_button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Parol_textBox1);
            this.groupBox1.Controls.Add(this.Vhod_button1);
            this.groupBox1.Controls.Add(this.login_textBox1);
            this.groupBox1.Controls.Add(this.Parol_label1);
            this.groupBox1.Controls.Add(this.login_label1);
            this.groupBox1.Location = new System.Drawing.Point(217, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(159, 170);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // FormVhod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 358);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Registracia_button1);
            this.Controls.Add(this.Registracia_label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormVhod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Vhod_button1;
        private System.Windows.Forms.TextBox login_textBox1;
        private System.Windows.Forms.TextBox Parol_textBox1;
        private System.Windows.Forms.Label login_label1;
        private System.Windows.Forms.Label Parol_label1;
        private System.Windows.Forms.Label Registracia_label1;
        private System.Windows.Forms.Button Registracia_button1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

