using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Book_Store
{
    public partial class Form3 : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        List<String> List = new List<string>();
        public int state;


        public Form3()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
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
           
            

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
           Form Form_cat = new Form_cat();
            Form_cat.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           try
            {
                con.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HOUCEM\source\repos\Book Store\Book Store\bookdb.mdf; Integrated Security = True");
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = " SELECT catg FROM CatBook ";
                var rd = cmd.ExecuteReader();

                while(rd.Read())
                {
                    List.Add(Convert.ToString(rd[0]));
                }
                int i = 0;
                while(i < List.LongCount())
                {
                    com1.Items.Add(List[i]);
                    i = i + 1;

                }


            }
            catch(Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var dia = new OpenFileDialog();
            var res = dia.ShowDialog();
                    if (res == DialogResult.OK)
            {
                cover.Image = Image.FromFile(dia.FileName);
            }
                   
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (state == 0)
            {       // insert 
                try
                {
               


                    MemoryStream ma = new MemoryStream();
                    cover.Image.Save(ma, System.Drawing.Imaging.ImageFormat.Jpeg);
                    var _cover = ma.ToArray();


                    con.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HOUCEM\source\repos\Book Store\Book Store\bookdb.mdf; Integrated Security = True");
                    cmd.Connection = con;
                    con.Open();

                    cmd.CommandText = " INSERT INTO TBBOOKS (titre, auther, price, catg, date, rate, cover) VALUES (@titre, @auther, @price, @catg, @date, @rate, @cover)";
                    cmd.Parameters.AddWithValue("@titre", txtname.Text);
                    cmd.Parameters.AddWithValue("@auther", txtauther.Text);
                    cmd.Parameters.AddWithValue("@price", txtprix.Text);
                    cmd.Parameters.AddWithValue("@catg", com1.Text);
                    cmd.Parameters.AddWithValue("@date", txdate.Value);
                    cmd.Parameters.AddWithValue("@rate", txtrate.Value);
                    cmd.Parameters.AddWithValue("@cover", _cover);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception EX)
                {
                MessageBox.Show(EX.Message);
                }
                finally
                {

                con.Close();
                }

                    Form Popup_categorie_succ = new Popup_categorie_succ();
                     Popup_categorie_succ.Show();
                    this.Close();
            } 
            else
            {
                // edit 
                try
                {



                    MemoryStream ma = new MemoryStream();
                    cover.Image.Save(ma, System.Drawing.Imaging.ImageFormat.Jpeg);
                    var _cover = ma.ToArray();


                    con.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HOUCEM\source\repos\Book Store\Book Store\bookdb.mdf; Integrated Security = True");
                    cmd.Connection = con;
                    con.Open();

                    cmd.CommandText = " UPDATE SET TBBOOKS titre=@titre , auther=@auther , price=@price , catg=@catg, date=@date , rate=@rate, cover=@cover ";
                    cmd.Parameters.AddWithValue("@titre", txtname.Text);
                    cmd.Parameters.AddWithValue("@auther", txtauther.Text);
                    cmd.Parameters.AddWithValue("@price", txtprix.Text);
                    cmd.Parameters.AddWithValue("@catg", com1.Text);
                    cmd.Parameters.AddWithValue("@date", txdate.Value);
                    cmd.Parameters.AddWithValue("@rate", txtrate.Value);
                    cmd.Parameters.AddWithValue("@cover", _cover);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception EX)
                {
                    MessageBox.Show(EX.Message);
                }
                finally
                {

                    con.Close();
                }

                Form Popup_categorie_succ = new Popup_categorie_succ();
                Popup_categorie_succ.Show();
                this.Close();

            }


        }
        

    }
}
