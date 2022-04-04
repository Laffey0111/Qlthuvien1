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

namespace Qlthuvien1._3
{
    public partial class muontra : Form
    {
        String str = "Data Source=DESKTOP-4O41KAV;Initial Catalog=qlthuvien1.5;Integrated Security=True";
        SqlConnection con;

        public muontra()
        {
            InitializeComponent();
        }

        public void loaddata()
        {

            SqlCommand cmd = new SqlCommand("select * from tb_muontra", con);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            ad.Fill(table);
            dgv.DataSource = table;

        }

        private void muontra_Load(object sender, EventArgs e)
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
            idmt.Text = dgv.Rows[i].Cells[0].Value.ToString();
            idthe.Text = dgv.Rows[i].Cells[1].Value.ToString();
            idsach.Text = dgv.Rows[i].Cells[2].Value.ToString();
            ghichu.Text = dgv.Rows[i].Cells[3].Value.ToString();
            ngaymuon.Text = dgv.Rows[i].Cells[4].Value.ToString();
            ngaytra.Text = dgv.Rows[i].Cells[5].Value.ToString();
            idnv.Text = dgv.Rows[i].Cells[6].Value.ToString();
        }

        private void ghichu_TextChanged(object sender, EventArgs e)
        {

        }


        //i basicly insert and delete form the server.(bad solution,but ok!!!)
        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand command = con.CreateCommand();
            command.CommandText = "insert into tb_muontra values('" + idmt.Text + "','" + idthe.Text + "','" + idsach.Text + "','" + ghichu.Text + "','" + ngaymuon.Text + "','" + ngaytra.Text + "','" + idnv.Text + "')";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SqlCommand command = con.CreateCommand();
            //command.CommandText = "delete from tb_muontra where id_muontra='" + idmt.Text + "'";
            //command.ExecuteNonQuery();
            //loaddata();

            SqlCommand command = con.CreateCommand();
            command.CommandText = "Update tb_muontra set id_muontra='" + idmt.Text + "', id_the='" + idthe.Text + "', id_sach='" + idsach.Text + "', ghi_chu='" + ghichu.Text + "', ngay_muon='" + ngaymuon.Text + "', ngay_tra='" + ngaytra.Text + "', id_NV='" + idnv.Text + "'where id_muontra='" + idmt.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
        }
    }
}
