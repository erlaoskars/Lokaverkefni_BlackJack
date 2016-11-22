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
    public partial class BlackJack : Form
    {
        public BlackJack()
        {
            InitializeComponent();
        }

        private void mInstructionsIS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Í Blackjack er markmiðið að summa dregna spila sé 21 eða minni. Ef kortasumman er hærri þá springur notandinn og tapar." +
            " Notandinn getur skráð sig inn og sem vistar svo breytingar, notandinn byrjar með 100$ en ef hann fer undir 0$ fær hann aftur 100$." +
            " Notandinn getur veðjað pening, ef notandinn vinnur þá fær hann tvöfalt sem hann lagði út en ef hann tapar missir hann peninginn." +

            "\n\nHit: Dragðu annað kort frá búnka og taka áhættuna á því að fara yfir 21." +
            "\n\nSignal: Ekki draga annað spil og taka áhættuna að talvan dregur lægri summu eða fer yfir 21." +
             "Þetta virkar, Þetta virkar aftur");
        }
    }
}
