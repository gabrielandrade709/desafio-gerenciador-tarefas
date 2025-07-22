namespace GerenciadorTarefas.Communication.Responses;

public class ResponseShortTaskJson
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public Enum.TaskStatus Status { get; set; }
}
