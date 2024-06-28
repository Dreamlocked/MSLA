using MediatR;
using MLSA.Domain.Entities.Exceptions;

namespace MLSA.Domain.UseCases.User.DoTask;
public class DoTaskCommandHandler : IRequestHandler<DoTaskCommandInput, DoTaskCommandOutput>
{
    public async Task<DoTaskCommandOutput> Handle(DoTaskCommandInput request, CancellationToken cancellationToken)
    {
        try
        {
            // Lógica de procesamiento de la solicitud
            await Task.Delay(5000, cancellationToken);
            return new DoTaskCommandOutput() { Result = "Tarea completada" };
        }
        catch(OperationCanceledException)
        {
            throw new CancellationException("La tarea fue cancelada");
        }
    }
}
