using System;
using System.IO;
using System.Collections.Generic;

class MainClass 
{
  public static void Main (string[] args) 
  {
    //Título - Utilizar PROMPT MAXIMIZADO!!!
    StreamReader z;
    string CaminhoT = "Titulo.txt";
    z = File.OpenText(CaminhoT);
    while(z.EndOfStream != true)
    {
      string linha = z.ReadLine();
      Console.WriteLine(linha);
    }
    z.Close();

    ListControl error = new ListControl();
    bool chave = true;
    do
    {
      //Entrada dos dados pelo usuário
      Console.Write("Deseja cadastrar uma novo Dispositivo? S/N ");
      string cad = Console.ReadLine().ToUpper();

      if(cad == "S" || cad == "SIM" )
      {
        Console.Write("Digite a Marca: ");
        string marca = Console.ReadLine();

        Console.Write("Digite o Modelo: ");
        string modelo = Console.ReadLine();

        Console.Write("Digite a Service Tag: ");
        string stag = Console.ReadLine();

        Console.Write("Digite o Tipo: ");
        string tipo = Console.ReadLine();

        Console.Write("Digite o Responsável: ");
        string responsaveldisp = Console.ReadLine();

        //Tratamento de exceções
        bool invalido = true;
        int matricularesp = 0;
        do
        {
          try
          {
            Console.Write("Digite a Matrícula do Responsável: ");
            matricularesp = int.Parse(Console.ReadLine());
            invalido = false;
          }
          catch(FormatException)
          {
            Console.WriteLine("Matrícula deve ser apenas NÚMEROS! Favor inserir novamente!");
            invalido = true;
          }
        }
        while (invalido);      
        
                    
        //Trabalhando com arquivo .txt
        StreamWriter x;
        string CaminhoNome = "dados.txt";
        x = File.AppendText(CaminhoNome);
        //Salvando dados no arquivo;
        ListControl.AddSubDevice(new SubDevice(marca, modelo, stag, tipo, responsaveldisp, matricularesp));
        List <SubDevice>Subdevices = ListControl.getListaSubDevice();      
        foreach(SubDevice subdevice in  Subdevices)
        {
          x.WriteLine(subdevice.Imprimir().ToUpper());
        }
        x.Close();
      }

      else if(cad == "N" || cad == "NAO" )
      {
        chave = false;
      }

      else
      {
        error.Exception();
      } 
    }
    while(chave);

    //Imprimir na tela os Dispostivos disponíveis;
    Console.WriteLine();
    Console.Write("Deseja verificar o banco de Dispostivos? S/N ");
    string buscadisp = Console.ReadLine().ToUpper();
    Console.WriteLine();

    if(buscadisp == "SIM" || buscadisp == "S")
    {
      StreamReader y;
      Console.WriteLine();
      Console.WriteLine("LISTA DE DISPOSITIVOS");
      Console.WriteLine();

      string Caminho = "dados.txt";
      y = File.OpenText(Caminho);

      while(y.EndOfStream != true)
      {
        string linha = y.ReadLine();
        Console.WriteLine(linha);        
      }    
      y.Close();

      Console.WriteLine();
      Console.Write("********PROGRAMA FINALIZADO*********");      
    }

    if(buscadisp == "NAO" || buscadisp == "N")
    {
      Console.Write("********PROGRAMA FINALIZADO*********");
    }
    //usando tratamento de exceções
    if(buscadisp != "N" && buscadisp != "S")
    {
      error.Exception();
    }    
  }
}