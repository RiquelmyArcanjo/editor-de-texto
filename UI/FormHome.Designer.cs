
namespace EditorDeTexto.UI
{
    partial class FormHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTextoArquivo = new System.Windows.Forms.TextBox();
            this.btnLer = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.grpFindReplace = new System.Windows.Forms.GroupBox();
            this.lblReplace = new System.Windows.Forms.Label();
            this.lblFind = new System.Windows.Forms.Label();
            this.btnReplace = new System.Windows.Forms.Button();
            this.btnBusca = new System.Windows.Forms.Button();
            this.txtReplace = new System.Windows.Forms.TextBox();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.grpFormatacao = new System.Windows.Forms.GroupBox();
            this.btnCaixaBaixa = new System.Windows.Forms.Button();
            this.btnCaixaAlta = new System.Windows.Forms.Button();
            this.grpFindReplace.SuspendLayout();
            this.grpFormatacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTextoArquivo
            // 
            this.txtTextoArquivo.Location = new System.Drawing.Point(90, 71);
            this.txtTextoArquivo.Multiline = true;
            this.txtTextoArquivo.Name = "txtTextoArquivo";
            this.txtTextoArquivo.Size = new System.Drawing.Size(767, 1026);
            this.txtTextoArquivo.TabIndex = 0;
            // 
            // btnLer
            // 
            this.btnLer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLer.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLer.Location = new System.Drawing.Point(303, 1123);
            this.btnLer.Name = "btnLer";
            this.btnLer.Size = new System.Drawing.Size(230, 78);
            this.btnLer.TabIndex = 1;
            this.btnLer.Text = "Ler arquivo";
            this.btnLer.UseVisualStyleBackColor = true;
            this.btnLer.Click += new System.EventHandler(this.btnLer_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGravar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGravar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGravar.Location = new System.Drawing.Point(590, 1123);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(267, 78);
            this.btnGravar.TabIndex = 2;
            this.btnGravar.Text = "Gravar arquivo";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // grpFindReplace
            // 
            this.grpFindReplace.Controls.Add(this.lblReplace);
            this.grpFindReplace.Controls.Add(this.lblFind);
            this.grpFindReplace.Controls.Add(this.btnReplace);
            this.grpFindReplace.Controls.Add(this.btnBusca);
            this.grpFindReplace.Controls.Add(this.txtReplace);
            this.grpFindReplace.Controls.Add(this.txtBusca);
            this.grpFindReplace.ForeColor = System.Drawing.Color.White;
            this.grpFindReplace.Location = new System.Drawing.Point(912, 71);
            this.grpFindReplace.Name = "grpFindReplace";
            this.grpFindReplace.Size = new System.Drawing.Size(761, 488);
            this.grpFindReplace.TabIndex = 3;
            this.grpFindReplace.TabStop = false;
            this.grpFindReplace.Text = "Find and Replace";
            // 
            // lblReplace
            // 
            this.lblReplace.AutoSize = true;
            this.lblReplace.Location = new System.Drawing.Point(88, 308);
            this.lblReplace.Name = "lblReplace";
            this.lblReplace.Size = new System.Drawing.Size(121, 41);
            this.lblReplace.TabIndex = 8;
            this.lblReplace.Text = "Replace";
            // 
            // lblFind
            // 
            this.lblFind.AutoSize = true;
            this.lblFind.Location = new System.Drawing.Point(88, 93);
            this.lblFind.Name = "lblFind";
            this.lblFind.Size = new System.Drawing.Size(75, 41);
            this.lblFind.TabIndex = 7;
            this.lblFind.Text = "Find";
            // 
            // btnReplace
            // 
            this.btnReplace.BackColor = System.Drawing.Color.LightGray;
            this.btnReplace.Enabled = false;
            this.btnReplace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReplace.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReplace.ForeColor = System.Drawing.Color.Black;
            this.btnReplace.Location = new System.Drawing.Point(325, 376);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(357, 58);
            this.btnReplace.TabIndex = 6;
            this.btnReplace.Text = "Replace";
            this.btnReplace.UseVisualStyleBackColor = false;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // btnBusca
            // 
            this.btnBusca.BackColor = System.Drawing.Color.LightGray;
            this.btnBusca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusca.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBusca.ForeColor = System.Drawing.Color.Black;
            this.btnBusca.Location = new System.Drawing.Point(325, 166);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(357, 58);
            this.btnBusca.TabIndex = 5;
            this.btnBusca.Text = "Find";
            this.btnBusca.UseVisualStyleBackColor = false;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // txtReplace
            // 
            this.txtReplace.Enabled = false;
            this.txtReplace.Location = new System.Drawing.Point(325, 302);
            this.txtReplace.Name = "txtReplace";
            this.txtReplace.Size = new System.Drawing.Size(357, 47);
            this.txtReplace.TabIndex = 1;
            // 
            // txtBusca
            // 
            this.txtBusca.Location = new System.Drawing.Point(325, 93);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(357, 47);
            this.txtBusca.TabIndex = 0;
            // 
            // grpFormatacao
            // 
            this.grpFormatacao.Controls.Add(this.btnCaixaBaixa);
            this.grpFormatacao.Controls.Add(this.btnCaixaAlta);
            this.grpFormatacao.ForeColor = System.Drawing.Color.White;
            this.grpFormatacao.Location = new System.Drawing.Point(912, 786);
            this.grpFormatacao.Name = "grpFormatacao";
            this.grpFormatacao.Size = new System.Drawing.Size(761, 311);
            this.grpFormatacao.TabIndex = 4;
            this.grpFormatacao.TabStop = false;
            this.grpFormatacao.Text = "Formatação";
            // 
            // btnCaixaBaixa
            // 
            this.btnCaixaBaixa.BackColor = System.Drawing.Color.LightGray;
            this.btnCaixaBaixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaixaBaixa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCaixaBaixa.ForeColor = System.Drawing.Color.Black;
            this.btnCaixaBaixa.Location = new System.Drawing.Point(406, 135);
            this.btnCaixaBaixa.Name = "btnCaixaBaixa";
            this.btnCaixaBaixa.Size = new System.Drawing.Size(309, 78);
            this.btnCaixaBaixa.TabIndex = 6;
            this.btnCaixaBaixa.Text = "caixa baixa";
            this.btnCaixaBaixa.UseVisualStyleBackColor = false;
            this.btnCaixaBaixa.Click += new System.EventHandler(this.btnCaixaBaixa_Click);
            // 
            // btnCaixaAlta
            // 
            this.btnCaixaAlta.BackColor = System.Drawing.Color.LightGray;
            this.btnCaixaAlta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaixaAlta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCaixaAlta.ForeColor = System.Drawing.Color.Black;
            this.btnCaixaAlta.Location = new System.Drawing.Point(47, 135);
            this.btnCaixaAlta.Name = "btnCaixaAlta";
            this.btnCaixaAlta.Size = new System.Drawing.Size(309, 78);
            this.btnCaixaAlta.TabIndex = 5;
            this.btnCaixaAlta.Text = "CAIXA ALTA";
            this.btnCaixaAlta.UseVisualStyleBackColor = false;
            this.btnCaixaAlta.Click += new System.EventHandler(this.btnCaixaAlta_Click);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(1776, 1282);
            this.Controls.Add(this.grpFormatacao);
            this.Controls.Add(this.grpFindReplace);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnLer);
            this.Controls.Add(this.txtTextoArquivo);
            this.Name = "FormHome";
            this.Text = "Editor de Texto";
            this.grpFindReplace.ResumeLayout(false);
            this.grpFindReplace.PerformLayout();
            this.grpFormatacao.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTextoArquivo;
        private System.Windows.Forms.Button btnLer;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.GroupBox grpFindReplace;
        private System.Windows.Forms.Label lblReplace;
        private System.Windows.Forms.Label lblFind;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Button btnBusca;
        private System.Windows.Forms.TextBox txtReplace;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.GroupBox grpFormatacao;
        private System.Windows.Forms.Button btnCaixaBaixa;
        private System.Windows.Forms.Button btnCaixaAlta;
    }
}