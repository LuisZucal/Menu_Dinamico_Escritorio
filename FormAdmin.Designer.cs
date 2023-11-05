
using System.Windows.Forms;

namespace autenticacion
{
    partial class FormAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Label lblNuevoNombreUsuario;
        private TextBox txtNuevoNombreUsuario;
        private Label lblNuevaContrasena;
        private TextBox txtNuevaContrasena;
        private CheckBox chkNuevoHabilitado;
        private Label lblNombreEmpresa;
        private Button btnGuardar;

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
            this.lblNuevoNombreUsuario = new System.Windows.Forms.Label();
            this.txtNuevoNombreUsuario = new System.Windows.Forms.TextBox();
            this.lblNuevaContrasena = new System.Windows.Forms.Label();
            this.txtNuevaContrasena = new System.Windows.Forms.TextBox();
            this.chkNuevoHabilitado = new System.Windows.Forms.CheckBox();
            this.lblNombreEmpresa = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.listBoxEmpresas = new System.Windows.Forms.ComboBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNuevoNombreUsuario
            // 
            this.lblNuevoNombreUsuario.AutoSize = true;
            this.lblNuevoNombreUsuario.Location = new System.Drawing.Point(12, 12);
            this.lblNuevoNombreUsuario.Name = "lblNuevoNombreUsuario";
            this.lblNuevoNombreUsuario.Size = new System.Drawing.Size(136, 13);
            this.lblNuevoNombreUsuario.TabIndex = 0;
            this.lblNuevoNombreUsuario.Text = "Nuevo Nombre de Usuario:";
            // 
            // txtNuevoNombreUsuario
            // 
            this.txtNuevoNombreUsuario.Location = new System.Drawing.Point(150, 10);
            this.txtNuevoNombreUsuario.Name = "txtNuevoNombreUsuario";
            this.txtNuevoNombreUsuario.Size = new System.Drawing.Size(150, 20);
            this.txtNuevoNombreUsuario.TabIndex = 1;
            // 
            // lblNuevaContrasena
            // 
            this.lblNuevaContrasena.AutoSize = true;
            this.lblNuevaContrasena.Location = new System.Drawing.Point(12, 40);
            this.lblNuevaContrasena.Name = "lblNuevaContrasena";
            this.lblNuevaContrasena.Size = new System.Drawing.Size(99, 13);
            this.lblNuevaContrasena.TabIndex = 2;
            this.lblNuevaContrasena.Text = "Nueva Contraseña:";
            // 
            // txtNuevaContrasena
            // 
            this.txtNuevaContrasena.Location = new System.Drawing.Point(150, 38);
            this.txtNuevaContrasena.Name = "txtNuevaContrasena";
            this.txtNuevaContrasena.Size = new System.Drawing.Size(150, 20);
            this.txtNuevaContrasena.TabIndex = 3;
            // 
            // chkNuevoHabilitado
            // 
            this.chkNuevoHabilitado.AutoSize = true;
            this.chkNuevoHabilitado.Location = new System.Drawing.Point(12, 68);
            this.chkNuevoHabilitado.Name = "chkNuevoHabilitado";
            this.chkNuevoHabilitado.Size = new System.Drawing.Size(73, 17);
            this.chkNuevoHabilitado.TabIndex = 4;
            this.chkNuevoHabilitado.Text = "Habilitado";
            // 
            // lblNombreEmpresa
            // 
            this.lblNombreEmpresa.AutoSize = true;
            this.lblNombreEmpresa.Location = new System.Drawing.Point(12, 100);
            this.lblNombreEmpresa.Name = "lblNombreEmpresa";
            this.lblNombreEmpresa.Size = new System.Drawing.Size(117, 13);
            this.lblNombreEmpresa.TabIndex = 5;
            this.lblNombreEmpresa.Text = "Nombre de la Empresa:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(12, 140);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // listBoxEmpresas
            // 
            this.listBoxEmpresas.FormattingEnabled = true;
            this.listBoxEmpresas.Location = new System.Drawing.Point(150, 92);
            this.listBoxEmpresas.Name = "listBoxEmpresas";
            this.listBoxEmpresas.Size = new System.Drawing.Size(150, 21);
            this.listBoxEmpresas.TabIndex = 8;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(93, 140);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 9;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FormAdmin
            // 
            this.ClientSize = new System.Drawing.Size(350, 200);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.listBoxEmpresas);
            this.Controls.Add(this.lblNuevoNombreUsuario);
            this.Controls.Add(this.txtNuevoNombreUsuario);
            this.Controls.Add(this.lblNuevaContrasena);
            this.Controls.Add(this.txtNuevaContrasena);
            this.Controls.Add(this.chkNuevoHabilitado);
            this.Controls.Add(this.lblNombreEmpresa);
            this.Controls.Add(this.btnGuardar);
            this.Name = "FormAdmin";
            this.Text = "Formulario de Administrador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox listBoxEmpresas;
        private Button btnVolver;
    }
}