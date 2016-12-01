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
        //Klasinn gagnagrunnur opnaður til þess að sækja aðferðir til að tengjast við Töflur í gagnagrunni
        Gagnagrunnur gagnagrunnur = new Gagnagrunnur();

        //Búið til random til þess að hægt sé að fá random tölu
        Random random = new Random();

        //int breyta
        int icon = 0;

        public fLokaverkefni()
        {
            InitializeComponent();

            //Hér er reynt að tengjast við gagnagrunnin sjálfan, sett í try/catch svo hægt sé að grípa villu ef hún kemur upp án þess að forritið krassar
            try
            {
                gagnagrunnur.TengingVidGagnagrunn();
            }
            catch (Exception ex)
            {
                //MessageBox kemur upp ef upp kemur villa
                MessageBox.Show(ex.ToString());
            }
        }

        private void fLokaverkefni_Load(object sender, EventArgs e)
        {
            //Hér er sett random tölu í breytuna icon 
            icon = random.Next(1, 5);


            //Hérna er síðan notað if eftir því hvaða tala kom upp í icon
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
        
            //Hér er sagt að lykilorðið megi ekki vera lengra en 15 stafir í heild
            tbLykilord.MaxLength = 15;
        }

        private void btnNyskra_Click(object sender, EventArgs e)
        {
            //String breytur búnar til, ToLower er notað til að setja alla stafi í lágstafi
            string nafn = tbNotendanafn.Text.ToLower();
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
                catch (Exception)
                {
                    gagnagrunnur.CloseConnection();
                    MessageBox.Show("Notendanafn þegar í notkun");
                }
            }
        }

        private void btnSkraInn_Click(object sender, EventArgs e)
        {
            string nafn = tbNotendanafn.Text;
            string lykilord = tbLykilord.Text;
            string passw = null;

            try
            {
                passw = gagnagrunnur.FinnaLykilord(nafn);

                if (passw == lykilord)
                {
                    BlackJack blackjack = new BlackJack(nafn);
                    blackjack.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Rangt lykilorð eða notendanafn");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            Application.Exit();
        }
    }
}
