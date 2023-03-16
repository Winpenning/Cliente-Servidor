using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Escola.controller;
using Escola.model;
using Escola.view;
namespace Escola.view
{
    public partial class FAluno : Form
    {
        public FAluno()
        {
            InitializeComponent();
        }

        public void desabilitarcampos()
        {
            dataaddres.Enabled = false;
            dataarea.Enabled = false;
            datacell.Enabled = false;
            datacep.Enabled = false;
            datacity.Enabled = false;
            datacpf.Enabled = false;
            dataemail.Enabled = false;
            datafu.Enabled = false;
            dataid.Enabled = false;
            dataname.Enabled = false;
            datanumber.Enabled = false;
            datarg.Enabled = false;
        }
        public void habilitarcampos()
        {
            dataaddres.Enabled = true;
            dataarea.Enabled = true;
            datacell.Enabled = true;
            datacep.Enabled = true;
            datacity.Enabled = true;
            datacpf.Enabled = true;
            dataemail.Enabled = true;
            datafu.Enabled = true;
            dataid.Enabled = false;
            dataname.Enabled = true;
            datanumber.Enabled = true;
            datarg.Enabled = true;
        }
        public void limparcampos()
        {
            dataaddres.Text = String.Empty;
            dataarea.Text = String.Empty;
            datacell.Text = String.Empty;
            datacep.Text = String.Empty;
            datacity.Text = String.Empty;
            datacpf.Text = String.Empty;
            dataemail.Text = String.Empty;
            datafu.Text = String.Empty;
            dataid.Text = String.Empty;
            dataname.Text = String.Empty;
            datanumber.Text = String.Empty;
            datarg.Text = String.Empty;
            dataname.Focus();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            habilitarcampos();
            limparcampos();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FAluno_Load(object sender, EventArgs e)
        {
            desabilitarcampos();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void botaosalvar_Click(object sender, EventArgs e)
        {
            Aluno obj = new Aluno();
            obj.nome = dataname.Text;
            obj.rg = datarg.Text;
            obj.cpf = datacpf.Text;
            obj.email = dataemail.Text;
            obj.uf = datafu.Text;
            obj.cep = datacep.Text;
            obj.celular = datacell.Text;
            obj.bairro = dataarea.Text;
            obj.cidade = datacity.Text;
            obj.numero = datanumber.Text;
            obj.endereco = dataaddres.Text;

            AlunoController controller = new AlunoController();
            controller.cadaastrarAluno(obj);
        }
    }
}
