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
    public partial class sach : Form
    {
        String str = "Data Source=DESKTOP-4O41KAV;Initial Catalog=qlthuvien1.5;Integrated Security=True";
        SqlConnection con;

        public void loaddata()
        { 
            //string co = comboBox1.SelectedItem.ToString();
            SqlCommand cmd = new SqlCommand("select * from tb_sach", con);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            ad.Fill(table);
            dgv.DataSource = table;
        }

        public sach()
        {
            //set datetime to String !!!!
            //string ngay = DateTimePicker.Value.Tostring("MM/dd/yyyy");
            
            InitializeComponent();
        }
        private void sach_Load(object sender, EventArgs e)
        {
            ///string selected = comboBox1.SelectedItem.ToString();
            con = new SqlConnection(str);
            con.Open();
            // con.Close();
            loaddata();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            //it make where if u click on the table it will do things!!!! :3.
            int i;
            i = dgv.CurrentRow.Index;
            idsach.Text = dgv.Rows[i].Cells[0].Value.ToString();
            tensach.Text = dgv.Rows[i].Cells[1].Value.ToString();
            idtacgia.Text = dgv.Rows[i].Cells[2].Value.ToString();
            idtheloai.Text = dgv.Rows[i].Cells[3].Value.ToString();
            idnxb.Text = dgv.Rows[i].Cells[4].Value.ToString();
            nxb.Text = dgv.Rows[i].Cells[5].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            SqlCommand command = con.CreateCommand();
            command.CommandText = "insert into tb_sach(id_sach,ten_sach,id_tacgia,id_theloai,id_NXB,nam_XB) values('"+idsach.Text+"','"+tensach.Text+ "','" + idtacgia.Text + "','" + idtheloai.Text + "','" + idnxb.Text + "','" + nxb.Text + "')";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand command = con.CreateCommand();
            command.CommandText = "delete from tb_sach where id_sach='" + idsach.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command = con.CreateCommand();
            command.CommandText = "Update tb_sach set id_sach='" + idsach.Text + "', ten_sach='" + tensach.Text + "', id_tacgia='" + idtacgia.Text + "', id_NXB='" + idnxb.Text + "', nam_XB='" + nxb.Text + "'where id_sach='" + idsach.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void search_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from tb_sach where id_sach='"+idsach.Text+"'", con);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            ad.Fill(table);
            dgv.DataSource = table;
        }
    }
}
