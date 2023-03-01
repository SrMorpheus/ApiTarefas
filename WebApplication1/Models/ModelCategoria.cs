namespace APITAREFA.Models
{
    public class ModelCategoria
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public List<ModelTarefas> Tarefas { get; set; } 


    }
}
