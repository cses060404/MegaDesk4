using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class ViewAllQuotes : Form
    {
        public string[] deskQuotes;

        public ViewAllQuotes()
        {
            InitializeComponent();
            loadGrid();
        }

        private void cancelQuoteButton(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void loadGrid() {
            try
            {
                deskQuotes = File.ReadAllLines(@"quotes.txt");

                foreach (string deskQuote in deskQuotes)
                {
                    string[] arrRow = deskQuote.Split(new char[] { ',' });
                    quoteSearchGrid.Rows.Add(arrRow);
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("No file is found");
            }
        }


        private void searchCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            quoteSearchGrid.Rows.Clear();
           // deskQuotes = File.ReadAllLines(@"OrderDetail.txt");


            foreach (string deskQuote in deskQuotes) { 
                switch (searchCombo.SelectedIndex) {
                case 0:
                    if (deskQuote.Contains("Laminate"))
                    {
                        string[] arrRow = deskQuote.Split(new char[] { ',' });
                        quoteSearchGrid.Rows.Add(arrRow);
                    }
                    break;
                    case 1:
                        if (deskQuote.Contains("Oak"))
                        {
                            string[] arrRow = deskQuote.Split(new char[] { ',' });
                            quoteSearchGrid.Rows.Add(arrRow);
                        }
                        break;

                    case 2:
                        if (deskQuote.Contains("Rosewood"))
                        {
                            string[] arrRow = deskQuote.Split(new char[] { ',' });
                            quoteSearchGrid.Rows.Add(arrRow);
                        }
                        break;
                    case 3:
                        if (deskQuote.Contains("Veneer"))
                        {
                            string[] arrRow = deskQuote.Split(new char[] { ',' });
                            quoteSearchGrid.Rows.Add(arrRow);
                        }
                        break;
                    case 4:
                        if (deskQuote.Contains("Pine"))
                        {
                            string[] arrRow = deskQuote.Split(new char[] { ',' });
                            quoteSearchGrid.Rows.Add(arrRow);
                        }
                        break;
                }

            }
        }

        private void ViewAllQuotes_FormClosing(object sender, FormClosingEventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
        }
    }
}
