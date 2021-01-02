using MySql.Data.MySqlClient;
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
    public partial class new_employee : Form
    {
        public new_employee()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if(System.Text.RegularExpressions.Regex.IsMatch(salary.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                salary.Text = salary.Text.Remove(salary.Text.Length - 1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            MySqlConnection con = new MySqlConnection("server = localhost; user id = root; password=root; database=salary_management");
            con.Open();


            String selected = department.GetItemText(department.SelectedItem);
            String did="d01"; 
            switch(selected)
            {
                case  "Computer Science" : did = "d01";
                    break;

                case "Mechanical": did = "d02";
                    break;

                case "Civil": did = "d03";
                    break;

                case "Electronics": did = "d04";
                    break;

                case "Information Science" : did = "d05"; break;

            }



            int salary1 = Convert.ToInt32(salary.Text);
            int remain = Convert.ToInt32(salary1 - (0.0833 * salary1 + 0.0377 * salary1));

            String query= "insert into employee values('"+employee_id.Text+"','"+employee_name.Text + "','" +city.Text+ "','" + phone.Text + "','" +did+"','" + designation.Text + "')";
            String query2 = "insert into salary_struct values('" + employee_id.Text + "','" + salary.Text + "','5000','"+0.0833*salary1+"','" +0.0377*salary1+"','"+remain+"')";

            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            cmd.CommandText = query2;
            cmd.ExecuteNonQuery();
            con.Close();
            Close();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(phone.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                phone.Text = phone.Text.Remove(phone.Text.Length - 1);
            }
        }

        private void department_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void new_employee_Load(object sender, EventArgs e)
        {

        }

        private void employee_id_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
