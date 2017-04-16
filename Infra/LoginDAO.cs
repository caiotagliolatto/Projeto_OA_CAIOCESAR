using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Infra
{
    public class LoginDAO
    {
        public int login(string u, string p)
        {
            DAL_Banco_Final dal = new DAL_Banco_Final();
            dal.BancoFinal();
            var sql = "SELECT COUNT(*) FROM USUARIO WHERE USUARIO = @user AND SENHA = @pass";
            var SqlCom = new SqlCommand(sql, dal.ConnectionDB);
            SqlCom.Parameters.AddWithValue("@user", u);
            SqlCom.Parameters.AddWithValue("@pass", p);
            Int32 count = (Int32)SqlCom.ExecuteScalar();
            dal.Dispose();
            return count;
        }
        public void cadastro(string u, string p)
        {
            DAL_Banco_Final dal = new DAL_Banco_Final();
            dal.BancoFinal();
            using (var SqlCom = new SqlCommand("INSERT INTO USUARIO(USUARIO, SENHA) VALUES(@u,@p)", dal.ConnectionDB))
            {
                SqlCom.Parameters.AddWithValue("@u", u);
                SqlCom.Parameters.AddWithValue("@p", p);
                SqlCom.ExecuteNonQuery();
            }
            dal.Dispose();
        }

    }
}
