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
    public partial class Форма_мастера : Form
    {
        Model1 db = new Model1();
        public Форма_мастера()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form vh = new Авторизация();
            vh.Visible = true;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form mat = new Список_материалов_закрытый_();
            mat.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form kom = new Список_комплектующих_закрытый_();
            kom.Visible = true;
        }
    }
}
