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
        public fLokaverkefni()
        {
            InitializeComponent();
        }


        private void fLokaverkefni_Load(object sender, EventArgs e)
        {
            tbLykilord.PasswordChar = '•';
            tbLykilord.MaxLength = 15;
        }

        private void btnNyskra_Click(object sender, EventArgs e)
        {
            string notendanafn = tbNotendanafn.Text;
            string lykilord = tbLykilord.Text;
        }
    }
}
