using eAgenda.Dominio.CompromissoModule;
using eAgenda.Dominio.ContatoModule;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAgenda.Controladores
{
     public class ControladorCompromisso : Controlador<Compromisso>
    {
        private readonly ControladorContato controladorContato =  new ControladorContato();
        #region Queries SQL
        private const string sqlInserir =
    @"INSERT INTO TBCOMPROMISSO
                (
                    [ASSUNTO],
                    [LOCAL],
                    [DATA],
                    [HORA_INICIO],
                    [HORA_TERMINO],
                    [LINK_ONLINE],
                    [ID_CONTATO]
                )
                VALUES
                (
                    @ASSUNTO,
                    @LOCAL,
                    @DATA,
                    @HORA_INICIO,
                    @HORA_TERMINO,
                    @LINK_ONLINE,
                    @ID_CONTATO
                );";

        private const string sqlEditar =
            @"UPDATE TBCOMPROMISSO
                SET
                    [ASSUNTO] = @ASSUNTO,
                    [LOCAL] = @LOCAL,
                    [LINK_REMOTO] = @LINK_REMOTO,
                    [DATA] = @DATA,
                    [HORA_INICIO] = @HORA_INICIO,
                    [HORA_TERMINO] = @HORA_TERMINO,
                    [LINK_ONLINE] = @LINK_ONLINE,
                    [ID_CONTATO] = @ID_CONTATO
                WHERE
                    [ID] = @ID";

        private const string sqlExcluir =
            @"DELETE FROM TBCOMPROMISSO	                
	        WHERE 
		        [ID] = @ID";

        private const string sqlSelecionarPorId =
            @"SELECT 
                C.[ASSUNTO], 
                C.[LOCAL], 
                C.[DATA],
                C.[HORA_INICIO],
                C.[HORA_TERMINO],
                C.[LINK_ONLINE],
                C.[ID_CONTATO]
            FROM 
                TBCOMPROMISSO
            WHERE 
                ID = @ID";

        private const string sqlSelecionarTodos =
            @"SELECT
                 CONP.[ID],
                 CONP.[ASSUNTO],
                 CONP.[LOCAL],
                 CONP.[DATA],
                 CONP.[HORA_INICIO],
                 CONP.[HORA_TERMINO],
                CONP.[LINK_ONLINE],
                CONP.[ID_CONTATO],
                 CONT.[NOME]
                FROM
                 TBCOMPROMISSO CONP LEFT JOIN
                 TBCONTATO CONT
                ON
                 CONT.ID = CONP.ID_CONTATO;";

        private const string sqlExiste =
            @"SELECT 
                COUNT(*) 
            FROM 
                TBCOMPROMISSO
            WHERE 
                [ID] = @ID";
        #endregion


        public override string InserirNovo(Compromisso registro)
        {
            string resultadoValidacao = registro.Validar();

            if (resultadoValidacao == "ESTA_VALIDO")
            {
                registro.Id = Db.Insert(sqlInserir, ObtemParametrosCompromisso(registro));
            }

            return resultadoValidacao;
        }

        public override string Editar(int id, Compromisso registro)
        {
            string resultadoValidacao = registro.Validar();

            if (resultadoValidacao == "ESTA_VALIDO")
            {
                registro.Id = id;
                Db.Update(sqlEditar, ObtemParametrosCompromisso(registro));
            }

            return resultadoValidacao;
        }

        public override bool Excluir(int id)
        {
            try
            {
                Db.Delete(sqlExcluir, AdicionarParametro("ID", id));
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public override bool Existe(int id)
        {
            return Db.Exists(sqlExiste, AdicionarParametro("ID", id));
        }

        public Compromisso SelecionarPorId(int id)
        {
            return Db.Get(sqlSelecionarTodos, ConverterEmCompromisso, AdicionarParametro("ID", id));
        }

        public override List<Compromisso> SelecionarTodos()
        {
            return Db.GetAll(sqlSelecionarTodos, ConverterEmCompromisso);
        }

        public List<Compromisso> SelecionarTodosQueJaOcorreram()
        {
            return SelecionarTodos().FindAll(x => x.Data + x.HoraTermino < DateTime.Now);
        }

        public List<Compromisso> SelecionarTodosQueVaoOcorrer()
        {
            return SelecionarTodos().FindAll(x => x.Data + x.HoraInicio > DateTime.Now);

        }

        private Compromisso ConverterEmCompromisso(IDataReader reader)
        {
            string assunto = Convert.ToString(reader["ASSUNTO"]);
            string local = Convert.ToString(reader["LOCAL"]);
            DateTime data = Convert.ToDateTime(reader["DATA"]);
            TimeSpan horaInicio = (TimeSpan)reader["HORA_INICIO"];
            TimeSpan horaTermino = (TimeSpan)reader["HORA_TERMINO"];
            string linkOnline = Convert.ToString(reader["LINK_ONLINE"]);
            int idContato;
            if (reader["ID_CONTATO"] == DBNull.Value)
                idContato = 0;
            else 
                idContato = Convert.ToInt32(reader["ID_CONTATO"]);
            Contato contato = null;
            if (controladorContato.Existe(idContato))
                contato = controladorContato.SelecionarPorId(idContato);
            Compromisso compromisso = new Compromisso(assunto, local, linkOnline, data, horaInicio, horaTermino, contato);
            compromisso.Id = Convert.ToInt32(reader["ID"]);
            
            return compromisso;
        }

        private Dictionary<string, object> ObtemParametrosCompromisso(Compromisso c)
        {
            var parametros = new Dictionary<string, object>();

            parametros.Add("ID", c.Id);
            parametros.Add("ASSUNTO", c.Assunto);
            parametros.Add("LOCAL", c.Local);
            parametros.Add("DATA", c.Data);
            parametros.Add("HORA_INICIO", c.HoraInicio);
            parametros.Add("HORA_TERMINO", c.HoraTermino);
            parametros.Add("LINK_ONLINE", c.LinkOnline);
            if (c.contato != null)
                parametros.Add("ID_CONTATO", c.contato.Id);
            else
                parametros.Add("ID_CONTATO", null);

            return parametros;
        }

        private static Dictionary<string, object> AdicionarParametro(string campo, int valor)
        {
            return new Dictionary<string, object>() { { campo, valor } };
        }
    }
}
