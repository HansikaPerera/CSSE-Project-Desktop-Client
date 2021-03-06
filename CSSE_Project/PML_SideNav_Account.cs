﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSSE_Project
{
    public partial class PML_SideNav_Account : Form
    {
        public PML_SideNav_Account()
        {
            InitializeComponent();
        }

        private void btn_Supervisor_signOut_Click(object sender, EventArgs e)
        {
            PML_Login login = new PML_Login();
            login.Show();
            this.Hide();
        }

        private void btn_Supervisor_POHistory_Click(object sender, EventArgs e)
        {
            PML_POhistory history = new PML_POhistory();
            history.Show();
            this.Hide();
        }
    }
}
