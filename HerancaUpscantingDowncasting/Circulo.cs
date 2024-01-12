using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaUpscanting
{
 public class Circulo:Forma
    {
        public Circulo() { }

        public Circulo(int x,int y): base(x, y) { }


        public override void Desenhar()
        {
            Console.WriteLine($"Desenhar - Forma : ({xpos},{ypos})");
        }

        public void PintarCirculo()
        {
            Console.WriteLine("PintarCirculo");
        }
    }
}
