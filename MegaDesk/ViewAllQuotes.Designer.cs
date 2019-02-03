namespace MegaDesk
{
    partial class ViewAllQuotes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.quoteSearchGrid = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.searchCombo = new System.Windows.Forms.ComboBox();
            this.searchBox = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RushDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SurfaceMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumDrawer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableDepth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.quoteSearchGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(280, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 79);
            this.button1.TabIndex = 3;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.cancelQuoteButton);
            // 
            // quoteSearchGrid
            // 
            this.quoteSearchGrid.AllowUserToAddRows = false;
            this.quoteSearchGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.quoteSearchGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Time,
            this.CustomerName,
            this.RushDay,
            this.SurfaceMaterial,
            this.NumDrawer,
            this.TableWidth,
            this.TableDepth,
            this.TotalPrice});
            this.quoteSearchGrid.Location = new System.Drawing.Point(12, 111);
            this.quoteSearchGrid.Name = "quoteSearchGrid";
            this.quoteSearchGrid.RowTemplate.Height = 24;
            this.quoteSearchGrid.Size = new System.Drawing.Size(776, 150);
            this.quoteSearchGrid.TabIndex = 4;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(490, 111);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(8, 8);
            this.dataGridView2.TabIndex = 5;
            // 
            // searchCombo
            // 
            this.searchCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchCombo.FormattingEnabled = true;
            this.searchCombo.ItemHeight = 20;
            this.searchCombo.Items.AddRange(new object[] {
            "Laminate",
            "Oak",
            "Rosewood",
            "Veneer",
            "Pine"});
            this.searchCombo.Location = new System.Drawing.Point(162, 27);
            this.searchCombo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchCombo.Name = "searchCombo";
            this.searchCombo.Size = new System.Drawing.Size(121, 28);
            this.searchCombo.TabIndex = 18;
            this.searchCombo.SelectedIndexChanged += new System.EventHandler(this.searchCombo_SelectedIndexChanged);
            // 
            // searchBox
            // 
            this.searchBox.AutoSize = true;
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(37, 26);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(107, 29);
            this.searchBox.TabIndex = 19;
            this.searchBox.Text = "Search: ";
            // 
            // Time
            // 
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            // 
            // CustomerName
            // 
            this.CustomerName.HeaderText = "Customer Name";
            this.CustomerName.Name = "CustomerName";
            // 
            // RushDay
            // 
            this.RushDay.HeaderText = "Rush Day";
            this.RushDay.Name = "RushDay";
            // 
            // SurfaceMaterial
            // 
            this.SurfaceMaterial.HeaderText = "Surface Material";
            this.SurfaceMaterial.Name = "SurfaceMaterial";
            // 
            // NumDrawer
            // 
            this.NumDrawer.HeaderText = "# of Drawers";
            this.NumDrawer.Name = "NumDrawer";
            // 
            // TableWidth
            // 
            this.TableWidth.HeaderText = "Table Width";
            this.TableWidth.Name = "TableWidth";
            // 
            // TableDepth
            // 
            this.TableDepth.HeaderText = "Table Depth";
            this.TableDepth.Name = "TableDepth";
            // 
            // TotalPrice
            // 
            this.TotalPrice.HeaderText = "Price";
            this.TotalPrice.Name = "TotalPrice";
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.searchCombo);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.quoteSearchGrid);
            this.Controls.Add(this.button1);
            this.Name = "ViewAllQuotes";
            this.Text = "Search Quotes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ViewAllQuotes_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.quoteSearchGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView quoteSearchGrid;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox searchCombo;
        private System.Windows.Forms.Label searchBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RushDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn SurfaceMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumDrawer;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableDepth;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
    }
}