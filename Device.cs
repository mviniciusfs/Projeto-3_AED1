using System;

class Device 

  //Classe com atributos e método para imprimir dados no arquivo.
  {
    public string Marca;
    public string Modelo;
    public string ServiceTag;

    public string Getmarca()
    {
      return Marca;
    }
    public void Setmarca(string m)
    {
      Marca = m;
    }

    public string Getmodelo()
    {
      return Modelo;
    }
    public void Setmodelo(string mo)
    {
      Modelo = mo;      
    }

    public string Getservicetag()
    {
      return ServiceTag;
    }
    public void Setservicetag(string st)
    {
      ServiceTag = st;
    }

    public Device (string m, string mo, string st)
    {
      Marca = m;
      Modelo = mo;
      ServiceTag = st;
    }

          
    public string Imprimir()
    {
      string dados = "Marca: " + Marca +"||Modelo: "+ Modelo + "||ServiceTag: "+ ServiceTag;

      return dados;
    }
        
  }
