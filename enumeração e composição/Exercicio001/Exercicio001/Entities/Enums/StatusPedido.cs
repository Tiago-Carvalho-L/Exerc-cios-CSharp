using System;

namespace Exercicio001.Entities.Enums
{
    enum StatusPedido : int
    {
        AguardandoPagamento = 0,
        Processando = 1,
        Enviado = 2,
        Entregue = 3
    }
}
