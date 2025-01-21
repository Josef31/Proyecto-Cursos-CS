/*
 * Creado por SharpDevelop.
 * Usuario: Jose
 * Fecha: 19/1/2025
 * Hora: 12:31 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Proyecto_19_01
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.lbl_codigo = new System.Windows.Forms.Label();
			this.tbx_codigo = new System.Windows.Forms.TextBox();
			this.tbx_instructor = new System.Windows.Forms.TextBox();
			this.lbl_instructor = new System.Windows.Forms.Label();
			this.tbx_titulo = new System.Windows.Forms.TextBox();
			this.lbl_titulo = new System.Windows.Forms.Label();
			this.lbl_tipo = new System.Windows.Forms.Label();
			this.cbx_tipo = new System.Windows.Forms.ComboBox();
			this.tbx_horas = new System.Windows.Forms.TextBox();
			this.lbl_horas = new System.Windows.Forms.Label();
			this.lbl_inicio = new System.Windows.Forms.Label();
			this.lbl_cierre = new System.Windows.Forms.Label();
			this.tbx_estudiantes = new System.Windows.Forms.TextBox();
			this.lbl_estudiantes = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.cbx_activo = new System.Windows.Forms.CheckBox();
			this.dtp_inicio = new System.Windows.Forms.DateTimePicker();
			this.dtp_cierre = new System.Windows.Forms.DateTimePicker();
			this.btn_Registrar = new System.Windows.Forms.Button();
			this.btn_buscar = new System.Windows.Forms.Button();
			this.btn_actualizar = new System.Windows.Forms.Button();
			this.btn_eliminar = new System.Windows.Forms.Button();
			this.btn_Limpiar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lbl_codigo
			// 
			this.lbl_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_codigo.Location = new System.Drawing.Point(13, 13);
			this.lbl_codigo.Name = "lbl_codigo";
			this.lbl_codigo.Size = new System.Drawing.Size(100, 23);
			this.lbl_codigo.TabIndex = 0;
			this.lbl_codigo.Text = "Codigo";
			// 
			// tbx_codigo
			// 
			this.tbx_codigo.Location = new System.Drawing.Point(179, 12);
			this.tbx_codigo.Name = "tbx_codigo";
			this.tbx_codigo.Size = new System.Drawing.Size(100, 20);
			this.tbx_codigo.TabIndex = 1;
			// 
			// tbx_instructor
			// 
			this.tbx_instructor.Location = new System.Drawing.Point(179, 48);
			this.tbx_instructor.Name = "tbx_instructor";
			this.tbx_instructor.Size = new System.Drawing.Size(100, 20);
			this.tbx_instructor.TabIndex = 3;
			// 
			// lbl_instructor
			// 
			this.lbl_instructor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_instructor.Location = new System.Drawing.Point(13, 49);
			this.lbl_instructor.Name = "lbl_instructor";
			this.lbl_instructor.Size = new System.Drawing.Size(100, 23);
			this.lbl_instructor.TabIndex = 2;
			this.lbl_instructor.Text = "Instructor";
			// 
			// tbx_titulo
			// 
			this.tbx_titulo.Location = new System.Drawing.Point(179, 86);
			this.tbx_titulo.Name = "tbx_titulo";
			this.tbx_titulo.Size = new System.Drawing.Size(100, 20);
			this.tbx_titulo.TabIndex = 5;
			// 
			// lbl_titulo
			// 
			this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_titulo.Location = new System.Drawing.Point(13, 87);
			this.lbl_titulo.Name = "lbl_titulo";
			this.lbl_titulo.Size = new System.Drawing.Size(100, 23);
			this.lbl_titulo.TabIndex = 4;
			this.lbl_titulo.Text = "Titulo";
			// 
			// lbl_tipo
			// 
			this.lbl_tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_tipo.Location = new System.Drawing.Point(13, 127);
			this.lbl_tipo.Name = "lbl_tipo";
			this.lbl_tipo.Size = new System.Drawing.Size(100, 23);
			this.lbl_tipo.TabIndex = 6;
			this.lbl_tipo.Text = "Tipo";
			// 
			// cbx_tipo
			// 
			this.cbx_tipo.FormattingEnabled = true;
			this.cbx_tipo.Items.AddRange(new object[] {
									"Presencial",
									"Semipresencial",
									"Virtual"});
			this.cbx_tipo.Location = new System.Drawing.Point(179, 126);
			this.cbx_tipo.Name = "cbx_tipo";
			this.cbx_tipo.Size = new System.Drawing.Size(121, 21);
			this.cbx_tipo.TabIndex = 7;
			// 
			// tbx_horas
			// 
			this.tbx_horas.Location = new System.Drawing.Point(183, 165);
			this.tbx_horas.Name = "tbx_horas";
			this.tbx_horas.Size = new System.Drawing.Size(100, 20);
			this.tbx_horas.TabIndex = 9;
			// 
			// lbl_horas
			// 
			this.lbl_horas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_horas.Location = new System.Drawing.Point(13, 166);
			this.lbl_horas.Name = "lbl_horas";
			this.lbl_horas.Size = new System.Drawing.Size(100, 23);
			this.lbl_horas.TabIndex = 8;
			this.lbl_horas.Text = "Horas";
			// 
			// lbl_inicio
			// 
			this.lbl_inicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_inicio.Location = new System.Drawing.Point(13, 205);
			this.lbl_inicio.Name = "lbl_inicio";
			this.lbl_inicio.Size = new System.Drawing.Size(100, 23);
			this.lbl_inicio.TabIndex = 10;
			this.lbl_inicio.Text = "Fecha Inicio";
			// 
			// lbl_cierre
			// 
			this.lbl_cierre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_cierre.Location = new System.Drawing.Point(13, 244);
			this.lbl_cierre.Name = "lbl_cierre";
			this.lbl_cierre.Size = new System.Drawing.Size(100, 23);
			this.lbl_cierre.TabIndex = 12;
			this.lbl_cierre.Text = "Fecha Cierre";
			// 
			// tbx_estudiantes
			// 
			this.tbx_estudiantes.Location = new System.Drawing.Point(179, 279);
			this.tbx_estudiantes.Name = "tbx_estudiantes";
			this.tbx_estudiantes.Size = new System.Drawing.Size(100, 20);
			this.tbx_estudiantes.TabIndex = 15;
			// 
			// lbl_estudiantes
			// 
			this.lbl_estudiantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_estudiantes.Location = new System.Drawing.Point(13, 280);
			this.lbl_estudiantes.Name = "lbl_estudiantes";
			this.lbl_estudiantes.Size = new System.Drawing.Size(155, 23);
			this.lbl_estudiantes.TabIndex = 14;
			this.lbl_estudiantes.Text = "Cantidad Estudiantes";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(13, 319);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 16;
			this.label1.Text = "Curso Activo";
			// 
			// cbx_activo
			// 
			this.cbx_activo.ForeColor = System.Drawing.Color.Black;
			this.cbx_activo.Location = new System.Drawing.Point(179, 317);
			this.cbx_activo.Name = "cbx_activo";
			this.cbx_activo.Size = new System.Drawing.Size(104, 24);
			this.cbx_activo.TabIndex = 17;
			this.cbx_activo.UseVisualStyleBackColor = true;
			// 
			// dtp_inicio
			// 
			this.dtp_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtp_inicio.Location = new System.Drawing.Point(179, 207);
			this.dtp_inicio.Name = "dtp_inicio";
			this.dtp_inicio.Size = new System.Drawing.Size(100, 20);
			this.dtp_inicio.TabIndex = 18;
			// 
			// dtp_cierre
			// 
			this.dtp_cierre.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtp_cierre.Location = new System.Drawing.Point(179, 240);
			this.dtp_cierre.Name = "dtp_cierre";
			this.dtp_cierre.Size = new System.Drawing.Size(100, 20);
			this.dtp_cierre.TabIndex = 19;
			// 
			// btn_Registrar
			// 
			this.btn_Registrar.Location = new System.Drawing.Point(12, 376);
			this.btn_Registrar.Name = "btn_Registrar";
			this.btn_Registrar.Size = new System.Drawing.Size(75, 23);
			this.btn_Registrar.TabIndex = 20;
			this.btn_Registrar.Text = "Registar";
			this.btn_Registrar.UseVisualStyleBackColor = true;
			// 
			// btn_buscar
			// 
			this.btn_buscar.Location = new System.Drawing.Point(111, 376);
			this.btn_buscar.Name = "btn_buscar";
			this.btn_buscar.Size = new System.Drawing.Size(75, 23);
			this.btn_buscar.TabIndex = 21;
			this.btn_buscar.Text = "Buscar";
			this.btn_buscar.UseVisualStyleBackColor = true;
			// 
			// btn_actualizar
			// 
			this.btn_actualizar.Location = new System.Drawing.Point(204, 376);
			this.btn_actualizar.Name = "btn_actualizar";
			this.btn_actualizar.Size = new System.Drawing.Size(75, 23);
			this.btn_actualizar.TabIndex = 22;
			this.btn_actualizar.Text = "Actualizar";
			this.btn_actualizar.UseVisualStyleBackColor = true;
			// 
			// btn_eliminar
			// 
			this.btn_eliminar.Location = new System.Drawing.Point(298, 376);
			this.btn_eliminar.Name = "btn_eliminar";
			this.btn_eliminar.Size = new System.Drawing.Size(75, 23);
			this.btn_eliminar.TabIndex = 23;
			this.btn_eliminar.Text = "Eliminar";
			this.btn_eliminar.UseVisualStyleBackColor = true;
			// 
			// btn_Limpiar
			// 
			this.btn_Limpiar.Location = new System.Drawing.Point(298, 319);
			this.btn_Limpiar.Name = "btn_Limpiar";
			this.btn_Limpiar.Size = new System.Drawing.Size(75, 23);
			this.btn_Limpiar.TabIndex = 24;
			this.btn_Limpiar.Text = "Limpiar";
			this.btn_Limpiar.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Info;
			this.ClientSize = new System.Drawing.Size(603, 454);
			this.Controls.Add(this.btn_Limpiar);
			this.Controls.Add(this.btn_eliminar);
			this.Controls.Add(this.btn_actualizar);
			this.Controls.Add(this.btn_buscar);
			this.Controls.Add(this.btn_Registrar);
			this.Controls.Add(this.dtp_cierre);
			this.Controls.Add(this.dtp_inicio);
			this.Controls.Add(this.cbx_activo);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbx_estudiantes);
			this.Controls.Add(this.lbl_estudiantes);
			this.Controls.Add(this.lbl_cierre);
			this.Controls.Add(this.lbl_inicio);
			this.Controls.Add(this.tbx_horas);
			this.Controls.Add(this.lbl_horas);
			this.Controls.Add(this.cbx_tipo);
			this.Controls.Add(this.lbl_tipo);
			this.Controls.Add(this.tbx_titulo);
			this.Controls.Add(this.lbl_titulo);
			this.Controls.Add(this.tbx_instructor);
			this.Controls.Add(this.lbl_instructor);
			this.Controls.Add(this.tbx_codigo);
			this.Controls.Add(this.lbl_codigo);
			this.Name = "MainForm";
			this.Text = "Cursos";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btn_Limpiar;
		private System.Windows.Forms.Button btn_eliminar;
		private System.Windows.Forms.Button btn_actualizar;
		private System.Windows.Forms.Button btn_buscar;
		private System.Windows.Forms.Button btn_Registrar;
		private System.Windows.Forms.DateTimePicker dtp_cierre;
		private System.Windows.Forms.DateTimePicker dtp_inicio;
		private System.Windows.Forms.CheckBox cbx_activo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lbl_estudiantes;
		private System.Windows.Forms.TextBox tbx_estudiantes;
		private System.Windows.Forms.Label lbl_cierre;
		private System.Windows.Forms.Label lbl_inicio;
		private System.Windows.Forms.Label lbl_horas;
		private System.Windows.Forms.TextBox tbx_horas;
		private System.Windows.Forms.ComboBox cbx_tipo;
		private System.Windows.Forms.Label lbl_tipo;
		private System.Windows.Forms.Label lbl_titulo;
		private System.Windows.Forms.TextBox tbx_titulo;
		private System.Windows.Forms.Label lbl_instructor;
		private System.Windows.Forms.TextBox tbx_instructor;
		private System.Windows.Forms.TextBox tbx_codigo;
		private System.Windows.Forms.Label lbl_codigo;
	}
}
