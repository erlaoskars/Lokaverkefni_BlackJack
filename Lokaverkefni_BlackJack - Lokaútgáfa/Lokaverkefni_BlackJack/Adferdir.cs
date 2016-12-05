using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lokaverkefni_BlackJack
{
    class Adferdir
    {
        public string randomstafur(string stafurspils)
        {

            int stafur = 0;
            Random rnd = new Random();
            stafur = rnd.Next(1, 5);

            if (stafur == 1)
            {
                stafurspils = "A";
            }
            if (stafur == 2)
            {
                stafurspils = "B";
            }
            if (stafur == 3)
            {
                stafurspils = "C";
            }
            if (stafur == 4)
            {
                stafurspils = "D";
            }
            
            return stafurspils;
        }

       public string instrIS(string instr)
       {
           instr = "Í Blackjack er markmiðið að summa dregna spila sé 21 eða sem nálægst 21. Ef kortasumman er hærri en 21 þá springur notandinn og tapar." +
            " Við fyrstu skráningu fær notandi 500$, notandi ræður hvað hann ætlar að veðja miklum pening í hvert skipti." +
            " Ef notandinn vinnur þá fær hann tvöfalt sem hann lagði út en ef hann tapar missir hann peninginn og ef jafntefli kemur upp fær notandi það sem hann lagði út." +
            "\n\nHit: Dragðu annað kort frá bunka og taka áhættuna á því að fara yfir 21." +
            "\n\nSignal: Ekki draga annað spil og taka áhættuna að talvan dregur hærri summu(=> 21) en þú.";
           return instr;
       }
       public string instrES(string instr)
       {
           instr = "En el blackjack, el objetivo es sumar retratado juego es 21 o 21. Si la tarjeta cerca de la suma es mayor que 21 entonces estalla usuario y un perdedor. "+
             "Para el primer usuario inclusión recibe $ 500, el usuario determina lo que va a apostar una gran cantidad de dinero cada vez." +
             "Si el usuario gana, se pone el doble expuso, pero si pierde, pierde dinero si se produce un empate, un usuario lo expuso." +
             "\n\nHit: Dibuje otra carta del mazo y tomar el riesgo de pasarse de 21." +
             "\n\nSignal: No dibujar otra tarjeta y tomar el riesgo de que el ordenador obtiene una suma superior (=> 21) que tú.";
           return instr;
       }
       public string instrEN(string instr)
       {
           instr = "In blackjack, the aim is to sum portrayed play is 21 or near 21. If the sum is greater than 21 the user loses. "+
             " For the first inclusion user gets 500$, the user determines what he is going to bet a lot of money every time." +
             " If the user wins then he gets twice as he laid out, but if he loses he loses the money  and if a tie occurs the users gets what he laid out." +
             "\n\nHit: Draw another card from the pile and take the risk of going over 21." +
             "\n\nSignal: Do not draw another card and take the risk that the computer draws a higher sum (=> 21) than you.";
           return instr;
       }
    }
}
