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
    public partial class ShowQuote : Form
    {
        ErrorProvider errorProvider1 = new ErrorProvider();
        

        public ShowQuote(DeskQuote deskQuote)
        {
            InitializeComponent();
            widthBox.Text = deskQuote.desk.Width.ToString();
            depthBox.Text = deskQuote.desk.Depth.ToString();
            drawerBox.Text = deskQuote.desk.DrawerNum.ToString();
            rushBox.Text = deskQuote.DeliveryType.ToString();
            materialBox.Text = deskQuote.desk.Material.ToString();
            nameBox.Text = deskQuote.customerName;
            priceBox.Text = deskQuote.totalPrice.ToString();
            
        }

        private void cancelQuoteButton(object sender, EventArgs e)
        {
            var addQuoteView = (AddQuote)Tag;
            addQuoteView.Show();
            Close();
        }

        private void AddQuote_Load(object sender, EventArgs e)
        {
            
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            string quoteDetail = nameBox.Text + ", " + rushBox.Text + ", "
                + materialBox.Text + ", " + drawerBox.Text + ", "+ depthBox.Text + ", " + widthBox.Text + Environment.NewLine;

            File.AppendAllText("OrderDetail.txt",quoteDetail);

            var addQuoteView = (AddQuote)Tag;
            addQuoteView.Close();
            Close();
        }

   

        private void AddQuote_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
