using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MegaDesk
{
    public partial class AddQuote : Form
    {
        ErrorProvider errorProvider1 = new ErrorProvider();
        DeskQuote newQuote = new DeskQuote();

        public AddQuote()
        {
            InitializeComponent();
            drawerCombo.SelectedIndex = -1;
            rushCombo.SelectedIndex = -1;
            materialCombo.SelectedIndex = -1;
        }

        private void cancelQuoteButton(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void AddQuote_Load(object sender, EventArgs e)
        {
            
        }

        private void createButton_Click(object sender, EventArgs e)
        {

            if (!(name.Text == "" || materialCombo.SelectedIndex == -1 || drawerCombo.SelectedIndex == -1 || rushCombo.SelectedIndex == -1))
            {
                newQuote.customerName = name.Text;

                newQuote.desk.Depth = (int)DepthNum.Value;
                newQuote.desk.Width = (int)WidthNum.Value;

                int index = materialCombo.SelectedIndex;
                newQuote.desk.Material = (Desk.Surface)index;

                index = drawerCombo.SelectedIndex;
                newQuote.desk.DrawerNum = index;

                index = rushCombo.SelectedIndex;
                newQuote.DeliveryType = (DeskQuote.Delivery)index;

                newQuote.CalCost();



                ShowQuote addNewQuoteForm = new ShowQuote(newQuote);
                addNewQuoteForm.Tag = this;
                addNewQuoteForm.Show(this);
                Hide();
            }
            else MessageBox.Show("Please enter everything!");
                
        }

        
        private void rushCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                int index = rushCombo.SelectedIndex;
                newQuote.DeliveryType = (DeskQuote.Delivery)index;
    
         }

        private void materialCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = materialCombo.SelectedIndex;
                newQuote.desk.Material = (Desk.Surface)index;
        }

        private void drawerCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = drawerCombo.SelectedIndex;
                newQuote.desk.DrawerNum = index;
        }

        private void AddQuote_FormClosing(object sender, FormClosingEventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
        }
    }
}
