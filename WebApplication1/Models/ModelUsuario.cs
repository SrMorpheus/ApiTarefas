namespace APITAREFA.Models
{
    public class ModelUsuario
    {

        public int Id { get; set; } 
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set;}
        public int ModelPerfilId { get; set; }
        public List<ModelTarefas> Tarefas { get; set; } 
        public ModelPerfil Perfil { get; set; }






    }
}
