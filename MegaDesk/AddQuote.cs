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
        ErrorProvider errorProvider1 = new ErrorProvider();
        DeskQuote newQuote = new DeskQuote();
        List<DeskQuote> quoteList;

        public AddQuote()
        {
            InitializeComponent();
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
            newQuote.customerName = name.Text;
            newQuote.desk.Depth = (int)DepthNum.Value;
            newQuote.desk.Width = (int)WidthNum.Value;
            newQuote.CalCost();
            quoteList = new List<DeskQuote>();
            quoteList.Add(newQuote);
            MessageBox.Show("Name: " + quoteList[0].customerName + " Width: " + quoteList[0].desk.Width + " Material: " 
                + quoteList[0].desk.Material.ToString() + " Price: " + quoteList[0].totalPrice);
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
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
