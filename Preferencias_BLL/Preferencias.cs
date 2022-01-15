using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.IO;
using System.Data;

namespace Preferencias_BLL
{
    public class Preferencias
    {
        StreamReader objLeitor;
        string strValorAntigo, strLinhaLida;
        OleDbCommand objComando;
        OleDbConnection objConexao;
        OleDbDataAdapter objAdaptador;
        OleDbDataReader objLeitorBd;

        DataTable objTabela;

        public List<string> ImportarTextoWhile()
        {
            List<string> Resultado = new List<string>();

            objLeitor = new StreamReader(@"C:\Users\Ygor_\Downloads\Cursoprogramacao-20210708T203728Z-001\Cursoprogramacao\Preferencias.txt");
            strLinhaLida = objLeitor.ReadLine();

            while (strLinhaLida != null)
            {
                Resultado.Add(strLinhaLida);
                strLinhaLida = objLeitor.ReadLine();
            }
            objLeitor.Close();
            return Resultado;
        }
        public List<string> ImportarBancoDeDadosConectado()
        {
            List<string> Resultado = new List<string>();

            objConexao = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Ygor_\Downloads\Cursoprogramacao-20210708T203728Z-001\Cursoprogramacao\Preferencias_3.accdb");
            objConexao.Open();

            objComando = new OleDbCommand("select Descricao from Preferencias_3", objConexao);

            objLeitorBd = objComando.ExecuteReader();

            while (objLeitorBd.Read())
            {
                Resultado.Add(objLeitorBd["Descricao"].ToString());
            }
            objConexao.Close();
            objLeitorBd.Close();
            return Resultado;
        }
        public List<string> ImportarBancoDeDadosDesconectado()
        {
            List<string> Resultado = new List<string>();

            objConexao = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Ygor_\Downloads\Cursoprogramacao-20210708T203728Z-001\Cursoprogramacao\Preferencias_3.accdb");

            objComando = new OleDbCommand("select Descricao from Preferencias_3", objConexao);

            objAdaptador = new OleDbDataAdapter(objComando);

            objTabela = new DataTable();
            objAdaptador.Fill(objTabela);

            foreach (DataRow LinhTabela in objTabela.Rows)
            {
                Resultado.Add(LinhTabela["Descricao"].ToString());
            }
            return Resultado;
        }
        public DataTable ConsultarBancoDeDados(string strParDescricao = null)
        {
            objConexao = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Ygor_\Downloads\Cursoprogramacao-20210708T203728Z-001\Cursoprogramacao\Preferencias_3.accdb");

            objComando = new OleDbCommand();
            objComando.Connection = objConexao;

            if (string.IsNullOrEmpty(strParDescricao))
            {
                objComando.CommandText = "select Descricao from Preferencias_3";
            }
            else
            {
                objComando.CommandText = "select Descricao from Preferencias_3 where Descricao= '" + strParDescricao + "'";
            }
            objAdaptador = new OleDbDataAdapter(objComando);

            objTabela = new DataTable();
            objAdaptador.Fill(objTabela);

            return objTabela;
        }
        public bool IncBd(string strValorAntigo)
        {
            bool Resultado = false;

            objConexao = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Ygor_\Downloads\Cursoprogramacao-20210708T203728Z-001\Cursoprogramacao\Preferencias_3.accdb");
            objConexao.Open();

            objComando = new OleDbCommand("insert into Preferencias_3 (Descricao) values ('" + strValorAntigo + "')", objConexao);

            if (objComando.ExecuteNonQuery() > 0)
            {
                Resultado = true;
            }
            else
            {
                Resultado = false;

            }
            objConexao.Close();
            return Resultado;
        }
        public bool ExcBd(string strValorAntigo)
        {
            bool Resultado = false;

            objConexao = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Ygor_\Downloads\Cursoprogramacao-20210708T203728Z-001\Cursoprogramacao\Preferencias_3.accdb");
            objConexao.Open();

            objComando = new OleDbCommand("delete Descricao from Preferencias_3 where Descricao= ('" + strValorAntigo + "')", objConexao);

            if (objComando.ExecuteNonQuery() > 0)
            {
                Resultado = true;
            }
            else
            {
                Resultado = false;
            }
            objConexao.Close();
            return Resultado;
        }
        public bool AltBd(string strValorAntigo, string strValorNovo)
        {
            bool Resultado = false;

            objConexao = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Ygor_\Downloads\Cursoprogramacao-20210708T203728Z-001\Cursoprogramacao\Preferencias_3.accdb");
            objConexao.Open();

            objComando = new OleDbCommand("update Preferencias_3 set Descricao= '" + strValorNovo + "' where Descricao= ('" + strValorAntigo + "')", objConexao);

            if (objComando.ExecuteNonQuery() > 0)
            {
                Resultado = true;
            }
            else
            {
                Resultado = false;
            }
            objConexao.Close();
            return Resultado;
        }
    }
}
