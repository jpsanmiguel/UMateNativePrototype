using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMate
{
    public enum Criterio { SeguirPensum, SubirPromedio, Nivelarse, Adelantarse };

    class Horario
    {
        private List<Materia> MateriasSugeridas { get; set; }

        private List<Materia> MateriasPensum { get; }

        private List<Materia> MateriasRecomendadasSubirPromedio { get;  }

        private List<Materia> OtrasMaterias { get;  }

        private List<Criterio> Criterios { get;  }

        private int NumeroCreditosSugeridos { get; }

        private int PromedioSemestreSegunHistoricos { get; }

        public Horario(List<Materia> materiasPensum, List<Materia> materiasRecomendadasSubirPromedio, List<Materia> otrasMaterias,
            List<Criterio> criterios, int numeroCreditosSugeridos, int promedioSemestreSegunHistoricos)
        {
            this.MateriasSugeridas = new List<Materia>();
            this.MateriasPensum = materiasPensum;
            this.MateriasRecomendadasSubirPromedio = materiasRecomendadasSubirPromedio;
            this.OtrasMaterias = otrasMaterias;
            this.Criterios = criterios;
            this.NumeroCreditosSugeridos = numeroCreditosSugeridos;
            this.PromedioSemestreSegunHistoricos = promedioSemestreSegunHistoricos;
        }

        public void GenerarRecomendacion()
        {
            foreach (Criterio criterio in Criterios)
            {

            }
        }
    }
}
