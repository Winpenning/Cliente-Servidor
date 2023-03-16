using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Escola.model;
using MySql.Data.MySqlClient;

namespace Escola.controller
{
    internal class AlunoController
    {
        private MySqlConnection connection;
        public AlunoController()
        {
            this.connection = new conn().gettconnection();
        }
        public void cadaastrarAluno(Aluno obj)
        {
            try
            {
                string sql =
                    @"insert into aluno(nome,rg,cpf,celular,cep,endereco,numero,cidade,uf,bairro)
                    values(@nome,@rg,@cpf,@celular,@cep,@endereco,@numero,@cidade,@uf,@bairro)";

                MySqlCommand exe = new MySqlCommand(sql, connection);
                exe.Parameters.AddWithValue("@nome",obj.nome);
                exe.Parameters.AddWithValue("@rg", obj.rg);
                exe.Parameters.AddWithValue("@cpf", obj.cpf);
                exe.Parameters.AddWithValue("@celular", obj.celular);
                exe.Parameters.AddWithValue("@cep", obj.cep);
                exe.Parameters.AddWithValue("@endereco", obj.endereco);
                exe.Parameters.AddWithValue("@numero", obj.numero);
                exe.Parameters.AddWithValue("@cidade", obj.cidade);
                exe.Parameters.AddWithValue("@uf", obj.uf);
                exe.Parameters.AddWithValue("@email", obj.email);
                exe.Parameters.AddWithValue("@bairro", obj.bairro);

                connection.Open();
                exe.ExecuteNonQuery();
                MessageBox.Show("Aluno cadastrado com sucesso!");

                connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
