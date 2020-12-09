using System;

class Device 

  //Classe com atributos e método para imprimir dados no arquivo.
  {
    public string Marca;
    public string Modelo;
    public string ServiceTag;

    public Device (string m, string mo, string st)
    {
      Marca = m;
      Modelo = mo;
      ServiceTag = st;
    }

          
    public string Imprimir()
    {
      string dados = Marca +"||Modelo: "+ Modelo + "||ServiceTag: "+ ServiceTag;

      return dados;
    }
        
  }
