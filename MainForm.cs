
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FinalTPILabo3
{
	
	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
			
		
		}
		
		
		void Button3Click(object sender, EventArgs e)
		{
			Conexion nueva = new Conexion();
			dataGridView1.DataSource = nueva.get();
			
	
		}
		void Button4Click(object sender, EventArgs e)
		{
			Conexion nueva = new Conexion();
			dataGridView2.DataSource = nueva.GetPersona();
		}
		void Button7Click(object sender, EventArgs e)
		{
			Conexion nueva = new Conexion();
			dataGridView3.DataSource = nueva.getanimal();
		}
		void Button10Click(object sender, EventArgs e)
		{
			Conexion nueva = new Conexion();
			dataGridView4.DataSource = nueva.getAmbiente();
		}
		void Button1Click(object sender, EventArgs e)
		{
			Close();
		}
		void Button2Click(object sender, EventArgs e)
		{
			Conexion adherir = new Conexion();
			adherir.SetCasa(int.Parse(textBox1.Text), textBox2.Text, textBox3.Text, textBox13.Text);
        }
		void Button5Click(object sender, EventArgs e)
		{
			Conexion adherir = new Conexion();
			adherir.SetPersona(int.Parse(textBox6.Text), textBox5.Text, int.Parse(textBox4.Text), textBox14.Text, textBox15.Text, textBox16.Text, textBox17.Text);

		}
		void Button8Click(object sender, EventArgs e)
		{
			Conexion adherir = new Conexion();
			try{
			adherir.Setanimal(int.Parse(textBox9.Text),textBox8.Text, textBox7.Text, textBox18.Text, textBox19.Text, int.Parse(textBox20.Text), textBox21.Text, int.Parse(textBox22.Text) );
			}
			catch{
				MessageBox.Show("hola carge los datos");
			}
			}
		void Button11Click(object sender, EventArgs e)
		{Conexion adherir = new Conexion();
			try{
			adherir.SetAmbiente(textBox12.Text, textBox11.Text, textBox10.Text);
			}
			catch{
				MessageBox.Show("hola carge los datos");
			}
			
		}
		
			
		
		
	}}
		
	
