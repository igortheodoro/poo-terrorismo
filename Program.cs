using System;


namespace Terrorismo
{
    class Program
    {
        static void criarObj(BaseDados vet){
            for(int i = 0; i < 10; i++){
                Random random = new Random();
                int tipo = random.Next(1, 6);

                int aleat = random.Next(1, 300);

                Ataques A = new Ataques(tipo, aleat, aleat, aleat, aleat);

                vet.Inserir(A);
            }
            
        }
        static void Main(string[] args)
        {
            BaseDados vet = new BaseDados();
            criarObj(vet);

            // Imprimir os dados de todos terroristas

            Console.WriteLine("Todos os dados cadastrados: ");
            vet.getDados();

            // Imprimir o tipo de terrorismo com ataques > 200

            Console.WriteLine("Tipos de terrorismos que mataram mais de 200: ");
            vet.getTerrorismos200();
           
            // Imprimir quantos terrorismos do tipo 5 (religioso) há cadastrado

            Console.WriteLine("Houve {0} terrorismos religiosos.", vet.getReligiosos());

            // Cálculo LTR

            System.Console.WriteLine("LTR: {0}", vet.GetLtr());
            
        }
    }
}
