namespace UI
{
    partial class frmPermisos
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
            this.label4 = new System.Windows.Forms.Label();
            this.metroButton1 = new System.Windows.Forms.Button();
            this.btnGuardarConfig = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMenuNuevo = new System.Windows.Forms.Button();
            this.btnMenuEditar = new System.Windows.Forms.Button();
            this.btnMenuSeleccionar = new System.Windows.Forms.Button();
            this.btnMenuNuevoGuardar = new System.Windows.Forms.Button();
            this.lblNombreNuevoMenu = new System.Windows.Forms.Label();
            this.lblMenuLista = new System.Windows.Forms.Label();
            this.txtBoxNombreMenu = new System.Windows.Forms.TextBox();
            this.cmbBoxMenuLista = new System.Windows.Forms.ComboBox();
            this.btnSubMenuSeleccionar = new System.Windows.Forms.Button();
            this.lblSubMenuLista = new System.Windows.Forms.Label();
            this.cmbBoxNombreSubMenu = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.treeView1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.treeView1.Location = new System.Drawing.Point(713, 100);
            this.treeView1.Margin = new System.Windows.Forms.Padding(4);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(360, 248);
            this.treeView1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(709, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 16);
            this.label4.TabIndex = 6;
            this.label4.Tag = "arbol_permisos";
            this.label4.Text = "Arbol de Permisos";
            // 
            // metroButton1
            // 
            this.metroButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroButton1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.metroButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.metroButton1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.metroButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroButton1.Location = new System.Drawing.Point(713, 375);
            this.metroButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(361, 58);
            this.metroButton1.TabIndex = 10;
            this.metroButton1.Tag = "eliminar_del_arbol";
            this.metroButton1.Text = "Eliminar del arbol";
            this.metroButton1.UseVisualStyleBackColor = false;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // btnGuardarConfig
            // 
            this.btnGuardarConfig.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuardarConfig.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnGuardarConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarConfig.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnGuardarConfig.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardarConfig.Location = new System.Drawing.Point(713, 452);
            this.btnGuardarConfig.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardarConfig.Name = "btnGuardarConfig";
            this.btnGuardarConfig.Size = new System.Drawing.Size(361, 58);
            this.btnGuardarConfig.TabIndex = 11;
            this.btnGuardarConfig.Tag = "guardar_configuracion";
            this.btnGuardarConfig.Text = "Guardar Configuracion";
            this.btnGuardarConfig.UseVisualStyleBackColor = false;
            this.btnGuardarConfig.Click += new System.EventHandler(this.btnGuardarConfig_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.lblUser);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1148, 46);
            this.panel1.TabIndex = 12;
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
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1037, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 23);
            this.label1.TabIndex = 5;
            this.label1.Tag = "permisos";
            this.label1.Text = "Permisos";
            // 
            // btnMenuNuevo
            // 
            this.btnMenuNuevo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMenuNuevo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnMenuNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuNuevo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnMenuNuevo.Location = new System.Drawing.Point(459, 290);
            this.btnMenuNuevo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMenuNuevo.Name = "btnMenuNuevo";
            this.btnMenuNuevo.Size = new System.Drawing.Size(163, 37);
            this.btnMenuNuevo.TabIndex = 17;
            this.btnMenuNuevo.Tag = "crear_nueva_familia";
            this.btnMenuNuevo.Text = "Crear Nueva Familia";
            this.btnMenuNuevo.UseVisualStyleBackColor = false;
            this.btnMenuNuevo.Click += new System.EventHandler(this.btnMenuNuevo_Click);
            // 
            // btnMenuEditar
            // 
            this.btnMenuEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMenuEditar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnMenuEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuEditar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnMenuEditar.Location = new System.Drawing.Point(289, 290);
            this.btnMenuEditar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMenuEditar.Name = "btnMenuEditar";
            this.btnMenuEditar.Size = new System.Drawing.Size(145, 37);
            this.btnMenuEditar.TabIndex = 16;
            this.btnMenuEditar.Tag = "editar";
            this.btnMenuEditar.Text = "Editar";
            this.btnMenuEditar.UseVisualStyleBackColor = false;
            this.btnMenuEditar.Click += new System.EventHandler(this.btnMenuEditar_Click);
            // 
            // btnMenuSeleccionar
            // 
            this.btnMenuSeleccionar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMenuSeleccionar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnMenuSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuSeleccionar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnMenuSeleccionar.Location = new System.Drawing.Point(99, 290);
            this.btnMenuSeleccionar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMenuSeleccionar.Name = "btnMenuSeleccionar";
            this.btnMenuSeleccionar.Size = new System.Drawing.Size(152, 37);
            this.btnMenuSeleccionar.TabIndex = 15;
            this.btnMenuSeleccionar.Tag = "seleccionar";
            this.btnMenuSeleccionar.Text = "Seleccionar";
            this.btnMenuSeleccionar.UseVisualStyleBackColor = false;
            this.btnMenuSeleccionar.Click += new System.EventHandler(this.btnMenuSeleccionar_Click);
            // 
            // btnMenuNuevoGuardar
            // 
            this.btnMenuNuevoGuardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMenuNuevoGuardar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnMenuNuevoGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuNuevoGuardar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnMenuNuevoGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMenuNuevoGuardar.Location = new System.Drawing.Point(228, 212);
            this.btnMenuNuevoGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMenuNuevoGuardar.Name = "btnMenuNuevoGuardar";
            this.btnMenuNuevoGuardar.Size = new System.Drawing.Size(263, 41);
            this.btnMenuNuevoGuardar.TabIndex = 14;
            this.btnMenuNuevoGuardar.Tag = "guarda_familia";
            this.btnMenuNuevoGuardar.Text = "Guardar Familia";
            this.btnMenuNuevoGuardar.UseVisualStyleBackColor = false;
            // 
            // lblNombreNuevoMenu
            // 
            this.lblNombreNuevoMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNombreNuevoMenu.AutoSize = true;
            this.lblNombreNuevoMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNombreNuevoMenu.Location = new System.Drawing.Point(95, 171);
            this.lblNombreNuevoMenu.Name = "lblNombreNuevoMenu";
            this.lblNombreNuevoMenu.Size = new System.Drawing.Size(103, 16);
            this.lblNombreNuevoMenu.TabIndex = 13;
            this.lblNombreNuevoMenu.Tag = "nombre_familia";
            this.lblNombreNuevoMenu.Text = "Nombre Familia";
            // 
            // lblMenuLista
            // 
            this.lblMenuLista.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMenuLista.AutoSize = true;
            this.lblMenuLista.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMenuLista.Location = new System.Drawing.Point(95, 122);
            this.lblMenuLista.Name = "lblMenuLista";
            this.lblMenuLista.Size = new System.Drawing.Size(111, 16);
            this.lblMenuLista.TabIndex = 12;
            this.lblMenuLista.Tag = "familia_permiso";
            this.lblMenuLista.Text = "Familia Permisos";
            // 
            // txtBoxNombreMenu
            // 
            this.txtBoxNombreMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxNombreMenu.Location = new System.Drawing.Point(228, 168);
            this.txtBoxNombreMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxNombreMenu.Name = "txtBoxNombreMenu";
            this.txtBoxNombreMenu.Size = new System.Drawing.Size(261, 22);
            this.txtBoxNombreMenu.TabIndex = 11;
            // 
            // cmbBoxMenuLista
            // 
            this.cmbBoxMenuLista.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbBoxMenuLista.FormattingEnabled = true;
            this.cmbBoxMenuLista.Location = new System.Drawing.Point(228, 122);
            this.cmbBoxMenuLista.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbBoxMenuLista.Name = "cmbBoxMenuLista";
            this.cmbBoxMenuLista.Size = new System.Drawing.Size(261, 24);
            this.cmbBoxMenuLista.TabIndex = 10;
            // 
            // btnSubMenuSeleccionar
            // 
            this.btnSubMenuSeleccionar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSubMenuSeleccionar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSubMenuSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubMenuSeleccionar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnSubMenuSeleccionar.Location = new System.Drawing.Point(257, 433);
            this.btnSubMenuSeleccionar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubMenuSeleccionar.Name = "btnSubMenuSeleccionar";
            this.btnSubMenuSeleccionar.Size = new System.Drawing.Size(205, 37);
            this.btnSubMenuSeleccionar.TabIndex = 20;
            this.btnSubMenuSeleccionar.Tag = "seleccionar";
            this.btnSubMenuSeleccionar.Text = "Seleccionar";
            this.btnSubMenuSeleccionar.UseVisualStyleBackColor = false;
            this.btnSubMenuSeleccionar.Click += new System.EventHandler(this.btnSubMenuSeleccionar_Click);
            // 
            // lblSubMenuLista
            // 
            this.lblSubMenuLista.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSubMenuLista.AutoSize = true;
            this.lblSubMenuLista.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSubMenuLista.Location = new System.Drawing.Point(177, 396);
            this.lblSubMenuLista.Name = "lblSubMenuLista";
            this.lblSubMenuLista.Size = new System.Drawing.Size(57, 16);
            this.lblSubMenuLista.TabIndex = 19;
            this.lblSubMenuLista.Tag = "permiso";
            this.lblSubMenuLista.Text = "Permiso";
            // 
            // cmbBoxNombreSubMenu
            // 
            this.cmbBoxNombreSubMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbBoxNombreSubMenu.FormattingEnabled = true;
            this.cmbBoxNombreSubMenu.Location = new System.Drawing.Point(257, 393);
            this.cmbBoxNombreSubMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbBoxNombreSubMenu.Name = "cmbBoxNombreSubMenu";
            this.cmbBoxNombreSubMenu.Size = new System.Drawing.Size(204, 24);
            this.cmbBoxNombreSubMenu.TabIndex = 18;
            // 
            // frmPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1148, 554);
            this.Controls.Add(this.btnSubMenuSeleccionar);
            this.Controls.Add(this.lblSubMenuLista);
            this.Controls.Add(this.cmbBoxNombreSubMenu);
            this.Controls.Add(this.btnMenuNuevo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnMenuEditar);
            this.Controls.Add(this.btnGuardarConfig);
            this.Controls.Add(this.btnMenuSeleccionar);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.btnMenuNuevoGuardar);
            this.Controls.Add(this.lblNombreNuevoMenu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblMenuLista);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.txtBoxNombreMenu);
            this.Controls.Add(this.cmbBoxMenuLista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmPermisos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "permisos";
            this.Text = "Permisos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPermisos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button metroButton1;
        private System.Windows.Forms.Button btnGuardarConfig;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMenuNuevo;
        private System.Windows.Forms.Button btnMenuEditar;
        private System.Windows.Forms.Button btnMenuSeleccionar;
        private System.Windows.Forms.Button btnMenuNuevoGuardar;
        private System.Windows.Forms.Label lblNombreNuevoMenu;
        private System.Windows.Forms.Label lblMenuLista;
        private System.Windows.Forms.TextBox txtBoxNombreMenu;
        private System.Windows.Forms.ComboBox cmbBoxMenuLista;
        private System.Windows.Forms.Button btnSubMenuSeleccionar;
        private System.Windows.Forms.Label lblSubMenuLista;
        private System.Windows.Forms.ComboBox cmbBoxNombreSubMenu;
    }
}