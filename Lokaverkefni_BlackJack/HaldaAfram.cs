using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lokaverkefni_BlackJack
{
    public partial class HaldaAfram : Form
    {
        Gagnagrunnur gagni = new Gagnagrunnur();

        string notendanafn = "";

        public HaldaAfram(string nafn)
        {
            InitializeComponent();

            //Hér er reynt að tengjast við gagnagrunnin sjálfan, sett í try/catch svo hægt sé að grípa villu ef hún kemur upp án þess að forritið krassar
            try
            {
                gagni.TengingVidGagnagrunn();
            }
            catch (Exception ex)
            {
                //MessageBox kemur upp ef upp kemur villa
                MessageBox.Show(ex.ToString());
            }

            notendanafn = nafn;
        }

        private void btnJa_Click(object sender, EventArgs e)
        {
            this.Hide();

            gagni.ByrjaAftur(notendanafn);
        }

        private void btnNei_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}
