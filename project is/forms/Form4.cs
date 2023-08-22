using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace project_is.forms
{
    public partial class Form4 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source= 3BDELATY; Initial Catalog = car sales; Integrated Security=true ");
        SqlCommand cmd;
        SqlDataReader rd;
        public Form4()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("select * from admin where admin_name = '" + textBox2.Text + "' and password ='" + textBox1.Text + "'", con);
            rd = cmd.ExecuteReader();
            int count = 0;
            while (rd.Read())
            {
                count += 1;
            }
            if (count == 1)
            {
                Form3 ff = new Form3();
                this.Hide();
                ff.ShowDialog(this);
                this.Close();
            }
            else if (count > 0)
            {
                MessageBox.Show("duplicate user name or password");
            }
            else
            {
                MessageBox.Show("username or password is incorrect", "Add", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            textBox2.Clear();
            textBox1.Clear();


            rd.Close();
            con.Close();
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form1 ff = new Form1();
            this.Hide();
            ff.ShowDialog(this);
            this.Close();
        }
    }
}
