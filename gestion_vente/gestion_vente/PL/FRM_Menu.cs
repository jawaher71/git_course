using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion_vente.PL
{
    public partial class FRM_Menu : Form
    {
        public FRM_Menu()
        {
            InitializeComponent();
            panel1.Size = new Size(197, 361);
        }

        private void FRM_Menu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelbut.Top = btnuser.Top;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if(panel1.Width==197)
            {
                 panel1.Size= new Size(43, 361);

            }
            else
            {
                panel1.Size = new Size(197, 361);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            panelbut.Top = btnproduit.Top;
        }

        private void btnclient_Click(object sender, EventArgs e)
        {
            panelbut.Top = btnclient.Top;
        }

        private void btncat_Click(object sender, EventArgs e)
        {
            panelbut.Top = btncommande.Top;
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            if (panel1.Width== 197)
            {
                panel1.Size= new Size(45,363);
            }
            else
            {
                panel1.Size = new Size(197, 361);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
