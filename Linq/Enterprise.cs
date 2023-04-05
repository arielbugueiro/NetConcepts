﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class Enterprise
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public Employee[]? Employees { get; set; } = new Employee[0]; //Al menos tengo un empleado
    }
}
