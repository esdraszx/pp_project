﻿namespace UI
{
    partial class Consulta_Usuario
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
            this.dgConsultaUsuario = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ConsultaUsuario_Eliminar = new System.Windows.Forms.Button();
            this.txt_ConsultaUsuario_ID = new System.Windows.Forms.TextBox();
            this.btn_Agregar_Usuario = new System.Windows.Forms.Button();
            this.txt_ConsultaUsuario_DNI = new System.Windows.Forms.TextBox();
            this.btn_Actualizar_Usuario = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_ConsultaUsuario_Consultar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgConsultaUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // dgConsultaUsuario
            // 
            this.dgConsultaUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgConsultaUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgConsultaUsuario.Location = new System.Drawing.Point(58, 111);
            this.dgConsultaUsuario.Name = "dgConsultaUsuario";
            this.dgConsultaUsuario.Size = new System.Drawing.Size(565, 248);
            this.dgConsultaUsuario.TabIndex = 38;
            this.dgConsultaUsuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgConsultaUsuario_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(84, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 24);
            this.label1.TabIndex = 36;
            this.label1.Text = "DNI";
            // 
            // btn_ConsultaUsuario_Eliminar
            // 
            this.btn_ConsultaUsuario_Eliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ConsultaUsuario_Eliminar.BackColor = System.Drawing.Color.Tomato;
            this.btn_ConsultaUsuario_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ConsultaUsuario_Eliminar.ForeColor = System.Drawing.Color.White;
            this.btn_ConsultaUsuario_Eliminar.Location = new System.Drawing.Point(668, 317);
            this.btn_ConsultaUsuario_Eliminar.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btn_ConsultaUsuario_Eliminar.Name = "btn_ConsultaUsuario_Eliminar";
            this.btn_ConsultaUsuario_Eliminar.Size = new System.Drawing.Size(177, 42);
            this.btn_ConsultaUsuario_Eliminar.TabIndex = 34;
            this.btn_ConsultaUsuario_Eliminar.Text = "Eliminar";
            this.btn_ConsultaUsuario_Eliminar.UseVisualStyleBackColor = false;
            this.btn_ConsultaUsuario_Eliminar.Click += new System.EventHandler(this.btn_ConsultaUsuario_Eliminar_Click);
            // 
            // txt_ConsultaUsuario_ID
            // 
            this.txt_ConsultaUsuario_ID.Location = new System.Drawing.Point(423, 37);
            this.txt_ConsultaUsuario_ID.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txt_ConsultaUsuario_ID.Name = "txt_ConsultaUsuario_ID";
            this.txt_ConsultaUsuario_ID.Size = new System.Drawing.Size(169, 20);
            this.txt_ConsultaUsuario_ID.TabIndex = 33;
            // 
            // btn_Agregar_Usuario
            // 
            this.btn_Agregar_Usuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Agregar_Usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btn_Agregar_Usuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Agregar_Usuario.ForeColor = System.Drawing.Color.White;
            this.btn_Agregar_Usuario.Location = new System.Drawing.Point(668, 210);
            this.btn_Agregar_Usuario.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btn_Agregar_Usuario.Name = "btn_Agregar_Usuario";
            this.btn_Agregar_Usuario.Size = new System.Drawing.Size(177, 42);
            this.btn_Agregar_Usuario.TabIndex = 32;
            this.btn_Agregar_Usuario.Text = "Agregar";
            this.btn_Agregar_Usuario.UseVisualStyleBackColor = false;
            this.btn_Agregar_Usuario.Click += new System.EventHandler(this.btn_Agregar_Usuario_Click);
            // 
            // txt_ConsultaUsuario_DNI
            // 
            this.txt_ConsultaUsuario_DNI.Location = new System.Drawing.Point(136, 38);
            this.txt_ConsultaUsuario_DNI.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txt_ConsultaUsuario_DNI.Name = "txt_ConsultaUsuario_DNI";
            this.txt_ConsultaUsuario_DNI.Size = new System.Drawing.Size(168, 20);
            this.txt_ConsultaUsuario_DNI.TabIndex = 31;
            // 
            // btn_Actualizar_Usuario
            // 
            this.btn_Actualizar_Usuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Actualizar_Usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btn_Actualizar_Usuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Actualizar_Usuario.ForeColor = System.Drawing.Color.White;
            this.btn_Actualizar_Usuario.Location = new System.Drawing.Point(668, 111);
            this.btn_Actualizar_Usuario.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btn_Actualizar_Usuario.Name = "btn_Actualizar_Usuario";
            this.btn_Actualizar_Usuario.Size = new System.Drawing.Size(177, 42);
            this.btn_Actualizar_Usuario.TabIndex = 30;
            this.btn_Actualizar_Usuario.Text = "Actualizar";
            this.btn_Actualizar_Usuario.UseVisualStyleBackColor = false;
            this.btn_Actualizar_Usuario.Click += new System.EventHandler(this.btn_Actualizar_Usuario_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(316, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 24);
            this.label2.TabIndex = 39;
            this.label2.Text = "ID Usuario";
            // 
            // btn_ConsultaUsuario_Consultar
            // 
            this.btn_ConsultaUsuario_Consultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ConsultaUsuario_Consultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btn_ConsultaUsuario_Consultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ConsultaUsuario_Consultar.ForeColor = System.Drawing.Color.White;
            this.btn_ConsultaUsuario_Consultar.Location = new System.Drawing.Point(668, 26);
            this.btn_ConsultaUsuario_Consultar.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btn_ConsultaUsuario_Consultar.Name = "btn_ConsultaUsuario_Consultar";
            this.btn_ConsultaUsuario_Consultar.Size = new System.Drawing.Size(177, 42);
            this.btn_ConsultaUsuario_Consultar.TabIndex = 40;
            this.btn_ConsultaUsuario_Consultar.Text = "Consultar";
            this.btn_ConsultaUsuario_Consultar.UseVisualStyleBackColor = false;
            this.btn_ConsultaUsuario_Consultar.Click += new System.EventHandler(this.btn_ConsultaUsuario_Consultar_Click);
            // 
            // Consulta_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 443);
            this.Controls.Add(this.btn_ConsultaUsuario_Consultar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgConsultaUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ConsultaUsuario_Eliminar);
            this.Controls.Add(this.txt_ConsultaUsuario_ID);
            this.Controls.Add(this.btn_Agregar_Usuario);
            this.Controls.Add(this.txt_ConsultaUsuario_DNI);
            this.Controls.Add(this.btn_Actualizar_Usuario);
            this.Name = "Consulta_Usuario";
            this.Text = "Consulta Usuario";
            this.Load += new System.EventHandler(this.Consulta_Usuario_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Ayuda);
            ((System.ComponentModel.ISupportInitialize)(this.dgConsultaUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgConsultaUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ConsultaUsuario_Eliminar;
        private System.Windows.Forms.TextBox txt_ConsultaUsuario_ID;
        private System.Windows.Forms.Button btn_Agregar_Usuario;
        private System.Windows.Forms.TextBox txt_ConsultaUsuario_DNI;
        private System.Windows.Forms.Button btn_Actualizar_Usuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_ConsultaUsuario_Consultar;
    }
}