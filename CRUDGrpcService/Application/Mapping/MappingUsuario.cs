using CRUDGrpcService.Adapters.MongoDB.Models;
using MongoDB.Bson;

namespace CRUDGrpcService.Application.Mapping
{
    public static class MappingUsuario
    {
        public static ModelsMongoDb MappingMongoUsuario(RequestUsuario request)
        {
            return new ModelsMongoDb()
            {
                Id = request.Identificador,
                tipo = 0,
                nome = request.Nome,
                idade = request.Idade,
                agencia = request.Cliente.Agencia,
                numeroConta = request.Cliente.NumeroConta,
                saldo= request.Cliente.Saldo,

            };

        }
    }
}
