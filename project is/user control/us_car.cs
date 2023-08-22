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
    public partial class us_car : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=3BDELATY;Initial Catalog=car sales;Integrated Security=SSPI");
        SqlCommand cmd;
        SqlDataAdapter DA;
        DataTable DT = new DataTable();
        SqlDataAdapter ad;
        DataTable td = new DataTable();
        public us_car()
        {
            InitializeComponent();
            DA = new SqlDataAdapter("select * from car", con);
            DA.Fill(DT);
            dataGridView1.DataSource = DT;
            ad = new SqlDataAdapter("select * from car", con);
            ad.Fill(td);
            comboBox1.DataSource = td;
            comboBox1.DisplayMember = "car_id";

           /* con.Open();
               cmd = new SqlCommand("select car_name,car_model,cost from car", con);
               SqlDataReader reader = cmd.ExecuteReader();
               DataTable tbl = new DataTable();
               tbl.Columns.Add("Name");
               tbl.Columns.Add("model");
               tbl.Columns.Add("Cost");
               DataRow row;
               while (reader.Read())
               {
                   row = tbl.NewRow();
                   row["Name"] = reader["car_name"];
                   row["model"] = reader["car_model"];
                   row["Cost"] = reader["cost"];
                   tbl.Rows.Add(row);
               }
               reader.Close();
               con.Close();
               dataGridView1.DataSource = tbl;*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(comboBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }
        string str = "";
        private void button2_Click(object sender, EventArgs e)
        {
            str += listBox1.SelectedItem + "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("insert into deliver2 (req_info,name,address)values('" + str + "','" + textBox1.Text + "','" + textBox2.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        
        }
    }
}
