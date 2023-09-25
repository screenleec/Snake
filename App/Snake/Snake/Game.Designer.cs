namespace Snake
{
    partial class Game
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.Restart_label = new System.Windows.Forms.Label();
            this.User_label = new System.Windows.Forms.Label();
            this.HighScore_label = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ChangeUser_button = new System.Windows.Forms.Button();
            this.labelScore = new System.Windows.Forms.Label();
            this.Start_label = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Restart_label
            // 
            this.Restart_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Restart_label.Font = new System.Drawing.Font("Cascadia Code", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Restart_label.ForeColor = System.Drawing.Color.White;
            this.Restart_label.Image = ((System.Drawing.Image)(resources.GetObject("Restart_label.Image")));
            this.Restart_label.Location = new System.Drawing.Point(12, 132);
            this.Restart_label.Name = "Restart_label";
            this.Restart_label.Size = new System.Drawing.Size(457, 224);
            this.Restart_label.TabIndex = 0;
            this.Restart_label.Text = "You Lose! \r\nPress R to restart";
            this.Restart_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // User_label
            // 
            this.User_label.AutoSize = true;
            this.User_label.Font = new System.Drawing.Font("Cascadia Code SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_label.Location = new System.Drawing.Point(6, 16);
            this.User_label.Name = "User_label";
            this.User_label.Size = new System.Drawing.Size(91, 15);
            this.User_label.TabIndex = 0;
            this.User_label.Text = "Пользователь: ";
            // 
            // HighScore_label
            // 
            this.HighScore_label.AutoSize = true;
            this.HighScore_label.Font = new System.Drawing.Font("Cascadia Code SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HighScore_label.Location = new System.Drawing.Point(6, 47);
            this.HighScore_label.Name = "HighScore_label";
            this.HighScore_label.Size = new System.Drawing.Size(55, 15);
            this.HighScore_label.TabIndex = 1;
            this.HighScore_label.Text = "Рекорд: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ChangeUser_button);
            this.groupBox1.Controls.Add(this.User_label);
            this.groupBox1.Controls.Add(this.HighScore_label);
            this.groupBox1.Location = new System.Drawing.Point(491, 355);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(161, 122);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // ChangeUser_button
            // 
            this.ChangeUser_button.Font = new System.Drawing.Font("Cascadia Code SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeUser_button.Location = new System.Drawing.Point(6, 85);
            this.ChangeUser_button.Name = "ChangeUser_button";
            this.ChangeUser_button.Size = new System.Drawing.Size(149, 29);
            this.ChangeUser_button.TabIndex = 2;
            this.ChangeUser_button.Text = "Сменить пользователя";
            this.ChangeUser_button.UseVisualStyleBackColor = true;
            this.ChangeUser_button.Click += new System.EventHandler(this.ChangeUser_button_Click);
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Cascadia Code SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelScore.Location = new System.Drawing.Point(515, 9);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(73, 21);
            this.labelScore.TabIndex = 3;
            this.labelScore.Text = "Score: ";
            // 
            // Start_label
            // 
            this.Start_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Start_label.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Start_label.ForeColor = System.Drawing.Color.White;
            this.Start_label.Image = ((System.Drawing.Image)(resources.GetObject("Start_label.Image")));
            this.Start_label.Location = new System.Drawing.Point(12, 9);
            this.Start_label.Name = "Start_label";
            this.Start_label.Size = new System.Drawing.Size(457, 468);
            this.Start_label.TabIndex = 4;
            this.Start_label.Text = resources.GetString("Start_label.Text");
            this.Start_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(230)))), ((int)(((byte)(126)))));
            this.ClientSize = new System.Drawing.Size(664, 489);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Restart_label);
            this.Controls.Add(this.Start_label);
            this.KeyPreview = true;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label Restart_label;
        private System.Windows.Forms.Label User_label;
        private System.Windows.Forms.Label HighScore_label;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ChangeUser_button;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label Start_label;
    }
}

