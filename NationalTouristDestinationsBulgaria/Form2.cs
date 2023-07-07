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
    public partial class FormIntern : Form
    {


        public bool PanelPlovdiv_Visability
        {
            get
            {
                return PPlovdiv.Visible;
            }
            set
            {
                PPlovdiv.Visible = value;
            }
        }

        public bool PanelSofia_Visability
        {
            get
            {
                return PSofia.Visible;
            }
            set
            {
                PSofia.Visible = value;
            }
        }

        public bool PanelLovech_Visability
        {
            get
            {
                return PLovech.Visible;
            }
            set
            {
                PLovech.Visible = value;
            }
        }

        public bool PanelTarnovo_Visability
        {
            get
            {
                return PTarnovo.Visible;
            }
            set
            {
                PTarnovo.Visible = value;
            }
        }

        public bool PanelVidin_Visability
        {
            get
            {
                return PVidin.Visible;
            }
            set
            {
                PVidin.Visible = value;
            }
        }

        public bool PanelGabrovo_Visability
        {
            get
            {
                return PGabrovo.Visible;
            }
            set
            {
                PGabrovo.Visible = value;
            }
        }

        public bool PanelSmolyan_Visability
        {
            get
            {
                return PSmolyan.Visible;
            }
            set
            {
                PSmolyan.Visible = value;
            }
        }

        public bool PanelVarna_Visability
        {
            get
            {
                return PVarna.Visible;
            }
            set
            {
                PVarna.Visible = value;
            }
        }

        public bool PanelShumen_Visability
        {
            get
            {
                return PShumen.Visible;
            }
            set
            {
                PShumen.Visible = value;
            }
        }
        public bool PanelSilistra_Visability
        {
            get
            {
                return PSilistra.Visible;
            }
            set
            {
                PSilistra.Visible = value;
            }
        }

        public FormIntern()
        {
            InitializeComponent();
        }

        private void BBackPlovdiv_Click(object sender, EventArgs e)
        {
          
            this.Close(); 
        }

        private void BBackSofia_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BBackLovech_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BBTarnovo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BBVidin_Click(object sender, EventArgs e)
        {
            this.Close();
        } 

        private void BBGabrovo_Click(object sender, EventArgs e)
        {
            this.Close();
        }   

        private void BBSmolyan_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BBVarna_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BBShoumen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BBSIlistra1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
