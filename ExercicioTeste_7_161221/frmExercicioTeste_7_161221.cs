using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;
using Preferencias_BLL;

namespace ExercicioTeste_7_161221
{
    public partial class frmExercicioTeste_7_161221 : Form
    {
        StreamReader objLeitor;
        string strValorAnitgo, strLinhaLida;
        OleDbCommand objComando;
        OleDbConnection objConexao;
        OleDbDataAdapter objAdaptador;
        OleDbDataReader objLeitorBd;

        DataTable objTabela;
        bool bolPreferenciaInserida;

        Preferencias objPreferencias;

        public frmExercicioTeste_7_161221()
        {
            InitializeComponent();
        }

        private void btnDesvCond_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Eescolha ok ou cancelar", "Desvio condicional", MessageBoxButtons.OK) == DialogResult.OK)
            {
                MessageBox.Show("Você escolheu ok");
            }
            else
            {
                MessageBox.Show("Você escolheu cancelar");

            }
        }

        private void btnImpTxt_Click(object sender, EventArgs e)
        {
            objPreferencias = new Preferencias();
            lstbxPreferencias.Items.AddRange(objPreferencias.ImportarTextoWhile().ToArray());
        }

        private void btnImpBdCon_Click(object sender, EventArgs e)
        {
            ImpBdCon();
        }
        public void ImpBdCon()
        {
            lstbxPreferencias.Items.Clear();
            objPreferencias = new Preferencias();
            lstbxPreferencias.Items.AddRange(objPreferencias.ImportarBancoDeDadosConectado().ToArray());
        }
        private void btnImpBdDesc_Click(object sender, EventArgs e)
        {
            ImpBdDesc();
        }
        public void ImpBdDesc()
        {
            lstbxPreferencias.Items.Clear();
            objPreferencias = new Preferencias();
            lstbxPreferencias.Items.AddRange(objPreferencias.ImportarBancoDeDadosDesconectado().ToArray());
        }

        private void btnConsBd_Click(object sender, EventArgs e)
        {
            ConsBd();
        }
        public void ConsBd(string strParDescricao = null)
        {
            objPreferencias = new Preferencias();
            bndsrc.DataSource = objPreferencias.ConsultarBancoDeDados(strParDescricao);
            dtgdvwPrefenrecias.DataSource = bndsrc;
        }

        private void btnIncBd_Click(object sender, EventArgs e)
        {
            IncBd(dtgdvwPrefenrecias.CurrentCell.Value.ToString());
        }
        public void IncBd(string strValorAntigo)
        {
            objPreferencias = new Preferencias();


            if (objPreferencias.IncBd(strValorAntigo))
            {
                MessageBox.Show("Preferencias Inclusa");
            }
            else
            {
                MessageBox.Show("erro");

            }
        }

        private void frmExercicioTeste_7_161221_Load(object sender, EventArgs e)
        {
            ConsBd();
        }

        private void btnExcBd_Click(object sender, EventArgs e)
        {
            ExcBd(dtgdvwPrefenrecias.CurrentCell.Value.ToString());
        }
        public void ExcBd(string strValorAntigo)
        {
            objPreferencias = new Preferencias();

            if (objPreferencias.ExcBd(strValorAntigo))
            {
                MessageBox.Show("Preferencias exclusa");
            }
            else
            {
                MessageBox.Show("erro");
            }
        }

        private void dtgdvwPrefenrecias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            strValorAnitgo = dtgdvwPrefenrecias.CurrentCell.Value.ToString();
        }

        private void btnAltBd_Click(object sender, EventArgs e)
        {
            AltBd(strValorAnitgo, dtgdvwPrefenrecias.CurrentCell.EditedFormattedValue.ToString());
        }
        public void AltBd(string strValorAntigo, string strValorNovo)
        {
            objPreferencias = new Preferencias();

            if (objPreferencias.AltBd(strValorAntigo, strValorNovo))
            {
                MessageBox.Show("Preferencias alterada");
            }
            else
            {
                MessageBox.Show("erro");

            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            bolPreferenciaInserida = true; ;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir a preferencia " + strValorAnitgo + "?", "Exclusão no banco de dados", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                ExcBd(strValorAnitgo);
            }
        }

        private void bndndBtnPesqPref_Click(object sender, EventArgs e)
        {
            ConsBd(bndndTxtPesqPref.Text);
        }

        private void bndnvBtnIncPref_Click(object sender, EventArgs e)
        {
            if (bolPreferenciaInserida)
            {
                if (MessageBox.Show("Deseja incluir " + dtgdvwPrefenrecias.CurrentCell.EditedFormattedValue.ToString(), "Inclusão no banco de dados", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    IncBd(dtgdvwPrefenrecias.CurrentCell.EditedFormattedValue.ToString());
                }
                bolPreferenciaInserida = false;
            }
            else
            {
                if (MessageBox.Show("Deseja alterar a preferencia " + strValorAnitgo + " por" + dtgdvwPrefenrecias.CurrentCell.EditedFormattedValue.ToString(), "Alteração no banco de dados", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    AltBd(strValorAnitgo, dtgdvwPrefenrecias.CurrentCell.EditedFormattedValue.ToString());
                }
            }
        }

        private void bndnv_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
