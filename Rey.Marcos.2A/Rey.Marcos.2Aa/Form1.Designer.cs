﻿namespace Rey.Marcos._2Aa
{
    partial class Form1
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
            this.rtbSalida = new System.Windows.Forms.RichTextBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnPrueba = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbSalida
            // 
            this.rtbSalida.Location = new System.Drawing.Point(12, 148);
            this.rtbSalida.Name = "rtbSalida";
            this.rtbSalida.Size = new System.Drawing.Size(663, 482);
            this.rtbSalida.TabIndex = 0;
            this.rtbSalida.Text = "";
            this.rtbSalida.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(85, 61);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(499, 43);
            this.btnMostrar.TabIndex = 1;
            this.btnMostrar.Text = "Mostrar Salida Por Pantalla";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnPrueba
            // 
            this.btnPrueba.Location = new System.Drawing.Point(85, 12);
            this.btnPrueba.Name = "btnPrueba";
            this.btnPrueba.Size = new System.Drawing.Size(499, 43);
            this.btnPrueba.TabIndex = 2;
            this.btnPrueba.Text = "PruebaClase";
            this.btnPrueba.UseVisualStyleBackColor = true;
            this.btnPrueba.Click += new System.EventHandler(this.btnPrueba_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 642);
            this.Controls.Add(this.btnPrueba);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.rtbSalida);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbSalida;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnPrueba;
    }
}

