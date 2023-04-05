using Generic.Entities;
using Generic.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.Repositories
{
    public class ClientRepository : Repository<Client>
    {
        public override Client Get(Client entity)
        {
            Console.WriteLine($"\nAge = {entity.Age} ");
            return base.Get(entity);
        }
    }
}
