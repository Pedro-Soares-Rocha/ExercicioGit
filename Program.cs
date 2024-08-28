/*Esse progama é um codigo para um jogo de quiz aleatorio, planejo oferecer
5 perguntas para isso pretendo usar um metodo case e um random number para 
escolher uma pergunta aleatoria 
*/

using static System.Runtime.InteropServices.JavaScript.JSType;

string verificador = "", respostaUsuario = "", pergunta = "", respostaCorreta = "";
int questao;

Random rand = new Random();

questao = rand.Next(1, 5);

void CriadorPergunta(string pergunta, string respostaUsuario, string respostaCorreta)
{
    Console.WriteLine(pergunta);
    respostaUsuario = Console.ReadLine();
    if(respostaUsuario.ToUpper() == respostaCorreta.ToUpper())
    {
        Console.WriteLine("Acertou");
    }
    else
    {
        Console.WriteLine("Errou!");
    }
}

switch (questao)
    {
    case 1:
        CriadorPergunta("Qual é a capital da França:", "", "Paris");
        break;
    
    case 2:
        CriadorPergunta("Qual é o quadrado de 7 ?", "", "49");
        break;
        
    case 3:
        CriadorPergunta("Qual é o maior pais do mundo?", "", "RÚSSIA");
        break;

    case 4: 
        CriadorPergunta("Buenos Aires é a capital de qual país?", "", "ARGENTINA");
        break;
    
    case 5:
        CriadorPergunta("Qual é a capital do Japão?", "", "TÓQUIO");
        break;
}