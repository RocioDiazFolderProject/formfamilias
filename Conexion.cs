

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTPILabo3
{

	public class Conexion
	{
		
			private string connectionString 
				
				= "Data Source=ROCIO\\SQLEXPRESS; Initial Catalog= BARRIOS; User = sa; Password = 123456 ;" ;
				
			

			public List<casa>  get()
			{
				List<casa> tablacasa = new List<casa>();
				
				string query = "Select  Id_Casa, Tipo, Tamaño, Color from Casa";
				
				using (SqlConnection conectate = new SqlConnection(connectionString))
				{
					SqlCommand mostrarme = new SqlCommand(query, conectate);
					
					try{
						conectate.Open();
						SqlDataReader reader = mostrarme.ExecuteReader();
						while( reader.Read())
						{
							casa nueva = new casa();
							
							nueva.id = reader.GetInt32(0);
							nueva.tipo = reader.GetString(1);
							nueva.tamaño = reader.GetString(2);
							nueva.color = reader.GetString(3);
							
							
							tablacasa.Add(nueva);
							
						}
					}
					catch{
						
						MessageBox.Show("no conecto");
					}
				}
				
				return tablacasa;
			}
			public List<Persona>  GetPersona()
			{
				List<Persona> tablaPersona = new List<Persona>();
				
				string query = "Select  Id_Persona, Nombre, Edad, Sexo, fecha_Nac, trabajo, Nivel_Estudio, Id_Casa from Persona";
				
				using (SqlConnection conectate = new SqlConnection(connectionString))
				{
					SqlCommand mostrarme = new SqlCommand(query, conectate);
					
					try{
						conectate.Open();
						SqlDataReader reader = mostrarme.ExecuteReader();
						while( reader.Read())
						{
							Persona NvaPer = new Persona();
							NvaPer.id = reader.GetInt32(0);
							NvaPer.nombre= reader.GetString(1);
							NvaPer.edad = reader.GetInt32(2);
							NvaPer.sexo = reader.GetString(3);
							NvaPer.fecha_Nac = reader.GetString(4);
							NvaPer.trabajo = reader.GetString(5);
							NvaPer.nivel_estudio = reader.GetString(6);
							
							tablaPersona.Add(NvaPer);
							
						}
					}
					catch{
						
						MessageBox.Show("no conecto");
					}
				}
				
				return tablaPersona;
			}
			public List<animal>  getanimal()
			{
				List<animal> tablaAnimal = new List<animal>();
				
				string query = "Select  Id_Animal, Clase, Dieta, Nombre, Tipo, Edad, Origen from Animal";
				
				using (SqlConnection conectate = new SqlConnection(connectionString))
				{
					SqlCommand mostrarme = new SqlCommand(query, conectate);
					
					try{
						conectate.Open();
						SqlDataReader reader = mostrarme.ExecuteReader();
						while( reader.Read())
						{
							animal nueva = new animal();
							nueva.id = reader.GetInt32(0);
							nueva.clase = reader.GetString(1);
							nueva.dieta = reader.GetString(2);
							nueva.nombre = reader.GetString(3);
							nueva.tipo = reader.GetString(4);
							nueva.edad = reader.GetInt32(5);
							nueva.origen = reader.GetString(6);
							tablaAnimal.Add(nueva);
							
						}
					}
					catch{
						
						MessageBox.Show("no conecto");
					}
				}
				
				return tablaAnimal;
			}
			public List<Ambiente>  getAmbiente()
			{
				List<Ambiente> tablaAmbiente = new List<Ambiente>();
				
				string query = "Select  Tamaño, Color, Tipo from Ambiente";
				
				using (SqlConnection conectate = new SqlConnection(connectionString))
				{
					SqlCommand mostrarme = new SqlCommand(query, conectate);
					
					try{
						conectate.Open();
						SqlDataReader reader = mostrarme.ExecuteReader();
						while( reader.Read())
						{
							Ambiente nueva = new Ambiente();
							nueva.tamaño = reader.GetString(0);
							nueva.color= reader.GetString(1);
							nueva.tipo =reader.GetString(2);
							
							tablaAmbiente.Add(nueva);
							
						}
					}
					catch{
						
						MessageBox.Show("no conecto");
					}
				}
				
				return tablaAmbiente;
			}
			
			
			
	public void   SetCasa(int ID, string tipo, string tamaño, string color)		
	{
		string query2 = "Insert into casa (Id_Casa, Tipo, Tamaño, Color) values (@id, @tipo, @tamaño, @color)";
		
		using (SqlConnection conectate = new SqlConnection(connectionString))
				{
					SqlCommand mostrarme = new SqlCommand(query2, conectate);
					mostrarme.Parameters.AddWithValue("@id" , ID);
					mostrarme.Parameters.AddWithValue("@tipo" , tipo);
					mostrarme.Parameters.AddWithValue("@tamaño" , tamaño);
					mostrarme.Parameters.AddWithValue("@color" , color);
					try{
						conectate.Open();
						mostrarme.ExecuteNonQuery();
						conectate.Close();
					}
					catch{
						
					}
						
			

		
		}}
	
	public void  SetPersona( int id, string nombre, int edad, string sexo, string fecha_Nac, string trabajo, string nivel_estudio )
	{
		string query2 = "Insert into persona (Id_Persona, Nombre, Edad, Sexo, fecha_Nac, Trabajo, Nivel_Estudio) values (@id, @nombre, @edad, @sexo, @fecha_Nac, @trabajo, @nivel_estudio)";
		
		using (SqlConnection conectate = new SqlConnection(connectionString))
		{
		
					SqlCommand mostrarme = new SqlCommand(query2, conectate);
					mostrarme.Parameters.AddWithValue("@id" , id);
					mostrarme.Parameters.AddWithValue("@nombre" , nombre);
					mostrarme.Parameters.AddWithValue("@edad" , edad);
					mostrarme.Parameters.AddWithValue("@sexo" , sexo);
					mostrarme.Parameters.AddWithValue("@fecha_Nac" , fecha_Nac);
					mostrarme.Parameters.AddWithValue("@trabajo" , trabajo);
					mostrarme.Parameters.AddWithValue("@nivel_estudio" , nivel_estudio);
					
					
					try{
						conectate.Open();
						mostrarme.ExecuteNonQuery();
						conectate.Close();
					}
					catch{
						
					}
		}
	}
	
	public void  Setanimal(int Id, string clase, string dieta, string nombre, string tipo, int edad, string origen, int id_casa)
	{
		string query2 = "Insert into animal (Id_Animal, Clase, Dieta, Nombre, Tipo, Edad, Origen, Id_Casa) values (@id, @clase, @dieta, @nombre, @tipo, @edad, @origen, @id_casa)";
		
		using (SqlConnection conectate = new SqlConnection(connectionString))
		{
		
					SqlCommand mostrarme = new SqlCommand(query2, conectate);
					mostrarme.Parameters.AddWithValue("@id" , Id);
					mostrarme.Parameters.AddWithValue("@clase" , clase);
					mostrarme.Parameters.AddWithValue("@dieta" , dieta);
					mostrarme.Parameters.AddWithValue("@nombre" , nombre);
					mostrarme.Parameters.AddWithValue("@tipo" , tipo);
					mostrarme.Parameters.AddWithValue("@edad" , edad);
					mostrarme.Parameters.AddWithValue("@origen" , origen);
					mostrarme.Parameters.AddWithValue("@id_casa" , id_casa);
					
					
					
					try{
						conectate.Open();
						mostrarme.ExecuteNonQuery();
						conectate.Close();
					}
					catch{
						
					}
		}
	}
	
	public void  SetAmbiente(string tamaño, string color, string tipo)
	{	
		string query2 = "Insert into ambiente (tamaño, color, tipo) values (@tamaño, @color, @tipo)";
		
		using (SqlConnection conectate = new SqlConnection(connectionString))
		{
		
					SqlCommand mostrarme = new SqlCommand(query2, conectate);
					mostrarme.Parameters.AddWithValue("@tamaño", tamaño);
					mostrarme.Parameters.AddWithValue("@color", color);
					mostrarme.Parameters.AddWithValue("@tipo", tipo);
					
					try{
						conectate.Open();
						mostrarme.ExecuteNonQuery();
						conectate.Close();
					}
					catch{
						
					}
	}
	}

public class casa
    {
        public string tipo { get; set; }
        public string tamaño { get; set; }
        public string color { get; set; }
        public int id{get; set;}


	}
	
	public class Persona
	{
		public int id {get; set;}
		public string nombre {get; set;}
		public int edad {get; set;}
		public string sexo {get; set;}
		public string fecha_Nac {get; set;}
		public string trabajo{get;set;}
		public string nivel_estudio{get;set;}
		
		
	}
		
	public class animal
	{
		public int id {get;set;}
		public string clase {get; set;}
		public string dieta {get; set;}
		public string nombre {get; set;}
		public string tipo {get; set;}
		public int edad {get; set;}
		public string origen{get;set;}
		
	}
	
	public class Ambiente
	{
		public string tamaño {get;set;}
		public string color {get;set;}
		public string tipo {get;set;}
	}
	}}
