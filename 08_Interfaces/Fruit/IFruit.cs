﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Interfaces.Fruit
{
    // Naming convention for interfaces: I_____
    public interface IFruit
    {
        string Name { get; }

        bool IsPeeled { get; }
        // Methods in interfaces don't have bodies
        // Can only set the return type, name, and parameters
        string Peel();
    }
}
