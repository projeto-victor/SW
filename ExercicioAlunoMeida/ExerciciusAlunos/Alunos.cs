namespace ExerciciusAlunos;
class Alunos
{
    public string nome="";

    public double nota1, nota2;

    //Média

    public double obterMedia(){
        double media = (nota1 + nota2)/2;
        return media;
    }

    //Situação

    public string obterSituacao(double media){
        string situacao="";
        if(media>=6){
            situacao = "Aprovado";
        }else{
            situacao ="Reprovado";
        }
        return situacao;
    }

    //Mensagem

    public void mensagem(){
        double mediaCalculada = obterMedia();
        string resulatdoSituacao = obterSituacao(mediaCalculada);
        Console.WriteLine(nome+"está "+resulatdoSituacao+" com media: " + mediaCalculada);
    }
}