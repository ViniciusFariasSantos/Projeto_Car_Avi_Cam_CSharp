using System;
using System.Collections.Generic;
using System.Text;

namespace Veiculos_Car_Avi_Cam
{
    class Aviao : Veiculo
    {
        

        public Aviao(int velocidade, int combustiveis, bool isLigado, string modelo, int passageiro, string tipo, string uso) : base(velocidade, combustiveis, isLigado, modelo, passageiro)
        {
          
        }


        public void Abastecer(string qtdLitros)
        {


            if (combustiveis < 300)
            {
                if (isLigado == false)
                {
                    int i = Convert.ToInt32(qtdLitros);
                    combustiveis = combustiveis + i;

                    if (combustiveis > 300)
                    {
                        int x = combustiveis - 300;
                        combustiveis = combustiveis - x;

                        Console.WriteLine("seu limite de abastecer excedeu, limitamos  até " + combustiveis + "  litros  para evitar acidente.");


                    }

                    Console.WriteLine("seu tanque está  " + combustiveis + "  litros");

                }
                else
                {


                    Console.WriteLine("Seu Veiculo esta em movimento, você não pode abastecer");


                }



            }


        }



    }
}
