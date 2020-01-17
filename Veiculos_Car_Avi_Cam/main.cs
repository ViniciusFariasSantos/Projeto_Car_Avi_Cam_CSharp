using System;
using System.Collections.Generic;
using System.Text;

namespace Veiculos_Car_Avi_Cam
{
    class main
    {
        public static void Main(string[] args)
        {
            Carro c = new Carro(20,100,false,null,0,null,0,0);
            Caminhao cam = new Caminhao(30,150,false,null,0,0,0,0);
            Aviao avi = new Aviao(100,300,false,null,0,null,null );


           Console.WriteLine("carro-------------------------------------------------------------------------------------------------------------");


            c.Ligar();
            c.Acelerar(20);
            c.Acelerar(20);
            c.Acelerar(20);
            c.Frear(20);
            c.Frear(20);
            c.Abastecer(3);
            c.Frear(20);
            c.Frear(20);
            c.Desligado();
            c.Abastecer(1);
            c.Abastecer(1);
            c.Abastecer(1);

            Console.WriteLine("caminhao-------------------------------------------------------------------------------------------------------------");

            cam.Ligar();
            cam.Acelerar(30);
            cam.Acelerar(30);
            cam.Acelerar(30);
            cam.Frear(30);
            cam.Frear(30);
            cam.Abastecer(3.0f);
            cam.Frear(30);
            cam.Frear(30);
            cam.Desligado();
            cam.Abastecer(1.0f);
            cam.Abastecer(1.0f);
            cam.Abastecer(5.0f);

            Console.WriteLine("aviao-------------------------------------------------------------------------------------------------------------");


            avi.Ligar();
            avi.Acelerar(100);
            avi.Acelerar(100);
            avi.Acelerar(100);
            avi.Frear(200);
            avi.Frear(200);
            avi.Abastecer("2");
            avi.Frear(200);
            avi.Frear(200);
            avi.Desligado();
            avi.Abastecer("1");
            avi.Abastecer("1");
            avi.Abastecer("5");


           

        }

    }
}
