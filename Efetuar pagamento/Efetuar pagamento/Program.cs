using Efetuar_pagamento.Enum;
using Efetuar_pagamento.Forma_de_pagamento;
using System;

namespace EfetuarPagamento
{
    class Program
    {
         /*
            Escrever um programa 
            que recebe os produtos a serem comprados 
            e a forma de pagamentos escolhida e, 
            de acordo com a forma de pagamento, 
            efetua a compra utilizando o correto meio de pagamento. 
         */

        
        static void Main(string[] produtos)
        {
            if(produtos.Length == 0)
            {
                Console.WriteLine("Nenhum produto listado");
                return;
            }

            Console.WriteLine("Porfavor selecionar a forma de pagamento (Boleto, Pix, CartaoCredito, Transferencia)");
            var formadepagamentodesejada = Console.ReadLine();

            if (string.IsNullOrEmpty(formadepagamentodesejada) || string.IsNullOrWhiteSpace(formadepagamentodesejada)
                || tipopagamento.Boleto.ToString() != formadepagamentodesejada
                && tipopagamento.Pix.ToString() != formadepagamentodesejada                      //aqui checa as formas
                && tipopagamento.Transferencia.ToString() != formadepagamentodesejada
                && tipopagamento.CartaoCredito.ToString() != formadepagamentodesejada)
            {
                Console.WriteLine($"A forma de pagamento {formadepagamentodesejada} não é válida");
                return;
            }

            formadepagamento formadepagamento;
            if(tipopagamento.Pix.ToString() == formadepagamentodesejada)
            {
                formadepagamento = new formadepagamentoPix();
            }else if(tipopagamento.Boleto.ToString() == formadepagamentodesejada)
            {
                formadepagamento = new formadepagamentoBoleto();
            }else if (tipopagamento.CartaoCredito.ToString() == formadepagamentodesejada)
            {
                formadepagamento = new formadepagamentoCartaocredito();
            }else if (tipopagamento.Transferencia.ToString() == formadepagamentodesejada)
            {
                formadepagamento = new formadepagamentoTransferencia();
            }
            else
            {
                Console.WriteLine($"A forma de pagamento {formadepagamentodesejada} não é válida");
                return;
            }

            if (formadepagamento != null)
            {
                formadepagamento.Efetuarpagamento();
            }
        }
    }
}
