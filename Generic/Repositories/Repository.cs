using Generic.Entities;
using Generic.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Generic.Repositories
{
    //El Repository acepta T, siempre y cuando T sea una Entidad
    public class Repository<T> : IRepository<T> where T : Entity
    {
        private IList<T> _list;

        public Repository()
        {
            _list = new List<T>();
        }

        /*Este método permite insertar el Id a un objeto*/
        public virtual T Get(T entity)
        {

            if (entity.Id.Equals(Guid.Empty))
            {
                entity.Id = Guid.NewGuid();
                _list.Add(entity);

                Console.WriteLine($"Id = {entity.Id}\nName = {entity.Name} \nLastName = {entity.LastName}");
            }
            else
            {
                Console.WriteLine("El Id pertenece a un objeto existente");
            }
            return entity;
        }


    }
}
