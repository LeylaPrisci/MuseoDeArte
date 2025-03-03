namespace Conexionsqlserver
{
    partial class Exhibicion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exhibicion));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tab_modificado = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.dataGridViewExhibicion = new System.Windows.Forms.DataGridView();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.textb_buscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dateTimePFinalizacion = new System.Windows.Forms.DateTimePicker();
            this.dateTp_FInicio = new System.Windows.Forms.DateTimePicker();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.text_nombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tab_modificado.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExhibicion)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btn_eliminar);
            this.panel1.Controls.Add(this.btn_agregar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1091, 95);
            this.panel1.TabIndex = 1;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.White;
            this.btn_eliminar.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btn_eliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.btn_eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_eliminar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.ForeColor = System.Drawing.Color.SlateGray;
            this.btn_eliminar.Location = new System.Drawing.Point(913, 27);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(74, 34);
            this.btn_eliminar.TabIndex = 4;
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
            this.btn_agregar.Location = new System.Drawing.Point(800, 27);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(74, 34);
            this.btn_agregar.TabIndex = 2;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = false;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.AliceBlue;
            this.label1.Location = new System.Drawing.Point(27, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Exhibicion";
            // 
            // tab_modificado
            // 
            this.tab_modificado.Controls.Add(this.tabPage2);
            this.tab_modificado.Controls.Add(this.tabPage3);
            this.tab_modificado.Location = new System.Drawing.Point(31, 174);
            this.tab_modificado.Name = "tab_modificado";
            this.tab_modificado.SelectedIndex = 0;
            this.tab_modificado.Size = new System.Drawing.Size(1021, 297);
            this.tab_modificado.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_actualizar);
            this.tabPage2.Controls.Add(this.dataGridViewExhibicion);
            this.tabPage2.Controls.Add(this.btn_buscar);
            this.tabPage2.Controls.Add(this.textb_buscar);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1013, 271);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Listado";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.BackColor = System.Drawing.Color.White;
            this.btn_actualizar.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btn_actualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.btn_actualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_actualizar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actualizar.ForeColor = System.Drawing.Color.SlateGray;
            this.btn_actualizar.Location = new System.Drawing.Point(761, 44);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(102, 34);
            this.btn_actualizar.TabIndex = 4;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.UseVisualStyleBackColor = false;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // dataGridViewExhibicion
            // 
            this.dataGridViewExhibicion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExhibicion.Location = new System.Drawing.Point(211, 109);
            this.dataGridViewExhibicion.Name = "dataGridViewExhibicion";
            this.dataGridViewExhibicion.Size = new System.Drawing.Size(442, 140);
            this.dataGridViewExhibicion.TabIndex = 4;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(671, 44);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(84, 34);
            this.btn_buscar.TabIndex = 3;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // textb_buscar
            // 
            this.textb_buscar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textb_buscar.Location = new System.Drawing.Point(211, 46);
            this.textb_buscar.Name = "textb_buscar";
            this.textb_buscar.Size = new System.Drawing.Size(432, 32);
            this.textb_buscar.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(134, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Buscar :";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dateTimePFinalizacion);
            this.tabPage3.Controls.Add(this.dateTp_FInicio);
            this.tabPage3.Controls.Add(this.btn_cancelar);
            this.tabPage3.Controls.Add(this.btn_guardar);
            this.tabPage3.Controls.Add(this.text_nombre);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1013, 271);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Modficaciones";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dateTimePFinalizacion
            // 
            this.dateTimePFinalizacion.Location = new System.Drawing.Point(823, 107);
            this.dateTimePFinalizacion.Name = "dateTimePFinalizacion";
            this.dateTimePFinalizacion.Size = new System.Drawing.Size(151, 20);
            this.dateTimePFinalizacion.TabIndex = 21;
            // 
            // dateTp_FInicio
            // 
            this.dateTp_FInicio.Location = new System.Drawing.Point(430, 105);
            this.dateTp_FInicio.Name = "dateTp_FInicio";
            this.dateTp_FInicio.Size = new System.Drawing.Size(151, 20);
            this.dateTp_FInicio.TabIndex = 20;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.White;
            this.btn_cancelar.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btn_cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.btn_cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_cancelar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.SlateGray;
            this.btn_cancelar.Location = new System.Drawing.Point(535, 194);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(74, 34);
            this.btn_cancelar.TabIndex = 15;
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
            this.btn_guardar.Location = new System.Drawing.Point(376, 194);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(74, 34);
            this.btn_guardar.TabIndex = 14;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // text_nombre
            // 
            this.text_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_nombre.Location = new System.Drawing.Point(107, 99);
            this.text_nombre.Name = "text_nombre";
            this.text_nombre.Size = new System.Drawing.Size(158, 24);
            this.text_nombre.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(621, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Fecha de Finalizacion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(291, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Fecha de Inicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombre";
            // 
            // Exhibicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Conexionsqlserver.Properties.Resources.museo_azul2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1086, 493);
            this.Controls.Add(this.tab_modificado);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Exhibicion";
            this.Text = "Exhibicion";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tab_modificado.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExhibicion)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tab_modificado;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.DataGridView dataGridViewExhibicion;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox textb_buscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.TextBox text_nombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePFinalizacion;
        private System.Windows.Forms.DateTimePicker dateTp_FInicio;
    }
}