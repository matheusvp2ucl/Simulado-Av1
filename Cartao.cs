class Cartao {
 
 
  public double saldo {get; set;}
  public double limite {get; set;}
  public bool fechada {get; set;}

  public Cartao(double _saldo){
    saldo = _saldo;
    limite = 50000;
    fechada = false;
  }
  
  public virtual void debito(double valor){
  }

  public void credito(double valor){
    if( valor > limite ){
      Console.WriteLine("Saldo insuficiente...")
    }
    limite -= valor;
    Console.WriteLine("Limite atual: " + limite);
  }

  public void comprar(double valor, string tipo){

    if(fechada){
      Console.WriteLine("Fatura ja esta fechada.")
      return;
    }

    if(tipo == "debito"){
      debito(valor)
    }else{
      credito(valor)
    }

  }

  public void comprar(double valor){
    if(fechada){
      Console.WriteLine("Fatura ja esta fechada.")
      return;
    }
    credito(valor)
  }
  
  public void fecharFatura(){
    fechada = true;
  }

  public pagarFatura(){
    limite = 50000;
    fechada = false;
  }

}