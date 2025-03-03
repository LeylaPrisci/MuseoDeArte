namespace Conexionsqlserver
{
    partial class Usuario
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tab_modificado = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.textb_buscar = new System.Windows.Forms.TextBox();
            this.dataGV_usuario = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.textb_telef = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.text_nombre = new System.Windows.Forms.TextBox();
            this.textb_dni = new System.Windows.Forms.TextBox();
            this.textb_contrasenia = new System.Windows.Forms.TextBox();
            this.cmbx_Rol = new System.Windows.Forms.ComboBox();
            this.text_direccion = new System.Windows.Forms.TextBox();
            this.text_apellido = new System.Windows.Forms.TextBox();
            this.text_nombreUsuario = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tab_modificado.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_usuario)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btn_eliminar);
            this.panel1.Controls.Add(this.btn_agregar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1011, 100);
            this.panel1.TabIndex = 0;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.White;
            this.btn_eliminar.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btn_eliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.btn_eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_eliminar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.ForeColor = System.Drawing.Color.SlateGray;
            this.btn_eliminar.Location = new System.Drawing.Point(808, 34);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(74, 34);
            this.btn_eliminar.TabIndex = 5;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.Color.White;
            this.btn_agregar.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btn_agregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.btn_agregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_agregar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.ForeColor = System.Drawing.Color.SlateGray;
            this.btn_agregar.Location = new System.Drawing.Point(692, 34);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(74, 34);
            this.btn_agregar.TabIndex = 3;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = false;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.AliceBlue;
            this.label1.Location = new System.Drawing.Point(28, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuarios";
            // 
            // tab_modificado
            // 
            this.tab_modificado.Controls.Add(this.tabPage1);
            this.tab_modificado.Controls.Add(this.tabPage2);
            this.tab_modificado.Location = new System.Drawing.Point(12, 128);
            this.tab_modificado.Name = "tab_modificado";
            this.tab_modificado.SelectedIndex = 0;
            this.tab_modificado.Size = new System.Drawing.Size(987, 401);
            this.tab_modificado.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_actualizar);
            this.tabPage1.Controls.Add(this.btn_buscar);
            this.tabPage1.Controls.Add(this.textb_buscar);
            this.tabPage1.Controls.Add(this.dataGV_usuario);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(979, 375);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.BackColor = System.Drawing.Color.White;
            this.btn_actualizar.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btn_actualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.btn_actualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_actualizar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actualizar.ForeColor = System.Drawing.Color.SlateGray;
            this.btn_actualizar.Location = new System.Drawing.Point(792, 70);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(102, 34);
            this.btn_actualizar.TabIndex = 11;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.UseVisualStyleBackColor = false;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(676, 70);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(84, 34);
            this.btn_buscar.TabIndex = 10;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // textb_buscar
            // 
            this.textb_buscar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textb_buscar.Location = new System.Drawing.Point(192, 72);
            this.textb_buscar.Name = "textb_buscar";
            this.textb_buscar.Size = new System.Drawing.Size(432, 32);
            this.textb_buscar.TabIndex = 9;
            // 
            // dataGV_usuario
            // 
            this.dataGV_usuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_usuario.Location = new System.Drawing.Point(47, 164);
            this.dataGV_usuario.Name = "dataGV_usuario";
            this.dataGV_usuario.Size = new System.Drawing.Size(890, 195);
            this.dataGV_usuario.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Buscar :";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_cancelar);
            this.tabPage2.Controls.Add(this.btn_guardar);
            this.tabPage2.Controls.Add(this.textb_telef);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.text_nombre);
            this.tabPage2.Controls.Add(this.textb_dni);
            this.tabPage2.Controls.Add(this.textb_contrasenia);
            this.tabPage2.Controls.Add(this.cmbx_Rol);
            this.tabPage2.Controls.Add(this.text_direccion);
            this.tabPage2.Controls.Add(this.text_apellido);
            this.tabPage2.Controls.Add(this.text_nombreUsuario);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(979, 375);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Modificaciones";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.White;
            this.btn_cancelar.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btn_cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.btn_cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_cancelar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.SlateGray;
            this.btn_cancelar.Location = new System.Drawing.Point(489, 257);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(74, 34);
            this.btn_cancelar.TabIndex = 42;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.White;
            this.btn_guardar.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btn_guardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.btn_guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_guardar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.Color.SlateGray;
            this.btn_guardar.Location = new System.Drawing.Point(344, 257);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(74, 34);
            this.btn_guardar.TabIndex = 41;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // textb_telef
            // 
            this.textb_telef.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textb_telef.Location = new System.Drawing.Point(185, 164);
            this.textb_telef.Name = "textb_telef";
            this.textb_telef.Size = new System.Drawing.Size(233, 24);
            this.textb_telef.TabIndex = 40;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(35, 164);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 18);
            this.label10.TabIndex = 39;
            this.label10.Text = "Telefono";
            // 
            // text_nombre
            // 
            this.text_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_nombre.Location = new System.Drawing.Point(614, 29);
            this.text_nombre.Name = "text_nombre";
            this.text_nombre.Size = new System.Drawing.Size(233, 24);
            this.text_nombre.TabIndex = 38;
            // 
            // textb_dni
            // 
            this.textb_dni.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textb_dni.Location = new System.Drawing.Point(185, 113);
            this.textb_dni.Name = "textb_dni";
            this.textb_dni.Size = new System.Drawing.Size(233, 24);
            this.textb_dni.TabIndex = 37;
            // 
            // textb_contrasenia
            // 
            this.textb_contrasenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textb_contrasenia.Location = new System.Drawing.Point(185, 67);
            this.textb_contrasenia.Name = "textb_contrasenia";
            this.textb_contrasenia.Size = new System.Drawing.Size(233, 24);
            this.textb_contrasenia.TabIndex = 36;
            // 
            // cmbx_Rol
            // 
            this.cmbx_Rol.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbx_Rol.FormattingEnabled = true;
            this.cmbx_Rol.Location = new System.Drawing.Point(614, 164);
            this.cmbx_Rol.Name = "cmbx_Rol";
            this.cmbx_Rol.Size = new System.Drawing.Size(233, 26);
            this.cmbx_Rol.TabIndex = 32;
            // 
            // text_direccion
            // 
            this.text_direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_direccion.Location = new System.Drawing.Point(614, 119);
            this.text_direccion.Name = "text_direccion";
            this.text_direccion.Size = new System.Drawing.Size(233, 24);
            this.text_direccion.TabIndex = 31;
            // 
            // text_apellido
            // 
            this.text_apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_apellido.Location = new System.Drawing.Point(614, 73);
            this.text_apellido.Name = "text_apellido";
            this.text_apellido.Size = new System.Drawing.Size(233, 24);
            this.text_apellido.TabIndex = 30;
            // 
            // text_nombreUsuario
            // 
            this.text_nombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_nombreUsuario.Location = new System.Drawing.Point(185, 26);
            this.text_nombreUsuario.Name = "text_nombreUsuario";
            this.text_nombreUsuario.Size = new System.Drawing.Size(233, 24);
            this.text_nombreUsuario.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(486, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 18);
            this.label9.TabIndex = 28;
            this.label9.Text = "Direccion";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(486, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 18);
            this.label8.TabIndex = 27;
            this.label8.Text = "Nombre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(485, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 18);
            this.label7.TabIndex = 26;
            this.label7.Text = "Apellido";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(486, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 18);
            this.label6.TabIndex = 25;
            this.label6.Text = "Rol";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 18);
            this.label5.TabIndex = 24;
            this.label5.Text = "DNI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 18);
            this.label4.TabIndex = 23;
            this.label4.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 18);
            this.label3.TabIndex = 22;
            this.label3.Text = "Nombre de Usuario";
            // 
            // Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Conexionsqlserver.Properties.Resources.museo_azul5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1011, 541);
            this.Controls.Add(this.tab_modificado);
            this.Controls.Add(this.panel1);
            this.Name = "Usuario";
            this.Text = "Usuario";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tab_modificado.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_usuario)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tab_modificado;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGV_usuario;
        private System.Windows.Forms.TextBox textb_buscar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.ComboBox cmbx_Rol;
        private System.Windows.Forms.TextBox text_direccion;
        private System.Windows.Forms.TextBox text_apellido;
        private System.Windows.Forms.TextBox text_nombreUsuario;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textb_contrasenia;
        private System.Windows.Forms.TextBox textb_dni;
        private System.Windows.Forms.TextBox text_nombre;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textb_telef;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_cancelar;
    }
}