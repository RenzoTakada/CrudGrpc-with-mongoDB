namespace CRUDGrpcService.Application.UserCase.RegistrarUSC
{
    public interface IUSCRegistrar
    {
        public Task<string> RegistrarUSC(RequestUsuario request);
    }
}
