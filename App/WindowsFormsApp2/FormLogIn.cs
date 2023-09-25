using System;
using System.Threading;
using System.Windows.Forms;
using Snake;

namespace WindowsFormsApp2
{
    public partial class FormLogIn : Form
    {
        Thread SnakeStart;
        private string userName;
        public FormLogIn()
        {
            InitializeComponent();
            this.BackColor = Images.BackGroundC;
        }

        private void Registracia_button1_Click(object sender, EventArgs e)
        {
            FormRegistr reg = new FormRegistr();
            Hide();
            reg.ShowDialog();
            this.Show();
        }

        public void open(object obj)
        {
            Application.Run(new Game(userName));
        }

        public void gameRun()
        {
            this.Close();
            SnakeStart = new Thread(open);
            SnakeStart.SetApartmentState(ApartmentState.STA);
            SnakeStart.Start();
        }

        private void Vhod_button1_Click(object sender, EventArgs e)
        {
            if (userAuthSucceess())
            {
                userName = login_textBox1.Text;
                MessageBox.Show("Вход выполнен!");
                this.DialogResult = DialogResult.OK;

                gameRun();
            }
            else
                return;
        }
        
        private bool userAuthSucceess()
        {
            if (incorrectFiledsOnForm())
            {
                MessageBox.Show("Некорректные поля на форме");
                return false;
            }


            if (hasUser(login_textBox1.Text, Parol_textBox1.Text))
                return true;
            else
            {
                MessageBox.Show("Неверный логин или пароль");
                return false;
            }
        }
        
        private bool incorrectFiledsOnForm()
        {
            if (isUnCorrectField(login_textBox1.Text) || isUnCorrectField(Parol_textBox1.Text))
                return true;

            return false;
        }

        private bool isUnCorrectField(string field)
        {
            if (String.IsNullOrWhiteSpace(field))
                return true;
            return false;
        }

        private bool hasUser(string login, string password)
        {
            User user = new User(login, password);

            return user.IsCorrect();
        }
    }
}
