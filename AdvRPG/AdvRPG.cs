using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvRPG
{
    public partial class AdvRPG : Form
    {
        public AdvRPG()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            label2.Text = "Hey I changedz!";
            lblExperience.Text = "230000";
        }

        private void AdvRPG_Load(object sender, EventArgs e)
        {

        }
    }
}
