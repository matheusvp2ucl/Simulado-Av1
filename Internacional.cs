class Internacional : Cartao {

  private double taxaTransacao;

  public Internacional(double saldo) : base(saldo){
    taxaTransacao = 0.05;
  }
  
  protected override void debito(double valor){
    saldo -= (valor + (valor * taxaTransacao));
  }

}