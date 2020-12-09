using System;

class SubDevice : Device

  //Classe com atributos e método para imprimir dados no arquivo.
  {
    public string Tipo;
    public string Responsavel;
    public int RespMatric;

    public SubDevice (string m, string mo, string st, string t, string r, int rm) : base (m, mo, st)
    {
      base.Marca = m;
      base.Modelo = mo;
      base.ServiceTag = st;
      this.Tipo = t;
      this.Responsavel = r;
      this.RespMatric = rm;      
    }

    public string Imprimir()
    {
      string dados = base.Imprimir() +"||Tipo: "+ Tipo +"||Responsável: "+ Responsavel +"Matrícula Resp.: "+ RespMatric;

      return dados;
    }    
  }