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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AplicacionReciclaje
{
    public partial class LogOutButton : Form
    {
        public LogOutButton()
        {
            InitializeComponent();
        }

        Form2 campoUsuario = new Form2();

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //string nombreUsuario = campoUsuario.Username;
            //label2.Text = nombreUsuario;
            //label2.Text = "" + nombreUsuario + "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new frmRegistrer().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Espera a la siguiente versión de la aplicación", "Pagina en desarrollo...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonNoticias_Click(object sender, EventArgs e)
        {
            new FormNoticias().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new FormConversión().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new FormCanjeo().Show();
            this.Hide();
        }
    }
}
