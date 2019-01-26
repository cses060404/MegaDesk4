using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class AddQuote : Form
    {
        bool cancelButtonClicked = false;
        ErrorProvider errorProvider1 = new ErrorProvider();
        DeskQuote newQuote = new DeskQuote();
        Desk desk = new Desk();
        private bool nonNumberEntered = false;


        public AddQuote()
        {
            InitializeComponent();
        }

        private void cancelQuoteButton(object sender, EventArgs e)
        {
            cancelButtonClicked = true;
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void AddQuote_Load(object sender, EventArgs e)
        {

        }




        private void createButton_Click(object sender, EventArgs e)
        {
            //newQuote.validateWidth(width.Text);
            //newQuote.validateDepth(depth.Text);

            //var mainMenu = (MainMenu)Tag;
            //mainMenu.Show();
            //Close();
        }

        private void tbWidth_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!int.TryParse(tbWidth.Text, out int realWidth))
            {
                e.Cancel = true;
                errorMsg = "Width must be an integer!";
                MessageBox.Show(errorMsg);
                tbWidth.Select(0, tbWidth.Text.Length);

            }
            else
            {
                if (!(realWidth >= 24 && realWidth <= 96))
                {
                    e.Cancel = true;
                    errorMsg = "Width must be between 24 to 96 inches!";
                    MessageBox.Show(errorMsg);
                    tbWidth.Select(0, tbWidth.Text.Length);
                }

                else if (cancelButtonClicked)
                {
                    e.Cancel = false;
                    cancelButtonClicked = false;
                }
            }
        }

        private void tbDepth_KeyDown(object sender, KeyEventArgs e)
        {
            nonNumberEntered = false;

            // Determine whether the keystroke is a number from the top of the keyboard.
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                // Determine whether the keystroke is a number from the keypad.
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    // Determine whether the keystroke is a backspace.
                    if (e.KeyCode != Keys.Back)
                    {
                        // A non-numerical keystroke was pressed.
                        // Set the flag to true and evaluate in KeyPress event.
                        nonNumberEntered = true;
                    }
                }
            }
            //If shift key was pressed, it's not a number.
            if (Control.ModifierKeys == Keys.Shift)
            {
                nonNumberEntered = true;
            }
        }

        private void tbDepth_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check for the flag being set in the KeyDown event.
            if (nonNumberEntered == true)
            {
                // Stop the character from being entered into the control since it is non-numerical.
                e.Handled = true;
            }
        }
    }
}
