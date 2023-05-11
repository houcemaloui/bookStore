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
    public partial class Form1 : System.Windows.Forms.Form
    {
        // var for sql connection 

        SqlConnection con = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand() ;
        List<String> List = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form Form3 = new Form3();
            bunifuTransition1.ShowSync(Form3);
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            con.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HOUCEM\source\repos\Book Store\Book Store\bookdb.mdf; Integrated Security = True");
            var sql = " SELECT id ,titre, auther, price, catg, date, rate, cover From TBBOOKS";
            da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form Form3 = new Form3();
            bunifuTransition1.ShowSync(Form3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form Popup_succ = new Popup_book_succ();
            bunifuTransition1.ShowSync(Popup_succ);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Form3 = new Form3();
           
            bunifuTransition1.ShowSync(Form3);
            try
            {
                con.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HOUCEM\source\repos\Book Store\Book Store\bookdb.mdf; Integrated Security = True");
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = " SELECT titre, auther, price, catg, date, rate FROM TBBOOKS WHERE id =@id  ";
                cmd.Parameters.AddWithValue("@id",Convert.ToInt16(dataGridView1.CurrentRow.Cells[0]));
                var rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    List.Add(Convert.ToString(rd[0]));
                    List.Add(Convert.ToString(rd[1]));
                    List.Add(Convert.ToString(rd[2]));
                    List.Add(Convert.ToString(rd[3]));
                    List.Add(Convert.ToString(rd[4]));
                    List.Add(Convert.ToString(rd[5]));
                }
                Form3 Form3 = new Form3();
                Form3.txtname.Text = List[0];
                Form3.txtname.Text = List[1];
                Form3.txtname.Text = List[2];
                Form3.txtname.Text = List[3];
                Form3.txtname.Text = List[4];
                Form3.txtname.Text = List[5];

                


            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
