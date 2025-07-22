using GerenciadorTarefas.Communication.Responses;

namespace GerenciadorTarefes.Application.UseCases.Task.GetAll;

public class GetAllTaskUseCase
{
    public ResponseAllTaskJson Execute()
    {
        return new ResponseAllTaskJson
        {
            Tasks = new List<ResponseShortTaskJson>
            {
                new ResponseShortTaskJson
                {
                    Id = 1,
                    Name = "Tarefa 1",
                    Status = GerenciadorTarefas.Communication.Enum.TaskStatus.Aguardando
                },

                new ResponseShortTaskJson
                {
                    Id = 1,
                    Name = "Tarefa 2",
                    Status = GerenciadorTarefas.Communication.Enum.TaskStatus.Concluido
                }
            }
        };
    }
}
