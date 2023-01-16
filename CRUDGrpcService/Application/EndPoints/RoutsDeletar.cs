
using CRUDGrpcService.Application.UserCase.DeletarUSC;
using Grpc.Core;

namespace CRUDGrpcService.Application.Routs
{
    public class ServiceDeletar : Deletar.DeletarBase
    {
        private IUSCDeletar iUSCDeletar;
        public ServiceDeletar(IUSCDeletar _iUSCDeletar)
        {
            iUSCDeletar = _iUSCDeletar;

        }
        public override async Task<baseReturn> DeletarUsuario(RequestUsuario request, ServerCallContext context)
        {
            var ret = await iUSCDeletar.DeletarUSC(request);
            return new baseReturn() { Status = 0, Mensagem = $"{ret}" };
        }
    }
}
