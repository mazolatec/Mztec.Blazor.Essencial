using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mztec.BlazorTarefas.Shared.Data
{
    public class Tarefa
    {
        public Guid ID { get; set; } = Guid.NewGuid();
        public int Id { get; set; }
        public string? Descricao { get; set; }
        public bool Concluida { get; set; }
        public DateTime DataCriacao { get; set; } 
    }
}
