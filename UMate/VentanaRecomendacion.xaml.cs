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
    public partial class ventanaRecomendacion : Window
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

    

        public ventanaRecomendacion()
        {
            InitializeComponent();
        }
        
    }
}
