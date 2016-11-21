using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*Erla Óskarsdóttir og Hrafnkell Þorri Þrastarson
 * Lokaverkefni - 3. önn - Haust 2016 */

namespace Lokaverkefni_BlackJack
{
    public partial class fLokaverkefni : Form
    {
        Gagnagrunnur gagnagrunnur = new Gagnagrunnur();
        Random random = new Random();

        int icon = 0;

        public fLokaverkefni()
        {
            InitializeComponent();

            try
            {
                gagnagrunnur.TengingVidGagnagrunn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void fLokaverkefni_Load(object sender, EventArgs e)
        {
            icon = random.Next(1, 5);

            if (icon == 1)
            {
                tbLykilord.PasswordChar = '♠';
            }
            if (icon == 2)
            {
                tbLykilord.PasswordChar = '♥';
            }
            if (icon == 3)
            {
                tbLykilord.PasswordChar = '♦';
            }
            if (icon == 4)
            {
                tbLykilord.PasswordChar = '♣';
            }
        
            tbLykilord.MaxLength = 15;
        }

        private void btnNyskra_Click(object sender, EventArgs e)
        {
            string nafn = tbNotendanafn.Text;
            string lykilord = tbLykilord.Text;


            if (nafn == "" && lykilord == "")
            {
                MessageBox.Show("Vantar notendanafn og lykilorð");
            }
            else if (lykilord == "")
            {
                MessageBox.Show("Vantar lykilorð");
            }
            else if (nafn == "")
            {
                MessageBox.Show("Vantar notendanafn");
            }
            else
            {
                try
                {
                    gagnagrunnur.SettInnSqlToflu(nafn, lykilord);
                    MessageBox.Show("Þetta tókst");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Notendanafn þegar í notkun" + ex);
                }
            }
        }

        private void btnSkraInn_Click(object sender, EventArgs e)
        {
            string nafn = tbNotendanafn.Text;
            string lykilord = tbLykilord.Text;
        }

        
    }
}
