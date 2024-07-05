namespace UI
{
    partial class frmAltaUsuario
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.Apellido = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMailAlta = new System.Windows.Forms.TextBox();
            this.txtApellidoAlta = new System.Windows.Forms.TextBox();
            this.txtNombreAlta = new System.Windows.Forms.TextBox();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.txtUserAlta = new System.Windows.Forms.TextBox();
            this.txtPassAlta = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(673, 39);
            this.panel1.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12.2F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(500, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 25);
            this.label7.TabIndex = 1;
            this.label7.Tag = "alta_usuario";
            this.label7.Text = "Alta de usuario";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalir.Location = new System.Drawing.Point(362, 275);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(188, 43);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Tag = "salir";
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogin.Location = new System.Drawing.Point(128, 275);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(188, 43);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Tag = "crear_usuario";
            this.btnLogin.Text = "Crear Usuario";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(33, 135);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 22);
            this.label2.TabIndex = 51;
            this.label2.Tag = "contraseña";
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(31, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 22);
            this.label1.TabIndex = 52;
            this.label1.Tag = "usuario";
            this.label1.Text = "Username";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Email.Location = new System.Drawing.Point(348, 196);
            this.Email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(46, 22);
            this.Email.TabIndex = 50;
            this.Email.Tag = "mail";
            this.Email.Text = "Mail";
            // 
            // Apellido
            // 
            this.Apellido.AutoSize = true;
            this.Apellido.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Apellido.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Apellido.Location = new System.Drawing.Point(348, 136);
            this.Apellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Apellido.Name = "Apellido";
            this.Apellido.Size = new System.Drawing.Size(84, 22);
            this.Apellido.TabIndex = 49;
            this.Apellido.Tag = "apellido";
            this.Apellido.Text = "Apellido";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(348, 79);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 22);
            this.label9.TabIndex = 48;
            this.label9.Tag = "nombre";
            this.label9.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(36, 195);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 22);
            this.label5.TabIndex = 40;
            this.label5.Tag = "confirmar_contraseña";
            this.label5.Text = "Confirm password";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(343, 231);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(331, 19);
            this.label12.TabIndex = 61;
            this.label12.Text = "----------------------------------------------";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(343, 171);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(331, 19);
            this.label10.TabIndex = 60;
            this.label10.Text = "----------------------------------------------";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(348, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(286, 21);
            this.label8.TabIndex = 59;
            this.label8.Text = "----------------------------------------------";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(31, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(331, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "----------------------------------------------";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(31, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(331, 19);
            this.label3.TabIndex = 57;
            this.label3.Text = "----------------------------------------------";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(31, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(286, 21);
            this.label4.TabIndex = 56;
            this.label4.Text = "----------------------------------------------";
            // 
            // txtMailAlta
            // 
            this.txtMailAlta.AcceptsReturn = true;
            this.txtMailAlta.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtMailAlta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMailAlta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMailAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMailAlta.ForeColor = System.Drawing.Color.DarkGray;
            this.txtMailAlta.Location = new System.Drawing.Point(346, 214);
            this.txtMailAlta.MaxLength = 20;
            this.txtMailAlta.Name = "txtMailAlta";
            this.txtMailAlta.Size = new System.Drawing.Size(193, 20);
            this.txtMailAlta.TabIndex = 6;
            // 
            // txtApellidoAlta
            // 
            this.txtApellidoAlta.AcceptsReturn = true;
            this.txtApellidoAlta.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtApellidoAlta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellidoAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoAlta.ForeColor = System.Drawing.Color.DarkGray;
            this.txtApellidoAlta.Location = new System.Drawing.Point(346, 155);
            this.txtApellidoAlta.MaxLength = 20;
            this.txtApellidoAlta.Name = "txtApellidoAlta";
            this.txtApellidoAlta.Size = new System.Drawing.Size(193, 20);
            this.txtApellidoAlta.TabIndex = 5;
            // 
            // txtNombreAlta
            // 
            this.txtNombreAlta.AcceptsReturn = true;
            this.txtNombreAlta.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtNombreAlta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreAlta.ForeColor = System.Drawing.Color.DarkGray;
            this.txtNombreAlta.Location = new System.Drawing.Point(346, 99);
            this.txtNombreAlta.MaxLength = 20;
            this.txtNombreAlta.Name = "txtNombreAlta";
            this.txtNombreAlta.Size = new System.Drawing.Size(193, 20);
            this.txtNombreAlta.TabIndex = 4;
            // 
            // txtConfirm
            // 
            this.txtConfirm.AcceptsReturn = true;
            this.txtConfirm.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtConfirm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirm.ForeColor = System.Drawing.Color.DarkGray;
            this.txtConfirm.Location = new System.Drawing.Point(36, 217);
            this.txtConfirm.MaxLength = 20;
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.PasswordChar = '*';
            this.txtConfirm.Size = new System.Drawing.Size(193, 20);
            this.txtConfirm.TabIndex = 3;
            // 
            // txtUserAlta
            // 
            this.txtUserAlta.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtUserAlta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserAlta.ForeColor = System.Drawing.Color.DarkGray;
            this.txtUserAlta.Location = new System.Drawing.Point(33, 98);
            this.txtUserAlta.MaxLength = 20;
            this.txtUserAlta.Name = "txtUserAlta";
            this.txtUserAlta.Size = new System.Drawing.Size(193, 21);
            this.txtUserAlta.TabIndex = 1;
            // 
            // txtPassAlta
            // 
            this.txtPassAlta.AcceptsReturn = true;
            this.txtPassAlta.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtPassAlta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassAlta.ForeColor = System.Drawing.Color.DarkGray;
            this.txtPassAlta.Location = new System.Drawing.Point(33, 156);
            this.txtPassAlta.MaxLength = 20;
            this.txtPassAlta.Name = "txtPassAlta";
            this.txtPassAlta.PasswordChar = '*';
            this.txtPassAlta.Size = new System.Drawing.Size(193, 20);
            this.txtPassAlta.TabIndex = 2;
            // 
            // frmAltaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(673, 367);
            this.Controls.Add(this.txtMailAlta);
            this.Controls.Add(this.txtApellidoAlta);
            this.Controls.Add(this.txtNombreAlta);
            this.Controls.Add(this.txtConfirm);
            this.Controls.Add(this.txtUserAlta);
            this.Controls.Add(this.txtPassAlta);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Apellido);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAltaUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "    ";
            this.Load += new System.EventHandler(this.frmAltaUsuario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Apellido;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMailAlta;
        private System.Windows.Forms.TextBox txtApellidoAlta;
        private System.Windows.Forms.TextBox txtNombreAlta;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.TextBox txtUserAlta;
        private System.Windows.Forms.TextBox txtPassAlta;
    }
}