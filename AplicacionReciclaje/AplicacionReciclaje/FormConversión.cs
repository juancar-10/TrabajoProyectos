using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionReciclaje
{
    public partial class FormConversión : Form
    {
        public FormConversión()
        {
            InitializeComponent();
        }

        private void FormConversión_Load(object sender, EventArgs e)
        {

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

        private void buttonInicio_Click(object sender, EventArgs e)
        {
            new LogOutButton().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new frmRegistrer().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new FormCanjeo().Show();
            this.Hide();
        }
    }
}
