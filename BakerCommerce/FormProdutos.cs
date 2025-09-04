using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BakerCommerce
{
    public partial class FormProdutos : Form
    {
        Model.Usuario usuario;

        public FormProdutos(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void lblCategoriaCadastro_Click(object sender, EventArgs e)
        {

        }
    }
}
