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
    public partial class nhanvien : Form
    {
        String str = "Data Source=DESKTOP-4O41KAV;Initial Catalog=qlthuvien1.5;Integrated Security=True";
        SqlConnection con;

        public void loaddata()
        {

            SqlCommand cmd = new SqlCommand("select * from tb_nhanvien", con);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            ad.Fill(table);
            dgv.DataSource = table;

        }

        public nhanvien()
        {
            InitializeComponent();
        }

        private void nhanvien_Load(object sender, EventArgs e)
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
            idnv.Text = dgv.Rows[i].Cells[0].Value.ToString();
            tennv.Text = dgv.Rows[i].Cells[1].Value.ToString();
            ns.Text = dgv.Rows[i].Cells[2].Value.ToString();
            sdt.Text = dgv.Rows[i].Cells[3].Value.ToString();
        }

        private void search_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from tb_nhanvien where id_NV='" + idnv.Text + "'", con);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            ad.Fill(table);
            dgv.DataSource = table;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand command = con.CreateCommand();
            command.CommandText = "insert into tb_nhanvien(id_NV,ten_nv,birthday,so_dt) values('" + idnv.Text + "','" + tennv.Text + "','" + ns.Text + "','" + sdt.Text + "')";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command = con.CreateCommand();
            command.CommandText = "Update tb_nhanvien set id_NV='" + idnv.Text + "', ten_nv='" + tennv.Text + "', birthday='" + ns.Text + "', so_dt='" + sdt.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand command = con.CreateCommand();
            command.CommandText = "delete from tb_sach where id_NV='" + idnv.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
        }
    }
}
