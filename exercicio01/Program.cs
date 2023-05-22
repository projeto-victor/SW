namespace exercicio01;
class Program
{
    static void Main(string[] args)
    {
        Animal a = new Animal();
        Homem h = new Homem();
        Cao c = new Cao();
        Gato g = new Gato();


        Console.WriteLine("O homem faz: " + h.Fala());
        Console.WriteLine("O cachorro faz: " + c.Fala());
        Console.WriteLine("O gato faz: " + g.Fala());
    }
}
