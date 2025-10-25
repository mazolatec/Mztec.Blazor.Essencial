

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
