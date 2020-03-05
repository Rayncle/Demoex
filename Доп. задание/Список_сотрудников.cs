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
    public partial class Список_сотрудников : Form
    {
        Model1 db = new Model1();
        public Список_сотрудников()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Список_сотрудников_Load(object sender, EventArgs e)
        {
            сотрудникиBindingSource.DataSource = db.Сотрудники.ToList();
        }
    }
}
