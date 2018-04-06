using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMate
{
    class Materia
    {
        private String Nombre { get; }

        private double NotaHistorica { get; set; }

        private int ExigenciaSegunHistoricos { get;  }

        private Boolean ObligatoriaPrograma { get;  }

        private int NumeroCreditos { get; }

        private int PromedioObjetivo { get; }

        private int SemestreSugerido { get; }

        private List<Materia> Prerequisitos { get; }

        private List<Materia> Corequisitos { get; }

        private List<HorarioMateria> Horarios { get; }

        private Boolean Cursada { get; set; }

        public Materia(String nombre, double notaHistorica, int exigenciaSegunHistoricos, Boolean obligatoriaPrograma, int numeroCreditos, 
            int promedioObjetivo, int semestreSugerido, List<Materia> prerequisitos, List<Materia> corequisitos, List<HorarioMateria> horarios,
            Boolean cursada)
        {
            this.Nombre = nombre;
            this.NotaHistorica = notaHistorica;
            this.ExigenciaSegunHistoricos = exigenciaSegunHistoricos;
            this.ObligatoriaPrograma = obligatoriaPrograma;
            this.NumeroCreditos = numeroCreditos;
            this.PromedioObjetivo = promedioObjetivo;
            this.SemestreSugerido = semestreSugerido;
            this.Prerequisitos = prerequisitos;
            this.Corequisitos = corequisitos;
            this.Horarios = horarios;
            this.Cursada = cursada;
        }
        

        public String darNombre()
        {
            return this.Nombre;
        }
        /**
* Método que da un número de puntos según los criterios y datos de la materia para recomendarla.
* */
        public int EsSugeribleEstaMateria(List<Criterio> criteriosAMirar, int semestreActual)
        {
            //Si no cumple los prerequisitos no se puede recomendar la materia.
            foreach (Materia pre in Prerequisitos)
            {
                if (!pre.Cursada)
                {
                    return 0;
                }
            }
            //Puntos a favor de recomendar la materia.
            int puntosRecomendacionMateria = 0;
            foreach (Criterio criterio in criteriosAMirar)
            {
                //Si quiere subir el promedio, primero buscamos las materias que tengan una nota historica mejor o igual a la deseada por el estudiante.
                if (criterio == Criterio.SubirPromedio)
                {
                    if (NotaHistorica >= PromedioObjetivo)
                    {
                        puntosRecomendacionMateria++;
                    }
                    //Miramos que la materia no sea muy demandante.
                    if(ExigenciaSegunHistoricos <= 5)
                    {
                        puntosRecomendacionMateria++;
                    }
                }
                //Si quiere seguir el pensum, miramos que cumpla con todos los prerequisitos y posteriormente que según su pensum esta materia este 
                //sugerida para su semester actual.
                if (criterio == Criterio.SeguirPensum)
                {
                    
                    if (SemestreSugerido == semestreActual)
                    {
                        puntosRecomendacionMateria++;
                    }
                    if(ObligatoriaPrograma)
                    {
                        puntosRecomendacionMateria++;
                    }
                }
                //Si quiere adelantarse, miramos que cumpla con todos los prerequisitos y sea una materia sugerida para un semestre más avanzado al 
                //actual del estudiante
                if (criterio == Criterio.Adelantarse)
                {
                    if (ObligatoriaPrograma)
                    {
                        puntosRecomendacionMateria++;
                    }
                    if (SemestreSugerido < semestreActual)
                    {
                        puntosRecomendacionMateria++;
                    }
                }
                //Si el estudiante desea nivelarse (porque se encuentra atrasado) el criterio más importante es sugerir una materia que este sugerida 
                //para un semestre anterior al suyo y sea obligatoria para su programa
                if (criterio == Criterio.Nivelarse)
                {
                    if (SemestreSugerido > semestreActual)
                    {
                        puntosRecomendacionMateria++;
                    }
                    if(ObligatoriaPrograma)
                    {
                        puntosRecomendacionMateria++;
                    }
                }
            }
            return puntosRecomendacionMateria;
        }
    }

    class HorarioMateria
    {

    }
}
