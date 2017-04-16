using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Infra
{
    internal class DAL_Banco_Final : IDisposable
    {
        public SqlConnection ConnectionDB { get; set; }

        public void BancoFinal()
        {
            ConnectionDB = new SqlConnection(configBanco.Default.Banco_Final);
            ConnectionDB.Open();

        }
        public void Dispose()
        {
            ConnectionDB.Close();
            Console.WriteLine("banco fechado");
        }

    }


}