
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

                //Executar o comando no SQL (Tecla F5 do SQL Server)
                sqlCmd.ExecuteNonQuery();                        
                
            }
        }
    }
}