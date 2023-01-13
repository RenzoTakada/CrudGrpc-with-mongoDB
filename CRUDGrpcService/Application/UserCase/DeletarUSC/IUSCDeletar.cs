namespace CRUDGrpcService.Application.UserCase.DeletarUSC
{
    public interface IUSCDeletar
    {
        public Task<baseReturn> DeletarUSC(RequestUsuario request);
    }
}
