using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OficinaApi.Models;

namespace OficinaApi.Services
{
    public class OrcamentoService
    {
        public (bool Sucesso, string Mensagem, object? Data) Criar(CriarOrcamentoRequest request)
        {
            if (request == null)
                return (false, "Requisição inválida.", null);

            if (request.ClienteId <= 0)
                return (false, "clienteId é obrigatório.", null);

            if (request.VeiculoId <= 0)
                return (false, "veiculoId é obrigatório.", null);

            if (request.Itens == null || request.Itens.Count == 0)
                return (false, "O orçamento deve possuir pelo menos 1 item.", null);

            foreach (var item in request.Itens)
            {
                if (string.IsNullOrWhiteSpace(item.Descricao))
                    return (false, "Item com descrição inválida.", null);

                if (item.Quantidade <= 0)
                    return (false, "Quantidade deve ser maior que zero.", null);

                if (item.ValorUnitario <= 0)
                    return (false, "ValorUnitario deve ser maior que zero.", null);
            }

            decimal valorTotal = 0;

            foreach (var item in request.Itens)
            {
                valorTotal += item.Quantidade * item.ValorUnitario;
            }

            var resultado = new
            {
                ClienteId = request.ClienteId,
                VeiculoId = request.VeiculoId,
                ValorTotal = valorTotal,
                Status = "Aberto",
                Itens = request.Itens
            };

            return (true, "Orçamento criado com sucesso.", resultado);
        }
    }
}