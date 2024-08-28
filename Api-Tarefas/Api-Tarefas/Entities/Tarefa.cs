namespace Api_Tarefas.Entities
{
    public enum Status
    {
        Pendente,
        Finalizado
    }
    public class Tarefa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime Data {  get; set; }
        public Status Status { get; set; }
    }
}
