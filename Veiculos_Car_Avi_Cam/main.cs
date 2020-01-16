using System;
using System.Collections.Generic;
using System.Text;

namespace Veiculos_Car_Avi_Cam
{
    class main
    {
        public static void Main(string[] args)
        {
            Carro c = new Carro(0,0,false,null,0,null,0,0);
            c.ligar();
            c.acelerar(20);
            c.acelerar(20);
            c.acelerar(20);
            c.frear(10);
            c.frear(10);
            c.frear(10);

            c.abastecer(3);

        }
 
    }
}
