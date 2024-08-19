int soma = 0;
while (true)
{
	Console.WriteLine("digite um número:");
	int numero = int.Parse(Console.ReadLine());
 
	if (numero == 0)
	{
        break;
	}
 
	soma += numero;
 
}
 
 
Console.WriteLine($"a soma é {soma}");