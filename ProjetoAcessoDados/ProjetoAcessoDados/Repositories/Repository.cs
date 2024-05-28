using Dapper.Contrib.Extensions;
using ProjetoAcessoDados.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAcessoDados.Repositories
{
    public class Repository<TModel> where TModel : class
    {
        //readonly é usado para leitura somente, ninguém poderá alterar a conexão
        private readonly SqlConnection _connection;


        //Método Construtor
        public Repository(SqlConnection conn)
           => _connection = conn;

        public IEnumerable<TModel> Get()
            => _connection.GetAll<TModel>();

        public TModel Get(int id)
            => _connection.Get<TModel>(id);

        public void Create(TModel model)
            => _connection.Insert<TModel>(model);

        public void Update(TModel model)
            => _connection.Update<TModel>(model);

        public void Delete(TModel model)
            =>  _connection.Delete<TModel>(model);

        public void Delete(int id)
        {
            var model = _connection.Get<TModel>(id);
            _connection.Delete<TModel>(model);
        }
    }
}
