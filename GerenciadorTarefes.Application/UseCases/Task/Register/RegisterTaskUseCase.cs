using GerenciadorTarefas.Communication.Requests;
using GerenciadorTarefas.Communication.Responses;

namespace GerenciadorTarefes.Application.UseCases.Task.Register;

public class RegisterTaskUseCase
{
    public ResponseTaskRegisteredJson Execute(RequestTaskJson request)
    {
       return new ResponseTaskRegisteredJson
        {
            Id = 1,
            Name = request.Name
        };

    }
}
