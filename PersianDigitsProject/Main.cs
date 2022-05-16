using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Gp20AppCode.Calculat;

namespace PersianDigitsProject
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void BtnPersianDigits_Click(object sender, EventArgs e)
        {
            lblResult.Text = PersianDigit.ConvertDigits(txtMyNumber.Text);
        }
    }
}
