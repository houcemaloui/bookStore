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


namespace Book_Store
{
    public partial class Form_cat : Form
    {
        // var for connection 
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public Form_cat()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (TXT_CATG.Text != "")
            {
                con.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HOUCEM\source\repos\Book Store\Book Store\bookdb.mdf; Integrated Security = True");
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = " INSERT INTO CatBook (catg) VALUES (@catg)";
                cmd.Parameters.AddWithValue("@catg", TXT_CATG.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                Form Popup_categorie_succ = new Popup_categorie_succ();
                Popup_categorie_succ.Show();
                this.Close();

            }
            else
            {

                MessageBox.Show("insert a categorie !! ");
            }

       
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
