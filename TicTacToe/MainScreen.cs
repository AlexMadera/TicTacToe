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
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void BtnPlay_Click_1(object sender, EventArgs e)
        {
            EnterTwoPlayersName f2 = new EnterTwoPlayersName();
            f2.ShowDialog();
        }
    }
}
