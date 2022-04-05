using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Cadastro_MVC.Models
{
    public class PessoaModel
    {
        // Campos (banco de dados) ou atributos desta classe
        [DisplayName("ID")] // É semelhante a uma etiqueta ou Label/Tag (APELIDO)
        public int PessoaID { get; set; }
        [DisplayName("Nome")]
        public string PessoaNome { get; set; }
        [DisplayName("Email")]        
        public string PessoaEmail { get; set; }
        [DisplayName("Telefone")]
        public string PessoaTelefone { get; set; }

        // Criar uma CONSTANTE para conexão com o banco de dados
                readonly string connectionString = @"Data Source=DESKTOP-68SK05H\SQLEXPRESS;Initial Catalog=cadastro_mvc;Integrated Security=True";         

        // Este método salva os dados que vieram do formulário no banco de dados.          
        public void Salvar()
        {
            // Cria uma conexão com o banco de dados
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {                 
                // Realiza a abertura de uma conexão com o banco de dados
                sqlCon.Open();

                // Cria uma instrução SQL para ser executada no servidor SQL Server
                SqlCommand sqlCmd = new SqlCommand("INSERT INTO tb_pessoa VALUES (@PessoaNome, @PessoaEmail, @PessoaTelefone)", sqlCon);

                sqlCmd.Parameters.AddWithValue("@PessoaNome", PessoaNome);
                sqlCmd.Parameters.AddWithValue("@PessoaEmail", PessoaEmail);
                sqlCmd.Parameters.AddWithValue("@PessoaTelefone", PessoaTelefone);

                // Executar o comando no SQL (Tecla F5 do SQL Server)
                sqlCmd.ExecuteNonQuery();                        
                
            }
        }

        // Método que retorna dentro de um DataTable todos os dados do BD.
        public DataTable Listar() 
        {
            // Criar uma variável para receber os dados da tabela no banco de dados (referência)
            using (DataTable tblPessoa = new DataTable())
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    // Abrir a conexão com o banco de dados
                    sqlCon.Open();

                    // Cria uma instrução SQL para ser executada no servidor SQL Server
                    SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM tb_pessoa", sqlCon);

                    // string sql = "SELECT * FROM tb_pessoa";
                    // SqlDataAdapter sqlDa = new SqlDataAdapter(sql, sqlCon);

                    // Recuperação dos dados após a execução da instrução
                    sqlDa.Fill(tblPessoa);
                }

                // Retornar os obtidos para serem mostrados na View (Index)
                return tblPessoa;
            }
        }

        // Método editar para selecionar o registro desejado no banco dados
        // O parâmetro id é o identificador do registro
        public void Editar(int idPessoa)
        {
            DataTable tblPessoa = new DataTable();
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
 
                // É necessário utilizar a cláusula WHERE, pois queremos apenas um (01) registro
                SqlDataAdapter sqlDa = new SqlDataAdapter(
                    "SELECT * FROM tb_pessoa WHERE PessoaID = @PessoaID", sqlCon);
 
                sqlDa.SelectCommand.Parameters.AddWithValue("@PessoaID", idPessoa);
 
                // Recuperar o registro
                sqlDa.Fill(tblPessoa);
            }
 
            // Atribuir os dados retornados do banco de dados para as variáveis do Model
            PessoaID = Convert.ToInt32(tblPessoa.Rows[0][0].ToString());
            PessoaNome = tblPessoa.Rows[0][1].ToString();
            PessoaEmail = tblPessoa.Rows[0][2].ToString();
            PessoaTelefone = tblPessoa.Rows[0][3].ToString();
        }

        // Método atualizar o registro desejado no banco dados
        public void Atualizar()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString)){
 
                sqlCon.Open();
 
                //Criação da instrução SQL para ser executada no banco de dados
                //A cláusula WHERE vai garantir que somente o registro escolhido seja atualizado
                SqlCommand sqlCmd = new SqlCommand(
                    "UPDATE tb_pessoa SET " +
                    "PessoaNome = @PessoaNome, " + 
                    "PessoaEmail = @PessoaEmail, " +
                    "PessoaTelefone = @PessoaTelefone " +
                    "WHERE PessoaID = @PessoaID", sqlCon // Condição para a atualização do registro
                    );
                /**
                Na atualização de um registro (salvamento) se não for informado O QUE DEVE ser
                atualizado, todos os registros serão atualizados com os mesmos dados
                */
                sqlCmd.Parameters.AddWithValue("@PessoaID", PessoaID); //Somente para o WHERE 
                sqlCmd.Parameters.AddWithValue("@PessoNome", PessoaNome);
                sqlCmd.Parameters.AddWithValue("@PessoaEmail", PessoaEmail);
                sqlCmd.Parameters.AddWithValue("@PessoaTelefone", PessoaTelefone);
 
                //Executar o comando UPDATE no banco de dados
                sqlCmd.ExecuteNonQuery();
            }
        }
    }
}