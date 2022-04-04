using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qlthuvien1._3
{
    public partial class tl : Form
    {

        String str = "Data Source=DESKTOP-4O41KAV;Initial Catalog=qlthuvien1.5;Integrated Security=True";
        SqlConnection con;

        void load_data()
        {
            SqlCommand com = con.CreateCommand();
            com.CommandText = "SELECT* FROM dbo.tb_theloai";
            SqlDataAdapter ad = new SqlDataAdapter();
            DataTable table = new DataTable();
            ad.SelectCommand = com;
            ad.Fill(table);
            dataGridView1.DataSource = table;
        }
        public tl()
        {
            InitializeComponent();
        }

        private void tl_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(str);
            con.Open();
            load_data();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            txtloai.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtten.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand("SELECT *  FROM tb_theloai WHERE id_theloai = '" + txtloai.Text + "'", con);
            //com = new SqlCommand("SELECT *  FROM tb_theloai WHERE ten_theloai = '" + txtten.Text + "'" , con);
            SqlDataAdapter ad = new SqlDataAdapter(com);
            DataTable table = new DataTable();
            ad.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand com = con.CreateCommand();
            com.CommandText = "INSERT INTO dbo.tb_theloai(id_theloai,ten_theloai) VALUES ('" + txtloai.Text + " ', ' " + txtten.Text + " ')";
            com.ExecuteNonQuery();
            load_data();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand com = con.CreateCommand();
            com.CommandText = "UPDATE dbo.tb_theloai SET ten_theloai ='" + txtten.Text + "' where id_theloai = '" + txtloai.Text + "'";
            com.ExecuteNonQuery();
            load_data();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //SqlCommand com = con.CreateCommand();
            //com.CommandText = "DELETE FROM [dbo].[tb_theloai] WHERE EXISTS(SELECT* FROM dbo.tb_sach WHERE dbo.tb_sach.id_theloai = dbo.tb_theloai.id_theloai AND dbo.tb_theloai.id_theloai = '"+ txtloai.Text+"')";
            SqlCommand command = con.CreateCommand();
            command.CommandText = "delete from tb_theloai where id_theloai='" + txtloai.Text + "'";
            command.ExecuteNonQuery();
            load_data();
        }
    }
}
