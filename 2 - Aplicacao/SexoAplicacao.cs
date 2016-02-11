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
    public class SexoAplicacao
    {
        private Contexto contexto;

        public Sexo ListarPorId(string ci_sexo)
        {
            using (contexto = new Contexto())
            {
                var strQuery = string.Format(" Select * from Sexo where ci_sexo = {0}", ci_sexo);
                var retornoDataReader = contexto.ExecutaComandoComRetorno(strQuery);
                return TransformaReaderEmListaDeObjeto(retornoDataReader).FirstOrDefault();
            }
        }

        public List<Sexo> ListarTodos()
        {
            using (contexto = new Contexto())
            {
                var strQuery = " Select * from Sexo ";
                var retornoDataReader = contexto.ExecutaComandoComRetorno(strQuery);
                return TransformaReaderEmListaDeObjeto(retornoDataReader);
            }
        }

        private List<Sexo> TransformaReaderEmListaDeObjeto(SqlDataReader reader)
        {
            var sexos = new List<Sexo>();
            while (reader.Read())
            {
                var temObjeto = new Sexo()
                {
                    ci_sexo = int.Parse(reader["ci_sexo"].ToString()),
                    dc_sexo = reader["dc_sexo"].ToString()
                };
                sexos.Add(temObjeto);
            }
            reader.Close();
            return sexos;
        }


    }
}
