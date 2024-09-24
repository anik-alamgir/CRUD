using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Metrics;

namespace CRUDapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool isAnyEmpty = false;
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    if (control.Text.Length == 0)
                    {
                        isAnyEmpty = true;
                        break;
                    }
                }
            }
            if (isAnyEmpty)
            {
                MessageBox.Show("Please fill the required box!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-8R7LIFN\\SQLEXPRESS01;Initial Catalog=\"crud app\";Integrated Security=True;TrustServerCertificate=True");
                con.Open();
                string insertQuery = "INSERT INTO crudapp (email, name, username, passward) VALUES(@email, @name, @username, @passward)";
                SqlCommand cmd = new SqlCommand(insertQuery, con);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@username", txtUser.Text);
                cmd.Parameters.AddWithValue("@passward", txtPass.Text);
                int count = cmd.ExecuteNonQuery();
                con.Close();
                if (count > 0)
                {
                    MessageBox.Show("Create Successfully!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error in Creation!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    control.Visible = false;
                }
                else if (control is NumericUpDown)
                {
                    control.Visible = false;
                }
                else if (control is Label)
                {
                    control.Visible = false;
                }
                else
                {
                    control.Visible = true;
                }
            }
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-8R7LIFN\\SQLEXPRESS01;Initial Catalog=\"crud app\";Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            string readQuery = "SELECT * FROM crudapp";
            SqlDataAdapter sda = new SqlDataAdapter(readQuery, con);
            SqlCommandBuilder cmd = new SqlCommandBuilder(sda);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is DataGridView)
                {
                    control.Visible = false;
                }
                else
                {
                    control.Visible = true;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-8R7LIFN\\SQLEXPRESS01;Initial Catalog=\"crud app\";Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            con.Open();
            string updateQuery = "UPDATE crudapp SET email= @email, name= @name, username= @username, passward= @passward WHERE id= @id";
            SqlCommand cmd = new SqlCommand(updateQuery, con);
            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@name", txtName.Text);
            cmd.Parameters.AddWithValue("@username", txtUser.Text);
            cmd.Parameters.AddWithValue("@passward", txtPass.Text);
            cmd.Parameters.AddWithValue("@id", numericUpDown1.Value);
            int count = cmd.ExecuteNonQuery();
            con.Close();
            if (count > 0)
            {
                MessageBox.Show("Upadate Successfully!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-8R7LIFN\\SQLEXPRESS01;Initial Catalog=\"crud app\";Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            con.Open();
            string deleteQuery = "DELETE FROM crudapp WHERE id = @id";
            SqlCommand cmd = new SqlCommand(deleteQuery , con);
            cmd.Parameters.AddWithValue("@id", numericUpDown1.Value);
            int count = cmd.ExecuteNonQuery();
            if(count > 0)
            {
                MessageBox.Show("Deleted Successfully!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
