namespace Conexionsqlserver
{
    partial class ArtistForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArtistForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dateTp_fch_fallecimiento = new System.Windows.Forms.DateTimePicker();
            this.dateTp_fch_naci = new System.Windows.Forms.DateTimePicker();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.cmbx_Estilo = new System.Windows.Forms.ComboBox();
            this.cmbx_Pais = new System.Windows.Forms.ComboBox();
            this.text_descripcion = new System.Windows.Forms.TextBox();
            this.text_epoca = new System.Windows.Forms.TextBox();
            this.text_nombre = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.textb_buscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tab_modificado = new System.Windows.Forms.TabControl();
            this.panel1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tab_modificado.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btn_eliminar);
            this.panel1.Controls.Add(this.btn_agregar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.Color.SteelBlue;
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1069, 64);
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
            this.btn_eliminar.Location = new System.Drawing.Point(859, 14);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(74, 34);
            this.btn_eliminar.TabIndex = 3;
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
            this.btn_agregar.Location = new System.Drawing.Point(753, 14);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(74, 34);
            this.btn_agregar.TabIndex = 1;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = false;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.AliceBlue;
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Artistas";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dateTp_fch_fallecimiento);
            this.tabPage3.Controls.Add(this.dateTp_fch_naci);
            this.tabPage3.Controls.Add(this.btn_cancelar);
            this.tabPage3.Controls.Add(this.btn_guardar);
            this.tabPage3.Controls.Add(this.cmbx_Estilo);
            this.tabPage3.Controls.Add(this.cmbx_Pais);
            this.tabPage3.Controls.Add(this.text_descripcion);
            this.tabPage3.Controls.Add(this.text_epoca);
            this.tabPage3.Controls.Add(this.text_nombre);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1042, 380);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Modficaciones";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dateTp_fch_fallecimiento
            // 
            this.dateTp_fch_fallecimiento.Location = new System.Drawing.Point(245, 164);
            this.dateTp_fch_fallecimiento.Name = "dateTp_fch_fallecimiento";
            this.dateTp_fch_fallecimiento.Size = new System.Drawing.Size(200, 20);
            this.dateTp_fch_fallecimiento.TabIndex = 21;
            // 
            // dateTp_fch_naci
            // 
            this.dateTp_fch_naci.Location = new System.Drawing.Point(245, 105);
            this.dateTp_fch_naci.Name = "dateTp_fch_naci";
            this.dateTp_fch_naci.Size = new System.Drawing.Size(200, 20);
            this.dateTp_fch_naci.TabIndex = 20;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.White;
            this.btn_cancelar.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btn_cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.btn_cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_cancelar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.SlateGray;
            this.btn_cancelar.Location = new System.Drawing.Point(525, 291);
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
            this.btn_guardar.Location = new System.Drawing.Point(404, 291);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(74, 34);
            this.btn_guardar.TabIndex = 14;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // cmbx_Estilo
            // 
            this.cmbx_Estilo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbx_Estilo.FormattingEnabled = true;
            this.cmbx_Estilo.Location = new System.Drawing.Point(680, 50);
            this.cmbx_Estilo.Name = "cmbx_Estilo";
            this.cmbx_Estilo.Size = new System.Drawing.Size(238, 26);
            this.cmbx_Estilo.TabIndex = 13;
            // 
            // cmbx_Pais
            // 
            this.cmbx_Pais.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbx_Pais.FormattingEnabled = true;
            this.cmbx_Pais.Location = new System.Drawing.Point(126, 221);
            this.cmbx_Pais.Name = "cmbx_Pais";
            this.cmbx_Pais.Size = new System.Drawing.Size(141, 26);
            this.cmbx_Pais.TabIndex = 12;
            // 
            // text_descripcion
            // 
            this.text_descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_descripcion.Location = new System.Drawing.Point(680, 164);
            this.text_descripcion.Name = "text_descripcion";
            this.text_descripcion.Size = new System.Drawing.Size(238, 24);
            this.text_descripcion.TabIndex = 11;
            // 
            // text_epoca
            // 
            this.text_epoca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_epoca.Location = new System.Drawing.Point(680, 99);
            this.text_epoca.Name = "text_epoca";
            this.text_epoca.Size = new System.Drawing.Size(238, 24);
            this.text_epoca.TabIndex = 10;
            // 
            // text_nombre
            // 
            this.text_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_nombre.Location = new System.Drawing.Point(245, 52);
            this.text_nombre.Name = "text_nombre";
            this.text_nombre.Size = new System.Drawing.Size(233, 24);
            this.text_nombre.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(552, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 18);
            this.label9.TabIndex = 6;
            this.label9.Text = "Descripcion";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(552, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 18);
            this.label8.TabIndex = 5;
            this.label8.Text = "Estilo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(552, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 18);
            this.label7.TabIndex = 4;
            this.label7.Text = "Epoca";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(58, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "Pais";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(58, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Fecha de Fallecimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Fecha de Nacimiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombre";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_actualizar);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.btn_buscar);
            this.tabPage2.Controls.Add(this.textb_buscar);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1042, 380);
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
            this.btn_actualizar.Location = new System.Drawing.Point(860, 107);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(102, 34);
            this.btn_actualizar.TabIndex = 4;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.UseVisualStyleBackColor = false;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(128, 171);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(737, 183);
            this.dataGridView1.TabIndex = 4;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(697, 107);
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
            this.textb_buscar.Location = new System.Drawing.Point(203, 101);
            this.textb_buscar.Name = "textb_buscar";
            this.textb_buscar.Size = new System.Drawing.Size(432, 32);
            this.textb_buscar.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(98, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Buscar :";
            // 
            // tab_modificado
            // 
            this.tab_modificado.Controls.Add(this.tabPage2);
            this.tab_modificado.Controls.Add(this.tabPage3);
            this.tab_modificado.Location = new System.Drawing.Point(12, 100);
            this.tab_modificado.Name = "tab_modificado";
            this.tab_modificado.SelectedIndex = 0;
            this.tab_modificado.Size = new System.Drawing.Size(1050, 406);
            this.tab_modificado.TabIndex = 2;
            // 
            // ArtistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Conexionsqlserver.Properties.Resources.museo_azul;
            this.ClientSize = new System.Drawing.Size(1066, 518);
            this.Controls.Add(this.tab_modificado);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ArtistForm";
            this.Text = "ArtistForm";
            this.Load += new System.EventHandler(this.ArtistForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tab_modificado.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textb_buscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tab_modificado;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbx_Estilo;
        private System.Windows.Forms.ComboBox cmbx_Pais;
        private System.Windows.Forms.TextBox text_descripcion;
        private System.Windows.Forms.TextBox text_epoca;
        private System.Windows.Forms.TextBox text_nombre;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.DateTimePicker dateTp_fch_naci;
        private System.Windows.Forms.DateTimePicker dateTp_fch_fallecimiento;
    }
}