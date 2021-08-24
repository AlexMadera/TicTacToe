using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class EnterTwoPlayersName : Form
    {
        public EnterTwoPlayersName()
        {
            InitializeComponent();
        }

        private void BTNOK_Click(object sender, EventArgs e)
        {
            TicTacToe f2 = new TicTacToe(txtnameOne.Text,txtnameTwo.Text);
            f2.ShowDialog();
          
        }
    }
}
