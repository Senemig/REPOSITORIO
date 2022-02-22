using System;
using System.Collections.Generic;
using MySqlConnector;

namespace Etapa_No._2.Models
{
    public class LoteamentoRepositorio
    {
        private const string DadosConexao = "Database=Loteamento; Data Source=localhost; User Id=root;";

        public List<Loteamento> Listar()
        {
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();
            // query Listar em SQL
            String Query = "select * from Lotes";
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);

            // Tratamento para SQL Inection


            MySqlDataReader Reader = Comando.ExecuteReader();

            List<Loteamento> Lista = new List<Loteamento>();

            while (Reader.Read())
            {
                Loteamento LoteEncontrado = new Loteamento();

                LoteEncontrado.Id = Reader.GetInt32("Id");

                if (!Reader.IsDBNull(Reader.GetOrdinal("Nome_Lote")))
                    LoteEncontrado.Nome_Lote = Reader.GetString("Nome_Lote");

                if (!Reader.IsDBNull(Reader.GetOrdinal("Nome_Cliente")))
                    LoteEncontrado.Nome_Cliente = Reader.GetString("Nome_Cliente");

                if (!Reader.IsDBNull(Reader.GetOrdinal("CPF")))
                    LoteEncontrado.CPF = Reader.GetString("CPF");

                if (!Reader.IsDBNull(Reader.GetOrdinal("Valor_Lote")))
                    LoteEncontrado.Valor_Lote = Reader.GetFloat("Valor_Lote");

                if (!Reader.IsDBNull(Reader.GetOrdinal("Entrada")))
                    LoteEncontrado.Entrada = Reader.GetFloat("Entrada");

                if (!Reader.IsDBNull(Reader.GetOrdinal("Qtd_Parcelas")))
                    LoteEncontrado.Qtd_Parcelas = Reader.GetInt32("Qtd_Parcelas");

                if (!Reader.IsDBNull(Reader.GetOrdinal("Valor_Parcela")))
                    LoteEncontrado.Valor_Parcela = Reader.GetFloat("Valor_Parcela");

                LoteEncontrado.Data_Contrato = Reader.GetDateTime("Data_Contrato");


                Lista.Add(LoteEncontrado);

            }

            Conexao.Close();
            return Lista;

        }

        public void Cadastrar(Loteamento lote)
        {
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();
            // query Inserir em SQL
            String Query = " insert into Lotes(Nome_Lote, Nome_Cliente, CPF, Valor_Lote, Entrada, Qtd_Parcelas, Valor_Parcela, Data_Contrato) values (@Nome_Lote, @Nome_Cliente, @CPF, @Valor_Lote, @Entrada,@Qtd_Parcelas,@Valor_Parcela, @Data_Contrato)";
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);

            // Tratamento para SQL Inection
            Comando.Parameters.AddWithValue("@Nome_Lote", lote.Nome_Lote);
            Comando.Parameters.AddWithValue("@Nome_Cliente", lote.Nome_Cliente);
            Comando.Parameters.AddWithValue("@CPF", lote.CPF);
            Comando.Parameters.AddWithValue("@Valor_Lote", lote.Valor_Lote);
            Comando.Parameters.AddWithValue("@Entrada", lote.Entrada);
            Comando.Parameters.AddWithValue("@Qtd_Parcelas", lote.Qtd_Parcelas);
            Comando.Parameters.AddWithValue("@Valor_Parcela", lote.Valor_Parcela);
            Comando.Parameters.AddWithValue("@Data_Contrato", lote.Data_Contrato);
            Comando.ExecuteNonQuery(); // executa a query no banco de dados
            Conexao.Close();
        }

        public void Editar(Loteamento lote)
        {
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();
            // query Editar em SQL
            String Query = "update Lotes set Nome_Lote=@Nome_Lote, Nome_Cliente=@Nome_Cliente, CPF=@CPF, Valor_Lote=@Valor_Lote, Entrada=@Entrada, Qtd_Parcelas=@Qtd_Parcelas, Valor_Parcela=@Valor_Parcela, Data_Contrato=@Data_Contrato where Id=@Id";
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);

            // Tratamento para SQL Injection
            Comando.Parameters.AddWithValue("@Id", lote.Id);
            Comando.Parameters.AddWithValue("@Nome_Lote", lote.Nome_Lote);
            Comando.Parameters.AddWithValue("@Nome_Cliente", lote.Nome_Cliente);
            Comando.Parameters.AddWithValue("@CPF", lote.CPF);
            Comando.Parameters.AddWithValue("@Valor_Lote", lote.Valor_Lote);
            Comando.Parameters.AddWithValue("@Entrada", lote.Entrada);
            Comando.Parameters.AddWithValue("@Qtd_Parcelas", lote.Qtd_Parcelas);
            Comando.Parameters.AddWithValue("@Valor_Parcela", lote.Valor_Parcela);
            Comando.Parameters.AddWithValue("@Data_Contrato", lote.Data_Contrato);
            Comando.ExecuteNonQuery(); // executa a query no banco de dados
            Conexao.Close();
        }

        public void Excluir(Loteamento lote)
        {
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();
            // query exclusão em SQL
            String Query = "delete from Lotes where Id=@Id";
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);

            // Tratamento para SQL Inection
            Comando.Parameters.AddWithValue("@Id", lote.Id);
            Comando.ExecuteNonQuery(); // executa a query no banco de dados
            Conexao.Close();


        }

        public Loteamento BuscarId(int Id)
        {
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);

            Conexao.Open();

            String Query = "select * from Lotes where Id=@Id";
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);

            // Tratamento para SQL Injection
            Comando.Parameters.AddWithValue("@Id", Id);

            MySqlDataReader Reader = Comando.ExecuteReader();

            Loteamento LoteEncontrado = new Loteamento();

            if (Reader.Read()){

                LoteEncontrado.Id=Reader.GetInt32("Id");

            if (!Reader.IsDBNull(Reader.GetOrdinal("Nome_Lote")))
                LoteEncontrado.Nome_Lote = Reader.GetString("Nome_Lote");
           
           
            if (!Reader.IsDBNull(Reader.GetOrdinal("Nome_Cliente")))
                LoteEncontrado.Nome_Cliente = Reader.GetString("Nome_Cliente");

            if (!Reader.IsDBNull(Reader.GetOrdinal("CPF")))
                LoteEncontrado.CPF = Reader.GetString("CPF");

            if (!Reader.IsDBNull(Reader.GetOrdinal("Valor_Lote")))
                LoteEncontrado.Valor_Lote = Reader.GetFloat("Valor_Lote");

            if (!Reader.IsDBNull(Reader.GetOrdinal("Entrada")))
                LoteEncontrado.Entrada = Reader.GetFloat("Entrada");

            if (!Reader.IsDBNull(Reader.GetOrdinal("Qtd_Parcelas")))
                LoteEncontrado.Qtd_Parcelas = Reader.GetInt32("Qtd_Parcelas");

            if (!Reader.IsDBNull(Reader.GetOrdinal("Valor_Parcela")))
                LoteEncontrado.Valor_Parcela = Reader.GetFloat("Valor_Parcela");

            LoteEncontrado.Data_Contrato = Reader.GetDateTime("Data_Contrato");

            }
            Conexao.Close();
            return LoteEncontrado;

        }


    }
}