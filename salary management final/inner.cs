using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace salary_management_final
{
    public partial class inner : Form
    {
        String prvg;
        public inner(String prv)
        {
            InitializeComponent();
            prvg = prv;
            if(prv.Equals("user"))
            {
                button1.Enabled = false;
                button1.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form edit  = new edit(this);
            edit.TopLevel = false;
            edit.AutoScroll = true;
            this.flowLayoutPanel2.Controls.Add(edit);
            edit.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            homepage hp = new homepage();
            hp.Show();
        }

        private void inner_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form payment = new payment();
            payment.TopLevel = false;
            payment.AutoScroll = true;
            this.flowLayoutPanel2.Controls.Add(payment);
            payment.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form view = new view();
            view.TopLevel = false;
            view.AutoScroll = true;
            this.flowLayoutPanel2.Controls.Add(view);
            view.Show();
        }
    }
}
