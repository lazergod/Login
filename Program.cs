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
            // Habilita estilos visuales para la aplicación
            Application.EnableVisualStyles();

            // Establece el valor predeterminado de la representación de texto compatible
            Application.SetCompatibleTextRenderingDefault(false);

            // Crea una instancia del formulario principal
            Form1 formPrincipal = new Form1();

            // Establece el formulario principal en estado minimizado al inicio
            formPrincipal.WindowState = FormWindowState.Minimized;

            // Muestra el formulario principal
            formPrincipal.Show();

            // Crea una instancia del formulario de carga
            Form2 formCarga = new Form2();

            // Hace que el formulario de carga esté siempre encima
            formCarga.TopMost = true;

            // Muestra el formulario de carga
            formCarga.Show();

            // Crea un nuevo temporizador para restaurar el formulario principal
            Timer restaurarTimer = new Timer();

            // Establece el intervalo de restauración en 7000 milisegundos (7 segundos)
            restaurarTimer.Interval = 5000;

            // Establece el evento Tick del temporizador para restaurar el formulario principal después de la espera
            restaurarTimer.Tick += (s, ev) =>
            {
                // Detiene el temporizador de restauración
                restaurarTimer.Stop();

                // Restaura el formulario principal a su tamaño normal
                formPrincipal.WindowState = FormWindowState.Normal;
            };

            // Inicia el temporizador de restauración
            restaurarTimer.Start();

            // Crea un nuevo temporizador para controlar el tiempo de espera antes de cerrar el formulario de carga
            Timer esperaTimer = new Timer();

            // Establece el intervalo de espera en 8000 milisegundos (8 segundos)
            esperaTimer.Interval = 8000;

            // Establece el evento Tick del temporizador para cerrar el formulario de carga después de la espera
            esperaTimer.Tick += (s, ev) =>
            {
                // Detiene el temporizador de espera
                esperaTimer.Stop();

                // Cierra el formulario de carga
                formCarga.Close();
            };

            // Inicia el temporizador de espera
            esperaTimer.Start();

            // Ejecuta la aplicación sin un formulario específico
            Application.Run();
        }
    }
}
