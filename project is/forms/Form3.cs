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
    public partial class Form3 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source= 3BDELATY; Initial Catalog = car sales; Integrated Security=true ");
        SqlDataAdapter da,da1,da2;
        DataTable dt = new DataTable();
        DataTable dt1 = new DataTable();
        DataTable dt2 = new DataTable();
        SqlDataAdapter Da;
        DataTable Dt= new DataTable();
        SqlCommand cmd;
        public Form3()
        {
            InitializeComponent();
           da = new SqlDataAdapter("select * from car", con);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            Da = new SqlDataAdapter("select * from part", con);
            Da.Fill(Dt);
            dataGridView2.DataSource = Dt;
           }
    

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 ff = new Form5();
            this.Hide();
            ff.ShowDialog(this);
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form6 ff = new Form6();
            this.Hide();
            ff.ShowDialog(this);
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("deletecar", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter param = new SqlParameter();
            param = new SqlParameter("@carid", SqlDbType.Int);
            param.Value = textBox1.Text;
            cmd.Parameters.Add(param);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Deleted successfully", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dt.Clear();
            da = new SqlDataAdapter("select * from car", con);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("deletepart", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter param1 = new SqlParameter();
            param1 = new SqlParameter("@partid", SqlDbType.Int);
            param1.Value = textBox2.Text;
            cmd.Parameters.Add(param1);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Deleted successfully", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Dt.Clear();
            Da = new SqlDataAdapter("select * from part", con);
            Da.Fill(Dt);
            dataGridView2.DataSource = Dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form8 ff = new Form8();
            this.Hide();
            ff.ShowDialog(this);
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form7 ff = new Form7();
            this.Hide();
            ff.ShowDialog(this);
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form1 ff = new Form1();
            this.Hide();
            ff.ShowDialog(this);
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            con.Open();
            dt1.Clear();
            da1 = new SqlDataAdapter("select * from client", con);
            da1.Fill(dt1);
            dataGridView3.DataSource = dt1;
            
           
            con.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            con.Open();
            dt2.Clear();
            da2 = new SqlDataAdapter("select * from deliver2", con);
            da2.Fill(dt2);
            dataGridView3.DataSource = dt2;


            con.Close();
        }
    }
}
