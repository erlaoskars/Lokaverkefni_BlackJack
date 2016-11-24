﻿using System;
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
        public BlackJack(string notendanafn)
        {
            InitializeComponent();

            string nafn = notendanafn;

            lblNafn.Text = nafn;
        }

        
        Aðferðir aðferðir = new Aðferðir();
        Gagnagrunnur gagnagrunnur = new Gagnagrunnur();
        Random rnd = new Random();
        

        private void mInstructionsIS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Í Blackjack er markmiðið að summa dregna spila sé 21 eða minni. Ef kortasumman er hærri þá springur notandinn og tapar." +
            " Notandinn getur skráð sig inn og sem vistar svo breytingar, notandinn byrjar með 100$ en ef hann fer undir 0$ fær hann aftur 100$." +
            " Notandinn getur veðjað pening, ef notandinn vinnur þá fær hann tvöfalt sem hann lagði út en ef hann tapar missir hann peninginn." +
            "\n\nHit: Dragðu annað kort frá búnka og taka áhættuna á því að fara yfir 21." +
            "\n\nSignal: Ekki draga annað spil og taka áhættuna að talvan dregur lægri summu eða fer yfir 21.");
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            Application.Exit();
        }

        private void BlackJack_Load(object sender, EventArgs e)
        {

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
            List<string> búinspil = new List<string>();
            int spil = 0; //Fundið gildispil og hefur gildi spil einnig.
            int tigulspaðilaufas = 0; //Fundið Tegund spils
            string stafurspils = "";
            string valiðspil = "";
            string gildispils = "";
            spil = rnd.Next(1, 14);
            tigulspaðilaufas = rnd.Next(1, 5);

            if(tigulspaðilaufas == 1)
            {
                stafurspils = "A";
            }
            if (tigulspaðilaufas == 2)
            {
                stafurspils = "B";
            }
            if (tigulspaðilaufas == 3)
            {
                stafurspils = "C";
            }
            if (tigulspaðilaufas == 4)
            {
                stafurspils = "D";
            }

            gildispils = spil.ToString();
            valiðspil = (gildispils + stafurspils).ToString();
            if(búinspil.Contains(valiðspil))
            {
                return;
            }
            else
            {
            búinspil.Add(valiðspil);
            pbSpil.Image = (Image)Properties.Resources.ResourceManager.GetObject(valiðspil);
            }
        }
    }
}
