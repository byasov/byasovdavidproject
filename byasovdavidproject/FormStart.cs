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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}
