using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Efetuar_pagamento.Forma_de_pagamento
{
    //poliformismo

    internal class formadepagamento
    {
        public virtual void Efetuarpagamento()
        {
            Console.WriteLine("Pagamento Efetuado");
        }

    }

    class formadepagamentoBoleto : formadepagamento
    {
        public override void Efetuarpagamento()
        {
            Console.WriteLine("Pagamento efetuado com Boleto");
        }
    }

    class formadepagamentoPix : formadepagamento
    {
        public override void Efetuarpagamento()
        {
            Console.WriteLine("Pagamento efetuado com Pix");
        }
    }

    class formadepagamentoTransferencia : formadepagamento
    {
        public override void Efetuarpagamento()
        {
            Console.WriteLine("Pagamento efetuado com Transferência");
        }
    }

    class formadepagamentoCartaocredito : formadepagamento
    {
        public override void Efetuarpagamento()
        {
            Console.WriteLine("Pagamento efetuado com Cartão de Crédito");
        }
    }
}
