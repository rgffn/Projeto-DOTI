using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOTI_Projeto
{
    public partial class frmCadServico : Form
    {
        public string funcao;
        string nome, empresa, empresa1, status, foto, foto1, foto2, foto3, desc, texto, atFoto, atFoto1, atFoto2, atFoto3;
        double valor;
        DateTime dataCad = DateTime.Now;
        DateTime horario;
        public int codigo;
        public int codigoEmpresa;
        public frmCadServico()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            frmServico servico = new frmServico();
            servico.Show();
            Close();
        }

        private void frmCadServico_Load(object sender, EventArgs e)
        {

        }
    }
}
