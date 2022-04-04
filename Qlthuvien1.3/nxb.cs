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
    public partial class nxb : Form
    {

        String str = "Data Source=DESKTOP-4O41KAV;Initial Catalog=qlthuvien1.5;Integrated Security=True";
        SqlConnection con;

        public void loaddata()
        {
            SqlCommand cmd = new SqlCommand("select * from tb_NXB", con);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            ad.Fill(table);
            dgv.DataSource = table;
        }

        public nxb()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //it make where if u click on the table it will do things!!!! :3.
            int i;
            i = dgv.CurrentRow.Index;
            idnxb.Text = dgv.Rows[i].Cells[0].Value.ToString();
            tennxb.Text = dgv.Rows[i].Cells[1].Value.ToString();
        }

        private void nxb_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(str);
            con.Open();
            // con.Close();
            loaddata();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command = con.CreateCommand();
            command.CommandText = "insert into tb_NXB(id_NXB,ten_NXB) values('" + idnxb.Text + "','" + tennxb.Text + "')";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand command = con.CreateCommand();
            command.CommandText = "update tb_NXB set id_NXB='" + idnxb.Text + "', ten_NXB='" + tennxb.Text + "'where id_NXB='" + idnxb.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand command = con.CreateCommand();
            command.CommandText = "delete from tb_NXB where id_NXB='" + idnxb.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
        }
    }
}
