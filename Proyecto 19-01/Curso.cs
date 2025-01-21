using System;

namespace Proyecto_19_01
{

	public class Curso
	{
		
		private String codigo, instructor, titulo, tipo;
		private DateTime fecha_inicio, fecha_cierre;
		private Int16 horas, cant_estudiantes;
		private Boolean activo; 
		
		public String Codigo {get {return codigo;} set {codigo = value;}}
		public String Instructor {get {return instructor;} set {instructor = value;}}
		public String Titulo {get {return titulo;} set {titulo = value;}}
		public String Tipo {get {return tipo;} set {tipo = value;}}
		public Int16 Horas {get {return horas;} set {horas = value;}}
		public DateTime Fecha_Inicio {get {return fecha_inicio;} set {fecha_inicio = value;}}
		public DateTime Fecha_Cierre {get {return fecha_cierre;} set {fecha_cierre = value;}}
		public Int16 Cant_Estudiantes {get {return cant_estudiantes;} set {cant_estudiantes = value;}}
		public Boolean Activo {get {return activo;} set {activo = value;}}
		
		public Curso()
		{
		}
	}
}
