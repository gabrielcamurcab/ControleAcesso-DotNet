using System;
using System.IO;
using System.Windows.Forms;

namespace ControleAcesso
{
    partial class Form1 : Form
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        /// 
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            using (StreamWriter stwArquivo = new StreamWriter("Dados.txt", true))
            {
                stwArquivo.WriteLine(txtCPF.Text);
                txtCPF.Clear();
            }
        }

        private void btnCarregarAcesso_Click(object sender, EventArgs e)
        {
            string strLinha;
            txtControleAcesso.Clear();
            using (StreamReader stwArquivo = new StreamReader("Dados.txt"))
            {
                while ((strLinha = stwArquivo.ReadLine()) != null)
                {
                    txtControleAcesso.Text += strLinha + "\r\n";
                }
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtCPF.Text == "")
            {
                MessageBox.Show("Informe o CPF para busca.");
            }
            else
            {
                string strLinha;
                using (StreamReader stwArquivo = new StreamReader("Dados.txt"))
                {
                    while ((strLinha = stwArquivo.ReadLine()) != null)
                    {
                        if (strLinha.Contains(txtCPF.Text))
                        {
                            MessageBox.Show("CPF encontrado no arquivo.");
                        }
                    }
                }
            }
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtControleAcesso = new System.Windows.Forms.TextBox();
            this.btnCarregarAcesso = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPF:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCPF
            // 
            this.txtCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPF.Location = new System.Drawing.Point(66, 18);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(295, 26);
            this.txtCPF.TabIndex = 1;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(367, 16);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(102, 30);
            this.btnRegistrar.TabIndex = 2;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(475, 16);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(102, 30);
            this.btnPesquisar.TabIndex = 3;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Controle de acesso";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtControleAcesso
            // 
            this.txtControleAcesso.Location = new System.Drawing.Point(16, 99);
            this.txtControleAcesso.Multiline = true;
            this.txtControleAcesso.Name = "txtControleAcesso";
            this.txtControleAcesso.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtControleAcesso.Size = new System.Drawing.Size(561, 298);
            this.txtControleAcesso.TabIndex = 5;
            // 
            // btnCarregarAcesso
            // 
            this.btnCarregarAcesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarregarAcesso.Location = new System.Drawing.Point(16, 408);
            this.btnCarregarAcesso.Name = "btnCarregarAcesso";
            this.btnCarregarAcesso.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnCarregarAcesso.Size = new System.Drawing.Size(561, 30);
            this.btnCarregarAcesso.TabIndex = 6;
            this.btnCarregarAcesso.Text = "Carregar controle de acesso";
            this.btnCarregarAcesso.UseVisualStyleBackColor = true;
            this.btnCarregarAcesso.Click += new System.EventHandler(this.btnCarregarAcesso_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 450);
            this.Controls.Add(this.btnCarregarAcesso);
            this.Controls.Add(this.txtControleAcesso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Controle de Acesso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtControleAcesso;
        private System.Windows.Forms.Button btnCarregarAcesso;
    }
}

