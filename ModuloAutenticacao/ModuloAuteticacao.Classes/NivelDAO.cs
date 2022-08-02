using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ModuloAuteticacao.Classes
{
    public class NivelDAO
    {
        public string Inserir(string nome)
        {   //Abrindo a Conexão
            Conexao.MinhaInstancia.Open();
            //Definindo o Comando
            SqlCommand comando = Conexao.MinhaInstancia.CreateCommand();
            //Definindo o tipo de Comando
            comando.CommandType = System.Data.CommandType.Text;
            //Iniciando a DML 
            comando.CommandText = "INSERT INTO Nivel(nome)Values(@Nome)";
            //Adicionando Parâmetros contra SQL Injection
            comando.Parameters.Add(new SqlParameter("@Nome", nome));
            //Esta tudo Pronto ! Vamos Executar o comando.
            comando.ExecuteNonQuery();
            //Fechar a Conexão
            Conexao.MinhaInstancia.Close();
            
            return "Dados Inseridos com Sucesso!";

        }
        public string Atualizar()
        {
            return "Você vai Atualiar";
        }
        public string Pesquisar()
        {
            return "Pesquisar";
        }
        public string Deletar()
        {
            return "Voce vai Deletar";
        }
    }
}
