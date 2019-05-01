using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;


namespace ArkhamHouse_Book_Order_Form
{

    public partial class Bg : Form
    {

        List<GeneralBook> Library = new List<GeneralBook>();
        public Bg()
        {


            int bookNumb = 0;
            /* nitializeComponent is a method automatically written for you by the Form Designer when you create/change your forms.*/
            InitializeComponent();
            try
            {          
                string[] stuffz = File.ReadAllLines("//Mac/Home/Desktop/ArkhamHouse Book Order Form 2/Titles books.txt");

                foreach (string xazebira in stuffz)
                {
                    string[] arr = xazebira.Split(',');
                    GeneralBook book = new GeneralBook(arr[0].Trim(), arr[1].Trim(), arr[2].Trim(), arr[3].Trim());
                    Library.Add(book);
                }
            }
            catch (IOException alfonso) { }

            while (bookNumb < Library.Count)
            {
                dropdown.Items.Add((Library[bookNumb].Bookname));
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
            Priceline.ReadOnly = true;
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
        {
            // .AllowUserToAddRows = false;

            for (int counter = 0; counter < Library.Count; counter++)
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
            authroline.ReadOnly = true;

        }

        private void taxlabel_Click(object sender, EventArgs e)
        {

        }


        //what happens when the confrim button gets clicked 
        private void confrimbutton_Click(object sender, EventArgs e)
        {
            string overas = overalltotal.Text;
            //int lora = int.Parse(overas);
            // lister.AllowUserToAddRows = false;
            if ((lister.Rows.Count > 1) && ((lister.Rows[0].Cells[0].Value.ToString()) != null)) //shows a message box when theres an error of nothing being selected
            {
                List<string> orderinfo = new List<string>();
                for (int counder = 0; counder < lister.Rows.Count - 1; counder++)
                {
                    int a = 0, b = 1, c = 2, d = 3;//a title , b price, c quantity 
                    string valueone, valuetwo, combo, valva, seperator, valuethree, linetotal;
                    valueone = lister.Rows[counder].Cells[a].Value.ToString();
                    //this shall parse the title to the string and give me a valueone string that containts the particular book name
                    valuetwo = lister.Rows[counder].Cells[c].Value.ToString();
                    valuethree = lister.Rows[counder].Cells[d].Value.ToString();
                    linetotal = "Line Total: " + valuethree;
                    //this will create a int of quantity and afterwards parse to my valuetwo as a string
                    combo = "Title: " + valueone + " , " + "QTY:" + valuetwo;
                    //we combine this two to get the Title and QTY in a formated way 
                    int aproxer = counder + 1;
                    string spacef = "\n";
                    orderinfo.Add(spacef);
                    valva = "order number  " + aproxer;
                    seperator = "______________________________________________________________________";

                    orderinfo.Add(valva);
                    orderinfo.Add(seperator);
                    orderinfo.Add(combo);
                    orderinfo.Add(linetotal);

                }
                string seperatodr = "______________________________________________________________________";
                orderinfo.Add(seperatodr);
                string overa = overalltotal.Text;
                string overatxt = "Total: " + overa;
                orderinfo.Add(overatxt);
                orderinfo.Add(seperatodr);
                string space = "\n";
                orderinfo.Add(space);



                try
                {  //adds the info of the order to the text file as asked in the pdf
                    System.IO.File.WriteAllLines("//Mac/Home/Desktop/ArkhamHouse Book Order Form 2/Invoice.txt", orderinfo);
                }
                //catches any problem that io might encounter (normal ones)
                catch (IOException somethinVeryspecial) { }
                lister.Rows.Clear();
                lister.Refresh();
                //using foreach loop clears all the textboxes , idea came from reading a bit from  stackoverflow
                foreach (TextBox textBox in Controls.OfType<TextBox>())
                    textBox.Text = "";
                dropdown.Text = " ";

                const string alertmessage = "Good Luck";//because nothing was ever found 
                const string titletext = "Hello User Your Order was proccesed ";
                var messageboxer = MessageBox.Show(titletext, alertmessage, MessageBoxButtons.OKCancel);
            }//if ends exactly here 
            else
            {
                const string alertmessage = "Sorry really Sorry";//because nothing was ever found 
                const string titletext = "Hello User Your Should enter some quantity of books ";
                var messageboxer = MessageBox.Show(titletext, alertmessage, MessageBoxButtons.OKCancel);
                lister.Rows.Clear();
                lister.Refresh();
                foreach (TextBox textBox in Controls.OfType<TextBox>())
                    textBox.Text = "";
                dropdown.Text = " ";
            }


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
            // lister.AllowUserToAddRows = false;
            int raodenoba = 0;
            int counter = 0;
            // lister.AllowUserToAddRows = false;



            try
            {
                raodenoba = int.Parse(quantitybox.Text);
            }
            catch (Exception ex)
            {
                const string alertmessage = "Erro 404";//because nothing was ever found 
                const string titletext = "Hello User Please enter amount/quantity of books you want in numbers";
                var messageboxer = MessageBox.Show(titletext, alertmessage, MessageBoxButtons.OKCancel);
                quantitybox.Focus();
                quantitybox.Text = " ";
            }


            //try catch ends here 
            if (dropdown.SelectedItem == null) //shows a message box when theres an error of nothing being selected
            {
                this.ActiveControl = dropdown;
                quantitybox.Focus();
                quantitybox.Text = " ";

                // const string alertmessage = "Erro 409";//because nothing was ever found 
                // const string titletext = "Hello User Please Choose a Book From Drop Down List or Enter it";
                dropdown.Focus();
                dropdown.SelectedItem = Library[0].Bookname;

                // var messageboxer = MessageBox.Show(titletext, alertmessage, MessageBoxButtons.OK);
                /*
                                if (messageboxer == DialogResult.OK)
                                {   
                                    this.ActiveControl = dropdown;
                                    quantitybox.Focus();
                                    quantitybox.Text = " ";
                                }*/
                //  return;
            }//if ends exactly here 

            if (raodenoba != 0)
            {
                int rigi = lister.Rows.Add();
                double alltotal = 0.0;//we get it from adition of subtotal + and the tax, so (tax+subtotal)= ((subtotal*0.1)+subtotal)
                subtotalbox.Text += "$";
                double subtotal = 0.0;//decleration of subtotal
                double statetax = 0.0;//the tax is 10% of subtotal so we once we have the subtotal we gonna calculate it by multipliying tax by 0.1 
                taxbox.Text += "$";
                double cashforgrid = double.Parse(Priceline.Text.TrimStart('$'));
                double sul = (raodenoba * cashforgrid);
                overalltotal.Text += "$";


                string serialcode = ISBNline.Text.ToString();
                string Title = dropdown.SelectedItem.ToString();

                subtotal = subtotal + sul;//calculation of the subtotal in the genreal sense 
                statetax = (subtotal * 0.1);
                alltotal = statetax + subtotal;
                int a = 0, b = 1, c = 2, d = 3;//a book title collumnt ,b cash or price collumn, 
                lister.Rows[rigi].Cells[a].Value = Title;//book title
                lister.Rows[rigi].Cells[b].Value = cashforgrid;//cash
                lister.Rows[rigi].Cells[c].Value = raodenoba;//quantity 
                lister.Rows[rigi].Cells[d].Value = sul;//total

                subtotalbox.Text = subtotal.ToString();
                taxbox.Text = statetax.ToString();
                overalltotal.Text = alltotal.ToString();
                quantitybox.Focus();
                quantitybox.Text = " ";
            }
            else
            {
                /* const string alertmessage = "Erro 4904";//because nothing was ever found 
                 const string titletext = "Hello User Please Choose a Book From Drop Down List or Enter it";
                // dropdown.Focus();

                 var messageboxer = MessageBox.Show(titletext, alertmessage, MessageBoxButtons.OK);*/
                quantitybox.Focus();
                quantitybox.Text = " ";
                //lister.Rows.RemoveAt(lister.CurrentRow.Index);
                foreach (var row in lister.SelectedRows)
                {
                    lister.Rows.Remove(lister.CurrentRow);
                }
                lister.Refresh();
            }
        }//add title ends here 

        private void subtotalbox_TextChanged(object sender, EventArgs e)
        {
            subtotalbox.ReadOnly = true;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            overalltotal.ReadOnly = true;
        }

        private void Bg_BackgroundImageChanged(object sender, EventArgs e)
        {

        }

        private void taxbox_TextChanged(object sender, EventArgs e)
        {
            taxbox.ReadOnly = true;
        }

        private void ISBNline_TextChanged(object sender, EventArgs e)
        {
            ISBNline.ReadOnly = true;
        }
    }

    public class GeneralBook
    {
        public string Cash;//double
        public string Bookname;//name of the book
        public string Writer;//what happens if two authors ? 
        public string Serial;//serial can be both number and digit





        public GeneralBook(string Bookname, string Writer, string Cash, string Serial)
        {
            this.Bookname = Bookname;//Book name or title
            this.Writer = Writer;//name of the writer
            this.Serial = Serial;//isbn nothing more than a serial code
            this.Cash = Cash;//cash or price 

        }


    }


}
