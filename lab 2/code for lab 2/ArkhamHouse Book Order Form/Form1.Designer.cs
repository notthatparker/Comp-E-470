namespace ArkhamHouse_Book_Order_Form
{
    partial class Bg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bg));
            this.dropdown = new System.Windows.Forms.ComboBox();
            this.Authorline = new System.Windows.Forms.Label();
            this.isbn = new System.Windows.Forms.Label();
            this.prce = new System.Windows.Forms.Label();
            this.authroline = new System.Windows.Forms.TextBox();
            this.ISBNline = new System.Windows.Forms.TextBox();
            this.Priceline = new System.Windows.Forms.TextBox();
            this.quantitybox = new System.Windows.Forms.TextBox();
            this.Quantity = new System.Windows.Forms.Label();
            this.lister = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LineTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotalbox = new System.Windows.Forms.TextBox();
            this.subtotal = new System.Windows.Forms.Label();
            this.taxbox = new System.Windows.Forms.TextBox();
            this.taxlabel = new System.Windows.Forms.Label();
            this.overalltotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.addtitle = new System.Windows.Forms.Button();
            this.confrimbutton = new System.Windows.Forms.Button();
            this.cancelorder = new System.Windows.Forms.Button();
            this.Total = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lister)).BeginInit();
            this.SuspendLayout();
            // 
            // dropdown
            // 
            this.dropdown.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.dropdown.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.dropdown.FormattingEnabled = true;
            this.dropdown.Location = new System.Drawing.Point(79, 34);
            this.dropdown.Name = "dropdown";
            this.dropdown.Size = new System.Drawing.Size(649, 21);
            this.dropdown.TabIndex = 0;
            this.dropdown.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Authorline
            // 
            this.Authorline.AutoSize = true;
            this.Authorline.Location = new System.Drawing.Point(76, 104);
            this.Authorline.Name = "Authorline";
            this.Authorline.Size = new System.Drawing.Size(38, 13);
            this.Authorline.TabIndex = 1;
            this.Authorline.Tag = "Name of author";
            this.Authorline.Text = "Author";
            this.Authorline.Click += new System.EventHandler(this.Authorlabel);
            // 
            // isbn
            // 
            this.isbn.AutoSize = true;
            this.isbn.Location = new System.Drawing.Point(525, 104);
            this.isbn.Name = "isbn";
            this.isbn.Size = new System.Drawing.Size(32, 13);
            this.isbn.TabIndex = 2;
            this.isbn.Text = "ISBN";
            this.isbn.Click += new System.EventHandler(this.isbn_Click);
            // 
            // prce
            // 
            this.prce.AutoSize = true;
            this.prce.Location = new System.Drawing.Point(293, 145);
            this.prce.Name = "prce";
            this.prce.Size = new System.Drawing.Size(31, 13);
            this.prce.TabIndex = 3;
            this.prce.Text = "Price";
            this.prce.Click += new System.EventHandler(this.Pricelabel);
            // 
            // authroline
            // 
            this.authroline.Location = new System.Drawing.Point(120, 101);
            this.authroline.Name = "authroline";
            this.authroline.Size = new System.Drawing.Size(165, 20);
            this.authroline.TabIndex = 4;
            this.authroline.TextChanged += new System.EventHandler(this.authroline_TextChanged);
            // 
            // ISBNline
            // 
            this.ISBNline.Location = new System.Drawing.Point(563, 101);
            this.ISBNline.Name = "ISBNline";
            this.ISBNline.Size = new System.Drawing.Size(165, 20);
            this.ISBNline.TabIndex = 5;
            this.ISBNline.TextChanged += new System.EventHandler(this.ISBNline_TextChanged);
            // 
            // Priceline
            // 
            this.Priceline.Location = new System.Drawing.Point(330, 142);
            this.Priceline.Name = "Priceline";
            this.Priceline.Size = new System.Drawing.Size(165, 20);
            this.Priceline.TabIndex = 6;
            this.Priceline.TextChanged += new System.EventHandler(this.Priceline_TextChanged);
            // 
            // quantitybox
            // 
            this.quantitybox.Location = new System.Drawing.Point(353, 195);
            this.quantitybox.Name = "quantitybox";
            this.quantitybox.Size = new System.Drawing.Size(102, 20);
            this.quantitybox.TabIndex = 8;
            this.quantitybox.TextChanged += new System.EventHandler(this.Quantitybox);
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.Location = new System.Drawing.Point(384, 169);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(46, 13);
            this.Quantity.TabIndex = 7;
            this.Quantity.Text = "Quantity";
            this.Quantity.Click += new System.EventHandler(this.Quantity_Click);
            // 
            // lister
            // 
            this.lister.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lister.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.Price,
            this.QTY,
            this.LineTotal});
            this.lister.Location = new System.Drawing.Point(191, 257);
            this.lister.Name = "lister";
            this.lister.Size = new System.Drawing.Size(442, 175);
            this.lister.TabIndex = 9;
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // QTY
            // 
            this.QTY.HeaderText = "QTY";
            this.QTY.Name = "QTY";
            // 
            // LineTotal
            // 
            this.LineTotal.HeaderText = "Line Total";
            this.LineTotal.Name = "LineTotal";
            // 
            // subtotalbox
            // 
            this.subtotalbox.Location = new System.Drawing.Point(83, 450);
            this.subtotalbox.Name = "subtotalbox";
            this.subtotalbox.Size = new System.Drawing.Size(165, 20);
            this.subtotalbox.TabIndex = 11;
            this.subtotalbox.TextChanged += new System.EventHandler(this.subtotalbox_TextChanged);
            // 
            // subtotal
            // 
            this.subtotal.AutoSize = true;
            this.subtotal.Location = new System.Drawing.Point(39, 453);
            this.subtotal.Name = "subtotal";
            this.subtotal.Size = new System.Drawing.Size(46, 13);
            this.subtotal.TabIndex = 10;
            this.subtotal.Text = "Subtotal";
            this.subtotal.Click += new System.EventHandler(this.Subtotallabel);
            // 
            // taxbox
            // 
            this.taxbox.Location = new System.Drawing.Point(340, 447);
            this.taxbox.Name = "taxbox";
            this.taxbox.Size = new System.Drawing.Size(165, 20);
            this.taxbox.TabIndex = 13;
            this.taxbox.TextChanged += new System.EventHandler(this.taxbox_TextChanged);
            // 
            // taxlabel
            // 
            this.taxlabel.AutoSize = true;
            this.taxlabel.Location = new System.Drawing.Point(296, 450);
            this.taxlabel.Name = "taxlabel";
            this.taxlabel.Size = new System.Drawing.Size(25, 13);
            this.taxlabel.TabIndex = 12;
            this.taxlabel.Text = "Tax";
            this.taxlabel.Click += new System.EventHandler(this.taxlabel_Click);
            // 
            // overalltotal
            // 
            this.overalltotal.Location = new System.Drawing.Point(589, 447);
            this.overalltotal.Name = "overalltotal";
            this.overalltotal.Size = new System.Drawing.Size(165, 20);
            this.overalltotal.TabIndex = 17;
            this.overalltotal.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(545, 450);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "  ";
            // 
            // addtitle
            // 
            this.addtitle.Location = new System.Drawing.Point(330, 221);
            this.addtitle.Name = "addtitle";
            this.addtitle.Size = new System.Drawing.Size(155, 23);
            this.addtitle.TabIndex = 18;
            this.addtitle.Text = "Add title";
            this.addtitle.UseVisualStyleBackColor = true;
            this.addtitle.Click += new System.EventHandler(this.addtitle_Click);
            // 
            // confrimbutton
            // 
            this.confrimbutton.Location = new System.Drawing.Point(219, 488);
            this.confrimbutton.Name = "confrimbutton";
            this.confrimbutton.Size = new System.Drawing.Size(155, 23);
            this.confrimbutton.TabIndex = 19;
            this.confrimbutton.Text = "Confrim Order";
            this.confrimbutton.UseVisualStyleBackColor = true;
            this.confrimbutton.Click += new System.EventHandler(this.confrimbutton_Click);
            // 
            // cancelorder
            // 
            this.cancelorder.Location = new System.Drawing.Point(446, 488);
            this.cancelorder.Name = "cancelorder";
            this.cancelorder.Size = new System.Drawing.Size(155, 23);
            this.cancelorder.TabIndex = 20;
            this.cancelorder.Text = "Cancel Order";
            this.cancelorder.UseVisualStyleBackColor = true;
            this.cancelorder.Click += new System.EventHandler(this.cancelorder_Click);
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(552, 450);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(31, 13);
            this.Total.TabIndex = 21;
            this.Total.Text = "Total";
            // 
            // Bg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ArkhamHouse_Book_Order_Form.Properties.Resources.photo_1507842217343_583bb7270b66;
            this.ClientSize = new System.Drawing.Size(800, 523);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.cancelorder);
            this.Controls.Add(this.confrimbutton);
            this.Controls.Add(this.addtitle);
            this.Controls.Add(this.overalltotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.taxbox);
            this.Controls.Add(this.taxlabel);
            this.Controls.Add(this.subtotalbox);
            this.Controls.Add(this.subtotal);
            this.Controls.Add(this.lister);
            this.Controls.Add(this.quantitybox);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.Priceline);
            this.Controls.Add(this.ISBNline);
            this.Controls.Add(this.authroline);
            this.Controls.Add(this.prce);
            this.Controls.Add(this.isbn);
            this.Controls.Add(this.Authorline);
            this.Controls.Add(this.dropdown);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Bg";
            this.Text = "Arkham House Books Order Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.BackgroundImageChanged += new System.EventHandler(this.Bg_BackgroundImageChanged);
            ((System.ComponentModel.ISupportInitialize)(this.lister)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox dropdown;
        private System.Windows.Forms.Label Authorline;
        private System.Windows.Forms.Label isbn;
        private System.Windows.Forms.Label prce;
        private System.Windows.Forms.TextBox ISBNline;
        private System.Windows.Forms.TextBox Priceline;
        private System.Windows.Forms.TextBox quantitybox;
        private System.Windows.Forms.Label Quantity;
        private System.Windows.Forms.DataGridView lister;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn LineTotal;
        private System.Windows.Forms.TextBox subtotalbox;
        private System.Windows.Forms.Label subtotal;
        private System.Windows.Forms.TextBox taxbox;
        private System.Windows.Forms.Label taxlabel;
        private System.Windows.Forms.TextBox overalltotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button addtitle;
        private System.Windows.Forms.Button confrimbutton;
        private System.Windows.Forms.Button cancelorder;
        private System.Windows.Forms.Label Total;
        public System.Windows.Forms.TextBox authroline;
    }
}

