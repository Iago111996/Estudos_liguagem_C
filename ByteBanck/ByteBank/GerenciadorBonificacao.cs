using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ByteBank.Funcionarios;

namespace ByteBank
{
  public class GerenciadorBonificacao
  {
    private double _totalBonificacao;
    public void Regitrar(Funcionario funcionario)
    {
      _totalBonificacao += funcionario.GetBonificacao();
    }
    // public void Regitrar(Diretor diretor)
    // {
    //   _totalBonificacao += diretor.GetBonificacao();
    // }

    public double GetTotalBonificacao()
    {
      return _totalBonificacao;
    }
  }
}