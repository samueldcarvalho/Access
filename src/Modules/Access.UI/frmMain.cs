using System;
using System.Windows.Forms;
using Access.src.Modules.Access.DAL;

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
            if (string.IsNullOrEmpty(txt_buscar.Text) || string.IsNullOrWhiteSpace(txt_buscar.Text))
            {
                switch (pnl_busca.Visible)
                {
                    case true:
                        pnl_busca.Visible = false;
                        LimparFiltros();
                        break;
                    case false:
                        pnl_busca.Visible = true;
                        break;
                }
            }

            if (!string.IsNullOrEmpty(txt_buscar.Text) || !string.IsNullOrWhiteSpace(txt_buscar.Text) && pnl_buscar.Visible == true)
            {
                gridControl1.DataSource = _objpnl_BuscarDAL.ListarAcessos(txt_buscar.Text);
                txt_buscar.Text = "";
            }

            
        }

        public int VerificarCentralFilial()
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

        private void separatorControl4_Click(object sender, EventArgs e)
        {

        }
    }
}
