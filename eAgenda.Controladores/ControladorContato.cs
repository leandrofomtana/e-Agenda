using eAgenda.Dominio;
using eAgenda.Dominio.ContatoModule;
using System;
using System.Collections.Generic;
using System.Data;

namespace eAgenda.Controladores
{
    public class ControladorContato : Controlador<Contato>
    {
        #region Queries
        private const string sqlInserir =
            @"INSERT INTO TBCONTATO
                    (
                        [NOME],
                        [EMAIL],
                        [TELEFONE],
                        [EMPRESA],
                        [CARGO]
                    )
                    VALUES
                    (
                        @NOME,
                        @EMAIL,
                        @TELEFONE,
                        @EMPRESA,
                        @CARGO
                    );";

        private const string sqlEditar =
            @"UPDATE TBCONTATO
            SET
                [NOME] = @NOME,
                [EMAIL] = @EMAIL,
                [TELEFONE] = @TELEFONE,
                [EMPRESA] = @EMPRESA,
                [CARGO] = @CARGO
            WHERE
                [ID] = @ID";

        private const string sqlExcluir =
            @"DELETE FROM TBCONTATO	                
	                WHERE 
		                [ID] = @ID";

        private const string sqlSelecionarTodos =
            @"SELECT 
                   [ID], 
                   [NOME], 
                   [EMAIL], 
                   [TELEFONE], 
                   [EMPRESA], 
                   [CARGO] 
                    FROM 
                   TBCONTATO
                    ORDER BY
                   [CARGO]";

        private const string sqlSelecaoPorId =
            @"SELECT 
                        [ID], 
                        [NOME], 
                        [EMAIL],
                        [TELEFONE],
                        [EMPRESA],
                        [CARGO]
                    FROM 
                        TBCONTATO
                    WHERE 
                        ID = @ID";

        private const string sqlExiste =
            @"SELECT 
                COUNT(*) 
            FROM 
                TBCONTATO
            WHERE 
                [ID] = @ID";

        #endregion

        public override string InserirNovo(Contato registro)
        {
            string resultadoValidacao = registro.Validar();

            if (resultadoValidacao == "ESTA_VALIDO")
            {
                registro.Id = Db.Insert(sqlInserir, ObtemParametrosContato(registro));
            }

            return resultadoValidacao;
        }

        public override string Editar(int id, Contato registro)
        {
            string resultadoValidacao = registro.Validar();

            if (resultadoValidacao == "ESTA_VALIDO")
            {
                registro.Id = id;
                Db.Update(sqlEditar, ObtemParametrosContato(registro));
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

        public Contato SelecionarPorId(int id)
        {
            return Db.Get(sqlSelecaoPorId, ConverterEmContato, AdicionarParametro("ID", id));
        }

        public override List<Contato> SelecionarTodos()
        {
            return Db.GetAll(sqlSelecionarTodos, ConverterEmContato);
        }

        private Contato ConverterEmContato(IDataReader reader)
        {
            string nome = Convert.ToString(reader["NOME"]);
            string email = Convert.ToString(reader["EMAIL"]);
            string telefone = Convert.ToString(reader["TELEFONE"]);
            string empresa = Convert.ToString(reader["EMPRESA"]);
            string cargo = Convert.ToString(reader["CARGO"]);

            Contato contato = new Contato(nome, email, telefone, empresa, cargo);

            contato.Id = Convert.ToInt32(reader["ID"]);

            return contato;
        }

        private Dictionary<string, object> ObtemParametrosContato(Contato contato)
        {
            var parametros = new Dictionary<string, object>();

            parametros.Add("ID", contato.Id);
            parametros.Add("NOME", contato.Nome);
            parametros.Add("EMAIL", contato.Email);
            parametros.Add("TELEFONE", contato.Telefone);
            parametros.Add("EMPRESA", contato.Empresa);
            parametros.Add("CARGO", contato.Cargo);

            return parametros;
        }

        private static Dictionary<string, object> AdicionarParametro(string campo, int valor)
        {
            return new Dictionary<string, object>() { { campo, valor } };
        }
    }
}