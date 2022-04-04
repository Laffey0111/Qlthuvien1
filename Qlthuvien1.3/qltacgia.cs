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
    public partial class qltacgia : Form
    {

        String str = "Data Source=DESKTOP-4O41KAV;Initial Catalog=qlthuvien1.5;Integrated Security=True";
        SqlConnection con;

        public void loaddata()
        {
            SqlCommand cmd = new SqlCommand("select * from tb_tacgia", con);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            ad.Fill(table);
            dgv.DataSource = table;
        }

        public qltacgia()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void qltacgia_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(str);
            con.Open();
            // con.Close();
            loaddata();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv.CurrentRow.Index;
            idtg.Text = dgv.Rows[i].Cells[0].Value.ToString();
            tentg.Text = dgv.Rows[i].Cells[1].Value.ToString();
        }

        private void search_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from tb_tacgia where id_tacgia='" + idtg.Text + "'", con);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            ad.Fill(table);
            dgv.DataSource = table;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand command = con.CreateCommand();
            command.CommandText = "insert into tb_tacgia(id_tacgia,ten_tg) values('" + idtg.Text + "','" + tentg.Text + "')";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command = con.CreateCommand();
            command.CommandText = "Update tb_tacgia set id_tacgia='" + idtg.Text + "', ten_tg='" + tentg.Text + "'where id_tacgia='" + idtg.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand command = con.CreateCommand();
            command.CommandText = "delete from tb_tacgia where id_tacgia='" + idtg.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
        }
    }
}
