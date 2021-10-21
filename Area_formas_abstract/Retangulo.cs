using System;
using System.Collections.Generic;
using System.Text;

namespace Area_formas_abstract
{
    class Retangulo : Forma
    {
        //Criação das variáveis Largura e Altura + encapsulamento.
        public double Largura { get; set; }
        public double Altura { get; set; }

        public Retangulo(double largura, double altura, Color cor) : base(cor)
        {
            Largura = largura;
            Altura = altura;
        }
        //Override no método da classe Forma.
        public override double Area()
        {
            return Largura * Altura;
        }
    }
}
