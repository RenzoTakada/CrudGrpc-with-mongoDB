using CRUDGrpcService.Application.UserCase.RegistrarUSC;
using Grpc.Core;

namespace CRUDGrpcService.Application.Routs
{
    public class ServiceRegistar : Registar.RegistarBase
    {
        private IUSCRegistrar _uSCRegistrar;
        public ServiceRegistar(IUSCRegistrar uSCRegistrar)
        {
            _uSCRegistrar = uSCRegistrar;
        }

        public override async Task<baseReturn> RegistarUsuario(RequestUsuario request, ServerCallContext context)
        {
            var ret = await _uSCRegistrar.RegistrarUSC(request);
            return new baseReturn() { Status = 0, Mensagem = $" {ret}" };
        }
    }
}
