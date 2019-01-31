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
        List<DeskQuote> quoteList;

        public static string customerName;
        public static string width;
        public static string depth;
        public static string drawerNum;
        public static string rushDay;
        public static string material;
        public static string totalPrice;

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
            customerName = newQuote.customerName;

            newQuote.desk.Depth = (int)DepthNum.Value;
            depth = newQuote.desk.Depth.ToString();

            newQuote.desk.Width = (int)WidthNum.Value;
            width = newQuote.desk.Width.ToString();

            newQuote.CalCost();
            totalPrice = newQuote.totalPrice.ToString();

            ShowQuote addNewQuoteForm = new ShowQuote();
            addNewQuoteForm.Tag = this;
            addNewQuoteForm.Show(this);
            Hide();
        }

        
        private void rushCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = rushCombo.SelectedIndex;
                newQuote.DeliveryType = (DeskQuote.Delivery)index;
            rushDay = newQuote.DeliveryType.ToString();
        }

        private void materialCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = materialCombo.SelectedIndex;
                newQuote.desk.Material = (Desk.Surface)index;
            material = newQuote.desk.Material.ToString();
        }

        private void drawerCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = drawerCombo.SelectedIndex;
                newQuote.desk.DrawerNum = index;
            drawerNum = newQuote.desk.DrawerNum.ToString();
        }

        private void AddQuote_FormClosing(object sender, FormClosingEventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
        }
    }
}
