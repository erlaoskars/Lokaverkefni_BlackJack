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
        int stig = 0;
        int spil = 0; //Fundið gildispil og hefur gildi spil einnig.
        int tigulspadilaufas = 0; //Fundið Tegund spils
        string stafurspils = "";
        string validspil = "";
        string gildispils = "";
        string nafn = "";

        Gagnagrunnur gagni = new Gagnagrunnur();


        public BlackJack(string notendanafn)
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

            nafn = notendanafn;
            lblNafn.Text = nafn;
        }

        Adferdir aðferðir = new Adferdir();
        Gagnagrunnur gagnagrunnur = new Gagnagrunnur();
        Random rnd = new Random();
        int round = 1;

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            Application.Exit();
        }

        private void mInstructionsIS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Í Blackjack er markmiðið að summa dregna spila sé 21 eða minni. Ef kortasumman er hærri þá springur notandinn og tapar." +
            " Notandinn getur skráð sig inn og sem vistar svo breytingar, notandinn byrjar með 100$ en ef hann fer undir 0$ fær hann aftur 100$." +
            " Notandinn getur veðjað pening, ef notandinn vinnur þá fær hann tvöfalt sem hann lagði út en ef hann tapar missir hann peninginn." +
            "\n\nHit: Dragðu annað kort frá búnka og taka áhættuna á því að fara yfir 21." +
            "\n\nSignal: Ekki draga annað spil og taka áhættuna að talvan dregur lægri summu eða fer yfir 21.");
        }
        
        private void mInstructionsENG_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In blackjack, the aim is to sum portrayed play is 21 or less. If a card sum is higher then explodes and the user will lose. "+
             "The user can log in and that saves such changes, the user starts with $ 100, but if it falls below $ 0 gets him back $ 100." +
             "The user can bet money, if the user wins then he gets twice as he laid out, but if he loses, he loses money." +
             "\n\n Hit: Draw another card from the pile and take the risk of going over 21." +
             "\n\n Signal: Do not draw another card and take the risk that the computer reduces lower sum or exceeds 21.");
        }

        private void mInstructionsES_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En el blackjack, el objetivo es sumar juego retratado es 21 o menos. Si una suma tarjeta es más alto que explota y el usuario perderá. " +
            "El usuario puede iniciar la sesión y que ahorra tales cambios, el usuario comienza con $ 100, pero si cae por debajo de $ 0 le vuelve $ 100." +
            "El usuario puede apostar dinero, si el usuario gana, se pone el doble expuso, pero si pierde, pierde dinero." +
            "\n\n hit: Dibuje otra carta del mazo y tomar el riesgo de pasarse de 21." +
            "\n\n e señal en: No dibujar otra tarjeta y correr el riesgo de que el equipo reduce suma inferior o superior a 21.");
        }

        private void mLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();

            fLokaverkefni form = new fLokaverkefni();
            form.Show();
        }

        private void mExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mAuthors_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Höfundar: Erla Óskarsdóttir og Hrafnkel þorri Þrastarson.");
        }

        private void BtnHit_Click(object sender, EventArgs e)
        {
            List<string> buinspil = new List<string>();
            
            spil = rnd.Next(1, 14);
            tigulspadilaufas = rnd.Next(1, 5);

            if(tigulspadilaufas == 1)
            {
                stafurspils = "A";
            }
            if (tigulspadilaufas == 2)
            {
                stafurspils = "B";
            }
            if (tigulspadilaufas == 3)
            {
                stafurspils = "C";
            }
            if (tigulspadilaufas == 4)
            {
                stafurspils = "D";
            }

            stig = stig + spil;
            lblStig.Text = stig.ToString();
            gildispils = spil.ToString();
            validspil = (gildispils + stafurspils).ToString();

            if(round == 1)
            {
                    buinspil.Add(validspil);
                    pbSpil.Image = (Image)Properties.Resources.ResourceManager.GetObject(validspil);
                    pbSpil.BringToFront();
            }
            else if (round == 2)
            {
                    buinspil.Add(validspil);
                    pbspil2.Image = (Image)Properties.Resources.ResourceManager.GetObject(validspil);
                    pbspil2.BringToFront();
            }
            else if (round == 3)
            {
                    buinspil.Add(validspil);
                    pbspil3.Image = (Image)Properties.Resources.ResourceManager.GetObject(validspil);
                    pbspil3.BringToFront();
            }
            else if (round == 4)
            {
                    buinspil.Add(validspil);
                    pbspil4.Image = (Image)Properties.Resources.ResourceManager.GetObject(validspil);
                    pbspil4.BringToFront();
            }
            else if (round == 5)
            {
                    buinspil.Add(validspil);
                    pbspil5.Image = (Image)Properties.Resources.ResourceManager.GetObject(validspil);
                    pbspil5.BringToFront();
            }
            else if (round == 6)
            {
                    buinspil.Add(validspil);
                    pbspil6.Image = (Image)Properties.Resources.ResourceManager.GetObject(validspil);
                    pbspil6.BringToFront();
            }
            round++;

            if (stig == 21)
            {
                MessageBox.Show("Winner");
                BtnHit.Hide();
                btnSignal.Hide();
                btnStart.Show();
            }
            if (stig > 21)
            {

                MessageBox.Show("Busted");
                BtnHit.Hide();
                btnSignal.Hide();
                btnStart.Show();
            }
        }
      

        private void btnStart_Click(object sender, EventArgs e)
        {
            stig = 0;
            spil = 0;
            tigulspadilaufas = 0;
            stafurspils = "";
            validspil = "";
            gildispils = "";
            lblStig.Text = "";
            BtnHit.Show();
            btnSignal.Show();
            btnStart.Hide();

            round = 1;
            pbSpil.Image = null; pbspil2.Image = null; pbspil3.Image = null;
            pbspil4.Image = null; pbspil5.Image = null; pbspil6.Image = null;

            int bet = 0;

            if (rbtn50.Checked)
            {
                bet = 50;
            }
            if (rbtn100.Checked)
            {
                bet = 100;
            }
            if (rbtn500.Checked)
            {
                bet = 500;
            }
            if (rbtn50.Checked)
            {
                bet = 1000;
            }
            
            gagni.SettInnBet(nafn, bet);
        }

        

        private void BlackJack_Load(object sender, EventArgs e)
        {
            round = 1;
            pbSpil.InitialImage = null; pbspil2.InitialImage = null; pbspil3.InitialImage = null;
            pbspil4.InitialImage = null; pbspil5.InitialImage = null; pbspil6.InitialImage = null;
        }

    }
}
