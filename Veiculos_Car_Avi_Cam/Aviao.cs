using System;
using System.Collections.Generic;
using System.Text;

namespace Veiculos_Car_Avi_Cam
{
    class Aviao : Veiculo
    {
        public String tipo;
        public String uso;

        public Aviao(int velocidade, int combustiveis, bool isLigado, string modelo, int passageiro, string tipo, string uso):base(velocidade, combustiveis, isLigado, modelo, passageiro)
        {
            this.tipo = tipo;
            this.uso = uso;

             void acelerar(int quantidade)
            {
                if (isLigado)
                {
                    velocidade += quantidade;
                    combustiveis--;
                    Console.WriteLine("Você acelerou, seu veiculos está  a   " + velocidade + " km/h ");
                }
                else
                {
                    Console.WriteLine("O veiculo esta desligado");
                }
            }

            void abastecer(int qtdLitros)
            {

                if (combustiveis < 100)
                {
                    if (isLigado == false)
                    {

                        combustiveis = combustiveis +Convert.ToInt32(qtdLitros);

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


                        Console.WriteLine("Seu Veiculo esta em movimento, você não pode abastecer");


                    }



                }


            }


        }

       
    }
}
