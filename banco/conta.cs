namespace banco;
class conta
{
     public int Numero {get; set;}
     private double Saldo{get; set;}
     public double Limite{get; private set;}

     public void Depositar(double valor){
        if(valor > this.Saldo + this.Limite){
            Console.WriteLine("Voce não pode realizar esse saque, Saldo indisponivel");

        }else{
            this.Saldo -= valor;
        }
     }

      public void Sacar(double valor){
        this.Saldo += valor;
     }

     public double MostrarSaldo(){
        return this.Saldo + this.Limite;
     }
     public void AjustaLimite(double valor){
        this.Limite = valor;
     }
}
