using System;
using System.Data.OleDb;
using System.Linq;
using System.Media;
using System.Windows.Forms;

// Declara el espacio de nombres "Login"
namespace Login
{
    // Declara la clase "Form1" que hereda de la clase "Form" de la biblioteca de Windows Forms
    public partial class Form1 : Form
    {

        // Declarar el connectionString en la clase del formulario
        OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=login.accdb");
        // Declara una instancia de SoundPlayer para reproducir sonidos
        private SoundPlayer player = new SoundPlayer();

        // Constructor de la clase "Form1"
        public Form1()
        {
            // Inicializa los componentes del formulario
            InitializeComponent();

            // Define la ubicaci�n del archivo de sonido a reproducir
            player.SoundLocation = "Elevator-Music.wav";
            // Inicia la reproducci�n del sonido
            player.PlayLooping();  // Reproduce el sonido en un bucle
        }

        // M�todo que se ejecuta cuando se carga el formulario
        private void Form1_Load(object sender, EventArgs e)
        {
            ValidateInput();

            try
            {
                conexion.Open();
            }
            catch (Exception a)
            {
                MessageBox.Show("Error al conectar por: " + a.ToString());
            }

            // Establece el modo de visualizaci�n del ComboBox
            emailDomainComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            // Agrega elementos al ComboBox
            emailDomainComboBox.Items.Add("@pascualbravo.com");
            emailDomainComboBox.Items.Add("@ingsoftware.com");

            // Establece el primer elemento como seleccionado por defecto
            emailDomainComboBox.SelectedIndex = 0;

            // Establece el foco en el control lblPropiedades
            this.ActiveControl = lblPropiedades;
        }

