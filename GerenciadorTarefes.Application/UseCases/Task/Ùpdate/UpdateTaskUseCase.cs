using GerenciadorTarefas.Communication.Requests;
using GerenciadorTarefas.Communication.Responses;

namespace GerenciadorTarefes.Application.UseCases.Task.Ùpdate;

public class UpdateTaskUseCase
{
    public ResponseTaskJson Execute(RequestTaskJson request)
    {
        return new ResponseTaskJson
        {
            Id = request.Id,
            Name = request.Name,
            Description = request.Description,
            Priority = request.Priority,
            Status = request.Status
        };
    }
}
