namespace WinAppGenDevis
{
    partial class genDevis
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNewDevis = new System.Windows.Forms.Label();
            this.labelCoordinates = new System.Windows.Forms.Label();
            this.textBoxCoordinates = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCoordinateClient = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.labelProduct = new System.Windows.Forms.Label();
            this.textBoxNameOfProduct = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.labelAmount = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.buttonGenDevis = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttondelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNewDevis
            // 
            this.labelNewDevis.AutoSize = true;
            this.labelNewDevis.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNewDevis.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelNewDevis.Location = new System.Drawing.Point(12, 9);
            this.labelNewDevis.Name = "labelNewDevis";
            this.labelNewDevis.Size = new System.Drawing.Size(143, 28);
            this.labelNewDevis.TabIndex = 0;
            this.labelNewDevis.Text = "Nouveau Devis";
            // 
            // labelCoordinates
            // 
            this.labelCoordinates.AutoSize = true;
            this.labelCoordinates.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCoordinates.Location = new System.Drawing.Point(12, 94);
            this.labelCoordinates.Name = "labelCoordinates";
            this.labelCoordinates.Size = new System.Drawing.Size(123, 21);
            this.labelCoordinates.TabIndex = 1;
            this.labelCoordinates.Text = "Vos Coordonées";
            // 
            // textBoxCoordinates
            // 
            this.textBoxCoordinates.Location = new System.Drawing.Point(12, 118);
            this.textBoxCoordinates.Multiline = true;
            this.textBoxCoordinates.Name = "textBoxCoordinates";
            this.textBoxCoordinates.Size = new System.Drawing.Size(315, 175);
            this.textBoxCoordinates.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(473, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Coordonnées Client";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxCoordinateClient
            // 
            this.textBoxCoordinateClient.Location = new System.Drawing.Point(473, 296);
            this.textBoxCoordinateClient.Multiline = true;
            this.textBoxCoordinateClient.Name = "textBoxCoordinateClient";
            this.textBoxCoordinateClient.Size = new System.Drawing.Size(315, 175);
            this.textBoxCoordinateClient.TabIndex = 4;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(12, 456);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(107, 21);
            this.labelTitle.TabIndex = 5;
            this.labelTitle.Text = "Titre Du Devis";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(12, 480);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(248, 23);
            this.textBoxTitle.TabIndex = 6;
            // 
            // labelProduct
            // 
            this.labelProduct.AutoSize = true;
            this.labelProduct.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelProduct.Location = new System.Drawing.Point(12, 534);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(117, 20);
            this.labelProduct.TabIndex = 7;
            this.labelProduct.Text = "Nom Du Produit";
            // 
            // textBoxNameOfProduct
            // 
            this.textBoxNameOfProduct.Location = new System.Drawing.Point(12, 557);
            this.textBoxNameOfProduct.Name = "textBoxNameOfProduct";
            this.textBoxNameOfProduct.Size = new System.Drawing.Size(284, 23);
            this.textBoxNameOfProduct.TabIndex = 8;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(302, 557);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(198, 23);
            this.textBoxPrice.TabIndex = 9;
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(506, 557);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(193, 23);
            this.textBoxAmount.TabIndex = 10;
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAmount.Location = new System.Drawing.Point(506, 534);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(66, 20);
            this.labelAmount.TabIndex = 11;
            this.labelAmount.Text = "Quantité";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPrice.Location = new System.Drawing.Point(302, 533);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(33, 20);
            this.labelPrice.TabIndex = 12;
            this.labelPrice.Text = "Prix";
            // 
            // buttonGenDevis
            // 
            this.buttonGenDevis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGenDevis.Location = new System.Drawing.Point(254, 672);
            this.buttonGenDevis.Name = "buttonGenDevis";
            this.buttonGenDevis.Size = new System.Drawing.Size(205, 67);
            this.buttonGenDevis.TabIndex = 13;
            this.buttonGenDevis.Text = "Générer Le Devis";
            this.buttonGenDevis.UseVisualStyleBackColor = true;
            this.buttonGenDevis.Click += new System.EventHandler(this.buttonGenDevis_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.Location = new System.Drawing.Point(705, 557);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(29, 23);
            this.buttonAdd.TabIndex = 14;
            this.buttonAdd.Text = "p";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttondelete
            // 
            this.buttondelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttondelete.Location = new System.Drawing.Point(740, 557);
            this.buttondelete.Name = "buttondelete";
            this.buttondelete.Size = new System.Drawing.Size(29, 23);
            this.buttondelete.TabIndex = 15;
            this.buttondelete.Text = "m";
            this.buttondelete.UseVisualStyleBackColor = true;
            // 
            // genDevis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 751);
            this.Controls.Add(this.buttondelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonGenDevis);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxNameOfProduct);
            this.Controls.Add(this.labelProduct);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.textBoxCoordinateClient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCoordinates);
            this.Controls.Add(this.labelCoordinates);
            this.Controls.Add(this.labelNewDevis);
            this.Name = "genDevis";
            this.Text = "Generateur Devis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelNewDevis;
        private Label labelCoordinates;
        private TextBox textBoxCoordinates;
        private Label label1;
        private TextBox textBoxCoordinateClient;
        private Label labelTitle;
        private TextBox textBoxTitle;
        private Label labelProduct;
        private TextBox textBoxNameOfProduct;
        private TextBox textBoxPrice;
        private TextBox textBoxAmount;
        private Label labelAmount;
        private Label labelPrice;
        private Button buttonGenDevis;
        private Button buttonAdd;
        private Button buttondelete;
    }
}