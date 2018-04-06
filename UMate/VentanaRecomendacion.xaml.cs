using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
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
        private List<Materia> arrText;
        //private ArrayList arr;




        public ventanaRecomendacion()
        {
            InitializeComponent();

            string path1 = @".\MateriasISIS.txt";
            StreamReader objReader = new StreamReader(path1); //C: \Users\ASUS COLOMBIA\Desktop\Proyecto PMC\UMateNativePrototype\UMate\Resources\MateriasISIS.txt
            string sLine = "";
            arrText = new List<Materia>();
            //arr = new ArrayList();

            while (sLine != null)
            {
                sLine = objReader.ReadLine();
                if (sLine != null) {
                    //arr.Add(sLine);
                    Materia materia = new Materia(sLine,2.5,3,true,3,4,2,null,null,null,false);
                    arrText.Add(materia);
                    this.lbx1.Items.Add(sLine);
                    this.lbx1Copy.Items.Add(sLine);
                }
            }
            objReader.Close();

            //foreach (string sOutput in arrText)
            //    Console.WriteLine(sOutput);
            Console.ReadLine();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if (txt1.Text == null || txt1.Text == "" || txt1.Text.Equals("") || txt1.Text.Equals(null))
            {
                //lbx1.Items.Clear();
                lbx1.Items.Refresh();
                lbx1.;
                //lbx1.(lbx1Copy.Items);
            }
            else
            {
                lbx1.Items.Clear();
                for (int i = 0; i < arrText.Count; i++)
                {
                    String buscar = arrText[i].darNombre();
                    if (buscar.StartsWith(txt1.Text.ToUpper()))
                        lbx1.Items.Add(arrText[i].darNombre());
                }
            }
        }

        private void txt1_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txt1.Text == null || txt1.Text == "" || txt1.Text.Equals("") || txt1.Text.Equals(null))
            {
                //lbx1.Items.Clear();
                lbx1.Items.Refresh();
                //lbx1.Items.Add(lbx1Copy.Items);
            }
            else
            {
                lbx1.Items.Clear();
                for (int i = 0; i < arrText.Count; i++)
                {
                    String buscar = arrText[i].darNombre();
                    if (buscar.StartsWith(txt1.Text.ToUpper()))
                        lbx1.Items.Add(arrText[i].darNombre());
                }
            }
        }

        private void lbx1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
