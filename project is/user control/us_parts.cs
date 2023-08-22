using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace project_is.user_control
{
    public partial class us_parts : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=3BDELATY;Initial Catalog=car sales;Integrated Security=SSPI");
        SqlCommand cmd;
        SqlDataAdapter AD;
        DataTable TD = new DataTable();
        SqlDataAdapter Ab;
        DataTable Ac= new DataTable();
        public us_parts()
        {
            InitializeComponent();
            AD = new SqlDataAdapter("select * from part", con);
            AD.Fill(TD);
            dataGridView1.DataSource = TD;
            Ab = new SqlDataAdapter("select * from part", con);
            Ab.Fill(Ac);
            comboBox1.DataSource = Ac;
            comboBox1.DisplayMember = "part_id";
          /*  con.Open();
            cmd = new SqlCommand("select part_name,cost from part", con);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable tbl = new DataTable();
            tbl.Columns.Add("Name");
            tbl.Columns.Add("Cost");
            DataRow row;
            while(reader.Read())
            {
                row = tbl.NewRow();
                row["Name"] = reader["part_name"];
                row["Cost"] = reader["cost"];
                tbl.Rows.Add(row);
            }
            reader.Close();
            con.Close();
            dataGridView1.DataSource = tbl;*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(comboBox1.Text);
        }
        string str="";
        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void us_parts_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Add(comboBox1.Text);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("insert into deliver2 (req_info,name,address)values('" + str + "','" + textBox1.Text + "','" + textBox2.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            str += listBox1.SelectedItem + "";
        }
    }
}
