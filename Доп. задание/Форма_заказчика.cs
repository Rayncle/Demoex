﻿using System;
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
    public partial class Форма_заказчика : Form
    {
        Model1 db = new Model1();
        public Форма_заказчика()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form vh = new Авторизация();
            vh.Visible = true;
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form zak = new Заказы();
            zak.Visible = true;
        }
    }
}
