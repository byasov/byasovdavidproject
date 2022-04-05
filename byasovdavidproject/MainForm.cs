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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            FormSecondlevel form = new FormSecondlevel();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            FormLoss form = new FormLoss();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
