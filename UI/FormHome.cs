using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditorDeTexto.UI
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            string busca = txtBusca.Text;
            string textoDoEditor = txtTextoArquivo.Text;
            int resultado = textoDoEditor.IndexOf(busca);
            if (resultado >= 0 && textoDoEditor != "")
            {
                MessageBox.Show("Texto encontrado: " + busca);
                btnReplace.Enabled = true;
                txtReplace.Enabled = true;
            }
            else
            {
                MessageBox.Show("Texto não encontrado!");
                btnReplace.Enabled = false;
                txtReplace.Enabled = false;
            }
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            string texto = txtTextoArquivo.Text;
            string replace = txtReplace.Text;
            string busca = txtBusca.Text;
            try
            {
                txtTextoArquivo.Text = texto.Replace(busca, replace);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro inesperado: " + ex.Message);
            }
            finally
            {
                txtBusca.Text = String.Empty;
                txtReplace.Text = String.Empty;
                btnReplace.Enabled = false;
                txtReplace.Enabled = false;
            }
        }

        private void btnCaixaAlta_Click(object sender, EventArgs e)
        {
            int inicioSelecao = txtTextoArquivo.SelectionStart;
            int tamanhoSelecao = txtTextoArquivo.SelectionLength;
            // agora vamos utilizar o Substring para pegar o texto selecionado
            string textoSelecionado = txtTextoArquivo.Text.Substring(inicioSelecao, tamanhoSelecao);
            // além do texto selecionado, precisamos do texto antes da seleção:
            string antes = txtTextoArquivo.Text.Substring(0, inicioSelecao);
            // e utambém do	texto depois
            string depois = txtTextoArquivo.Text.Substring(inicioSelecao + tamanhoSelecao);
            // E agora só precisamos redefinir o campo texto
            txtTextoArquivo.Text = antes + textoSelecionado.ToUpper() + depois;
        }

        private void btnCaixaBaixa_Click(object sender, EventArgs e)
        {
            int inicioSelecao = txtTextoArquivo.SelectionStart;
            int tamanhoSelecao = txtTextoArquivo.SelectionLength;
            // agora vamos utilizar o Substring para pegar o texto selecionado
            string textoSelecionado = txtTextoArquivo.Text.Substring(inicioSelecao, tamanhoSelecao);
            // além do texto selecionado, precisamos do texto antes da seleção:
            string antes = txtTextoArquivo.Text.Substring(0, inicioSelecao);
            // e utambém do	texto depois
            string depois = txtTextoArquivo.Text.Substring(inicioSelecao + tamanhoSelecao);
            // E agora só precisamos redefinir o campo texto
            txtTextoArquivo.Text = antes + textoSelecionado.ToLower() + depois;
        }

        private void btnLer_Click(object sender, EventArgs e)
        {
            txtTextoArquivo.Text = String.Empty;
            if (File.Exists("texto.txt"))
            {
                using (Stream arquivo = File.Open("texto.txt", FileMode.Open))
                using (StreamReader leitor = new StreamReader(arquivo))
                {
                    txtTextoArquivo.Text = leitor.ReadToEnd();
                }
            }
            else
                MessageBox.Show("Arquivo não encontrado!");
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            using (Stream arquivo = File.Open("texto.txt", FileMode.Create))
            using (StreamWriter escritor = new StreamWriter(arquivo))
            {
                escritor.Write(txtTextoArquivo.Text);
            }
            txtTextoArquivo.Text = String.Empty;
        }
    }
}
