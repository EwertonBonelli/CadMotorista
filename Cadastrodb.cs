using CadMotorista.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadMotorista
{
    public class Cadastrodb
    {
        //Estanciando a classe Conexaodb.
        Conexaodb conexao = new Conexaodb();

        //Estanciando o SqlCommand.
        SqlCommand cmd = new SqlCommand();

        public String mensagem = ""; // Variavel para guardar a mensagem de erro ou sucesso.


        //Metodo Construtor.
        public Cadastrodb()
        {
        }

        public string Salvar(Motorista motorista, Veiculo veiculo, Endereco endereco)
        {
            // Comando SQL --- SqlCommand.
            cmd.CommandText = @"insert into tbinfomotorista(nome, cpf) values('" + motorista.Nome + "','" + motorista.Cpf + "'); SELECT SCOPE_IDENTITY();"; //Comando de texto.



            // Parametros.
            //cmd.Parameters.AddWithValue("",);

            try
            {
                // Conectar com o banco --- Conexaodb.
                cmd.Connection = conexao.conectar(); //Recebendo o endereco do banco de dados.

                // Executar comando.
                 // Com o comando NonQuery eu consigo enviar e receber dados do banco.
                int idMotorista =  Convert.ToInt32(cmd.ExecuteScalar());

                //cmd.CommandText = idMotorista
                // executenonquey

                //cmd.CommandText da tabela endereco passando o idMotorista na FK

                // Desconectar do banco.
                conexao.desconectar();

                // Mostrar mensagem de erro ou sucesso --- Variavel.
                this.mensagem = "Cadastro realizado com sucesso!"; //Mensagem de cadastro caso não tiver nenhum erro.


            }
            catch (SqlException e) //o "SqlException" e usado para erro especifico ao SQL e o "e" é uma veriavel para
            // se guardar esse erro. Se fosse para qualquer erro usariamos somente o "Exception".
            {

                this.mensagem = "Erro ao tentar conectar com o banco de dados!"; //Mensagem de erro.
            }


            return mensagem;

        }
    }
}
