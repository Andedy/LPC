﻿using System;

namespace diagramalivraria
{
    class Program
    {
        static void Main(string[] args)
        {
           
           Materiais material = new Materiais();

           material.emprestar();
           material.devolver();
        }
    }
}
