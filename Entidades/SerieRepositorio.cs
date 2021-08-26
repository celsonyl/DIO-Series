using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIO.Series.Interfaces;

namespace DIO.Series.Entidades
{
    class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> series = new List<Serie>();

        public void Atualiza(int id, Serie obj)
        {
            series[id] = obj;
        }

        public void Exclui(int id)
        {
            series[id].Excluir();
        }

        public void Insere(Serie obj)
        {
            series.Add(obj);
        }

        public List<Serie> Lista()
        {
            return series;
        }

        public int ProximoId()
        {
            return series.Count;
        }

        public Serie RetornaSeriePorId(int id)
        {
            return series[id];
        }
    }
}
