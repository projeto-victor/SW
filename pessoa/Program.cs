namespace pessoa;
class Program
{
    static void Main(string[] args)
    {
        Pessoa p1 = new Pessoa("Godofredo", 18);
        p1.AlteraNome("Victor");
        p1.AlteraSobreNome("Marques");
        p1.AlteraIdade(16);
        p1.MostraDados();
    }
}
