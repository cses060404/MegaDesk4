namespace MegaDesk
{
    partial class ShowQuote
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.labelWidth = new System.Windows.Forms.Label();
            this.labelDepth = new System.Windows.Forms.Label();
            this.labelNumDrawer = new System.Windows.Forms.Label();
            this.labelMaterial = new System.Windows.Forms.Label();
            this.labelRush = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
            this.depthBox = new System.Windows.Forms.TextBox();
            this.rushBox = new System.Windows.Forms.TextBox();
            this.materialBox = new System.Windows.Forms.TextBox();
            this.widthBox = new System.Windows.Forms.TextBox();
            this.drawerBox = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.Label();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(314, 280);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(168, 64);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelQuoteButton);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Enabled = false;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(47, 25);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(75, 25);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Name: ";
            // 
            // nameBox
            // 
            this.nameBox.Enabled = false;
            this.nameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.Location = new System.Drawing.Point(173, 29);
            this.nameBox.Margin = new System.Windows.Forms.Padding(0);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(76, 23);
            this.nameBox.TabIndex = 3;
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Enabled = false;
            this.labelWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWidth.Location = new System.Drawing.Point(48, 86);
            this.labelWidth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(74, 25);
            this.labelWidth.TabIndex = 4;
            this.labelWidth.Text = "Width: ";
            // 
            // labelDepth
            // 
            this.labelDepth.AutoSize = true;
            this.labelDepth.Enabled = false;
            this.labelDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDepth.Location = new System.Drawing.Point(48, 152);
            this.labelDepth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDepth.Name = "labelDepth";
            this.labelDepth.Size = new System.Drawing.Size(70, 25);
            this.labelDepth.TabIndex = 6;
            this.labelDepth.Text = "Depth:";
            // 
            // labelNumDrawer
            // 
            this.labelNumDrawer.AutoSize = true;
            this.labelNumDrawer.Enabled = false;
            this.labelNumDrawer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumDrawer.Location = new System.Drawing.Point(309, 25);
            this.labelNumDrawer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNumDrawer.Name = "labelNumDrawer";
            this.labelNumDrawer.Size = new System.Drawing.Size(132, 25);
            this.labelNumDrawer.TabIndex = 8;
            this.labelNumDrawer.Text = "# of Drawers: ";
            // 
            // labelMaterial
            // 
            this.labelMaterial.AutoSize = true;
            this.labelMaterial.Enabled = false;
            this.labelMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaterial.Location = new System.Drawing.Point(309, 86);
            this.labelMaterial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMaterial.Name = "labelMaterial";
            this.labelMaterial.Size = new System.Drawing.Size(92, 25);
            this.labelMaterial.TabIndex = 10;
            this.labelMaterial.Text = "Material: ";
            // 
            // labelRush
            // 
            this.labelRush.AutoSize = true;
            this.labelRush.Enabled = false;
            this.labelRush.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRush.Location = new System.Drawing.Point(309, 152);
            this.labelRush.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRush.Name = "labelRush";
            this.labelRush.Size = new System.Drawing.Size(123, 25);
            this.labelRush.TabIndex = 13;
            this.labelRush.Text = "Rush Order: ";
            // 
            // createButton
            // 
            this.createButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createButton.Location = new System.Drawing.Point(123, 280);
            this.createButton.Margin = new System.Windows.Forms.Padding(2);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(168, 64);
            this.createButton.TabIndex = 14;
            this.createButton.Text = "Comfirm";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // depthBox
            // 
            this.depthBox.Enabled = false;
            this.depthBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depthBox.Location = new System.Drawing.Point(173, 156);
            this.depthBox.Margin = new System.Windows.Forms.Padding(0);
            this.depthBox.Name = "depthBox";
            this.depthBox.Size = new System.Drawing.Size(76, 23);
            this.depthBox.TabIndex = 15;
            // 
            // rushBox
            // 
            this.rushBox.Enabled = false;
            this.rushBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rushBox.Location = new System.Drawing.Point(473, 156);
            this.rushBox.Margin = new System.Windows.Forms.Padding(0);
            this.rushBox.Name = "rushBox";
            this.rushBox.Size = new System.Drawing.Size(76, 23);
            this.rushBox.TabIndex = 16;
            // 
            // materialBox
            // 
            this.materialBox.Enabled = false;
            this.materialBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialBox.Location = new System.Drawing.Point(473, 90);
            this.materialBox.Margin = new System.Windows.Forms.Padding(0);
            this.materialBox.Name = "materialBox";
            this.materialBox.Size = new System.Drawing.Size(76, 23);
            this.materialBox.TabIndex = 17;
            // 
            // widthBox
            // 
            this.widthBox.Enabled = false;
            this.widthBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthBox.Location = new System.Drawing.Point(173, 90);
            this.widthBox.Margin = new System.Windows.Forms.Padding(0);
            this.widthBox.Name = "widthBox";
            this.widthBox.Size = new System.Drawing.Size(76, 23);
            this.widthBox.TabIndex = 18;
            // 
            // drawerBox
            // 
            this.drawerBox.Enabled = false;
            this.drawerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawerBox.Location = new System.Drawing.Point(473, 29);
            this.drawerBox.Margin = new System.Windows.Forms.Padding(0);
            this.drawerBox.Name = "drawerBox";
            this.drawerBox.Size = new System.Drawing.Size(76, 23);
            this.drawerBox.TabIndex = 19;
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Enabled = false;
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.Location = new System.Drawing.Point(224, 228);
            this.price.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(67, 25);
            this.price.TabIndex = 20;
            this.price.Text = "Price: ";
            this.price.Click += new System.EventHandler(this.label1_Click);
            // 
            // priceBox
            // 
            this.priceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceBox.Location = new System.Drawing.Point(314, 232);
            this.priceBox.Margin = new System.Windows.Forms.Padding(0);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(76, 23);
            this.priceBox.TabIndex = 21;
            // 
            // ShowQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.price);
            this.Controls.Add(this.drawerBox);
            this.Controls.Add(this.widthBox);
            this.Controls.Add(this.materialBox);
            this.Controls.Add(this.rushBox);
            this.Controls.Add(this.depthBox);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.labelRush);
            this.Controls.Add(this.labelMaterial);
            this.Controls.Add(this.labelNumDrawer);
            this.Controls.Add(this.labelDepth);
            this.Controls.Add(this.labelWidth);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.cancelButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ShowQuote";
            this.Text = "Quote";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddQuote_FormClosing);
            this.Load += new System.EventHandler(this.AddQuote_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.Label labelDepth;
        private System.Windows.Forms.Label labelNumDrawer;
        private System.Windows.Forms.Label labelMaterial;
        private System.Windows.Forms.Label labelRush;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.TextBox depthBox;
        private System.Windows.Forms.TextBox rushBox;
        private System.Windows.Forms.TextBox materialBox;
        private System.Windows.Forms.TextBox widthBox;
        private System.Windows.Forms.TextBox drawerBox;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.TextBox priceBox;
    }
}