using Generic.Entities;
using Generic.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.Repositories
{
    public class WaitressRepository : Repository<Waitress>
    {
        public override Waitress Get(Waitress entity)
        {
            base.Get(entity);
            Console.WriteLine($"\nEmail = {entity.Email} ");
            return entity;
        }
    }
}
