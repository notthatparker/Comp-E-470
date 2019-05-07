using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Homework : Form
    {
        List<Book> Library = new List<Book>();
        public Homework()
        {
           
           
            
                
                /* nitializeComponent is a method automatically written for you by the Form Designer when you create/change your forms.*/
                InitializeComponent();
                Book DarkTower1 = new Book("The Gunslinger", "Stephen King", "$13.00", "01");
                Library.Add(DarkTower1);
                Book DarkTower2 = new Book("The Drawing of the Three", "Stephen King", "$5.00", "02");
                Library.Add(DarkTower2);
                Book DarkTower3 = new Book("The Waste Lands", "Stephen King", "$2.99", "03");
                Library.Add(DarkTower3);
                Book DarkTower4 = new Book("Wizard and Glass", "Stephen King", "$3.23", "04");
                Library.Add(DarkTower4);
                Book DarkTower5 = new Book("The Wind Through the Keyhole", "Stephen King", "$7.00", "05");
                Library.Add(DarkTower5);
                Book DarkTower6 = new Book("Wolves of the Calla", "Stephen King", "$18.12", "06");
                Library.Add(DarkTower6);
                Book DarkTower7= new Book("Song of Susannah", "Stephen King", "$12.00", "07");
                Library.Add(DarkTower7);

            for (int BookCount = 0; BookCount < Library.Count; BookCount++)

                {
                    NameDrop.Items.Add((Library[BookCount].name));
                }
            
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
             if (dataGridView1.Rows.Count != 0) //shows a message box when theres an error of nothing being selected
            {
                
                const string Notification = "Alert";//because nothing was ever found 
                const string saxeli = "Hello User if youll press ok now you will lose the data ";
                var dialogi = MessageBox.Show(saxeli, Notification, MessageBoxButtons.OKCancel);
                
                if (dialogi == DialogResult.OK)
                { //stckoverflowdan avige ravi
                    dataGridView1.Rows.Clear();
                    dataGridView1.Refresh();
                    foreach (TextBox txt in Controls.OfType<TextBox>())
                        txt.Text = "";
                    NameDrop.Text = " ";
                }

            }//if ends exactl

        }
        //confrim button 
        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count != 0) //shows a message box when theres an error of nothing being selected
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                foreach (TextBox txt in Controls.OfType<TextBox>())
                    txt.Text = "";
                NameDrop.Text = " ";

                const string alertmessage = "Good Luck";//because nothing was ever found 
                const string titletext = "Hello User Your Order was proccesed ";

                var dialogi = MessageBox.Show(titletext, alertmessage, MessageBoxButtons.OKCancel);


            }//if ends exactly here 

        }

        private void AuthorN_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tax_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void NameDrop_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int counter = 0; counter < Library.Count; counter++)
            {
                if (NameDrop.SelectedItem.ToString() == Library[counter].name)
                {
                    ISBN.Text = Library[counter].codi;
                    AuthorN.Text = Library[counter].author;
                    Price.Text = Library[counter].fasi;

                }
            }
        }

        private void Price_TextChanged(object sender, EventArgs e)
        {

        }

        private void ISBN_TextChanged(object sender, EventArgs e)
        {

        }

        private void addt_Click(object sender, EventArgs e)
        {
            int place = dataGridView1.Rows.Add();
            int qty = 0;
            int i = 0;



            try { qty = int.Parse(Quantity.Text); }

            catch (Exception Warning)

            {
                const string notification = "Erro 404";//because nothing was ever found 
                const string titletext = "Hello User Please enter amount/quantity of books you want";
                var dialogi = MessageBox.Show(titletext, notification, MessageBoxButtons.OKCancel);
                Quantity.Focus();
            Quantity.Text = " ";
            }







            //try catch ends here 


            if (NameDrop.SelectedItem == null) //shows a message box when theres an error of nothing being selected
            {
                const string alertmessage = "Erro 404";//because nothing was ever found 
                const string titletext = "Hello User Please Choose a Book From Drop Down List or Enter it";
                NameDrop.Focus();

                var messageboxer = MessageBox.Show(titletext, alertmessage, MessageBoxButtons.OKCancel);

                if (messageboxer == DialogResult.OK)
                {
                    this.ActiveControl = NameDrop;
                }
                return;
            }//if ends exactly here 
            double alltotal = 0.0;//we get it from adition of subtotal + and the tax, so (tax+subtotal)= ((subtotal*0.1)+subtotal)
            Subtotal.Text += "$";
            double subtotal = 0.0;//decleration of subtotal
            double statetax = 0.0;//the tax is 10% of subtotal so we once we have the subtotal we gonna calculate it by multipliying tax by 0.1 
            textBox6.Text += "$";
            double cashforgrid = double.Parse(Price.Text.TrimStart('$'));
            double sul = (qty * cashforgrid);
            Total.Text += "$";


            string serialcode = ISBN.Text.ToString();
            string Title = NameDrop.SelectedItem.ToString();

            subtotal = subtotal + sul;//calculation of the subtotal in the genreal sense 
            statetax = (subtotal * 0.1);
            alltotal = statetax + subtotal;
            int a = 0, b = 1, c = 2, d = 3;//a book title collumnt ,b cash or price collumn, 
            dataGridView1.Rows[place].Cells[a].Value = Title;
            dataGridView1.Rows[place].Cells[b].Value = cashforgrid;
            dataGridView1.Rows[place].Cells[c].Value = qty;
            dataGridView1.Rows[place].Cells[d].Value = sul;

            Subtotal.Text = subtotal.ToString();
            textBox6.Text = statetax.ToString();
            Total.Text = alltotal.ToString();
        }

        private void Total_TextChanged(object sender, EventArgs e)
        {

        }

        private void Quantity_TextChanged(object sender, EventArgs e)
        {

        }
    }

    public class Book
    {
        public string fasi;
        public string name;
        public string author;
        public string codi;





        public Book(string name, string author, string fasi, string codi)
        {
            this.name = name;//Book name or title
            this.author = author;//name of the writer
            this.codi = codi;//isbn nothing more than a serial code
            this.fasi = fasi;//cash or price 

        }


    }
}
