using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesterProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            LoginForm a = new LoginForm();
            a.Show();
        }

        private void btnKasir_Click(object sender, EventArgs e)
        {
            LoginForm a = new LoginForm();
            a.Show();
        }

        private void btnKepala_Click(object sender, EventArgs e)
        {
            LoginForm a = new LoginForm();
            a.Show();
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm a = new LoginForm();
            a.Show();
        }

        private void btnAdmin_MouseClick(object sender, MouseEventArgs e)
        {
            LoginForm a = new LoginForm();
            a.Show();
        }

        private void btnAdmin_Click_1(object sender, EventArgs e)
        {
            LoginForm a = new LoginForm();
            this.Hide();
            a.Show();
            
        }
    }
}
