namespace ExercicioAlunos;

class Alunos
{
    public string? nome="";

    public double numero1, numero2;


    public double obterMedia(){
    double media = (numero1+numero2)/2;
    return media;
}

    public string obterSituacao(double media){
        string situacao="";
        if(media>=6){
            situacao="aprovado";
        }else{
            situacao="reprovado";
        }
        return situacao;
    }

    public void mensagem(){
        double mediaCalculada = obterMedia();
        string resultadoSituacao = obterSituacao(mediaCalculada);
        Console.WriteLine(nome+" está "+resultadoSituacao+" com média: "+mediaCalculada);
    }
}