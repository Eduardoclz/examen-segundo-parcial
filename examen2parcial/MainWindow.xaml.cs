using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace examen2parcial
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        float click = 0;
        public MainWindow()
        {
            InitializeComponent();

        }

        private void iniciar_Click(object sender, RoutedEventArgs e)
        {
            Panelc.Children.Clear();
            Panelc.Children.Add(new UserControl1());



        }

        private void sig_Click(object sender, RoutedEventArgs e)
        {

            if (click == 0)
            {
                var userControl1 =
(UserControl1)
Panelc.Children[0];
                if (userControl1.nombre.Text.Length == 0)
                {
                    userControl1.primero.Text = "!";
                }

                if (userControl1.ap.Text.Length == 0)
                {
                    userControl1.segundo.Text = "!";
                }

                if (userControl1.am.Text.Length == 0)
                {
                    userControl1.tercero.Text = "!";
                }

                if (userControl1.edad.Text.Length == 0)
                {
                    userControl1.cuarto.Text = "!";
                }

                else
                {
                    click = click + 1;
                }


                if (click == 1)
                {
                    Panelc.Children.Clear();
                    Panelc.Children.Add(new Contacto());
                    var contacto =
       (Contacto)
       Panelc.Children[0];
                    if (contacto.correo.Text.Length == 0)
                    {
                        contacto.no.Text = "Es nesesario llenar todos los campos";
                    }

                    if (contacto.tele.Text.Length == 0)
                    {
                        contacto.no.Text = "Es nesesario llenar todos los campos";
                    }

                    if (contacto.celular.Text.Length == 0)
                    {
                        contacto.no.Text = "Es nesesario llenar todos los campos";
                    }

                  

                }
                if (click == 2)
                {
                    Panelc.Children.Clear();
                    Panelc.Children.Add(new Pago());
                }

            }
        }
    }
}
