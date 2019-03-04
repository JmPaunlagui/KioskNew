using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KioskFINALFINAL.UC
{
    public partial class ucASTI : UserControl
    {
        public ucASTI()
        {
            InitializeComponent();
            ucMission1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Form1.Instance.PnlContainer.Controls.ContainsKey("ucMain"))
            {
                ucMAIN main = new ucMAIN();
                main.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainer.Controls.Add(main);
            }
            Form1.Instance.PnlContainer.Controls["ucMain"].BringToFront();
            return ;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ucMission1.BringToFront();
            ucMission1.Show();

            ucVision1.Hide();
           
            ucStiHymn1.Hide();

            return;
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ucVision1.BringToFront();
            ucVision1.Show();

            ucMission1.Hide();
            
            ucStiHymn1.Hide();

            return;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ucStiHymn1.BringToFront();
            ucStiHymn1.Show();

            ucMission1.Hide();
           
            ucVision1.Hide();

            return;

        }

        private void ucStiHymn1_Load(object sender, EventArgs e)
        {
           // ucMission1.BringToFront();
        }
    }
}
