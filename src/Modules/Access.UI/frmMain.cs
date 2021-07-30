using System;
using System.Data;
using System.Windows.Forms;
using Access.src.Modules.Access.DAL;
using DevExpress.XtraGrid.Views.Grid;

namespace frm_Main
{
    public partial class frmMain : Form
    {
        public pnl_BuscarDAL _objpnl_BuscarDAL = new pnl_BuscarDAL();
        public frmMain()
        {
            InitializeComponent();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (pnl_busca.Visible == false)
            {
                pnl_busca.Visible = true;
                txt_buscar.Focus();
                return;
            }
            gridControl_Busca.DataSource = _objpnl_BuscarDAL.ListarAcessos(txt_buscar.Text, ckbox_busca_rede.Checked, VerificarFiltroServidor());
            txt_buscar.Text = "";
            txt_buscar.Focus();
            
        }

        public int VerificarFiltroServidor()
        {
            int numRef = 0;

            if (rdbtn_busca_central.Checked == true)
                numRef = 1;
            if (rdbtn_busca_filial.Checked == true)
                numRef = 2;
            if (rdbtn_busca_central.Checked == false && rdbtn_busca_filial.Checked == false)
                numRef = 0;
            return numRef;
        }

        public void LimparFiltros()
        {
            txt_buscar.Text = "";
            rdbtn_busca_central.Checked = false;
            rdbtn_busca_filial.Checked = false;
            ckbox_busca_rede.Checked = false;
            return;
        }

        private void gridView_Buscar_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            int countLines = gridView_Buscar.SelectedRowsCount;

            if (countLines > 0)
            {
                DataTable dt = new DataTable();
                var getId = gridView_Buscar.GetFocusedRowCellValue(gridColumn_key);
                //slcId = dgv.SelectedRows[0].Cells[0].ToString();
                dt = _objpnl_BuscarDAL.ObterInformacoes((int)getId);

                lbl_filicodigo.Text = dt.Rows[0].Field<Int32>("codigo_filial_automatiza").ToString();
                txt_nome_rede.Text = dt.Rows[0].Field<string>("rede_nome");
                txt_nome_filial.Text = dt.Rows[0].Field<string>("filial_nome");
                txt_id_acesso.Text = dt.Rows[0].Field<string>("filial_id_acesso");
                txt_senha_acesso.Text = dt.Rows[0].Field<string>("filial_senha_acesso");
                txt_tipo_acesso.Text = dt.Rows[0].Field<string>("filial_tipo_acesso");
                ckbox_Central.Checked = Convert.ToBoolean(dt.Rows[0].Field<int>("filial_central"));
            }
        }

    }
    }
