using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Dominio;
using Application.Repositorio;


namespace Application.Aplicacao
{
    public class AlunoAplicacao
    {
        private Contexto contexto;

        private void Inserir(Aluno aluno)
        {
            var strQuery = "";
            strQuery += " INSERT INTO ALUNO (Nome, Mae, DataNascimento, ci_sexo, nr_cpf, ci_Cadeirante, ci_Fala, p172, p15,nr_idade,nm_email,nr_dinheiro,dc_obs,nm_usuario,nm_senha,ci_raca) ";
            strQuery += string.Format(" VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}') ",
            aluno.Nome, aluno.Mae, aluno.DataNascimento, aluno.ci_sexo, aluno.nr_cpf, aluno.ci_Cadeirante.BoolToInt(), aluno.ci_Fala.BoolToInt(), aluno.p172, aluno.p15, aluno.nr_idade.ToString().ToInt(), aluno.nm_email, aluno.nr_dinheiro.ToString().ToDecDb(), aluno.dc_obs, aluno.nm_usuario, aluno.nm_senha, aluno.ci_raca
            );

            using (contexto = new Contexto())
            {
                contexto.ExecutaComando(strQuery);
            }

        }


        private void Alterar(Aluno aluno)
        {
            var strQuery = "";
            strQuery += string.Format(" UPDATE ALUNO SET ");
            strQuery += string.Format(" Nome = '{0}', ", aluno.Nome);
            strQuery += string.Format(" Mae = '{0}', ", aluno.Mae);
            strQuery += string.Format(" DataNascimento = '{0}', ", aluno.DataNascimento);
            strQuery += string.Format(" ci_sexo = '{0}', ", aluno.ci_sexo);
            strQuery += string.Format(" ci_raca = '{0}', ", aluno.ci_raca);
            strQuery += string.Format(" nr_cpf  = '{0}', ", aluno.nr_cpf);
            strQuery += string.Format(" ci_Cadeirante = '{0}', ", aluno.ci_Cadeirante.BoolToInt());
            strQuery += string.Format(" ci_Fala = '{0}', ", aluno.ci_Fala.BoolToInt());
            strQuery += string.Format(" p172 = '{0}', ", aluno.p172);
            strQuery += string.Format(" p15  = '{0}', ", aluno.p15);
            strQuery += string.Format(" nr_idade  = '{0}', ", aluno.nr_idade.ToString().ToInt());      
            strQuery += string.Format(" nm_email  = '{0}', ", aluno.nm_email);
            strQuery += string.Format(" nr_dinheiro  = '{0}', ", aluno.nr_dinheiro.ToString().ToDecDb());   
            strQuery += string.Format(" dc_obs  = '{0}', ", aluno.dc_obs);       
            strQuery += string.Format(" nm_usuario  = '{0}', ", aluno.nm_usuario);
            strQuery += string.Format(" nm_senha  = '{0}' ", aluno.nm_senha); 
            strQuery += string.Format(" WHERE Id = {0} ", aluno.Id);

            using (contexto = new Contexto())
            {
                contexto.ExecutaComando(strQuery);
            }

        }

        public void Salvar(Aluno aluno)
        {
            if (aluno.Id > 0)
            {
                Alterar(aluno);
            }
            else
            {
                Inserir(aluno);
            }

        }

        public void Excluir(string id)
        {
            using (contexto = new Contexto())
            {
                var strQuery = string.Format(" DELETE FROM ALUNO WHERE Id = {0}", id);
                contexto.ExecutaComando(strQuery);
            }

        }

        public List<Aluno> ListarTodos()
        {
            using (contexto = new Contexto())
            {
                var strQuery = " Select *,replace(replace(t1.ci_sexo,1,'Masculino'),2,'Feminino') dc_sexo,replace(replace(t1.p172,'1','Sim'),'2','Não') dc_p172,t2.dc_raca from Aluno t1 left join raca t2 on t1.ci_raca=t2.ci_raca ";
                var retornoDataReader = contexto.ExecutaComandoComRetorno(strQuery);
                return TransformaReaderEmListaDeObjeto(retornoDataReader);
            }
        }

        public Aluno ListarPorId(string id)
        {
            using (contexto = new Contexto())
            {
                var strQuery = string.Format(" Select *,replace(replace(t1.ci_sexo,1,'Masculino'),2,'Feminino') dc_sexo,replace(replace(t1.p172,'1','Sim'),'2','Não') dc_p172,t2.dc_raca from Aluno t1 left join raca t2 on t1.ci_raca=t2.ci_raca where t1.Id = {0}", id);
                var retornoDataReader = contexto.ExecutaComandoComRetorno(strQuery);
                return TransformaReaderEmListaDeObjeto(retornoDataReader).FirstOrDefault();
            }
        }

        private List<Aluno> TransformaReaderEmListaDeObjeto(SqlDataReader reader)
        {
            var alunos = new List<Aluno>();
            while (reader.Read())
            {
                var temObjeto = new Aluno()
                {
                    Id              = reader["Id"].ToString().ToInt(),
                    Nome            = reader["Nome"].ToString(),
                    Mae             = reader["Mae"].ToString(),
                    DataNascimento  = reader["DataNascimento"].ToString().ToDate(),
                    ci_sexo         = reader["ci_sexo"].ToString().ToInt() ,
                    dc_sexo         = reader["dc_sexo"].ToString(),
                    ci_raca         = reader["ci_raca"].ToString().ToInt() ,
                    dc_raca         = reader["dc_raca"].ToString(),
                    nr_cpf          = reader["nr_cpf"].ToString(),
                    ci_Cadeirante   = reader["ci_Cadeirante"].ToString().ToBool(),
                    ci_Fala         = reader["ci_Fala"].ToString().ToBool(),
                    p172            = reader["p172"].ToString(),
                    dc_p172         = reader["dc_p172"].ToString(),
                    p15             = reader["p15"].ToString(),
                    nr_idade        = reader["nr_idade"].ToString().ToInt(),
                    nm_email        = reader["nm_email"].ToString(),
                    nr_dinheiro     = reader["nr_dinheiro"].ToString().ToDec(),
                    dc_obs          = reader["dc_obs"].ToString(),
                    nm_usuario      = reader["nm_usuario"].ToString(),
                    nm_senha        = reader["nm_senha"].ToString()
                };
                alunos.Add(temObjeto);
            }
            reader.Close();
            return alunos;
        }

     }
}

