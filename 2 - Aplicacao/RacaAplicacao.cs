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
    public class RacaAplicacao
    {
        private Contexto contexto;

        public Raca ListarPorId(string ci_raca)
        {
            using (contexto = new Contexto())
            {
                var strQuery = string.Format(" Select * from Raca where ci_raca = {0}", ci_raca);
                var retornoDataReader = contexto.ExecutaComandoComRetorno(strQuery);
                return TransformaReaderEmListaDeObjeto(retornoDataReader).FirstOrDefault();
            }
        }

        public List<Raca> ListarTodos()
        {
            using (contexto = new Contexto())
            {
                var strQuery = " Select * from Raca ";
                var retornoDataReader = contexto.ExecutaComandoComRetorno(strQuery);
                return TransformaReaderEmListaDeObjeto(retornoDataReader);
            }
        }

        private List<Raca> TransformaReaderEmListaDeObjeto(SqlDataReader reader)
        {
            var racas = new List<Raca>();
            while (reader.Read())
            {
                var temObjeto = new Raca()
                {
                    ci_raca = int.Parse(reader["ci_raca"].ToString()),
                    dc_raca = reader["dc_raca"].ToString()
                };
                racas.Add(temObjeto);
            }
            reader.Close();
            return racas;
        }


    }
}
