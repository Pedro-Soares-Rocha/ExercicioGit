/*Esse progama é um codigo para um jogo de quiz aleatorio, planejo oferecer
5 perguntas para isso pretendo usar um metodo case e um random number para 
escolher uma pergunta aleatoria 
*/

using static System.Runtime.InteropServices.JavaScript.JSType;

string verificador;
int questao;

Random rand = new Random();

questao = rand.Next(1, 5);
//apenas para testar se funciona
questao = 1;

switch (questao)
    {
    case 1:
        Console.WriteLine("Qual é a capital da frança ?");
        verificador = Console.ReadLine();
        if(verificador.ToUpper() == "PARIS")
        {
            Console.WriteLine("Acertou");
        }
        else
        {
            Console.WriteLine("Errou!");
        }
        break;
    }