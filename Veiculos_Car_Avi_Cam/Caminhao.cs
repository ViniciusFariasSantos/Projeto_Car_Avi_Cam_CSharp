﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Veiculos_Car_Avi_Cam
{
    class Caminhao : Veiculo
    {
        int cacamba;
        int ano;
        int porta;

        public Caminhao(int velocidade, int combustiveis, bool isLigado, string modelo, int passageiro, int cacamba, int ano, int porta) : base(velocidade, combustiveis, isLigado, modelo, passageiro)
        {
            this.cacamba = cacamba;
            this.ano = ano;
            this.porta = porta;

          
        }


        public  void Abastecer(float qtdLitros)
        {

            if (combustiveis < 150)
            {
                if (isLigado == false)
                {

                    combustiveis = combustiveis + (int)qtdLitros;

                    if (combustiveis > 150)
                    {
                        int x = combustiveis - 150;
                        combustiveis = combustiveis - x;

                        Console.WriteLine("seu limite de abastecer excedeu, limitamos  até " + combustiveis + "  litros  para evitar acidente.");


                    }

                    Console.WriteLine("seu tanque está  " + combustiveis + "  litros");

                }
                else
                {


                    Console.WriteLine("Seu Veiculo esta ligado ou em movimento, freia e desligue para abastecer");


                }



            }


        }



    }

}

