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
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //colored button.
            //homepanel.BackColor = Color.FromArgb(172, 252, 243);//this change the uhmmmm home thing to diff color.
            button1.BackColor = Color.FromArgb(244, 126, 112);
            button1.ForeColor = Color.Black;

            button6.BackColor = Color.Transparent;
            button6.ForeColor = Color.FromArgb(244, 126, 112);
            button2.BackColor = Color.Transparent;
            button2.ForeColor = Color.FromArgb(244, 126, 112);
            button4.BackColor = Color.Transparent;
            button4.ForeColor = Color.FromArgb(244, 126, 112);
            button5.BackColor = Color.Transparent;
            button5.ForeColor = Color.FromArgb(244, 126, 112);

            //uhmmmmmmm make things go away.....???(border,yes!!!)
            view.Controls.Clear();//hide fuction button.
            menusach s = new menusach() { Dock = DockStyle.Fill, TopLevel = true, TopMost = true };
            s.TopLevel = false;
            view.Controls.Add(s);
            s.FormBorderStyle = FormBorderStyle.None;
            s.Show();
            //s.Close();//uhmmm dont turn this on!!! pls!.
        }

        private void view_Paint(object sender, PaintEventArgs e)
        {

        }


        //SET fuction for button [B/Y/R]
        //private void homepanel_MouseDown(object sender, MouseEventArgs e)
        //{
        //    ReleaseCapture();
        //    SendMessage(this.Handle, 0x112, 0xf012, 0);
        //}

        //private void button6_Click(object sender, EventArgs e)
        //{
        //    Application.Exit();
        //}

        //private void button7_Click(object sender, EventArgs e)
        //{
        //    if (WindowState == FormWindowState.Normal)
        //        this.WindowState = FormWindowState.Maximized;
        //    else
        //        this.WindowState = FormWindowState.Normal;
        //}

        //private void button8_Click(object sender, EventArgs e)
        //{
        //    this.WindowState = FormWindowState.Minimized;
        //}

        //set border to NONE
        private void home_Load(object sender, EventArgs e)
        {
            //loading this form with no border :3.
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.BackColor = Color.FromArgb(244, 126, 112);
            button6.ForeColor = Color.Black;

            button1.BackColor = Color.Transparent;
            button1.ForeColor = Color.FromArgb(244, 126, 112);
            button2.BackColor = Color.Transparent;
            button2.ForeColor = Color.FromArgb(244, 126, 112);
            button4.BackColor = Color.Transparent;
            button4.ForeColor = Color.FromArgb(244, 126, 112);
            button5.BackColor = Color.Transparent;
            button5.ForeColor = Color.FromArgb(244, 126, 112);


            //uhmmmmmmm make things go away.....???(border,yes!!!)
            view.Controls.Clear();//hide fuction button.
            setting se = new setting() { Dock = DockStyle.Fill, TopLevel = true, TopMost = true };
            se.TopLevel = false;
            view.Controls.Add(se);
            se.FormBorderStyle = FormBorderStyle.None;
            se.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            button5.BackColor = Color.FromArgb(244, 126, 112);
            button5.ForeColor = Color.Black;

            button1.BackColor = Color.Transparent;
            button1.ForeColor = Color.FromArgb(244, 126, 112);
            button2.BackColor = Color.Transparent;
            button2.ForeColor = Color.FromArgb(244, 126, 112);
            button4.BackColor = Color.Transparent;
            button4.ForeColor = Color.FromArgb(244, 126, 112);
            button6.BackColor = Color.Transparent;
            button6.ForeColor = Color.FromArgb(244, 126, 112);


            //uhmmmmmmm make things go away.....???(border,yes!!!)
            view.Controls.Clear();//hide fuction button.
            thedg tg = new thedg() { Dock = DockStyle.Fill, TopLevel = true, TopMost = true };
            tg.TopLevel = false;
            view.Controls.Add(tg);
            tg.FormBorderStyle = FormBorderStyle.None;
            tg.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(244, 126, 112);
            button2.ForeColor = Color.Black;

            button1.BackColor = Color.Transparent;
            button1.ForeColor = Color.FromArgb(244, 126, 112);
            button6.BackColor = Color.Transparent;
            button6.ForeColor = Color.FromArgb(244, 126, 112);
            button4.BackColor = Color.Transparent;
            button4.ForeColor = Color.FromArgb(244, 126, 112);
            button5.BackColor = Color.Transparent;
            button5.ForeColor = Color.FromArgb(244, 126, 112);

            //load with no border.
            view.Controls.Clear();//hide fuction button.
            muontra mt = new muontra() { Dock = DockStyle.Fill, TopLevel = true, TopMost = true };
            mt.TopLevel = false;
            view.Controls.Add(mt);
            mt.FormBorderStyle = FormBorderStyle.None;
            mt.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.FromArgb(244, 126, 112);
            button4.ForeColor = Color.Black;

            button1.BackColor = Color.Transparent;
            button1.ForeColor = Color.FromArgb(244, 126, 112);
            button6.BackColor = Color.Transparent;
            button6.ForeColor = Color.FromArgb(244, 126, 112);
            button2.BackColor = Color.Transparent;
            button2.ForeColor = Color.FromArgb(244, 126, 112);
            button5.BackColor = Color.Transparent;
            button5.ForeColor = Color.FromArgb(244, 126, 112);

            //i dont want to say again.
            view.Controls.Clear();//hide fuction button.
            nhanvien nv = new nhanvien() { Dock = DockStyle.Fill, TopLevel = true, TopMost = true };
            nv.TopLevel = false;
            view.Controls.Add(nv);
            nv.FormBorderStyle = FormBorderStyle.None;
            nv.Show();
        }
    }
}
