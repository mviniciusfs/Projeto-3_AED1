using System;
using System.Collections.Generic;

class ListControl

  {
    //Lista - dados de Subdevices.
    public static List<SubDevice>Subdevices = new List<SubDevice>();

    //Adicionar dados inseridos pelo operador do sistema.
    public static void AddSubDevice(SubDevice p1)
    {
      Subdevices.Add(p1);
    }

    public static List<SubDevice> getListaSubDevice() 
    {
      return Subdevices;
    }

    public void Exception()
    {
      throw new System.ArgumentException("OPÇÃO INVÁLIDA: Programa finalizado");
    }          
  }
