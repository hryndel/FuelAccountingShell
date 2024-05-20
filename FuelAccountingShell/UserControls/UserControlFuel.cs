﻿using FuelAccountingShell.Forms;
using System;
using System.Windows.Forms;

namespace FuelAccountingShell.UserControls
{
    public partial class UserControlFuel : UserControl
    {
        public UserControlFuel()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAddEditFuel form = new FormAddEditFuel();
            form.ShowDialog();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            FormAddEditFuel form = new FormAddEditFuel("test");
            form.ShowDialog();
        }
    }
}
