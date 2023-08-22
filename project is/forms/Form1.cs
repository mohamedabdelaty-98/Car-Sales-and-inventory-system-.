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
using project_is.forms;

namespace project_is
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source= 3BDELATY; Initial Catalog = car sales; Integrated Security=true ");
        SqlCommand cmd;
        SqlDataReader rd;
        
        
        
        public Form1()
        {
           
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            MessageBox.Show("connection state is : " + con.State);
            con.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("select * from client where user_name = '"+textBox1.Text+"' and password ='"+textBox2.Text+"'",con );
            rd = cmd.ExecuteReader();
            int count = 0;
             while(rd.Read())
             {
                 count += 1;
             }
             if (count == 1)
             {
                 Form2 ff = new Form2();
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
             textBox1.Clear();
             textBox2.Clear();
          
             
             rd.Close();
            con.Close();
           
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            cmd = new SqlCommand("insertdata", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter[] param = new SqlParameter[9];
            param[0] = new SqlParameter("@firstname", SqlDbType.NChar, 10);
            param[0].Value = textBox6.Text;
            param[1] = new SqlParameter("@lastname", SqlDbType.NChar, 10);
            param[1].Value = textBox7.Text;
            param[2] = new SqlParameter("@username", SqlDbType.NChar, 10);
            param[2].Value = textBox5.Text;
            param[3] = new SqlParameter("@city", SqlDbType.NChar, 10);
            param[3].Value = textBox9.Text;
            param[4] = new SqlParameter("@address", SqlDbType.NChar, 50);
            param[4].Value = textBox8.Text;
            param[5] = new SqlParameter("@gender", SqlDbType.NChar, 10);
            param[5].Value = textBox11.Text;
            param[6] = new SqlParameter("@Email", SqlDbType.NChar, 50);
            param[6].Value = textBox10.Text;
            param[7] = new SqlParameter("@password", SqlDbType.NChar,50);
            param[7].Value = textBox4.Text;
            param[8] = new SqlParameter("@userid", SqlDbType.Int);
            param[8].Value = textBox3.Text;

            cmd.Parameters.AddRange(param);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Added successfully", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBox6.Clear();
            textBox7.Clear();
            textBox5.Clear();
            textBox9.Clear();
            textBox8.Clear();
            textBox11.Clear();
            textBox10.Clear();
            textBox4.Clear();
            textBox3.Clear();
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form4 ff = new Form4();
            this.Hide();
            ff.ShowDialog(this);
            this.Close();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter) button1_Click_1(sender, e);
        }
    }
}
