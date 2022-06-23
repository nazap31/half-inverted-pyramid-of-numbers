//piramide invertida

Console.Write("Ingrese un numero: ");
int numero = Convert.ToInt32(Console.ReadLine());
for (int i = numero; i >= 1; i--)
{
    for (int j = i; j >= 1; j--)
    {
        Console.Write(j + " ");
    }
        Console.Write("\n");
}
Console.WriteLine("Programa terminado!");



