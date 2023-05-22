namespace exercicio02;
class Program
{
    static void Main(string[] args)
    {
        Contrato c = new Contrato();
        ContratoPessoaFisica cf = new ContratoPessoaFisica();
        ContratoPessoaJuridica cj = new ContratoPessoaJuridica();

        cf.Nome = "Vitu";
        cf.Email = "Vitotoso@gmail.com";
        cf.Telefone = "(11)99999-9999";
        cf.Idade = 16;
        cf.Cpf = 454545454-54;
        cj.Nome = "Jeferçon";
        cj.Email = "jeferçon@gmail.com";
        cj.Telefone = "(11)88888-8888";
        cj.Cnpj = 01010101010101;
        cj.Inscricao = 212121212121;

        Console.WriteLine(cf.MostraDados());
        Console.WriteLine(cj.MostraDados());
    }
} 

