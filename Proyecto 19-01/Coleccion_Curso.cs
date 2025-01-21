using System;
using System.Collections.Generic;

namespace Proyecto_19_01
{

	public class Coleccion_Curso
	{
		
		private List<Curso> curso_lista = new List<Curso>();
		public List<Curso> Curso_Lista {get {return curso_lista;} set {curso_lista = value;}}
		
		public Coleccion_Curso()
		{
			Curso_Lista = new List<Curso>();
		}
		
		
		public void Registrar(Curso x){
			Curso_Lista.Add(x);
		}
		
		public Boolean Buscar(String n)
		{
			Boolean x = false;
			Int16 j = 0;
			while ((j < Curso_Lista.Count) && (!x))
			{
				if (Curso_Lista[j].Codigo == n) x = true;
				j++;
			}
			return x;
		}
		
		public Curso Consultar(String n)
		{
			Curso u = new Curso();
			Boolean x = false;
			Int16 j = 0;
			while ((j < Curso_Lista.Count) && (!x))
			{
				if (Curso_Lista[j].Codigo == n && Curso_Lista[j].Activo == true) x = true;
				   else j++;
			}
			if (x == true) u = Curso_Lista[j];
			return u;
		}
		
		
		public void Actualizar(Curso x)
		{
			Int16 j = 0;
			while (j < Curso_Lista.Count)
			{
				if (Curso_Lista[j].Codigo == x.Codigo) 
				{
					Curso_Lista[j].Instructor = x.Instructor;
					Curso_Lista[j].Titulo = x.Titulo;
					Curso_Lista[j].Tipo = x.Tipo;
					Curso_Lista[j].Horas = x.Horas;
					Curso_Lista[j].Fecha_Inicio = x.Fecha_Inicio;
					Curso_Lista[j].Fecha_Cierre = x.Fecha_Cierre;
					Curso_Lista[j].Cant_Estudiantes = x.Cant_Estudiantes;
					Curso_Lista[j].Activo = x.Activo;
			        break;
				} else j++;
			}
		}
		
		
		public void Borrar(Curso x)
		{
			Int16 j = 0;
			while (j < Curso_Lista.Count)
			{
				if (Curso_Lista[j].Codigo == x.Codigo) 
				{
					Curso_Lista[j].Activo = false;
                    break;
				} else j++;
			}
		}
		
	}
}
