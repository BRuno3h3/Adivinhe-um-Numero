Random aleatorio = new Random();
int numeroSecreto = aleatorio.Next(1, 11); // Next(1, 10) gera um número entre 1 e 9, então é melhor usar Next(1, 11)

Console.WriteLine("Digite um número entre 1 e 10: ");
Console.WriteLine("Você tem 3 chances!!!");

bool acertou = false;

for (int i = 3; i > 0; i--)
{
    if(i != 3)
    {
    Console.WriteLine($"Você tem {i} tentativas");
    }
    int chute = int.Parse(Console.ReadLine()!);

    if (chute == numeroSecreto)
    {
        Console.WriteLine("Parabéns! Você acertou o número.");
        acertou = true;
        break;
    }
    else if (chute < numeroSecreto)
    {
        Console.WriteLine("O número é maior.");
    }
    else
    {
        Console.WriteLine("O número é menor.");
    }
}

if (!acertou)
{
    Console.WriteLine($"O jogo acabou. Você não acertou o número secreto que era {numeroSecreto}.");
}
else
{
    Console.WriteLine("O jogo acabou. Você acertou o número secreto!");
}
