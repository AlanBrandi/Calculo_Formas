using System;
using System.Collections.Generic;
using System.Text;

namespace Area_formas_abstract
{
    class Circulo : Forma
    {
        //Criação da variável Raio + encapsulamento.
        public double Raio { get; set; }

        public Circulo(double raio, Color cor) : base(cor)
        {
            Raio = raio;
        }
        //Override no método da classe Forma.
        public override double Area()
        {
            return Math.PI * Raio * Raio;
        }
    }
}
