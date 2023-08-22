using project_is.user_control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_is.forms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void addcontrol(Control c)
        {
            c.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(c);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            us_parts h = new us_parts();
            addcontrol(h);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            us_car h = new us_car();
            addcontrol(h);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            us_parts h = new us_parts();
            addcontrol(h);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            us_car h = new us_car();
            addcontrol(h);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 ff = new Form2();
            this.Hide();
            ff.ShowDialog(this);
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 ff = new Form1();
            this.Hide();
            ff.ShowDialog(this);
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
