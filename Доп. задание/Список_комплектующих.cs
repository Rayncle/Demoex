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
    public partial class Список_комплектующих : Form
    {
        Model1 db = new Model1();
        public Список_комплектующих()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Список_комплектующих_Load(object sender, EventArgs e)
        {
            комплектующийBindingSource.DataSource = db.Комплектующий.ToList();
        }
    }
}
