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

namespace AplicacionReciclaje
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\juanc\\OneDrive - UFV\\Proyectos\\Aplicación\\TrabajoProyectos\\AplicacionReciclaje\\AplicacionReciclaje\\Database1.mdf\";Integrated Security=True;");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter sda = new SqlDataAdapter();

        public string Username
        {
            get { return txtUsername.Text; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            string login = "SELECT * FROM InfoUsuario WHERE NombreUsuario= @NombreUsuario and Contraseña= @Contraseña";
            cmd = new SqlCommand(login, connection);
            cmd.Parameters.AddWithValue("@NombreUsuario", txtUsername.Text);
            cmd.Parameters.AddWithValue("@Contraseña", txtPassword.Text);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read() == true)
            {
                new LogOutButton().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrectos, Por favor intentalo de nuevo", "Inicio de Sesión Falido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtUsername.Focus();
            }
            connection.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtUsername.Focus();
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '•';
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            new frmRegistrer().Show();
            this.Hide();
        }

        private void labelPassword_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
