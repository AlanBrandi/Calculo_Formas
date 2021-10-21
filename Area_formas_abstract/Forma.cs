using System;
using System.Collections.Generic;
using System.Text;

namespace Area_formas_abstract
{
    abstract class Forma
    {
        //Criação da classe Forma, junto de cor + encapsulamento.
        public Color Color { get; set; }
        public Forma(Color color)
        {
            Color = color;
        }
        //Criação do método Area.
        public abstract double Area();
    }
}
