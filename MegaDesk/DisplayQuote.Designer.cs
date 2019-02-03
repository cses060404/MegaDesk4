namespace MegaDesk
{
    partial class DisplayQuote
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
            this.quoteGrid = new System.Windows.Forms.DataGridView();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RushDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SurfaceMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumDrawer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableDepth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.quoteGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(283, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 79);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.cancelQuoteButton);
            // 
            // quoteGrid
            // 
            this.quoteGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.quoteGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerName,
            this.RushDay,
            this.SurfaceMaterial,
            this.NumDrawer,
            this.TableWidth,
            this.TableDepth});
            this.quoteGrid.Location = new System.Drawing.Point(12, 30);
            this.quoteGrid.Name = "quoteGrid";
            this.quoteGrid.RowTemplate.Height = 24;
            this.quoteGrid.Size = new System.Drawing.Size(776, 150);
            this.quoteGrid.TabIndex = 5;
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
            // DisplayQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.quoteGrid);
            this.Controls.Add(this.button1);
            this.Name = "DisplayQuote";
            this.Text = "All Quotes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DisplayQuote_FormClosing);
            this.Load += new System.EventHandler(this.DisplayQuote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quoteGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView quoteGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RushDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn SurfaceMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumDrawer;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableDepth;
    }
}