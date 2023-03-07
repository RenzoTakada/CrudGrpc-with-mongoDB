using CRUDGrpcService.Application.UserCase.ConsultarUSC;
using Grpc.Core;

namespace CRUDGrpcService.Application.Routs
{
    public class ServiceConsultar : Consultar.ConsultarBase
    {
        private IUSCConsultar uSCConsultar;
        public ServiceConsultar(IUSCConsultar consultar)
        {
            uSCConsultar = consultar;
        }

        public override async Task<baseReturn> ConsultarUsuario(RequestUsuario request, ServerCallContext context)
        {
            var ret = await uSCConsultar.ConsultarUSC(request);
            return new baseReturn() { Status = 0, Mensagem = $"{ret}" };
        }
    }
}
