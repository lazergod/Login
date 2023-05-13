using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Namespace para el formulario de inicio de sesión
namespace Login
{
    // Formulario parcial de inicio de sesión
    public partial class Form3 : Form
    {
        // Conexión a la base de datos
        OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=login.accdb");

        // Constructor del formulario
        public Form3()
        {
            InitializeComponent();
        }

        // Método ejecutado cuando se carga el formulario
        private void Form3_Load(object sender, EventArgs e)
        {
            // Intenta abrir la conexión a la base de datos
            try
            {
                conexion.Open();
            }
            catch (Exception a)
            {
                // Muestra un mensaje de error si la conexión falla
                MessageBox.Show("Error al conectar por: " + a.ToString());
            }

            // Configura el ComboBox
            emailDomainComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            // Agrega opciones al ComboBox
            emailDomainComboBox.Items.Add("@pascualbravo.com");
            emailDomainComboBox.Items.Add("@ingsoftware.com");

            // Establece la primera opción del ComboBox por defecto
            emailDomainComboBox.SelectedIndex = 0;

            // Establece el foco inicial en la etiqueta 1
            this.ActiveControl = label1;
        }

        // Método para cerrar la aplicación
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Método para el botón de inicio de sesión
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            // Combina el texto de usuario y dominio
            string usuario = txtUsuario.Text + emailDomainComboBox.Text;
            string password = txtPassword.Text;

            // Verifica si la contraseña está vacía
            if (txtPassword.Text == "")
            {
                // Emite un pitido si la contraseña está vacía
                System.Media.SystemSounds.Beep.Play();
            }
            else
            {
                // Consulta a la base de datos para validar las credenciales
                string consulta = "select password,usuario from login where password = '" + password + "' and usuario = '" + usuario + "';";
                OleDbCommand comando = new OleDbCommand(consulta, conexion);
                OleDbDataReader leedb;
                leedb = comando.ExecuteReader();
                Boolean existereg = leedb.HasRows;
                if (existereg)
                {
                    // Si las credenciales son válidas, abre el formulario 4
                    Form4 form4 = new Form4();
                    this.Hide();
                    form4.Show();
                }
                else
                {
                    // Si las credenciales no son válidas, muestra un mensaje de error
                    MessageBox.Show("El Usuario y/o Contraseña es incorrecto.");
                    return;
                }
                // Cierra la conexión a la base de datos
                conexion.Close();
            }
        }

        // Método para el enlace de registro
        private void linklblRegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Abre el formulario de registro
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
            conexion.Close();
        }

        // Método para la casilla de verificación de la contraseñai
        private void checkPassword_CheckedChanged(object sender, EventArgs e)
        {
            // Cambia la visibilidad de la contraseña
            if (txtPassword.UseSystemPasswordChar == true)
            {
                // Si la contraseña está oculta, la muestra
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                // Si la contraseña está visible, la oculta
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        // Maneja el evento KeyDown del TextBox 'txtPassword'.
        // Cambia el foco al botón 'btnIngresar' cuando se presiona la tecla "Enter".
        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnIngresar.Focus();
            }
        }

        // Maneja el evento KeyDown del TextBox 'txtUsuario'.
        // Cambia el foco al TextBox 'txtPassword' cuando se presiona la tecla "Enter".
        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                txtPassword.Focus();
            }
        }

    }
}
