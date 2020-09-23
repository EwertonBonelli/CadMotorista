using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadMotorista
{
   public class Conexaodb
    {
        //Criando uma conexão com o banco de dados e estanciando o SqlConnection.
        SqlConnection con = new SqlConnection();


        //Construtor que é o mesmo nome da classe.
        public Conexaodb() 
        {
            //Conectando com o banco de dados.
            //A utilização do @ antes dos " " é para ignorar todas as barras que contem dentro do caminho da conecxao do banco de dados.
            //Caminho da conexao do banco de dados.
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ewert\Documents\bdCadMotorista.mdf;Integrated Security=True";
        }

        //Metodo Conectar
        public SqlConnection conectar()
        {
            //Verificando se o estado do banco esta desconectado, se ele estiver então ele se conecta.
            //"con.State" = o estado que esta o banco.
            // "System.Data.ConnectionState.Closed" = conexão fechada.
            if (con.State == System.Data.ConnectionState.Closed) //Se o estado da minha conexão for igual a conexão FECHADA, então pode conectar.
            {
                con.Open(); //Conectando com o banco.
            }
                return con; // Retornando a conexão.
        }

        //Metodo Desconectar
        public void desconectar()
        {
            //Verificando se o estado do banco esta aberto, se tiver ele fecha.
            //"con.State" = o estado que esta o banco.
            // "System.Data.ConnectionState.Open" = conexão aberta.
            if (con.State == System.Data.ConnectionState.Open) //Se o estado da minha conexão for igual a conexão ABERTA, então pode fechar.
            {
                con.Close(); //Fechando o banco.
            }
                
        }
    }
}
