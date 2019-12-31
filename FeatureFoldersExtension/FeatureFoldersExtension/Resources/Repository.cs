using Dapper;
using System.Data.SqlClient;
using System.Threading.Tasks;
using _PROJECT_NAME_.Infrastructure;
using _PROJECT_NAME_.Infrastructure.Database;

namespace _NAMESPACE_
{
    class Repository : IRepository
    {
        private readonly IConnectionStringFactory _connectionStringFactory;
        private readonly TeacherContext _dbContext;

        public Repository(IConnectionStringFactory connectionStringFactory, TeacherContext dbContext)
        {
            _connectionStringFactory = connectionStringFactory;
            _dbContext = dbContext;
        }
    }
}