        // M�todo que se ejecuta cuando se presiona una tecla en el campo de texto txtUsuario
        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Si el car�cter introducido es '@' o un espacio, se ignora y se emite un pitido
            if (e.KeyChar == '@' || e.KeyChar == ' ')
            {
                e.Handled = true;
                System.Media.SystemSounds.Beep.Play();
            }
        }
        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            ValidateInput();
        }
        // M�todo que se ejecuta cuando cambia el texto en el campo de texto txtPassword
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            // Valida la entrada
            ValidateInput();
        }

        // M�todo que se ejecuta cuando cambia el texto en el campo de texto txtPassword2
        private void txtPassword2_TextChanged(object sender, EventArgs e)
        {
            // Valida la entrada
            ValidateInput();
        }

        // M�todo para validar la entrada del usuario
        private void ValidateInput()
        {
            // Captura el texto introducido en los campos txtUsuario y txtPassword
            string usuario = txtUsuario.Text;
            string password = txtPassword.Text;

            // Verifica si el usuario no est� vac�o y tiene m�s de 5 caracteres
            bool isUsuarioValid = !string.IsNullOrWhiteSpace(usuario) && usuario.Length > 5;

            // Verifica si la contrase�a contiene al menos una letra, un n�mero y un s�mbolo y si las dos contrase�as coinciden
            bool hasLetter = password.Any(char.IsLetter);
            bool hasDigit = password.Any(char.IsDigit);
            bool hasSymbol = password.Any(ch => !Char.IsLetterOrDigit(ch));
            bool arePasswordsEqual = txtPassword.Text == txtPassword2.Text;

            // Si se cumplen todas las condiciones, se activa el bot�n de ingreso. De lo contrario, se desactiva.
            if (isUsuarioValid && password.Length >= 8 && hasLetter && hasDigit && hasSymbol && arePasswordsEqual)
            {
                btnIngresar.Enabled = true;
            }
            else
            {
                btnIngresar.Enabled = false;
            }
        }


        // M�todo que se ejecuta cuando se cambia el estado del checkPassword
        private void checkPassword_CheckedChanged(object sender, EventArgs e)
        {
            // Si los campos de la contrase�a est�n enmascarados, los desenmascara, y viceversa
            if (txtPassword.UseSystemPasswordChar == true || txtPassword2.UseSystemPasswordChar == true)
            {
                txtPassword.UseSystemPasswordChar = false;
                txtPassword2.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                txtPassword2.UseSystemPasswordChar = true;
            }
        }

        // M�todo que se ejecuta cuando se hace clic en el bot�n de ingreso
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text + emailDomainComboBox.Text;
            string password = txtPassword.Text;

            // Verificar si el usuario ya existe
            string consultaUsuarioExistente = "SELECT COUNT(*) FROM [login] WHERE [usuario] = '" + usuario + "'";
            OleDbCommand comandoUsuarioExistente = new OleDbCommand(consultaUsuarioExistente, conexion);
            int countUsuarios = (int)comandoUsuarioExistente.ExecuteScalar();

            if (countUsuarios > 0)
            {
                MessageBox.Show("El usuario ya existe en la base de datos.");
                return;
            }

            string consultaInsertarUsuario = "INSERT INTO [login] ([usuario], [password]) VALUES ('" + usuario + "', '" + password + "')";
            OleDbCommand comando = new OleDbCommand(consultaInsertarUsuario, conexion);

            try
            {
                comando.ExecuteNonQuery();
                MessageBox.Show("Usuario registrado exitosamente");
                conexion.Close();
                Form3 form3 = new Form3();
                this.Hide();
                form3.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al registrar el usuario: " + ex.Message);
            }

        }

        // M�todo que se ejecuta cuando se hace clic en el bot�n de detener
        private void btnStop_Click(object sender, EventArgs e)
        {
            // Detiene la reproducci�n del sonido
            player.Stop();

            // Oculta el bot�n de detener y muestra el bot�n de reproducir
            btnStop.Visible = false;
            btnPlay.Visible = true;
        }

        // M�todo que se ejecuta cuando se hace clic en el bot�n de reproducir
        private void btnPlay_Click(object sender, EventArgs e)
        {
            // Comienza la reproducci�n del sonido
            player.Play();

            // Muestra el bot�n de detener y oculta el bot�n de reproducir
            btnStop.Visible = true;
            btnPlay.Visible = false;
        }

        // M�todo que se ejecuta cuando se hace clic en el bot�n de cerrar
        private void btnClose_Click(object sender, EventArgs e)
        {
            conexion.Close();

            // Finalizar la aplicaci�n
            Application.Exit();
        }

        // M�todo que se ejecuta cuando se hace clic en la etiqueta 1
        private void label1_Click(object sender, EventArgs e)
        {
            // El m�todo est� vac�o, lo que sugiere que podr�a ser un marcador de posici�n para una funcionalidad futura
        }

        private void linklblLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 form3 = new Form3();
            this.Hide();
            form3.Show();
            conexion.Close();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        // Maneja el evento KeyDown del TextBox 'txtUsuario'.
        // Cambia el foco al TextBox 'txtPassword' cuando se presiona la tecla "Enter".
        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita que se procese el evento predeterminado de la tecla "Enter"
                txtPassword.Focus(); // Cambia el foco al TextBox 'txtPassword'
            }
        }

        // Maneja el evento KeyDown del TextBox 'txtPassword'.
        // Cambia el foco al TextBox 'txtPassword2' cuando se presiona la tecla "Enter".
        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita que se procese el evento predeterminado de la tecla "Enter"
                txtPassword2.Focus(); // Cambia el foco al TextBox 'txtPassword2'
            }
        }

        // Maneja el evento KeyDown del TextBox 'txtPassword2'.
        // Cambia el foco al bot�n 'btnIngresar' cuando se presiona la tecla "Enter".
        private void txtPassword2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita que se procese el evento predeterminado de la tecla "Enter"
                btnIngresar.Focus(); // Cambia el foco al bot�n 'btnIngresar'
            }
        }

    }
}