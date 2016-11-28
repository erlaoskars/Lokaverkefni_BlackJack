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
        //Breytur fyrir Notanda
        int stig = 0;
        int spil = 0; //Fundið gildispil og hefur gildi spil einnig.
        int tigulspadilaufas = 0; //Fundið Tegund spils
        string stafurspils = "";
        string validspil = "";
        string gildispils = "";
        string nafn = "";
        int money = 0;
        int bet = 0;

        //Breytur fyrir A.I Andstæðing.
        int spiltolvu = 0;
        int stigtolvu = 0;
        string gildispilstolvu = "";
        string validspiltolvu = "";
        string stafurspiltolvu = "";

        Gagnagrunnur gagni = new Gagnagrunnur();
        Adferdir adferd = new Adferdir();

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
            string instr = ""; 
            instr = adferd.instrIS(instr); 
            MessageBox.Show(instr);
        }
        
        private void mInstructionsENG_Click(object sender, EventArgs e)
        {
            string instr = "";
            instr = adferd.instrEN(instr);
            MessageBox.Show(instr);   
        }

        private void mInstructionsES_Click(object sender, EventArgs e)
        {
            string instr = "";
            instr = adferd.instrES(instr);
            MessageBox.Show(instr);
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
            spiltolvu = rnd.Next(1, 14);
            tigulspadilaufas = rnd.Next(1, 5);


            stafurspils = adferd.randomstafur(stafurspils); //Aðferðir til að ákveða hvort spilið sé Ás, Spaði, Lauf eða Tígull
            stafurspiltolvu = adferd.randomstafur(stafurspiltolvu);

            stig = stig + spil; //Stigin útreiknað 
            stigtolvu = stigtolvu + spiltolvu; //stigin útreiknuð fyrir tolvu

            lblStig.Text = stig.ToString(); // Label fyrir notanda
            lblstigtolvu.Text = stigtolvu.ToString(); // test label
            gildispils = spil.ToString(); 
            validspil = (gildispils + stafurspils).ToString(); //sett saman Value og staf svo hægt sé að birta mynd
            validspiltolvu = (gildispilstolvu + stafurspiltolvu).ToString(); 


            if (round == 1)
            {
                    buinspil.Add(validspil);
                    pbSpil.Image = (Image)Properties.Resources.ResourceManager.GetObject(validspil);
                    pbSpil.BringToFront();
            }
            if (round == 2)
            {
                    buinspil.Add(validspil);
                    pbspil2.Image = (Image)Properties.Resources.ResourceManager.GetObject(validspil);
                    pbspil2.BringToFront();
            }
            if (round == 3)
            {
                    buinspil.Add(validspil);
                    pbspil3.Image = (Image)Properties.Resources.ResourceManager.GetObject(validspil);
                    pbspil3.BringToFront();
            }
            if (round == 4)
            {
                    buinspil.Add(validspil);
                    pbspil4.Image = (Image)Properties.Resources.ResourceManager.GetObject(validspil);
                    pbspil4.BringToFront();
            }
            if (round == 5)
            {
                    buinspil.Add(validspil);
                    pbspil5.Image = (Image)Properties.Resources.ResourceManager.GetObject(validspil);
                    pbspil5.BringToFront();
            }
            if (round == 6)
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
                money = money + (bet * 2);
                gagni.SettInnMoney(nafn, money);
                lblMoney.Text = money.ToString() + "$";
            }
            if (stig > 21)
            {
                MessageBox.Show("Busted");
                BtnHit.Hide();
                btnSignal.Hide();
                btnStart.Show();
                money = money - bet;
                gagni.SettInnMoney(nafn, money);
                lblMoney.Text = money.ToString() + "$";
            }

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            bet = Convert.ToInt32(tbBet.Text);

            if (bet > money)
            {
                MessageBox.Show("Þú átt ekki nægan pening");
            }
            else
            {
                stig = 0;
                stigtolvu = 0;
                spil = 0;
                tigulspadilaufas = 0;
                stafurspils = "";
                validspil = "";
                gildispils = "";
                lblStig.Text = "";
                lblstigtolvu.Text = "";
                BtnHit.Show();
                btnSignal.Show();
                btnStart.Hide();

                round = 1;
                pbSpil.Image = null; pbspil2.Image = null; pbspil3.Image = null;
                pbspil4.Image = null; pbspil5.Image = null; pbspil6.Image = null;
            }
        }

        private void BlackJack_Load(object sender, EventArgs e)
        {
            money = Convert.ToInt32(gagni.FinnaMoney(nafn));
            lblMoney.Text = money.ToString() + "$";

            HaldaAfram haldaafram = new HaldaAfram(nafn);

            if (money == 0)
            {
                haldaafram.Show();
            }

            money = Convert.ToInt32(gagni.FinnaMoney(nafn));
            lblMoney.Text = money.ToString() + "$";
        }
    }
}
