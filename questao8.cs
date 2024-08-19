Console.WriteLine("digite três números:");
int numero1 = int.Parse(Console.ReadLine());
int numero2 = int.Parse(Console.ReadLine());
int numero3 = int.Parse(Console.ReadLine());
 
if (numero1 > numero2 && numero1 > numero3)
{
    Console.WriteLine($"o maior número é {numero1}");
}
else if(numero2 > numero1 && numero2 > numero3)
{
    Console.WriteLine($"o maior número é {numero2}");
}
else
{
    Console.WriteLine($"o maior número é {numero3}");
}
 
if(numero1 < numero2 && numero1 < numero3)
{
    Console.WriteLine($"o menor número é {numero1}");
}
else if(numero2 < numero1 && numero2 < numero3)
{
    Console.WriteLine($"o menor número é {numero2}");
}
else
{
    Console.WriteLine($"o menor número é {numero3}");
}
