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

namespace WindowsFormsInterface
{
    public partial class Interface : Form
    {
        public Interface()
        {
            InitializeComponent();
            
        }



        private void Form1_Load(object sender, EventArgs e)
        {
           

            string connectionstring = "server=proj-mysql.uopnet.plymouth.ac.uk;user id=ISAD157_ASmith;persistsecurityinfo=True;database=isad157_asmith;";
            SqlConnection connection = new SqlConnection(connectionstring);
            connection.Open();
            SqlCommand cmd = new SqlCommand("select * twitter_users='" + listBox1.Text.Trim() + "'", connection);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                listBox2.Text = dr.GetString(1);
                listBox3.Text = dr.GetString(2);

            }
        }

        

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
