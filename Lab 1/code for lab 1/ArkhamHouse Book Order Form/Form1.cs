using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArkhamHouse_Book_Order_Form
{
    
    public partial class Bg : Form
    {
       
            List<Book> Library = new List<Book>();
            public Bg()
        {
            int bookNumb = 0;
            /* nitializeComponent is a method automatically written for you by the Form Designer when you create/change your forms.*/
            InitializeComponent();
                Book Dreamsinwitch = new Book("Dreams in the witchhouse", "H.P Lovecraft", "$6.00", "1333");
            Library.Add(Dreamsinwitch);
            Book Wondereofpast = new Book("Wonderer of past", "Robert.E.Bloch", "$11.00", "12333");
            Library.Add(Wondereofpast);
            Book Musicoferichzhan = new Book("Music of Erich Zahn", "H.P Lovecraft", "$4.00", "1445");
                Library.Add(Musicoferichzhan);
            Book spaceoutof = new Book("Space out of color", "H.P Lovecraft", "$2.00", "01936");
            Library.Add(spaceoutof);
            Book thingondoor = new Book("thing at the doorstep", "H.P Lovecraft", "$1.00", "01925");

            Library.Add(thingondoor);
    
            while(bookNumb<Library.Count)
  
                {
                    dropdown.Items.Add((Library[bookNumb].Bookname ));
                    bookNumb++;
                }
            } 

        private void Authorlabel(object sender, EventArgs e)//label of the authro line 
        {

        }

        private void Pricelabel(object sender, EventArgs e)//label of the price line 
        {

        }

        private void Priceline_TextChanged(object sender, EventArgs e)//text box of the price line 
        {

        }

        private void Quantity_Click(object sender, EventArgs e)
        {

        }

        private void Quantitybox(object sender, EventArgs e)
        {

        }

        private void Subtotallabel(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {   for (int counter = 0; counter < Library.Count; counter++)
            {
                if (dropdown.SelectedItem.ToString() == Library[counter].Bookname)
                {
                    ISBNline.Text = Library[counter].Serial;
                    authroline.Text = Library[counter].Writer;
                    Priceline.Text = Library[counter].Cash;

                }
            }
            }
         
        
     

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void isbn_Click(object sender, EventArgs e)
        {

        }

        private void authroline_TextChanged(object sender, EventArgs e)
        {

        }

        private void taxlabel_Click(object sender, EventArgs e)
        {

        }

        private void confrimbutton_Click(object sender, EventArgs e)
        {
            if (lister.Rows.Count != 0) //shows a message box when theres an error of nothing being selected
            {
                lister.Rows.Clear();
                lister.Refresh();
                foreach (TextBox textBox in Controls.OfType<TextBox>())
                    textBox.Text = "";
                dropdown.Text = " ";
 
                const string alertmessage = "Good Luck";//because nothing was ever found 
                const string titletext = "Hello User Your Order was proccesed ";

                var messageboxer = MessageBox.Show(titletext, alertmessage, MessageBoxButtons.OKCancel);

              
            }//if ends exactly here 


        }

        private void cancelorder_Click(object sender, EventArgs e)
        {
            if (lister.Rows.Count != 0) //shows a message box when theres an error of nothing being selected
            {
                
                const string alertmessage = "Alert";//because nothing was ever found 
                const string titletext = "Hello User if youll press ok now you will lose the data ";
                var messageboxer = MessageBox.Show(titletext, alertmessage, MessageBoxButtons.OKCancel);
                
                if (messageboxer == DialogResult.OK)
                {
                    lister.Rows.Clear();
                    lister.Refresh();
                    foreach (TextBox textBox in Controls.OfType<TextBox>())
                        textBox.Text = "";
                    dropdown.Text = " ";
                }

            }//if ends exactly 
        }

        private void addtitle_Click(object sender, EventArgs e)
        {

            int rigi =lister.Rows.Add();
            int raodenoba = 0;
            int counter = 0;

          

            try { raodenoba = int.Parse(quantitybox.Text); }

            catch (Exception warn )

            {   const string alertmessage = "Erro 404";//because nothing was ever found 
                const string titletext = "Hello User Please enter amount/quantity of books you want";
                var messageboxer = MessageBox.Show(titletext, alertmessage, MessageBoxButtons.OKCancel);
                quantitybox.Focus();
                quantitybox.Text = " ";
            }

          
                
                
            
         

            //try catch ends here 


            if (dropdown.SelectedItem == null) //shows a message box when theres an error of nothing being selected
            {
                const string alertmessage = "Erro 404";//because nothing was ever found 
                const string titletext = "Hello User Please Choose a Book From Drop Down List or Enter it";
                dropdown.Focus();

                var messageboxer = MessageBox.Show(titletext, alertmessage, MessageBoxButtons.OKCancel);

                if (messageboxer == DialogResult.OK)
                {
                    this.ActiveControl = dropdown;
                }
                return;
            }//if ends exactly here 
            double alltotal=0.0;//we get it from adition of subtotal + and the tax, so (tax+subtotal)= ((subtotal*0.1)+subtotal)
            subtotalbox.Text += "$";
            double subtotal = 0.0;//decleration of subtotal
            double statetax = 0.0;//the tax is 10% of subtotal so we once we have the subtotal we gonna calculate it by multipliying tax by 0.1 
            taxbox.Text += "$";
            double cashforgrid = double.Parse(Priceline.Text.TrimStart('$'));
            double sul = (raodenoba * cashforgrid);
            overalltotal.Text += "$";
       

            string serialcode = ISBNline.Text.ToString();
            string Title = dropdown.SelectedItem.ToString();
   
            subtotal= subtotal + sul;//calculation of the subtotal in the genreal sense 
            statetax = (subtotal * 0.1);
            alltotal = statetax + subtotal;
            int a = 0, b = 1, c = 2, d = 3;//a book title collumnt ,b cash or price collumn, 
            lister.Rows[rigi].Cells[a].Value = Title;
            lister.Rows[rigi].Cells[b].Value = cashforgrid;
            lister.Rows[rigi].Cells[c].Value = raodenoba;
            lister.Rows[rigi].Cells[d].Value = sul;
           
            subtotalbox.Text = subtotal.ToString();
            taxbox.Text = statetax.ToString();
            overalltotal.Text = alltotal.ToString();
        }//add title ends here 

        private void subtotalbox_TextChanged(object sender, EventArgs e)
        {
            //subtotalbox.Text +="$";
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Bg_BackgroundImageChanged(object sender, EventArgs e)
        {

        }
    }

    public class Book
    {
        public string Cash;
        public string Bookname;
        public string Writer;
        public string Serial;





        public Book(string Bookname, string Writer, string Cash, string Serial)
        {
            this.Bookname = Bookname;//Book name or title
            this.Writer = Writer;//name of the writer
            this.Serial = Serial;//isbn nothing more than a serial code
            this.Cash = Cash;//cash or price 

        }


    }
  

}
