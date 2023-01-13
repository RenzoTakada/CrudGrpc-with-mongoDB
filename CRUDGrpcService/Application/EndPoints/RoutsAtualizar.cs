using Grpc.Core;

namespace CRUDGrpcService.Application.Routs
{
    public class SeriviceAtualizar : Atualizar.AtualizarBase
    {
        public override async Task<baseReturn> AtualizarUsuario(RequestUsuario request, ServerCallContext context)
        {
            return new baseReturn() { Status = 0, Mensagem = $"Atualizado com sucesso | Request: {request}" };
        }
    }
}
