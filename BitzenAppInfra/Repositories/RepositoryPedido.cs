using BitzenAppDomain.Entities;
using BitzenAppDomain.Interfaces.Repositories;
using BitzenAppInfra.Interfaces;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BitzenAppInfra.Repositories
{
    public class RepositoryPedido : IRepositoryPedido
    {
        private readonly IDbConnectionString _dbConnectionString;

        public RepositoryPedido(IDbConnectionString dbConnectionString)
        {
            _dbConnectionString = dbConnectionString;
            DefaultTypeMap.MatchNamesWithUnderscores = true;
        }

        public bool RealizarPedido(Pedido p)
        {
            // Aqui faria o insert do pedido.
            throw new NotImplementedException();
        }






        #region Metodos não utilizados nesse exemplo, porém em uma aplicação de porte grande, ficaria o crud padrão
        public int Adicionar(Pedido entity)
        {
            throw new NotImplementedException();
        }

        public int Atualizar(Pedido entity)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _dbConnectionString.Dispose();
            GC.SuppressFinalize(this);
        }

        public Pedido ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Pedido> ObterTodos()
        {
            throw new NotImplementedException();
        }


        public int Remover(int id)
        {
            throw new NotImplementedException();
        }


        #endregion

    



      
}
