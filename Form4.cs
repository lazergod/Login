using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();

            // Hacer que el control WebView2 se expanda para llenar todo el formulario
            webView21.Dock = DockStyle.Fill;

            // Inicializa CoreWebView2
            InitializeAsync();
        }

        async void InitializeAsync()
        {
            await webView21.EnsureCoreWebView2Async(null);

            // Navegar a la URL del video de YouTube
            string videoId = "L1Ty7WrHwZQ";
            webView21.CoreWebView2.Navigate($"https://www.youtube.com/embed/{videoId}?autoplay=1&loop=1&playlist={videoId}&mute=1");
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Cierra la aplicación
            Application.Exit();
        }
    }
}
