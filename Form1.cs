using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formsAPP
{
    public partial class Form1 : Form
    {
        Pracownik pracownik = new Pracownik();
        //List<string> p = new List<string>();
        PasswordValidation passwordValidation = new PasswordValidation();
        int ilość_pracowników = 0;

        public Form1()
        {


            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            label1.Visible = false;
            label2.Visible = false;


        }

        private void addButton_click(object sender, EventArgs e)
        {


            pracownik.p.Add(new Pracownik()
            {
                Id = (int)numericUpDown2.Value,
                name = textBox1.Text,
                surname = textBox2.Text,
                age = (int)numericUpDown1.Value,
                date = dateTimePicker1.Value,
            });




            pracownik.liczbaPracowników.Add(1);



            dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, numericUpDown1.Value.ToString());







        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {






            //textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].ToString();



        }

        private void PasswordValidationButton_Click(object sender, EventArgs e)
        {

            passwordValidation.checkValidation(password: textBox3.Text);
            label1.Visible = true;
            label1.Text = "działa";

  
            if (passwordValidation.validationCorrect == false)
            {
                    label1.Visible = true;
                    label1.Text = "nie działa";
            }
            passwordValidation.refreshCorrectPassword();

            //passwordValidation.refreshCorrectPassword();

        }



        








    }
}
