using Generic.Entities;
using Generic.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class GenericClass
    {
        static void Main(string[] args)
        {

            var clientRepository = new ClientRepository();
            clientRepository.Get(new Client() { Name = "Andres", LastName = "Sanchez", Age = 34 });



            var waitressRepository = new WaitressRepository();
            waitressRepository.Get(new Waitress { Name = "Ernesto", LastName = "Baldo", Email = "ab.gl@gl.com" });

        }

    }
}
