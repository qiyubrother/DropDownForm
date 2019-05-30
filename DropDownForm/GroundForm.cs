﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DropDownForm
{
    public partial class GroundForm : Form
    {
        public GroundForm()
        {
            InitializeComponent();
        }

        private void display_Click(object sender, EventArgs e)
        {
            DropDownForm.Instance().ShowForm();//显示窗体
        }

        private void close_Click(object sender, EventArgs e)
        {
            DropDownForm.Instance().CloseForm();//隐藏窗体
            //关闭窗体
            this.Close();
        }
    }
}
