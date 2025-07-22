using GerenciadorTarefas.Communication.Enum;
using System.Runtime.CompilerServices;

namespace GerenciadorTarefas.Communication.Requests;

public class RequestTaskJson
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public TaskPriority Priority { get; set; }
    public Enum.TaskStatus Status { get; set; }
}
