namespace Conexionsqlserver
{
    partial class Caracteristica
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.dataGV_carect = new System.Windows.Forms.DataGridView();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.textb_buscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cmbx_arte = new System.Windows.Forms.ComboBox();
            this.text_detalles = new System.Windows.Forms.TextBox();
            this.text_grosor = new System.Windows.Forms.TextBox();
            this.textb_altura = new System.Windows.Forms.TextBox();
            this.text_pintura = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tab_modificado.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_carect)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btn_eliminar);
            this.panel1.Controls.Add(this.btn_agregar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1085, 94);
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
            this.btn_eliminar.Location = new System.Drawing.Point(907, 32);
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
            this.btn_agregar.Location = new System.Drawing.Point(762, 32);
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
            this.label1.Location = new System.Drawing.Point(31, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Caracteristicas del Objeto";
            // 
            // tab_modificado
            // 
            this.tab_modificado.Controls.Add(this.tabPage2);
            this.tab_modificado.Controls.Add(this.tabPage3);
            this.tab_modificado.Location = new System.Drawing.Point(27, 194);
            this.tab_modificado.Name = "tab_modificado";
            this.tab_modificado.SelectedIndex = 0;
            this.tab_modificado.Size = new System.Drawing.Size(1041, 358);
            this.tab_modificado.TabIndex = 5;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_actualizar);
            this.tabPage2.Controls.Add(this.dataGV_carect);
            this.tabPage2.Controls.Add(this.btn_buscar);
            this.tabPage2.Controls.Add(this.textb_buscar);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1033, 332);
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
            // dataGV_carect
            // 
            this.dataGV_carect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_carect.Location = new System.Drawing.Point(188, 138);
            this.dataGV_carect.Name = "dataGV_carect";
            this.dataGV_carect.Size = new System.Drawing.Size(643, 167);
            this.dataGV_carect.TabIndex = 4;
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
            this.tabPage3.Controls.Add(this.cmbx_arte);
            this.tabPage3.Controls.Add(this.text_detalles);
            this.tabPage3.Controls.Add(this.text_grosor);
            this.tabPage3.Controls.Add(this.textb_altura);
            this.tabPage3.Controls.Add(this.text_pintura);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.btn_cancelar);
            this.tabPage3.Controls.Add(this.btn_guardar);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1033, 332);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Modficaciones";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // cmbx_arte
            // 
            this.cmbx_arte.FormattingEnabled = true;
            this.cmbx_arte.Location = new System.Drawing.Point(238, 57);
            this.cmbx_arte.Name = "cmbx_arte";
            this.cmbx_arte.Size = new System.Drawing.Size(218, 21);
            this.cmbx_arte.TabIndex = 32;
            // 
            // text_detalles
            // 
            this.text_detalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_detalles.Location = new System.Drawing.Point(238, 142);
            this.text_detalles.Name = "text_detalles";
            this.text_detalles.Size = new System.Drawing.Size(218, 24);
            this.text_detalles.TabIndex = 31;
            // 
            // text_grosor
            // 
            this.text_grosor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_grosor.Location = new System.Drawing.Point(721, 94);
            this.text_grosor.Name = "text_grosor";
            this.text_grosor.Size = new System.Drawing.Size(218, 24);
            this.text_grosor.TabIndex = 30;
            // 
            // textb_altura
            // 
            this.textb_altura.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textb_altura.Location = new System.Drawing.Point(721, 51);
            this.textb_altura.Name = "textb_altura";
            this.textb_altura.Size = new System.Drawing.Size(218, 24);
            this.textb_altura.TabIndex = 29;
            // 
            // text_pintura
            // 
            this.text_pintura.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_pintura.Location = new System.Drawing.Point(238, 97);
            this.text_pintura.Name = "text_pintura";
            this.text_pintura.Size = new System.Drawing.Size(218, 24);
            this.text_pintura.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(557, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 18);
            this.label9.TabIndex = 26;
            this.label9.Text = "Grosor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(557, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 18);
            this.label7.TabIndex = 25;
            this.label7.Text = "Altura";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(63, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 18);
            this.label5.TabIndex = 24;
            this.label5.Text = "Otros detalles";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 18);
            this.label4.TabIndex = 23;
            this.label4.Text = "Tipo de Pintura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 18);
            this.label3.TabIndex = 22;
            this.label3.Text = "Nombre";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.White;
            this.btn_cancelar.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btn_cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.btn_cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_cancelar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.SlateGray;
            this.btn_cancelar.Location = new System.Drawing.Point(516, 245);
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
            this.btn_guardar.Location = new System.Drawing.Point(404, 245);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(74, 34);
            this.btn_guardar.TabIndex = 14;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // Caracteristica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Conexionsqlserver.Properties.Resources.museo_azul1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1080, 580);
            this.Controls.Add(this.tab_modificado);
            this.Controls.Add(this.panel1);
            this.Name = "Caracteristica";
            this.Text = "Caracteristica";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tab_modificado.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_carect)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGV_carect;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox textb_buscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox text_detalles;
        private System.Windows.Forms.TextBox text_grosor;
        private System.Windows.Forms.TextBox textb_altura;
        private System.Windows.Forms.TextBox text_pintura;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.ComboBox cmbx_arte;
    }
}