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

namespace UMate
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class ventanaPrincipal : Window
    {
        //Atributos relacionados con carrera y semestre actual
        private String carrera;
        private int semestre;

        //Atributos relacionados con criterios recomendación.
        private Boolean seguirPensum;
        private Boolean adelantar;
        private Boolean subirPromedio;
        private Boolean nivelarse;
        private Boolean otro;
        private String otroRecomendado;


        public ventanaPrincipal()
        {
            InitializeComponent();
        }
        

        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Carrera(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Sistemas(object sender, RoutedEventArgs e)
        {

        }

        private void continuar(object sender, RoutedEventArgs e)
        {
            var win2 = new ventanaRecomendacion();
            win2.Show();
            this.Close();
        }

        private void deseaSeguirPensum(object sender, RoutedEventArgs e)
        {

        }

        private void deseaAdelantar(object sender, RoutedEventArgs e)
        {

        }

        private void deseaSubirPromedio(object sender, RoutedEventArgs e)
        {

        }

        private void deseaNivelarse(object sender, RoutedEventArgs e)
        {

        }

        private void deseaOtro(object sender, RoutedEventArgs e)
        {

        }

        private void Derecho(object sender, RoutedEventArgs e)
        {

        }

        private void Semestre(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Primero(object sender, RoutedEventArgs e)
        {

        }

        private void Segundo(object sender, RoutedEventArgs e)
        {

        }

        private void Tercero(object sender, RoutedEventArgs e)
        {

        }

        private void Cuarto(object sender, RoutedEventArgs e)
        {

        }

        private void Quinto(object sender, RoutedEventArgs e)
        {

        }

        private void Sexto(object sender, RoutedEventArgs e)
        {

        }

        private void Septimo(object sender, RoutedEventArgs e)
        {

        }

        private void Octavo(object sender, RoutedEventArgs e)
        {

        }

        private void Noveno(object sender, RoutedEventArgs e)
        {

        }

        private void Decimo(object sender, RoutedEventArgs e)
        {

        }

        private void Otro(object sender, RoutedEventArgs e)
        {

        }
    }
}
