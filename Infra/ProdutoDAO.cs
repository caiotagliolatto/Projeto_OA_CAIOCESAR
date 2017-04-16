using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra
{
    public class ProdutoDAO
    {

        public bool Inserir(Produto p)
        {
            
            try
            {
                DAL_Banco_Final dal = new DAL_Banco_Final();


                using (var SqlCom = new SqlCommand("INSERT INTO PRODUTO(NOME, DESCRICAO, PRECO) VALUES(@nome,@descricao,@preco)", dal.ConnectionDB))
                {
                    dal.BancoFinal();
                    SqlCom.Connection = dal.ConnectionDB;
                    SqlCom.Parameters.AddWithValue("@nome", p.nome);
                    SqlCom.Parameters.AddWithValue("@preco", p.preco);
                    SqlCom.Parameters.AddWithValue("@descricao", p.descricao);
                    SqlCom.ExecuteNonQuery();
                    Console.WriteLine("deu certo");
                    dal.Dispose();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Message: " + ex.Message);
                return false;
            }
        }

        public Produto ler(int id)
        {
            DAL_Banco_Final dal = new DAL_Banco_Final();
            dal.BancoFinal();
            using (var SqlCom = new SqlCommand("SELECT * FROM PRODUTO WHERE id = " + id, dal.ConnectionDB))
            {
                
                using (var reader = SqlCom.ExecuteReader())
                {
                    reader.Read();
                    var nome = reader["NOME"].ToString();
                    var desc = reader["DESCRICAO"].ToString();
                    var preco = reader["PRECO"].ToString();
                    Console.WriteLine("erou >"+nome);
                    dal.Dispose();
                    return new Produto(preco, nome, desc);
                }
            }
        }

        public void Atualizar(Produto p, int id)
        {
            DAL_Banco_Final dal = new DAL_Banco_Final();
            dal.BancoFinal();
                using (var SqlCom = new SqlCommand("UPDATE PRODUTO SET NOME = @nome, DESCRICAO = @descricao, PRECO = @preco WHERE id = @id", dal.ConnectionDB))
                {

                    SqlCom.Parameters.AddWithValue("@nome", p.nome);
                    SqlCom.Parameters.AddWithValue("@preco", p.preco);
                    SqlCom.Parameters.AddWithValue("@descricao", p.descricao);
                    SqlCom.Parameters.AddWithValue("@id", id);
                    SqlCom.ExecuteNonQuery();
                }
            dal.Dispose();
        }
        public void Excluir(int id)
        {
            DAL_Banco_Final dal = new DAL_Banco_Final();
            dal.BancoFinal();
            using (var SqlCom = new SqlCommand("DELETE FROM PRODUTO WHERE id = @id", dal.ConnectionDB))
            {
                SqlCom.Parameters.AddWithValue("@id", id);
                SqlCom.ExecuteNonQuery();
            }
            dal.Dispose();

        }

    }
}
