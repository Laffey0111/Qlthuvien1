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
    public partial class onload : Form
    {
        public onload()
        {
            //loadtime.Start();
            InitializeComponent();
            loadtime.Start();
            
        }

        private void loadtime_Tick(object sender, EventArgs e)
        {
            //solution 1:load other form before closing this one.

            //close this windows open another
            //this.Hide();
            //home sa = new home();
            //sa.Closed += (s, args) => this.Close();//close this form for good!!! :3
            //sa.Show();


            //solution 2:Loading other form in one panel

            //load in panel
            panel1.Controls.Clear();//hide fuction button.
            home s = new home() { Dock = DockStyle.Fill, TopLevel = true, TopMost = true };
            s.TopLevel = false;
            panel1.Controls.Add(s);
            s.FormBorderStyle = FormBorderStyle.None;
            s.Show();
            loadtime.Stop();
        }

        //load this windows with no border
        private void onload_Load(object sender, EventArgs e)
        {
            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }
    }
}
