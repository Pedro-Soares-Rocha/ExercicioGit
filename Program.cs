/*Esse progama é um codigo para um jogo de quiz aleatorio, planejo oferecer
5 perguntas para isso pretendo usar um metodo case e um random number para 
escolher uma pergunta aleatoria 
*/

using static System.Runtime.InteropServices.JavaScript.JSType;

string verificador;
int questao;

Random rand = new Random();

questao = rand.Next(1, 5);

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
    
    case 2:
        Console.WriteLine("Qual é o quadrado de 7 ?");
        verificador = Console.ReadLine();
        if (verificador.ToUpper() == "49")
        {
            Console.WriteLine("Acertou");
        }
        else
        {
            Console.WriteLine("Errou!");
        }
        break;
    
    case 3:
        Console.WriteLine("Qual o maior país do mundo?");
        verificador = Console.ReadLine();
        if (verificador.ToUpper() == "RUSSIA" || verificador.ToUpper() == "RÚSSIA")
        {
            Console.WriteLine("Acertou");
        }
        else
        {
            Console.WriteLine("Errou!");
        }
        break;
    
    case 4:
        Console.WriteLine("Buenos Aires é capital de qual pais ?");
        verificador = Console.ReadLine();
        if (verificador.ToUpper() == "ARGENTINA")
        {
            Console.WriteLine("Acertou");
        }
        else
        {
            Console.WriteLine("Errou!");
        }
        break;
    
    case 5:
        Console.WriteLine("Qual é a capital do Japão ?");
        verificador = Console.ReadLine();
        if (verificador.ToUpper() == "TOQUIO" || verificador.ToUpper() == "TÓQUIO")
        {
            Console.WriteLine("Acertou");
        }
        else
        {
            Console.WriteLine("Errou!");
        }
        break;
}