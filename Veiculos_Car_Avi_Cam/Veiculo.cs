using System;

namespace Veiculos_Car_Avi_Cam
{
    class Veiculo
    {
        public  int velocidade { get; set; }
        public int combustiveis { get; set; } 
        public bool isLigado { get; set; }

        string Modelo { get; set; }

        int Passageiro{ get; set; }

        public Veiculo(int velocidade, int combustiveis, bool isLigado, string modelo, int passageiro)
        {
            this.velocidade = velocidade;
            this.combustiveis = combustiveis;
            this.isLigado = isLigado;
            Modelo = modelo;
            Passageiro = passageiro;
        }

        public void Ligar()
        {
            isLigado = true;
            Console.WriteLine("O veiculo esta ligado e andando a  " + velocidade + " km/h");

        }





        public void Acelerar(int quantidade)
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







        public void Frear(int quantidade)
        {
            if ((isLigado == true) && (velocidade != 0)) { 
                velocidade -= quantidade;

                Console.WriteLine("Você freou, seu veiculo está a  " + velocidade + " km/h ");
            }else  {

                Console.WriteLine("O veiculo esta desligado");
            }
        }


        public void Abastecer(int qtdLitros)
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


                    Console.WriteLine("Seu Veiculo esta em movimento, você não pode abastecer");


                }




            }
        }




            public void Desligado()
        {



            if (velocidade == 0)
            {

                isLigado = false;

                Console.WriteLine("Seu seu veiculo está desligado");

            }
            else
            {
                Console.WriteLine("Você precisa Frear o carro, para poder desligar  ");
            }

        }



        //void pintar(String novCor)
        //{
        //    Console.WriteLine("Sua cor atual é  " + cor);
        //    Console.WriteLine("Escolhe uma cor ");
        //    cor = novCor;
        //    Console.WriteLine("Sua nova cor é " + cor);
        //}
}
}



    