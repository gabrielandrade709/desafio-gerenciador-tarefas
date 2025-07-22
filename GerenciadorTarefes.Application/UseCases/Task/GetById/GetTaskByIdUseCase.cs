using GerenciadorTarefas.Communication.Responses;

namespace GerenciadorTarefes.Application.UseCases.Task.GetById;

public class GetTaskByIdUseCase
{
    public ResponseTaskJson Execute(int id)
    {
        return new ResponseTaskJson
        {
            Id = id,
            Name = "Tarefa 1",
            Description = "Essa é uma tarefa ",
            Priority = GerenciadorTarefas.Communication.Enum.TaskPriority.Alta,
            Status = GerenciadorTarefas.Communication.Enum.TaskStatus.EmAndamento
        };
    }
}
