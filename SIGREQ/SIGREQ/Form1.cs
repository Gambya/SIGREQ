using SIGREQ.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIGREQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            GerenciarRequisitosView telaGerenciarRequisitos = new GerenciarRequisitosView();
            telaGerenciarRequisitos.MdiParent = this;
            telaGerenciarRequisitos.Show();
        }

        private void criarRequisitoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.FileDialogProj.Title = "Novo Projeto";
            this.FileDialogProj.InitialDirectory = @"C:\";
            this.FileDialogProj.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            this.FileDialogProj.FilterIndex = 1;
            if (this.FileDialogProj.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void cadastrarRequisitoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CadRequisitosView telaCadRequisito = new CadRequisitosView();
            telaCadRequisito.MdiParent = this;
            telaCadRequisito.Show();
        }

        private void salvarProjetoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.FileDialogProjSave.Title = "Novo Projeto";
            this.FileDialogProjSave.InitialDirectory = @"C:\";
            this.FileDialogProjSave.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            this.FileDialogProjSave.FilterIndex = 1;
            if (this.FileDialogProjSave.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void sairESalvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gerenciarRequisitosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GerenciarRequisitosView telaGerenciarRequisitos = new GerenciarRequisitosView();
            telaGerenciarRequisitos.MdiParent = this;
            telaGerenciarRequisitos.Show();
        }

        private void btnCadStackHolder_Click(object sender, EventArgs e)
        {
            GerenciadorStackholderView telaGerenciadorStackholder = new GerenciadorStackholderView();
            telaGerenciadorStackholder.MdiParent = this;
            telaGerenciadorStackholder.Show();
        }

        private void gerenciarStackholderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GerenciadorStackholderView telaGerenciadorStackholder = new GerenciadorStackholderView();
            telaGerenciadorStackholder.MdiParent = this;
            telaGerenciadorStackholder.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            GerenciarTipoStackholder telaGerenciarTipoStackholder = new GerenciarTipoStackholder();
            telaGerenciarTipoStackholder.MdiParent = this;
            telaGerenciarTipoStackholder.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            GerenciarCronogramaView telaGerenciarCronograma = new GerenciarCronogramaView();
            telaGerenciarCronograma.MdiParent = this;
            telaGerenciarCronograma.Show();
        }

        private void cadastrarStackholderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadStackholderView telaCadStackholder = new CadStackholderView();
            telaCadStackholder.MdiParent = this;
            telaCadStackholder.Show();
        }

        private void cadastrarTiposDeStackholderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadTipoStackholderView telaCadTipoStackholder = new CadTipoStackholderView();
            telaCadTipoStackholder.MdiParent = this;
            telaCadTipoStackholder.Show();
        }

        private void gerenciarTiposDeStackholderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GerenciarTipoStackholder telaGerenciarTipoStackholder = new GerenciarTipoStackholder();
            telaGerenciarTipoStackholder.MdiParent = this;
            telaGerenciarTipoStackholder.Show();
        }

        private void novoCronogramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadCronogramaView telaCadCronogramaView = new CadCronogramaView();
            telaCadCronogramaView.MdiParent = this;
            telaCadCronogramaView.Show();
        }

        private void gerenciarCronogramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GerenciarCronogramaView telaGerenciarCronograma = new GerenciarCronogramaView();
            telaGerenciarCronograma.MdiParent = this;
            telaGerenciarCronograma.Show();
        }
    }
}
