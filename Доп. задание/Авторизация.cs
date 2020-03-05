using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Доп.задание
{
    public partial class Авторизация : Form
    {
        public static Авторизация VHOD { get; set; }
        public static Пользователь USER { get; set; }
        public Авторизация()
        {
            InitializeComponent();

        }
        Model1 db = new Model1();

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Нужно задать логин и пароль!");
                return;
            }

            Пользователь usr = db.Пользователь.Find(textBox1.Text);

            if ((usr != null) && (usr.Пароль == textBox2.Text))
            {

                USER = usr;
                VHOD = this;
                if (usr.Роль == "Директор")
                {
                    Форма_директора dr = new Форма_директора();
                    dr.Visible = true;
                    this.Hide();
                }
                else if (usr.Роль == "Менеджер")
                {
                    Форма_менеджера mn = new Форма_менеджера();
                    mn.Visible = true;
                    this.Hide();
                }
                else if (usr.Роль == "Заказчик")
                {
                    Форма_заказчика zk = new Форма_заказчика();
                    zk.Visible = true;
                    this.Hide();
                }
                else if (usr.Роль == "Конструктор")
                {
                    Форма_конструктора kn = new Форма_конструктора();
                    kn.Visible = true;
                    this.Hide();
                }
                else if (usr.Роль == "Мастер")
                {
                    Форма_мастера mas = new Форма_мастера();
                    mas.Visible = true;
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Такого пользователя не существует или неверно введен пароль!");
                textBox2.Text = "";
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Регистрация reg = new Регистрация();
            reg.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Вход_Load(object sender, EventArgs e)
        {

        }
    }
}
