﻿namespace UI
{
    partial class frmPermisosUsuarios
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btnSubMenuSeleccionar = new System.Windows.Forms.Button();
            this.btnMenuSeleccionar = new System.Windows.Forms.Button();
            this.cmbBoxMenuLista = new System.Windows.Forms.ComboBox();
            this.cmbBoxNombreSubMenu = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGuardarConfig = new System.Windows.Forms.Button();
            this.btnUsuarioEditar = new System.Windows.Forms.Button();
            this.cmbUsuarios = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminarPermiso = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUser = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.treeView1.Location = new System.Drawing.Point(497, 75);
            this.treeView1.Margin = new System.Windows.Forms.Padding(4);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(309, 287);
            this.treeView1.TabIndex = 16;
            this.treeView1.Tag = "arbol_permisos";
            // 
            // btnSubMenuSeleccionar
            // 
            this.btnSubMenuSeleccionar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSubMenuSeleccionar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSubMenuSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubMenuSeleccionar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnSubMenuSeleccionar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSubMenuSeleccionar.Location = new System.Drawing.Point(202, 369);
            this.btnSubMenuSeleccionar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubMenuSeleccionar.Name = "btnSubMenuSeleccionar";
            this.btnSubMenuSeleccionar.Size = new System.Drawing.Size(225, 49);
            this.btnSubMenuSeleccionar.TabIndex = 25;
            this.btnSubMenuSeleccionar.Tag = "seleccionar_permiso";
            this.btnSubMenuSeleccionar.Text = "Seleccionar Permiso";
            this.btnSubMenuSeleccionar.UseVisualStyleBackColor = false;
            this.btnSubMenuSeleccionar.Click += new System.EventHandler(this.btnSubMenuSeleccionar_Click_1);
            // 
            // btnMenuSeleccionar
            // 
            this.btnMenuSeleccionar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMenuSeleccionar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnMenuSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuSeleccionar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnMenuSeleccionar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMenuSeleccionar.Location = new System.Drawing.Point(201, 276);
            this.btnMenuSeleccionar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMenuSeleccionar.Name = "btnMenuSeleccionar";
            this.btnMenuSeleccionar.Size = new System.Drawing.Size(227, 43);
            this.btnMenuSeleccionar.TabIndex = 24;
            this.btnMenuSeleccionar.Tag = "seleccionar_arbol";
            this.btnMenuSeleccionar.Text = "Seleccionar Arbol";
            this.btnMenuSeleccionar.UseVisualStyleBackColor = false;
            this.btnMenuSeleccionar.Click += new System.EventHandler(this.btnMenuSeleccionar_Click_1);
            // 
            // cmbBoxMenuLista
            // 
            this.cmbBoxMenuLista.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbBoxMenuLista.FormattingEnabled = true;
            this.cmbBoxMenuLista.Location = new System.Drawing.Point(201, 245);
            this.cmbBoxMenuLista.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbBoxMenuLista.Name = "cmbBoxMenuLista";
            this.cmbBoxMenuLista.Size = new System.Drawing.Size(225, 24);
            this.cmbBoxMenuLista.TabIndex = 21;
            // 
            // cmbBoxNombreSubMenu
            // 
            this.cmbBoxNombreSubMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbBoxNombreSubMenu.FormattingEnabled = true;
            this.cmbBoxNombreSubMenu.Location = new System.Drawing.Point(201, 338);
            this.cmbBoxNombreSubMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbBoxNombreSubMenu.Name = "cmbBoxNombreSubMenu";
            this.cmbBoxNombreSubMenu.Size = new System.Drawing.Size(225, 24);
            this.cmbBoxNombreSubMenu.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(89, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 18;
            this.label2.Tag = "familia_permiso";
            this.label2.Text = "Familia Permiso";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(135, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 19;
            this.label3.Tag = "permiso";
            this.label3.Text = "Permiso";
            // 
            // btnGuardarConfig
            // 
            this.btnGuardarConfig.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuardarConfig.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnGuardarConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarConfig.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnGuardarConfig.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardarConfig.Location = new System.Drawing.Point(497, 420);
            this.btnGuardarConfig.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardarConfig.Name = "btnGuardarConfig";
            this.btnGuardarConfig.Size = new System.Drawing.Size(311, 50);
            this.btnGuardarConfig.TabIndex = 23;
            this.btnGuardarConfig.Tag = "guardar_config";
            this.btnGuardarConfig.Text = "Guardar Configuracion";
            this.btnGuardarConfig.UseVisualStyleBackColor = false;
            this.btnGuardarConfig.Click += new System.EventHandler(this.btnGuardarConfig_Click_1);
            // 
            // btnUsuarioEditar
            // 
            this.btnUsuarioEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUsuarioEditar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnUsuarioEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarioEditar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnUsuarioEditar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUsuarioEditar.Location = new System.Drawing.Point(202, 142);
            this.btnUsuarioEditar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUsuarioEditar.Name = "btnUsuarioEditar";
            this.btnUsuarioEditar.Size = new System.Drawing.Size(225, 41);
            this.btnUsuarioEditar.TabIndex = 21;
            this.btnUsuarioEditar.Tag = "permisos_usuario";
            this.btnUsuarioEditar.Text = "Permisos Usuarios";
            this.btnUsuarioEditar.UseVisualStyleBackColor = false;
            this.btnUsuarioEditar.Click += new System.EventHandler(this.btnUsuarioEditar_Click_1);
            // 
            // cmbUsuarios
            // 
            this.cmbUsuarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbUsuarios.FormattingEnabled = true;
            this.cmbUsuarios.Location = new System.Drawing.Point(201, 111);
            this.cmbUsuarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbUsuarios.Name = "cmbUsuarios";
            this.cmbUsuarios.Size = new System.Drawing.Size(225, 24);
            this.cmbUsuarios.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(137, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 17;
            this.label1.Tag = "usuario";
            this.label1.Text = "Usuario";
            // 
            // btnEliminarPermiso
            // 
            this.btnEliminarPermiso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminarPermiso.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnEliminarPermiso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarPermiso.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnEliminarPermiso.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarPermiso.Location = new System.Drawing.Point(497, 369);
            this.btnEliminarPermiso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarPermiso.Name = "btnEliminarPermiso";
            this.btnEliminarPermiso.Size = new System.Drawing.Size(311, 46);
            this.btnEliminarPermiso.TabIndex = 22;
            this.btnEliminarPermiso.Tag = "eliminar_arbol";
            this.btnEliminarPermiso.Text = "Eliminar del Arbol";
            this.btnEliminarPermiso.UseVisualStyleBackColor = false;
            this.btnEliminarPermiso.Click += new System.EventHandler(this.btnEliminarPermiso_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.lblUser);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 46);
            this.panel1.TabIndex = 24;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(721, 9);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(0, 25);
            this.lblUser.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(680, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 23);
            this.label4.TabIndex = 5;
            this.label4.Tag = "modificar_permisos";
            this.label4.Text = "Modificar Permisos";
            // 
            // frmPermisosUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(885, 512);
            this.Controls.Add(this.btnSubMenuSeleccionar);
            this.Controls.Add(this.btnMenuSeleccionar);
            this.Controls.Add(this.btnUsuarioEditar);
            this.Controls.Add(this.cmbBoxMenuLista);
            this.Controls.Add(this.cmbUsuarios);
            this.Controls.Add(this.cmbBoxNombreSubMenu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEliminarPermiso);
            this.Controls.Add(this.btnGuardarConfig);
            this.Controls.Add(this.treeView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmPermisosUsuarios";
            this.Text = "Permisos Usuarios";
            this.Load += new System.EventHandler(this.frmPermisosUsuarios_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ComboBox cmbBoxMenuLista;
        private System.Windows.Forms.ComboBox cmbBoxNombreSubMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUsuarioEditar;
        private System.Windows.Forms.ComboBox cmbUsuarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardarConfig;
        private System.Windows.Forms.Button btnEliminarPermiso;
        private System.Windows.Forms.Button btnSubMenuSeleccionar;
        private System.Windows.Forms.Button btnMenuSeleccionar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label label4;
    }
}