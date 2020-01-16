using System;

namespace Veiculos_Car_Avi_Cam
{
    class Veiculo
    {
        int velocidade { get; set; }
        int combustiveis { get; set; }
        bool isLigado { get; set; }

        string Modelo { get; set; }

        int Passageiro{ get; set; }

        public Veiculo(int velocidade, int combustiveis, bool isLigado, string modelo, int passageiro)
        {
            velocidade = velocidade;
            this.combustiveis = combustiveis;
            this.isLigado = isLigado;
            Modelo = modelo;
            Passageiro = passageiro;
        }

        public void ligar()
        {
            isLigado = true;
            Console.WriteLine("O veiculo esta ligado e andando a  " + velocidade + " km/h");

        }





        public void acelerar(int quantidade)
        {
        }







        public void frear(int quantidade)
        {
            if ((isLigado == true) && (velocidade != 0)) { 
                velocidade -= quantidade;

                Console.WriteLine("Você freou, seu veiculo está a  " + velocidade + " km/h ");
            }else  {

                Console.WriteLine("O veiculo esta desligado");
            }
        }


        public void abastecer(int quantidade)
        {

            
        }





        public void desligado()
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



    