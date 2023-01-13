namespace CRUDGrpcService.Application.UserCase.ConsultarUSC
{
    public interface IUSCConsultar
    {
        public Task<baseReturn> ConsultarUSC(RequestUsuario request);
    }
}
