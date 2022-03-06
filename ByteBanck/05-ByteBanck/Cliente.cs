using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _05_ByteBanck
{
  public class Cliente
  {
    private string _cpf;
    public string Nome { get; set; }

    public string CPF
    {
      get { return _cpf; }
      set
      {
        //logica de validacao 
        _cpf = value;
      }
    }

    public string Profissao { get; set; }

  }
}