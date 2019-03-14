using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICanDoThatGame
{
    public partial class DisplayWinnerScreen : Form
    {
        public string Winner { get; set; }

        //Create your private font collection object.
        PrivateFontCollection pfc = new PrivateFontCollection();

        public DisplayWinnerScreen()
        {
            InitializeComponent();
        }

        private void DisplayWinnerScreen_Load(object sender, EventArgs e)
        {
            CustomFontARCarter();
            lblWins.Font = new Font(pfc.Families[0], 80);
            lblWins.Text = $"{Winner} wins!";
           
            
            //MessageBox.Show($"Game over. {winnerName} wins!");
        }

        public void CustomFontARCarter()
        {

            //Select your font from the resources.
            //My font here is "Digireu.ttf"
            int fontLength = Properties.Resources.ARCARTER.Length;

            // create a buffer to read in to
            byte[] fontdata = Properties.Resources.ARCARTER;

            // create an unsafe memory block for the font data
            System.IntPtr data = Marshal.AllocCoTaskMem(fontLength);

            // copy the bytes to the unsafe memory block
            Marshal.Copy(fontdata, 0, data, fontLength);

            // pass the font to the font collection
            pfc.AddMemoryFont(data, fontLength);
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            GameForm newGame = new GameForm();
            newGame.Show();
            this.Close();
        }

        private void btnExitGame_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
