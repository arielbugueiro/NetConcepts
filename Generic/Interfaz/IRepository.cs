using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.Interfaz
{
    public interface IRepository<T>
    {
        public T Get(T entity);
    }
}
