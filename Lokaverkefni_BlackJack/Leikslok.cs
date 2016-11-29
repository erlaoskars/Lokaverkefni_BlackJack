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
    public partial class Leikslok : Form
    {

        int stigP1 = 0;
        int stigT1 = 0;
        int tapeðawin = 0;

        public Leikslok(int stigPlayer, int stigTalva, int peningur)
        {
            InitializeComponent();

            stigP1 = stigPlayer;
            stigT1 = stigTalva;
            tapeðawin = peningur;
        }

        private void Leikslok_Load(object sender, EventArgs e)
        {
            lblPlayerpoints.Text = stigP1.ToString();
            lblCpupoints.Text = stigT1.ToString();
            lblMoneygol.Text = tapeðawin.ToString();

        }
    }
}
