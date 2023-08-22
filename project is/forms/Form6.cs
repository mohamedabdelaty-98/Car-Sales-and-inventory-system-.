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
    public partial class Form6 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=3BDELATY;Initial Catalog=car sales;Integrated Security=SSPI");
        SqlCommand cmd;
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlParameter[] param = new SqlParameter[4];
            cmd = new SqlCommand("insertpart", con);
            cmd.CommandType = CommandType.StoredProcedure;
            param[0] = new SqlParameter("@partid", SqlDbType.Int);
            param[0].Value = textBox2.Text;
            param[1] = new SqlParameter("@partname", SqlDbType.NChar, 10);
            param[1].Value = textBox3.Text;
            param[2] = new SqlParameter("@cost", SqlDbType.Money);
            param[2].Value = textBox4.Text;
            param[3] = new SqlParameter("@quantity", SqlDbType.Int);
            param[3].Value = textBox1.Text;
            cmd.Parameters.AddRange(param);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Added successfully", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Form3 ff = new Form3();
            this.Hide();
            ff.ShowDialog(this);
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 ff = new Form3();
            this.Hide();
            ff.ShowDialog(this);
            this.Close();

        }
            
        }
    }

