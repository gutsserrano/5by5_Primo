// Faça um programa que leia um numero e informe se este numero é primo

int n, contador = 1;
int option = 0;

do
{
    do
    {
        Console.WriteLine("Digite um número:");
        n = int.Parse(Console.ReadLine());

        if (n < 1)
        {
            Console.WriteLine("\nO número deve ser maior que 0!\n");
        }
    } while (n < 1);

    for(int i = 1; i < n; i++)
    {
        if (n % i == 0)
        {
            contador++;
        }
    }

    switch (contador)
    {
        case 2:
            Console.WriteLine($"\n{n} é um número primo\n");
            break;
        default:
            Console.WriteLine($"\n{n} NÃO é um número primo\n");
            break;
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