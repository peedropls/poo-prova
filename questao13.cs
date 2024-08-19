{
    private static void Main(string[] args)
    {
        string nomes = Console.ReadLine();
        string[] nomesArray = nomes.Split(' ');
        Array.Sort(nomesArray);
        foreach (string nome in nomesArray)
        {
            Console.WriteLine(nome);

        }


        int n = int.Parse(Console.ReadLine());

        if (n < 0)
        {
            Console.WriteLine("não é possível calcular o fatorial de um número negativo.");
        }
        else
        {
            int resultado = CalcularFatorial(n);
            Console.WriteLine($"o fatorial de {n} é {resultado}!");
        }
        static int CalcularFatorial(int n)}
}