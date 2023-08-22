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
    public partial class Form7 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source= 3BDELATY; Initial Catalog = car sales; Integrated Security=true ");
        SqlCommand cmd;
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlParameter[] param = new SqlParameter[5];
            cmd = new SqlCommand("updatecar", con);
            cmd.CommandType = CommandType.StoredProcedure;
            param[0] = new SqlParameter("@carid", SqlDbType.Int);
            param[0].Value = textBox1.Text;
            param[1] = new SqlParameter("@cost", SqlDbType.NChar, 10);
            param[1].Value = textBox2.Text;
            param[2] = new SqlParameter("@quantity", SqlDbType.NChar, 10);
            param[2].Value = textBox3.Text;
            param[3] = new SqlParameter("@carname", SqlDbType.NChar, 10);
            param[3].Value = textBox4.Text;
            param[4] = new SqlParameter("@carmodel", SqlDbType.NChar, 10);
            param[4].Value = textBox5.Text;
            cmd.Parameters.AddRange(param);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Edited successfully", "updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Form3 ff = new Form3();
            this.Hide();
            ff.ShowDialog(this);
            this.Close();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 ff = new Form3();
            this.Hide();
            ff.ShowDialog(this);
            this.Close();
        }
    }
}
