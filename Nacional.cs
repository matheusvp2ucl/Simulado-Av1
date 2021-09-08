class Nacional : Cartao {

  private double taxaTransacao;

  public Nacional(double saldo) : base(saldo){
    taxaTransacao = 0.03;
  }

  public override void debito(){
    saldo -= (valor + (valor * taxaTransacao));
  }

}