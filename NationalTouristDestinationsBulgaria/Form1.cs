using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;



namespace NationalTouristDestinationsBulgaria
{
    public partial class FormMain : Form
    { 

        public FormMain()
        {
            InitializeComponent();


        }

        private void PBPlovdiv_Click(object sender, EventArgs e)
        {
            FormIntern f2 = new FormIntern();
            f2.Show();
            f2.PanelSilistra_Visability = false;
            f2.PanelShumen_Visability = false;
            f2.PanelVarna_Visability = false;
            f2.PanelSmolyan_Visability = false;
            f2.PanelVidin_Visability = false;
            f2.PanelTarnovo_Visability = false;
            f2.PanelLovech_Visability = false;
            f2.PanelSofia_Visability = false;
            f2.PanelGabrovo_Visability = false;
            f2.PanelPlovdiv_Visability = true;
        }

        private void PBSofia_Click(object sender, EventArgs e)
        {
            FormIntern f2 = new FormIntern();
            f2.Show();
            f2.PanelSilistra_Visability = false;
            f2.PanelShumen_Visability = false;
            f2.PanelVarna_Visability = false;
            f2.PanelSmolyan_Visability = false;
            f2.PanelGabrovo_Visability = false;
            f2.PanelVidin_Visability = false;
            f2.PanelLovech_Visability = false;
            f2.PanelSofia_Visability = true;
           
        }

        private void PBLovech_Click(object sender, EventArgs e)
        {
            FormIntern f2 = new FormIntern();
            f2.Show();
            f2.PanelSilistra_Visability = false;
            f2.PanelShumen_Visability = false;
            f2.PanelVarna_Visability = false;
            f2.PanelSmolyan_Visability = false;
            f2.PanelGabrovo_Visability = false;
            f2.PanelVidin_Visability = false;
            f2.PanelTarnovo_Visability = false;
            f2.PanelLovech_Visability = true;

        }

        private void PBVTarnovo_Click(object sender, EventArgs e)
        {
            FormIntern f2 = new FormIntern();
            f2.Show();
            f2.PanelSilistra_Visability = false;
            f2.PanelShumen_Visability = false;
            f2.PanelVarna_Visability = false;
            f2.PanelSmolyan_Visability = false;
            f2.PanelGabrovo_Visability = false;
            f2.PanelVidin_Visability = false;
            f2.PanelTarnovo_Visability = true;
        }

        private void PBVidin_Click(object sender, EventArgs e)
        {
            FormIntern f2 = new FormIntern();
            f2.Show();
            f2.PanelSilistra_Visability = false;
            f2.PanelShumen_Visability = false;
            f2.PanelVarna_Visability = false;
            f2.PanelSmolyan_Visability = false;
            f2.PanelGabrovo_Visability = false;
            f2.PanelVidin_Visability = true;
        }

        private void PBGabrovo_Click(object sender, EventArgs e)
        {
            FormIntern f2 = new FormIntern();
            f2.Show();
            f2.PanelSilistra_Visability = false;
            f2.PanelShumen_Visability = false;
            f2.PanelVarna_Visability = false;
            f2.PanelSmolyan_Visability = false;
            f2.PanelGabrovo_Visability = true;
        }

        private void PBSmolyan_Click(object sender, EventArgs e)
        {
            FormIntern f2 = new FormIntern();
            f2.Show();
            f2.PanelSilistra_Visability = false;
            f2.PanelShumen_Visability = false;
            f2.PanelVarna_Visability = false;
            f2.PanelSmolyan_Visability = true;

        }

        private void PBVarna_Click(object sender, EventArgs e)
        {
            FormIntern f2 = new FormIntern();
            f2.Show();
            f2.PanelSilistra_Visability = false;
            f2.PanelShumen_Visability = false;
            f2.PanelVarna_Visability = true;

        }

        private void PBShumen_Click(object sender, EventArgs e)
        {
            FormIntern f2 = new FormIntern();
            f2.Show();
            f2.PanelSilistra_Visability = false; ;
            f2.PanelShumen_Visability = true;
        }

        private void PBSilistra_Click(object sender, EventArgs e)
        {
            FormIntern f2 = new FormIntern();
            f2.Show();
            f2.PanelSilistra_Visability = true;
        }
    }
}
