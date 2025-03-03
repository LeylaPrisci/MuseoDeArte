namespace Conexionsqlserver
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textb_usuario = new System.Windows.Forms.TextBox();
            this.textb_contraseña = new System.Windows.Forms.TextBox();
            this.btn_inicio = new System.Windows.Forms.Button();
            this.btn_cerrarSeccion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.BackgroundImage = global::Conexionsqlserver.Properties.Resources.avatar_13579967;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 347);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(282, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bienvenido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(219, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(219, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Contraseña";
            // 
            // textb_usuario
            // 
            this.textb_usuario.BackColor = System.Drawing.Color.Gainsboro;
            this.textb_usuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textb_usuario.Location = new System.Drawing.Point(349, 99);
            this.textb_usuario.Name = "textb_usuario";
            this.textb_usuario.Size = new System.Drawing.Size(155, 20);
            this.textb_usuario.TabIndex = 4;
            // 
            // textb_contraseña
            // 
            this.textb_contraseña.BackColor = System.Drawing.Color.LightGray;
            this.textb_contraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textb_contraseña.Location = new System.Drawing.Point(349, 169);
            this.textb_contraseña.Name = "textb_contraseña";
            this.textb_contraseña.Size = new System.Drawing.Size(155, 20);
            this.textb_contraseña.TabIndex = 5;
            // 
            // btn_inicio
            // 
            this.btn_inicio.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_inicio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_inicio.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inicio.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_inicio.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_inicio.Location = new System.Drawing.Point(245, 253);
            this.btn_inicio.Name = "btn_inicio";
            this.btn_inicio.Size = new System.Drawing.Size(102, 40);
            this.btn_inicio.TabIndex = 6;
            this.btn_inicio.Text = "Inicio seccion";
            this.btn_inicio.UseVisualStyleBackColor = false;
            this.btn_inicio.Click += new System.EventHandler(this.btn_inicio_Click);
            // 
            // btn_cerrarSeccion
            // 
            this.btn_cerrarSeccion.BackColor = System.Drawing.Color.SlateGray;
            this.btn_cerrarSeccion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cerrarSeccion.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrarSeccion.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_cerrarSeccion.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_cerrarSeccion.Location = new System.Drawing.Point(383, 253);
            this.btn_cerrarSeccion.Name = "btn_cerrarSeccion";
            this.btn_cerrarSeccion.Size = new System.Drawing.Size(102, 40);
            this.btn_cerrarSeccion.TabIndex = 7;
            this.btn_cerrarSeccion.Text = "Cerrar seccion";
            this.btn_cerrarSeccion.UseVisualStyleBackColor = false;
            this.btn_cerrarSeccion.Click += new System.EventHandler(this.btn_cerrarSeccion_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(516, 335);
            this.Controls.Add(this.btn_cerrarSeccion);
            this.Controls.Add(this.btn_inicio);
            this.Controls.Add(this.textb_contraseña);
            this.Controls.Add(this.textb_usuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "login";
            this.Text = "Login";
            this.TransparencyKey = System.Drawing.Color.White;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textb_usuario;
        private System.Windows.Forms.TextBox textb_contraseña;
        private System.Windows.Forms.Button btn_inicio;
        private System.Windows.Forms.Button btn_cerrarSeccion;
    }
}