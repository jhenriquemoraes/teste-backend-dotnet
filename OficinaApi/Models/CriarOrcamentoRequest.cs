using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OficinaApi.Models
{
    public class CriarOrcamentoRequest
    {
        public int ClienteId { get; set; }
        public int VeiculoId { get; set; }
        public List<ItemOrcamentoRequest> Itens { get; set; }
    }
}