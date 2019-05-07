namespace WindowsFormsApp4
{
    partial class Homework
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
            this.NameDrop = new System.Windows.Forms.ComboBox();
            this.AuthorN = new System.Windows.Forms.TextBox();
            this.ISBN = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.TextBox();
            this.Quantity = new System.Windows.Forms.TextBox();
            this.Subtotal = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.Total = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LineTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Author = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.addt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // NameDrop
            // 
            this.NameDrop.FormattingEnabled = true;
            this.NameDrop.Location = new System.Drawing.Point(45, 38);
            this.NameDrop.Name = "NameDrop";
            this.NameDrop.Size = new System.Drawing.Size(699, 24);
            this.NameDrop.TabIndex = 1;
            this.NameDrop.SelectedIndexChanged += new System.EventHandler(this.NameDrop_SelectedIndexChanged);
            // 
            // AuthorN
            // 
            this.AuthorN.Location = new System.Drawing.Point(110, 97);
            this.AuthorN.Name = "AuthorN";
            this.AuthorN.Size = new System.Drawing.Size(145, 22);
            this.AuthorN.TabIndex = 2;
            this.AuthorN.TextChanged += new System.EventHandler(this.AuthorN_TextChanged);
            // 
            // ISBN
            // 
            this.ISBN.Location = new System.Drawing.Point(546, 97);
            this.ISBN.Name = "ISBN";
            this.ISBN.Size = new System.Drawing.Size(145, 22);
            this.ISBN.TabIndex = 3;
            this.ISBN.TextChanged += new System.EventHandler(this.ISBN_TextChanged);
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(333, 136);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(124, 22);
            this.Price.TabIndex = 4;
            this.Price.TextChanged += new System.EventHandler(this.Price_TextChanged);
            // 
            // Quantity
            // 
            this.Quantity.Location = new System.Drawing.Point(333, 192);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(124, 22);
            this.Quantity.TabIndex = 5;
            this.Quantity.TextChanged += new System.EventHandler(this.Quantity_TextChanged);
            // 
            // Subtotal
            // 
            this.Subtotal.Location = new System.Drawing.Point(110, 448);
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.Size = new System.Drawing.Size(145, 22);
            this.Subtotal.TabIndex = 7;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(323, 448);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(145, 22);
            this.textBox6.TabIndex = 8;
            // 
            // Total
            // 
            this.Total.Location = new System.Drawing.Point(546, 448);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(145, 22);
            this.Total.TabIndex = 9;
            this.Total.TextChanged += new System.EventHandler(this.Total_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.Column1,
            this.QTY,
            this.LineTotal});
            this.dataGridView1.Location = new System.Drawing.Point(178, 292);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(439, 150);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Price";
            this.Column1.Name = "Column1";
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(226, 506);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Confirm Order";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(429, 506);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Canel Order";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Author
            // 
            this.Author.AutoSize = true;
            this.Author.Location = new System.Drawing.Point(50, 97);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(54, 17);
            this.Author.TabIndex = 13;
            this.Author.Text = "Author:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(494, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "ISBN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Quantity:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 448);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Subtotal:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(281, 448);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Tax:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(496, 448);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Total:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(343, 266);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 23);
            this.label8.TabIndex = 21;
            this.label8.Text = "Order Summary";
            // 
            // addt
            // 
            this.addt.Location = new System.Drawing.Point(356, 229);
            this.addt.Name = "addt";
            this.addt.Size = new System.Drawing.Size(75, 23);
            this.addt.TabIndex = 22;
            this.addt.Text = "Add Title";
            this.addt.UseVisualStyleBackColor = true;
            this.addt.Click += new System.EventHandler(this.addt_Click);
            // 
            // Homework
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 574);
            this.Controls.Add(this.addt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.Subtotal);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.ISBN);
            this.Controls.Add(this.AuthorN);
            this.Controls.Add(this.NameDrop);
            this.Name = "Homework";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Tax_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox NameDrop;
        private System.Windows.Forms.TextBox AuthorN;
        private System.Windows.Forms.TextBox ISBN;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.TextBox Quantity;
        private System.Windows.Forms.TextBox Subtotal;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox Total;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn LineTotal;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label Author;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button addt;
    }
}

