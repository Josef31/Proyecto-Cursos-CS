/*
 * Creado por SharpDevelop.
 * Usuario: Jose
 * Fecha: 19/1/2025
 * Hora: 12:31 p. m.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Proyecto_19_01
{

	public partial class MainForm : Form
	{
		
		private Coleccion_Curso curso = new Coleccion_Curso();
		
		public MainForm()
		{
			InitializeComponent();
			btn_Limpiar.Click += new EventHandler(btn_Limpiar_Click);
			btn_Registrar.Click += new EventHandler(btn_Registrar_Click);
			btn_buscar.Click += new EventHandler(btn_buscar_Click);
			btn_actualizar.Click += new EventHandler(btn_actualizar_Click);
			btn_eliminar.Click += new EventHandler(btn_eliminar_Click);
			
			
		}

		void btn_eliminar_Click(object sender, EventArgs e)
		{
			String code = tbx_codigo.Text;
			if (curso.Buscar(code) == true)
			{
    		    Curso m = curso.Consultar(code);
				DialogResult w = MessageBox.Show("Quieres eliminar los datos del curso con el siguiente codigo?: " + m.Codigo,
    		                                     "Pregunta de Confirmación",MessageBoxButtons.YesNo,
    		                                     MessageBoxIcon.Warning);
    		    if (w == DialogResult.Yes)
    		    {
				    curso.Borrar(m);
				    MessageBox.Show("Los datos del curso han sido eliminados de la lista","Informacion");
				    tbx_codigo.Clear();
					tbx_instructor.Clear();
					tbx_titulo.Clear();
					cbx_tipo.ResetText();
					tbx_horas.Clear();
					dtp_inicio.Value = DateTime.Now;
					dtp_cierre.Value = DateTime.Now;
					tbx_estudiantes.Clear();
					cbx_activo.Checked = false;
					tbx_codigo.Focus();
    		    }
			} else 
			{
				MessageBox.Show("El codigo del curso no fue encontrado.","Informacion");				
			}
			
		}
		 

		void btn_actualizar_Click(object sender, EventArgs e)
		{
			Curso x = new Curso();
			
			x.Codigo = tbx_codigo.Text;
			tbx_codigo.Enabled = true;
			x.Instructor = tbx_instructor.Text;
			String InstructorNombre = tbx_instructor.Text.Trim();
			String[] NOMBRES = InstructorNombre.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
			if (NOMBRES.Length < 2)
    {
        MessageBox.Show("Por favor, ingrese tanto el nombre como el apellido del instructor.", "RECORDATORIO", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
        tbx_instructor.Focus(); // Regresar el foco al TextBox
        return; // Sale del método si la validación falla
    }
			x.Instructor = InstructorNombre;
			x.Titulo = tbx_titulo.Text;
			x.Tipo = cbx_tipo.SelectedItem.ToString();
			Int16 horas;
			try
			{
				if (!Int16.TryParse(tbx_horas.Text, out horas))
    {
        MessageBox.Show("Por favor, ingrese solo números para determinar la hora .", "ADVERTENCIA", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
    }
				tbx_horas.Clear();
				
				
        
        if (horas < 20 || horas > 80)
        {
            MessageBox.Show("El número de horas debe estar entre 20 y 80.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return; // Salir del método si la validación falla
        }
        
        x.Horas = horas; // Asignar el valor si es válido
    }

    catch (OverflowException)
    {
        MessageBox.Show("El número de horas es demasiado grande o pequeño.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return; // Salir del método si hay un desbordamiento
    
			}
			x.Fecha_Inicio = dtp_inicio.Value;
			x.Fecha_Cierre = dtp_cierre.Value;
			Int16 cant_estudiantes;
			try
			{
				if (!Int16.TryParse(tbx_estudiantes.Text, out cant_estudiantes))
    {
        MessageBox.Show("Por favor, ingrese solo números enteros.", "ADVERTENCIA", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return; 
    }
				
				if(cant_estudiantes < 4 || cant_estudiantes > 10)
				{
		MessageBox.Show("La cantidad minima requerida para el curso son de 4 alumnos y maxima de 10","ADVERTENCIA",
					                MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			x.Cant_Estudiantes = cant_estudiantes;
			}
			
				catch(OverflowException)
				{
				
					MessageBox.Show("El numero de estudiantes es demasiado grande","ERROR",MessageBoxButtons.RetryCancel,MessageBoxIcon.Error);
				}
			
			x.Activo = cbx_activo.Checked;
						
			if (curso.Buscar(x.Codigo) == true)
			{
				curso.Actualizar(x);
				MessageBox.Show("Datos del Curso Actualizados","Informacion");
				tbx_codigo.Clear();
				tbx_codigo.Clear();
				tbx_instructor.Clear();
				tbx_titulo.Clear();
				cbx_tipo.ResetText();
				tbx_horas.Clear();
				dtp_inicio.Value = DateTime.Now;
				dtp_cierre.Value = DateTime.Now;
				tbx_estudiantes.Clear();
				cbx_activo.Checked = false;
				tbx_codigo.Focus();
			} else 
			{
				MessageBox.Show("Codigo del incorrecto o inexistente.","Informacion");				
			}
		}

		void btn_buscar_Click(object sender, EventArgs e)
		{
			String code = tbx_codigo.Text.Trim();
		
			if(String.IsNullOrEmpty(code)|| code.Length < 4)
			{
				MessageBox.Show("El campo de codigo no puede estar vacío si algo deseas buscar .", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			tbx_codigo.Focus();
			if (curso.Buscar(code) == true)
			{
				Curso m = curso.Consultar(code);
				if (m.Activo == false)
				{
				    MessageBox.Show("Curso registrado pero no activo","Informacion");
                    tbx_codigo.Clear();
					tbx_instructor.Clear();
					tbx_titulo.Clear();
					cbx_tipo.ResetText();
					tbx_horas.Clear();
					dtp_inicio.Value = DateTime.Now;
					dtp_cierre.Value = DateTime.Now;
					tbx_estudiantes.Clear();
					cbx_activo.Checked = false;
					tbx_codigo.Focus();
				} else 
				{
				    
					tbx_instructor.Text = m.Instructor;
					tbx_titulo.Text = m.Titulo;
					cbx_tipo.Text = m.Tipo;
					tbx_horas.Text = Convert.ToString(m.Horas);
					dtp_inicio.Value = m.Fecha_Inicio;
					dtp_cierre.Value = m.Fecha_Cierre;
					tbx_estudiantes.Text = Convert.ToString(m.Cant_Estudiantes);
					cbx_activo.Checked = m.Activo;
					
				
				}
			} else 
			{
				MessageBox.Show("Curso no registrado o el campo de codigo esta vacio","Informacion");
                tbx_codigo.Clear();
				tbx_instructor.Clear();
				tbx_titulo.Clear();
				cbx_tipo.ResetText();
				tbx_horas.Clear();
				dtp_inicio.Value = DateTime.Now;
				dtp_cierre.Value = DateTime.Now;
				tbx_estudiantes.Clear();
				cbx_activo.Checked = false;
				tbx_codigo.Focus();
			}
		}

		void btn_Registrar_Click(object sender, EventArgs e)
		{
			String code = tbx_codigo.Text;
			if(curso.Buscar(code) == false && tbx_codigo.Text.Trim().Length > 0){
				Curso x = new Curso();
				x.Codigo = tbx_codigo.Text;
				String Codigo = tbx_codigo.Text.Trim();
			if(String.IsNullOrEmpty(Codigo)|| Codigo.Length < 4)
			{
				MessageBox.Show("El campo de codigo no puede estar vacío y debe contener al menos 4 caracteres.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			tbx_codigo.Focus();
				x.Instructor = tbx_instructor.Text;
						String InstructorNombre = tbx_instructor.Text.Trim();
			String[] NOMBRES = InstructorNombre.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
			if (NOMBRES.Length < 2)
    {
        MessageBox.Show("Por favor, ingrese tanto el nombre como el apellido del instructor.", "RECORDATORIO", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
        tbx_instructor.Focus(); // Regresar el foco al TextBox
        return; // Sale del método si la validación falla
    }
				x.Titulo = tbx_titulo.Text;
				x.Tipo = cbx_tipo.SelectedItem.ToString();
			
				
				Int16 horas;
					try
				{
						if (!Int16.TryParse(tbx_horas.Text, out horas))
    {
        MessageBox.Show("Por favor, ingrese solo números para determinar la hora .", "ADVERTENCIA", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
    }
        
        if (horas < 20 || horas > 80)
        {
            MessageBox.Show("El número de horas debe estar entre 20 y 80. ingresa una hora valida", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return; // Se sale del método si la validación falla
        }
        
        x.Horas = horas; // Asigna el valor si es válido
    }
    
    catch (OverflowException)
    {
        MessageBox.Show("El número de horas es demasiado grande o pequeño.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return; // Sale del método si hay un desbordamiento
    }
				x.Fecha_Inicio = dtp_inicio.Value;
				x.Fecha_Cierre = dtp_cierre.Value;
				x.Cant_Estudiantes = Convert.ToInt16(tbx_estudiantes.Text);
				Int16 cant_estudiantes2;
			try
			{
				if (!Int16.TryParse(tbx_estudiantes.Text, out cant_estudiantes2))
    {
        MessageBox.Show("Por favor, ingrese solo números enteros.", "ADVERTENCIA", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return; // Salir del método si la entrada no es válida
    }
				
				if(cant_estudiantes2 < 4 || cant_estudiantes2 > 10)
				{
		MessageBox.Show("La cantidad minima requerida para el curso son de 4 alumnos y maxima de 10","ADVERTENCIA",
					                MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			x.Cant_Estudiantes = cant_estudiantes2;
			}
			catch(FormatException)
			{
			MessageBox.Show("formato no valido","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			
				catch(OverflowException)
				{
				
					MessageBox.Show("El numero de estudiantes es demasiado grande","ERROR",MessageBoxButtons.RetryCancel,MessageBoxIcon.Error);
				}
				x.Activo = cbx_activo.Checked;
				curso.Registrar(x);
				
				MessageBox.Show("Curso registrado exitosamente", "Informacion");
				tbx_codigo.Clear();
				tbx_instructor.Clear();
				tbx_titulo.Clear();
				cbx_tipo.ResetText();
				tbx_horas.Clear();
				dtp_inicio.Value = DateTime.Now;
				dtp_cierre.Value = DateTime.Now;
				tbx_estudiantes.Clear();
				cbx_activo.Checked = false;
				tbx_codigo.Focus();
				
				
			}else{
				MessageBox.Show("El codigo ya existe, o el campo esta vacio");
			}
		}

		void btn_Limpiar_Click(object sender, EventArgs e)
		{
			
			tbx_codigo.Clear();
			tbx_instructor.Clear();
			tbx_titulo.Clear();
			cbx_tipo.ResetText();
			tbx_horas.Clear();
			dtp_inicio.Value = DateTime.Now;
			dtp_cierre.Value = DateTime.Now;
			tbx_estudiantes.Clear();
			cbx_activo.Checked = false;
			tbx_codigo.Focus();
			
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			
		}
	}
		
}
