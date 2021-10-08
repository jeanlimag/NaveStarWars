using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaveStarWars.Dao
{
    public abstract class DaoBase : IDisposable
    {
        protected readonly SqlConnection con;
        protected DaoBase()
        {
            con = new SqlConnection(@"Data Source=DESKTOP-2AVPGQ2\SQLEXPRESS;Initial Catalog=Estrela Da Morte;Integrated Security=True");

        }

        protected async Task Insert(string comando)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(comando, con);
            await cmd.ExecuteNonQueryAsync();
            con.Close();

        }
        protected async Task Select(string comando, Action<SqlDataReader> tratamentoLeitura)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(comando, con);
            SqlDataReader dr = await cmd.ExecuteReaderAsync();
            tratamentoLeitura(dr);
            con.Close();
        }
        public void Dispose()
        {
            con?.Close();
            con?.Open();
        }
    }
}
