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

    Console.Write("Deseja cadastrar uma novo Dispositivo? ");
    string cad = Console.ReadLine().ToUpper();

    if(cad == "S" || cad == "SIM")
    {
      //Entrada dos dados pelo usuário
      while(cad == "SIM" || cad == "S")
      {
        Console.Write("Digite o Marca: ");
        string marca = Console.ReadLine();

        Console.Write("Digite o Modelo: ");
        string modelo = Console.ReadLine();

        Console.Write("Digite o Service Tag: ");
        string stag = Console.ReadLine();

        Console.Write("Digite o Tipo: ");
        string tipo = Console.ReadLine();

        Console.Write("Digite o Responsável: ");
        string responsaveldisp = Console.ReadLine();

        //Tratamento de exceções
        bool invalido = true;
        int matricularesp = 0;
        double salario = 0;

        do
        {
          try
          {
            Console.Write("Digite a Matrícula do Responsável: ");
            matricularesp = int.Parse(Console.ReadLine());
            invalido = false;
          }
          catch (FormatException)
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

        Console.Write("Deseja cadastrar um novo Dispositivo? ");
        string cad2 = Console.ReadLine().ToUpper();
        
        if(cad2 == "NAO" || cad2 == "N")
        {
          break;
        }
        //Usando tratamento de esceções
        else if(cad2 != "SIM" && cad2!= "S")
        {
          throw new System.ArgumentException("INVÁLIDO: Programa finalizado");
        }        
      }

    }

    if (cad == "N" || cad == "NAO")
    {
      Console.WriteLine();
      Console.Write("PROGRAMA FINALIZADO");
      Environment.Exit(0);           
    }
	  //usando tratamento de esceções
    else
    {
      throw new Exception("AVISO: OPÇÃO INVALIDA. PROGRAMA FINALIZADO!");
    }

    //Imprimir na tela os Dispostivos disponíveis;
    Console.WriteLine();
    Console.WriteLine("Deseja verificar o banco de Dispostivos? ");
    string resultfinal = Console.ReadLine().ToUpper();
    Console.WriteLine();

    if(resultfinal == "SIM" || resultfinal == "S")
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

    if(resultfinal == "NAO" || resultfinal == "N")
    {
      Console.Write("********PROGRAMA FINALIZADO*********");
    }
	  //usando tratamento de exceções
    else if(resultfinal != "NAO" || resultfinal == "N" || resultfinal != "SIM" || resultfinal != "S")
    {
      throw new System.ArgumentException("INVÁLIDO: Programa finalizado");
    }
    
  }
}