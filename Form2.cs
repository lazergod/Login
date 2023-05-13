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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();


            // Configura el estilo de la rueda de carga como "Marquee"
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.MarqueeAnimationSpeed = 30; // Velocidad de la animación de la rueda de carga
            progressBar1.Visible = true; // Muestra la rueda de carga

            // Crea el control Label
            Label label1 = new Label
            {
                Location = new Point(20, 20),
                Size = new Size(160, 120),
                AutoSize = false,
                AutoEllipsis = false,
                TextAlign = ContentAlignment.TopLeft,
                Text = "Este es un texto largo\nque se muestra en varias líneas\nen un Label."
            };
        }

    }
}