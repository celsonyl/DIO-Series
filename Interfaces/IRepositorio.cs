using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIO.Series.Interfaces
{
    interface IRepositorio<T>
    {
        List<T> Lista();
        T RetornaSeriePorId(int id);
        void Insere(T obj);
        void Exclui(int id);
        void Atualiza(int id, T obj);
        int ProximoId();
    }
}
