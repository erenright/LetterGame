using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LetterGame
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            SetRandomLetter();
        }

        /// <summary>
        /// Updates the letter label with a random character between 'A' and 'Z', inclusive.
        /// If the letter would be the same, a different one is randomly selected to ensure
        /// that it is different every time.
        /// </summary>
        private void SetRandomLetter()
        {
            var rand = new Random();
            string s = lblLetter.Text;

            // Prevent the same char from showing up twice in a row
            while (s == lblLetter.Text)
            {
                lblLetter.Text = ((char)rand.Next((int)'A', (int)'Z' + 1)).ToString();
            }
        }

        /// <summary>
        /// Event handler for form keystrokes.  If the pressed key matches the displayed
        /// letter, pick a new random letter.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString().ToUpper() == lblLetter.Text)
            {
                SetRandomLetter();
            }
        }
    }
}
