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
        DeskQuote newQuote = new DeskQuote();

        public ShowQuote()
        {
            InitializeComponent();
            widthBox.Text = AddQuote.width;
            depthBox.Text = AddQuote.depth;
            drawerBox.Text = AddQuote.drawerNum;
            rushBox.Text = AddQuote.rushDay;
            materialBox.Text = AddQuote.material;
            nameBox.Text = AddQuote.customerName;
            priceBox.Text = AddQuote.totalPrice;
            
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
