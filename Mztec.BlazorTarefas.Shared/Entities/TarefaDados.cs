using Mztec.BlazorTarefas.Shared.Data;


namespace Mztec.BlazorTarefas.Shared.Entities
{
    public static class TarefaDados
    {
        // Método assíncrono que retorna uma lista de tarefas
        public static async Task<List<Tarefa>> ObterTarefasAssinc()
        {
            // Aqui, simulamos uma operação assíncrona (por exemplo, buscar do banco)
            // apenas para simular latência

            return new List<Tarefa>
            {
                new Tarefa
                {
                    Descricao = "Fazer curso",
                    Concluida = false,
                    DataCriacao = DateTime.Parse("2025-01-25")
                },
                new Tarefa
                {
                    Descricao = "Estudar .NET 9",
                    Concluida = false,
                    DataCriacao = DateTime.Parse("2025-02-20")
                },
                new Tarefa
                {
                    Descricao = "Ler documentação Blazor",
                    Concluida = false,
                    DataCriacao = DateTime.Parse("2025-03-04")
                },
                new Tarefa
                {
                    Descricao = "Praticar consultas LINQ",
                    Concluida = false,
                    DataCriacao = DateTime.Parse("2025-04-09")
                },
                new Tarefa
                {
                    Descricao = "Criar API com EF Core",
                    Concluida = false,
                    DataCriacao = DateTime.Parse("2025-05-12")
                },
                new Tarefa
                {
                    Descricao = "Fazer testes unitários",
                    Concluida = false,
                    DataCriacao = DateTime.Parse("2025-06-01")
                },
                new Tarefa
                {
                    Descricao = "Publicar no GitHub",
                    Concluida = false,
                    DataCriacao = DateTime.Parse("2025-06-15")
                }
            };
            
        }
    }
}
