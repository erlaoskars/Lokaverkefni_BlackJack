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
        string instr = "";
        int stig = 0;
        int round = 1;
        int spil = 0; //Fundið gildispil og hefur gildi spil einnig.
        int tigulspadilaufas = 0; //Fundið Tegund spils
        string stafurspils = "";
        string validspil = "";
        string gildispils = "";
        string nafn = "";
        int money = 0;
        int bet = 0;

        //Breytur fyrir Lokaform
        int lokastig = 0;
        int lokastigTolvu = 0;
        int peningur = 0;

        //Breytur fyrir A.I Andstæðing.
        int spiltolvu = 0;
        int rndakvordun = 0;
        int stigtolvu = 0;
        int roundtolvu = 0;
        string gildispilstolvu = "";
        string validspiltolvu = "";
        string stafurspiltolvu = "";

        //tengingar við classa
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

        Adferdir aðferðir = new Adferdir(); //tengingar við classa
        Gagnagrunnur gagnagrunnur = new Gagnagrunnur();
        Random rnd = new Random();

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e); //Lokar móðurforminu þótt notandi sé á child formi
            Application.Exit();
        }

        private void mInstructionsIS_Click(object sender, EventArgs e)
        {
            instr = adferd.instrIS(instr);  //aðferð sem sparar pláss fyrir upplýsingar
            MessageBox.Show(instr);
        }
        
        private void mInstructionsENG_Click(object sender, EventArgs e)
        {
            instr = adferd.instrEN(instr); //aðferð sem sparar pláss fyrir upplýsingar
            MessageBox.Show(instr);   
        }

        private void mInstructionsES_Click(object sender, EventArgs e)
        {
            instr = adferd.instrES(instr); //aðferð sem sparar pláss fyrir upplýsingar
            MessageBox.Show(instr);
        }

        private void mLogOut_Click(object sender, EventArgs e)
        {
            this.Hide(); //felur form svo notandi getur endurskráð sig inn
            fLokaverkefni form = new fLokaverkefni();
            form.Show();
        }

        private void mExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mAuthors_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Höfundar: Erla Óskarsdóttir og Hrafnkell Þorri Þrastarson.");
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            money = Convert.ToInt32(gagni.FinnaMoney(nafn));
            lblMoney.Text = money.ToString() + "$";

            if (tbBet.Text == "")
            {
                MessageBox.Show("Þarft að setja inn bet");
            }
            else
            {
                bet = Convert.ToInt32(tbBet.Text);
                HaldaAfram haldaafram = new HaldaAfram(nafn);

                if (money == 0)
                {
                    haldaafram.Show();

                }
                else if (bet > money)
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
                    btnHit.Show();
                    btnSignal.Show();
                    btnStart.Hide();

                    round = 1;
                    roundtolvu = 0;
                    pbSpil.Image = null; pbspil2.Image = null; pbspil3.Image = null;
                    pbspil4.Image = null; pbspil5.Image = null; pbspil6.Image = null;
                    pbtolvuspil1.Image = null; pbtolvuspil2.Image = null; pbtolvuspil3.Image = null;
                    pbtolvuspil4.Image = null; pbtolvuspil5.Image = null; pbtolvuspil6.Image = null;
                }
            }
        }

        private void BlackJack_Load(object sender, EventArgs e)
        {
            money = Convert.ToInt32(gagni.FinnaMoney(nafn));
            lblMoney.Text = money.ToString() + "$";
        }

        private void btnSignal_Click(object sender, EventArgs e)
        {
            lokastig = stig;
            lokastigTolvu = stigtolvu;
            rndakvordun = rnd.Next(1, 101);
            if (stigtolvu > 17) //A.I Tekur ákvörðun hvort hún ætti að "hitta" einsusinni en
            {

            }
            else if (stigtolvu < 17)
            {
                spiltolvu = rnd.Next(1, 14);
                tigulspadilaufas = rnd.Next(1, 5);
                stafurspiltolvu = adferd.randomstafur(stafurspiltolvu);
                stigtolvu = stigtolvu + spiltolvu; //stigin útreiknuð fyrir tolvu
                gildispils = spil.ToString();
                validspiltolvu = (gildispilstolvu + stafurspiltolvu).ToString();
                roundtolvu++;
                if (roundtolvu == 1)
                {
                    pbtolvuspil1.Image = Lokaverkefni_BlackJack.Properties.Resources.spilabak;
                }
                else if(roundtolvu == 2)
                {
                    pbtolvuspil2.Image = Lokaverkefni_BlackJack.Properties.Resources.spilabak;
                }
                else if (roundtolvu == 3)
                {
                    pbtolvuspil3.Image = Lokaverkefni_BlackJack.Properties.Resources.spilabak;
                }
                else if (roundtolvu == 4)
                {
                    pbtolvuspil4.Image = Lokaverkefni_BlackJack.Properties.Resources.spilabak;
                }
                else if (roundtolvu == 5)
                {
                    pbtolvuspil5.Image = Lokaverkefni_BlackJack.Properties.Resources.spilabak;
                }
                else
                {
                    pbtolvuspil6.Image = Lokaverkefni_BlackJack.Properties.Resources.spilabak;

                }

                lokastigTolvu = lokastigTolvu + spiltolvu;

                if (stigtolvu == lokastig && stigtolvu <= 21 && lokastig <= 21)
                {
                    peningur = bet;
                    money = money + bet;
                    gagni.SettInnMoney(nafn, money);
                    lblMoney.Text = money.ToString() + "$";
                }
                else if (lokastig > lokastigTolvu && lokastig <= 21)
                {
                    peningur = bet * 2;
                    money = money + bet * 2;
                    gagni.SettInnMoney(nafn, money);
                    lblMoney.Text = money.ToString() + "$";

                }
                else if (lokastig < lokastigTolvu && lokastigTolvu <= 21)
                {
                    peningur = -bet;
                    money = money + bet;
                    gagni.SettInnMoney(nafn, money);
                    lblMoney.Text = money.ToString() + "$";
                }
                
            }

                btnHit.Hide(); 
                btnSignal.Hide(); //falið takka
                btnStart.Show();

                Leikslok leikslok = new Leikslok(lokastig, lokastigTolvu, peningur); //sett niðurstöðu í gagnagrunn
                leikslok.Show();
       
        }

        private void btnHit_Click(object sender, EventArgs e)
        {
            spil = rnd.Next(1, 14); //Valið er random tölu korts 1-13
            tigulspadilaufas = rnd.Next(1, 5); // hér er valið tölu 1-4 sem verður svo notað til að velja tegund korts
            stafurspils = adferd.randomstafur(stafurspils); //Aðferðir til að ákveða hvort spilið sé Ás, Spaði, Lauf eða Tígull
            stig = stig + spil; //Stigin útreiknað 
            lblStig.Text = stig.ToString(); // Label fyrir notanda
            gildispils = spil.ToString();
            validspil = (gildispils + stafurspils).ToString(); //sett saman Value og staf svo hægt sé að birta 

            if (stigtolvu > 15)
            {
                
            }
            else
            {
                spiltolvu = rnd.Next(1, 14);
                tigulspadilaufas = rnd.Next(1, 5);
                stafurspiltolvu = adferd.randomstafur(stafurspiltolvu);
                stigtolvu = stigtolvu + spiltolvu; //stigin útreiknuð fyrir tolvu
                gildispils = spil.ToString(); //gildi spils sett
                validspiltolvu = (gildispilstolvu + stafurspiltolvu).ToString(); //valið spil fær gildi tveggja breyta og sameinar þær til að fá nafn korts
                roundtolvu++; //talið er umferðir og hér hækkar hún um einn

                if (roundtolvu == 1) //Spiltölvu birt
                {
                    pbtolvuspil1.Image = Lokaverkefni_BlackJack.Properties.Resources.spilabak;
                }
                if (roundtolvu == 2)
                {
                    pbtolvuspil2.Image = Lokaverkefni_BlackJack.Properties.Resources.spilabak;
                }
                if (roundtolvu == 3)
                {
                    pbtolvuspil3.Image = Lokaverkefni_BlackJack.Properties.Resources.spilabak;
                }
                if (roundtolvu == 4)
                {
                    pbtolvuspil4.Image = Lokaverkefni_BlackJack.Properties.Resources.spilabak;
                }
                if (roundtolvu == 5)
                {
                    pbtolvuspil5.Image = Lokaverkefni_BlackJack.Properties.Resources.spilabak;
                }
                if (roundtolvu == 6)
                {
                    pbtolvuspil6.Image = Lokaverkefni_BlackJack.Properties.Resources.spilabak;
                }
            }

            //PictureBox Notanda
            if (round == 1)
            {
                pbSpil.Image = (Image)Properties.Resources.ResourceManager.GetObject(validspil);
                pbSpil.BringToFront();
            }
            if (round == 2)
            {
                pbspil2.Image = (Image)Properties.Resources.ResourceManager.GetObject(validspil);
                pbspil2.BringToFront();
            }
            if (round == 3)
            {
                pbspil3.Image = (Image)Properties.Resources.ResourceManager.GetObject(validspil);
                pbspil3.BringToFront();
            }
            if (round == 4)
            {
                pbspil4.Image = (Image)Properties.Resources.ResourceManager.GetObject(validspil);
                pbspil4.BringToFront();
            }
            if (round == 5)
            {
                pbspil5.Image = (Image)Properties.Resources.ResourceManager.GetObject(validspil);
                pbspil5.BringToFront();
            }
            if (round == 6)
            {
                pbspil6.Image = (Image)Properties.Resources.ResourceManager.GetObject(validspil);
                pbspil6.BringToFront();
            }

            round++;

            if (stigtolvu > 21 && stig > 21)
            {
                MessageBox.Show("You Both Busted!");
                btnHit.Hide();
                btnSignal.Hide();
                btnStart.Show();
                money = money + 0;
                gagni.SettInnMoney(nafn, money);
                lblMoney.Text = money.ToString() + "$";
                lokastig = stig;
                lokastigTolvu = stigtolvu;
                peningur = 0;

                Leikslok leikslok = new Leikslok(lokastig, lokastigTolvu, peningur);
                leikslok.Show();
            }
            else if (stig > 21)
            {
                MessageBox.Show("Busted");
                btnHit.Hide();
                btnSignal.Hide();
                btnStart.Show();
                money = money - bet;
                gagni.SettInnMoney(nafn, money);
                lblMoney.Text = money.ToString() + "$";
                lokastig = stig;
                lokastigTolvu = stigtolvu;
                peningur = -bet;

                Leikslok leikslok = new Leikslok(lokastig, lokastigTolvu, peningur);
                leikslok.Show();
            }
            else if (stigtolvu > 21)
            {
                MessageBox.Show("CPU Busted");
                btnHit.Hide();
                btnSignal.Hide();
                btnStart.Show();
                money = money + (bet * 2);
                gagni.SettInnMoney(nafn, money);
                lblMoney.Text = money.ToString() + "$";
                lokastig = stig;
                lokastigTolvu = stigtolvu;
                peningur = (bet * 2);
                                           
                Leikslok leikslok = new Leikslok(lokastig, lokastigTolvu, peningur);
                leikslok.Show();
            }
           
        }

        private void instructionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tbBet_TextChanged(object sender, EventArgs e)
        {
            
        }

    }
}
