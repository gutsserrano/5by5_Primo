// Faça um programa que leia um numero e informe se este numero é primo

int n, contador = 1;
int option = 0;

do
{
    Console.WriteLine("Digite um número:");
    n = int.Parse(Console.ReadLine());

    for(int i = 1; i < (n/2) + 1; i++)
    {
        if (n % i == 0)
        {
            contador++;
        }
    }

    if (contador == 2)
    {
        Console.WriteLine($"\n{n} é um número primo\n");
    }
    else
    {
        Console.WriteLine($"\n{n} NÃO é um número primo\n");
    }

    do
    {
        Console.WriteLine("Deseja sair?");
        Console.WriteLine("1 - sim");
        Console.WriteLine("2 - não");
        option = int.Parse(Console.ReadLine());
    } while (option < 1 || option > 2);

    contador = 1;
} while (option == 2);