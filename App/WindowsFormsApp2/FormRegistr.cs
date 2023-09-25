using Snake;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FormRegistr : Form
    {
        public FormRegistr()
        {
            InitializeComponent();
            this.BackColor = Images.BackGroundC;
        }

        private void Password_textBox_TextChanged(object sender, EventArgs e)
        {
            if (Password_textBox.Text != RepeatPassword_textBox.Text)
            {
                warning_label.Visible = true;
                warning_label.Text = "Введенные пароли не совпадают";
            }
            else warning_label.Visible = false;
        }

        private void RepeatPassword_textBox_TextChanged(object sender, EventArgs e)
        {
            if (Password_textBox.Text != RepeatPassword_textBox.Text)
            {
                warning_label.Visible = true;
                warning_label.Text = "Введенные пароли не совпадают";
            }
            else warning_label.Visible = false;
        }
        
        private void ToRegistr_button_Click(object sender, EventArgs e)
        {
            Database db = new Database("Data Source=dataBase.db;Version=3;");

            if (Password_textBox.Text == RepeatPassword_textBox.Text && isCorrect())
            {
                if (db.createUser(Login_textBox.Text, Password_textBox.Text))
                {
                    this.Close();
                }
                return;
            }
            else
            {
                MessageBox.Show("Ошибка ввода данных");
            }
        }

        private bool isCorrect()
        {
            return !(String.IsNullOrWhiteSpace(Password_textBox.Text)
                && String.IsNullOrWhiteSpace(RepeatPassword_textBox.Text)
                && String.IsNullOrWhiteSpace(Login_textBox.Text));
        }

        private void ReturnToLogIn_button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
