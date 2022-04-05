using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace byasovdavidproject
{
    public partial class FormSecondlevel : Form
    {
        public FormSecondlevel()
        {
            InitializeComponent();
        }

        private void buttonRight_Clic(object sender, EventArgs e)
        {
            FormLoss form = new FormLoss();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void ButtonLeft_Click(object sender, EventArgs e)
        {
            FormThirdlevel form = new FormThirdlevel();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}
