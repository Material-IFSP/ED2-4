﻿
namespace AppAtendimentoFilas
{
    partial class Atendimentos
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGerar = new System.Windows.Forms.Button();
            this.btnListarSenhas = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnChamar = new System.Windows.Forms.Button();
            this.btnListarAtendimentos = new System.Windows.Forms.Button();
            this.lbxFilaSenhas = new System.Windows.Forms.ListBox();
            this.lbxFilaAtendimentos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblQtdeGuiches = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGuiches = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGerar
            // 
            this.btnGerar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerar.Location = new System.Drawing.Point(79, 12);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(87, 31);
            this.btnGerar.TabIndex = 0;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // btnListarSenhas
            // 
            this.btnListarSenhas.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnListarSenhas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarSenhas.Location = new System.Drawing.Point(44, 267);
            this.btnListarSenhas.Name = "btnListarSenhas";
            this.btnListarSenhas.Size = new System.Drawing.Size(162, 31);
            this.btnListarSenhas.TabIndex = 0;
            this.btnListarSenhas.Text = "Listar senhas";
            this.btnListarSenhas.UseVisualStyleBackColor = true;
            this.btnListarSenhas.Click += new System.EventHandler(this.btnListarSenhas_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.Transparent;
            this.btnAdicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(288, 175);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAdicionar.Size = new System.Drawing.Size(95, 26);
            this.btnAdicionar.TabIndex = 0;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnChamar
            // 
            this.btnChamar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnChamar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChamar.Location = new System.Drawing.Point(660, 12);
            this.btnChamar.Name = "btnChamar";
            this.btnChamar.Size = new System.Drawing.Size(87, 31);
            this.btnChamar.TabIndex = 0;
            this.btnChamar.Text = "Chamar";
            this.btnChamar.UseVisualStyleBackColor = true;
            this.btnChamar.Click += new System.EventHandler(this.btnChamar_Click);
            // 
            // btnListarAtendimentos
            // 
            this.btnListarAtendimentos.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnListarAtendimentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarAtendimentos.Location = new System.Drawing.Point(466, 267);
            this.btnListarAtendimentos.Name = "btnListarAtendimentos";
            this.btnListarAtendimentos.Size = new System.Drawing.Size(266, 31);
            this.btnListarAtendimentos.TabIndex = 0;
            this.btnListarAtendimentos.Text = "Listar atendimentos";
            this.btnListarAtendimentos.UseVisualStyleBackColor = true;
            this.btnListarAtendimentos.Click += new System.EventHandler(this.btnListarAtendimentos_Click);
            // 
            // lbxFilaSenhas
            // 
            this.lbxFilaSenhas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxFilaSenhas.FormattingEnabled = true;
            this.lbxFilaSenhas.ItemHeight = 20;
            this.lbxFilaSenhas.Location = new System.Drawing.Point(3, 49);
            this.lbxFilaSenhas.Name = "lbxFilaSenhas";
            this.lbxFilaSenhas.Size = new System.Drawing.Size(250, 204);
            this.lbxFilaSenhas.TabIndex = 1;
            // 
            // lbxFilaAtendimentos
            // 
            this.lbxFilaAtendimentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxFilaAtendimentos.FormattingEnabled = true;
            this.lbxFilaAtendimentos.ItemHeight = 18;
            this.lbxFilaAtendimentos.Location = new System.Drawing.Point(418, 49);
            this.lbxFilaAtendimentos.Name = "lbxFilaAtendimentos";
            this.lbxFilaAtendimentos.Size = new System.Drawing.Size(356, 202);
            this.lbxFilaAtendimentos.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(275, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Qtde guichês";
            // 
            // lblQtdeGuiches
            // 
            this.lblQtdeGuiches.AutoSize = true;
            this.lblQtdeGuiches.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdeGuiches.Location = new System.Drawing.Point(316, 130);
            this.lblQtdeGuiches.Name = "lblQtdeGuiches";
            this.lblQtdeGuiches.Size = new System.Drawing.Size(32, 33);
            this.lblQtdeGuiches.TabIndex = 0;
            this.lblQtdeGuiches.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(436, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Guiche:";
            // 
            // txtGuiches
            // 
            this.txtGuiches.Location = new System.Drawing.Point(506, 17);
            this.txtGuiches.Name = "txtGuiches";
            this.txtGuiches.Size = new System.Drawing.Size(100, 20);
            this.txtGuiches.TabIndex = 3;
            this.txtGuiches.Text = "0";
            // 
            // Atendimentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(783, 307);
            this.Controls.Add(this.txtGuiches);
            this.Controls.Add(this.lblQtdeGuiches);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbxFilaAtendimentos);
            this.Controls.Add(this.lbxFilaSenhas);
            this.Controls.Add(this.btnListarSenhas);
            this.Controls.Add(this.btnListarAtendimentos);
            this.Controls.Add(this.btnChamar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnGerar);
            this.MaximumSize = new System.Drawing.Size(799, 346);
            this.MinimumSize = new System.Drawing.Size(799, 346);
            this.Name = "Atendimentos";
            this.Text = "Fila de Atendimentos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Button btnListarSenhas;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnChamar;
        private System.Windows.Forms.Button btnListarAtendimentos;
        private System.Windows.Forms.ListBox lbxFilaSenhas;
        private System.Windows.Forms.ListBox lbxFilaAtendimentos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblQtdeGuiches;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGuiches;
    }
}

