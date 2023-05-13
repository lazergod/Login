using System;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Login
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // Habilita estilos visuales para la aplicaci�n
            Application.EnableVisualStyles();

            // Establece el valor predeterminado de la representaci�n de texto compatible
            Application.SetCompatibleTextRenderingDefault(false);

            // Crea una instancia del formulario principal
            Form1 formPrincipal = new Form1();

            // Establece el formulario principal en estado minimizado al inicio
            formPrincipal.WindowState = FormWindowState.Minimized;

            // Muestra el formulario principal
            formPrincipal.Show();

            // Crea una instancia del formulario de carga
            Form2 formCarga = new Form2();

            // Hace que el formulario de carga est� siempre encima
            formCarga.TopMost = true;

            // Muestra el formulario de carga
            formCarga.Show();

            // Crea un nuevo temporizador para restaurar el formulario principal
            Timer restaurarTimer = new Timer();

            // Establece el intervalo de restauraci�n en 7000 milisegundos (7 segundos)
            restaurarTimer.Interval = 5000;

            // Establece el evento Tick del temporizador para restaurar el formulario principal despu�s de la espera
            restaurarTimer.Tick += (s, ev) =>
            {
                // Detiene el temporizador de restauraci�n
                restaurarTimer.Stop();

                // Restaura el formulario principal a su tama�o normal
                formPrincipal.WindowState = FormWindowState.Normal;
            };

            // Inicia el temporizador de restauraci�n
            restaurarTimer.Start();

            // Crea un nuevo temporizador para controlar el tiempo de espera antes de cerrar el formulario de carga
            Timer esperaTimer = new Timer();

            // Establece el intervalo de espera en 8000 milisegundos (8 segundos)
            esperaTimer.Interval = 8000;

            // Establece el evento Tick del temporizador para cerrar el formulario de carga despu�s de la espera
            esperaTimer.Tick += (s, ev) =>
            {
                // Detiene el temporizador de espera
                esperaTimer.Stop();

                // Cierra el formulario de carga
                formCarga.Close();
            };

            // Inicia el temporizador de espera
            esperaTimer.Start();

            // Ejecuta la aplicaci�n sin un formulario espec�fico
            Application.Run();
        }
    }
}
