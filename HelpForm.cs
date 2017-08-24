using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_clinic
{
    public partial class HelpForm : Form
    {
        Form1 parent;
        public HelpForm(Form1 p)
        {
            parent = p;
            InitializeComponent();
        }

        private void HelpForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
            this.Close();
        }
    }
}
