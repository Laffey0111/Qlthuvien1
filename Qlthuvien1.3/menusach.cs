using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qlthuvien1._3
{
    public partial class menusach : Form
    {
        public menusach()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(244, 126, 112);
            button1.ForeColor = Color.Black;

            button2.BackColor = Color.Transparent;
            button2.ForeColor = Color.FromArgb(244, 126, 112);
            button3.BackColor = Color.Transparent;
            button3.ForeColor = Color.FromArgb(244, 126, 112);
            button4.BackColor = Color.Transparent;
            button4.ForeColor = Color.FromArgb(244, 126, 112);


            view.Controls.Clear();//hide fuction button.
            sach s = new sach() { Dock = DockStyle.Fill, TopLevel = true, TopMost = true };
            s.TopLevel = false;
            view.Controls.Add(s);
            s.FormBorderStyle = FormBorderStyle.None;
            s.Show();

        }


        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }



        private void menusach_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(244, 126, 112);
            button2.ForeColor = Color.Black;

            button1.BackColor = Color.Transparent;
            button1.ForeColor = Color.FromArgb(244, 126, 112);
            button3.BackColor = Color.Transparent;
            button3.ForeColor = Color.FromArgb(244, 126, 112);
            button4.BackColor = Color.Transparent;
            button4.ForeColor = Color.FromArgb(244, 126, 112);

            view.Controls.Clear();//hide fuction button.
            tl s = new tl() { Dock = DockStyle.Fill, TopLevel = true, TopMost = true };
            s.TopLevel = false;
            view.Controls.Add(s);
            s.FormBorderStyle = FormBorderStyle.None;
            s.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.FromArgb(244, 126, 112);
            button3.ForeColor = Color.Black;

            button1.BackColor = Color.Transparent;
            button1.ForeColor = Color.FromArgb(244, 126, 112);
            button2.BackColor = Color.Transparent;
            button2.ForeColor = Color.FromArgb(244, 126, 112);
            button4.BackColor = Color.Transparent;
            button4.ForeColor = Color.FromArgb(244, 126, 112);



            //uhmmmmmmm make things go away.....???(border,yes!!!)
            view.Controls.Clear();//hide fuction button.
            nxb s = new nxb() { Dock = DockStyle.Fill, TopLevel = true, TopMost = true };
            s.TopLevel = false;
            view.Controls.Add(s);
            s.FormBorderStyle = FormBorderStyle.None;
            s.Show();
            //s.Close();//uhmmm dont turn this on!!! pls!.
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.FromArgb(244, 126, 112);
            button4.ForeColor = Color.Black;

            button1.BackColor = Color.Transparent;
            button1.ForeColor = Color.FromArgb(244, 126, 112);
            button2.BackColor = Color.Transparent;
            button2.ForeColor = Color.FromArgb(244, 126, 112);
            button3.BackColor = Color.Transparent;
            button3.ForeColor = Color.FromArgb(244, 126, 112);



            //uhmmmmmmm make things go away.....???(border,yes!!!)
            view.Controls.Clear();//hide fuction button.
            qltacgia s = new qltacgia() { Dock = DockStyle.Fill, TopLevel = true, TopMost = true };
            s.TopLevel = false;
            view.Controls.Add(s);
            s.FormBorderStyle = FormBorderStyle.None;
            s.Show();
            //s.Close();//uhmmm dont turn this on!!! pls!.
        }
    }
}
