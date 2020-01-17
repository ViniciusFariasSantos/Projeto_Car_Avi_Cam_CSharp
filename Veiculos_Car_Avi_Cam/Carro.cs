using System;
using System.Collections.Generic;
using System.Text;

namespace Veiculos_Car_Avi_Cam
{
    class Carro : Veiculo
    {
        public string marca;
        public int portas;
        public int ano;

        public Carro(int velocidade, int combustiveis , bool isLigado, string modelo, int passageiro, string marca, int portas, int ano):base(velocidade , combustiveis , isLigado, modelo, passageiro)
        {
            this.marca = marca;
            this.portas = portas;
            this.ano = ano;




             void Abastecer(int qtdLitros)
            {

                if (combustiveis < 100)
                {
                    if (isLigado == false)
                    {

                        combustiveis = combustiveis + qtdLitros;

                        if (combustiveis > 100)
                        {
                            int x = combustiveis - 100;
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
}
