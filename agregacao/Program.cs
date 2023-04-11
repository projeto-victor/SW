namespace agregacao;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Agregação");
        
        CartaoDeCredito cdc = new CartaoDeCredito();
        Cliente cli = new Cliente();

        cli.Nome = "Victor Marques";

        cdc.Numero = "40028922";
        cdc.DataValidade = "05/2025";

        cdc.Cliente = cli;

        Console.WriteLine("O nome do cliente é: " + cli.Nome);
        Console.WriteLine("O número do cartão é: " + cdc.Numero);
        Console.WriteLine("A data de validade é: " + cdc.DataValidade);
        Console.WriteLine("O nome do cliente agregado é: " + cdc.Cliente.Nome);

    }
}