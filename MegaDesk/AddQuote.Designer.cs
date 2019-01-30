namespace MegaDesk
{
    partial class AddQuote
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
            this.name = new System.Windows.Forms.TextBox();
            this.labelWidth = new System.Windows.Forms.Label();
            this.labelDepth = new System.Windows.Forms.Label();
            this.labelNumDrawer = new System.Windows.Forms.Label();
            this.labelMaterial = new System.Windows.Forms.Label();
            this.drawerCombo = new System.Windows.Forms.ComboBox();
            this.labelRush = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
            this.WidthNum = new System.Windows.Forms.NumericUpDown();
            this.DepthNum = new System.Windows.Forms.NumericUpDown();
            this.materialCombo = new System.Windows.Forms.ComboBox();
            this.rushCombo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.WidthNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepthNum)).BeginInit();
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
            // name
            // 
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(173, 20);
            this.name.Margin = new System.Windows.Forms.Padding(0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(76, 30);
            this.name.TabIndex = 3;
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Enabled = false;
            this.labelWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWidth.Location = new System.Drawing.Point(47, 115);
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
            this.labelDepth.Location = new System.Drawing.Point(47, 202);
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
            this.labelMaterial.Location = new System.Drawing.Point(309, 115);
            this.labelMaterial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMaterial.Name = "labelMaterial";
            this.labelMaterial.Size = new System.Drawing.Size(92, 25);
            this.labelMaterial.TabIndex = 10;
            this.labelMaterial.Text = "Material: ";
            // 
            // drawerCombo
            // 
            this.drawerCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drawerCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawerCombo.FormattingEnabled = true;
            this.drawerCombo.ItemHeight = 16;
            this.drawerCombo.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.drawerCombo.Location = new System.Drawing.Point(460, 29);
            this.drawerCombo.Margin = new System.Windows.Forms.Padding(2);
            this.drawerCombo.Name = "drawerCombo";
            this.drawerCombo.Size = new System.Drawing.Size(92, 24);
            this.drawerCombo.TabIndex = 12;
            this.drawerCombo.SelectedIndexChanged += new System.EventHandler(this.drawerCombo_SelectedIndexChanged);
            // 
            // labelRush
            // 
            this.labelRush.AutoSize = true;
            this.labelRush.Enabled = false;
            this.labelRush.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRush.Location = new System.Drawing.Point(309, 202);
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
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // WidthNum
            // 
            this.WidthNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WidthNum.Location = new System.Drawing.Point(173, 110);
            this.WidthNum.Margin = new System.Windows.Forms.Padding(2);
            this.WidthNum.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.WidthNum.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.WidthNum.Name = "WidthNum";
            this.WidthNum.Size = new System.Drawing.Size(75, 30);
            this.WidthNum.TabIndex = 15;
            this.WidthNum.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // DepthNum
            // 
            this.DepthNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepthNum.Location = new System.Drawing.Point(173, 197);
            this.DepthNum.Margin = new System.Windows.Forms.Padding(2);
            this.DepthNum.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.DepthNum.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.DepthNum.Name = "DepthNum";
            this.DepthNum.Size = new System.Drawing.Size(75, 30);
            this.DepthNum.TabIndex = 16;
            this.DepthNum.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // materialCombo
            // 
            this.materialCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialCombo.FormattingEnabled = true;
            this.materialCombo.ItemHeight = 16;
            this.materialCombo.Items.AddRange(new object[] {
            "Laminate",
            "Oak",
            "Rosewood",
            "Veneer",
            "Pine"});
            this.materialCombo.Location = new System.Drawing.Point(460, 110);
            this.materialCombo.Margin = new System.Windows.Forms.Padding(2);
            this.materialCombo.Name = "materialCombo";
            this.materialCombo.Size = new System.Drawing.Size(92, 24);
            this.materialCombo.TabIndex = 17;
            this.materialCombo.SelectedIndexChanged += new System.EventHandler(this.materialCombo_SelectedIndexChanged);
            // 
            // rushCombo
            // 
            this.rushCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rushCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rushCombo.FormattingEnabled = true;
            this.rushCombo.ItemHeight = 16;
            this.rushCombo.Items.AddRange(new object[] {
            "Rush 3 Days",
            "Rush 5 Days",
            "Rush 7 Days",
            "Reg 14 Days"});
            this.rushCombo.Location = new System.Drawing.Point(460, 206);
            this.rushCombo.Margin = new System.Windows.Forms.Padding(2);
            this.rushCombo.Name = "rushCombo";
            this.rushCombo.Size = new System.Drawing.Size(92, 24);
            this.rushCombo.TabIndex = 18;
            this.rushCombo.SelectedIndexChanged += new System.EventHandler(this.rushCombo_SelectedIndexChanged);
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.rushCombo);
            this.Controls.Add(this.materialCombo);
            this.Controls.Add(this.DepthNum);
            this.Controls.Add(this.WidthNum);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.labelRush);
            this.Controls.Add(this.drawerCombo);
            this.Controls.Add(this.labelMaterial);
            this.Controls.Add(this.labelNumDrawer);
            this.Controls.Add(this.labelDepth);
            this.Controls.Add(this.labelWidth);
            this.Controls.Add(this.name);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.cancelButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddQuote_FormClosing);
            this.Load += new System.EventHandler(this.AddQuote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WidthNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepthNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.Label labelDepth;
        private System.Windows.Forms.Label labelNumDrawer;
        private System.Windows.Forms.Label labelMaterial;
        private System.Windows.Forms.ComboBox drawerCombo;
        private System.Windows.Forms.Label labelRush;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.NumericUpDown WidthNum;
        private System.Windows.Forms.NumericUpDown DepthNum;
        private System.Windows.Forms.ComboBox materialCombo;
        private System.Windows.Forms.ComboBox rushCombo;
    }
}