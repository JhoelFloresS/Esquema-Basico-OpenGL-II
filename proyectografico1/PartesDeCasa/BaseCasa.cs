/*
 * Created by SharpDevelop.
 * User: jhoel
 * Date: 16/10/2021
 * Time: 2:14
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using proyectografico1;
using proyectografico1.PartesDeCasa;

namespace proyectografico1.PartesDeCasa
{
	/// <summary>
	/// Description of Class1.
	/// </summary>
	
	
	public class BaseCasa
	{
		CVertice centro;
		double largo;
		double ancho;
		double escala;
		FaseC terreno;
		
		public BaseCasa()
		{
			centro = new CVertice();
				
				
		}
		
		public BaseCasa(double length, double width){
			centro = new CVertice();
			largo = length;
			ancho = width;
			escala = 1.0;
			terreno = new FaseC(new double[4,3]{{centro.X-length/2,centro.Y,centro.Z+width/2},
			                     {centro.X+length/2,centro.Y,centro.Z+width/2},
			                     {centro.X+length/2,centro.Y,centro.Z-width/2},
			                     {centro.X-length/2,centro.Y,centro.Z-width/2}}, Color.Green);
		}
		
		public BaseCasa(CVertice c, double length, double width){
			centro = c;
			largo = length;
			ancho = width;
			escala = 1.0;
			terreno = new FaseC(new double[,]{{centro.X-length/2,centro.Y,centro.Z+width/2},
			                     {centro.X+length/2,centro.Y,centro.Z+width/2},
			                     {centro.X+length/2,centro.Y,centro.Z-width/2},
			                     {centro.X-length/2,centro.Y,centro.Z-width/2}}, Color.Green);
		}
		
		public BaseCasa(CVertice c, double length, double width, double scale){
			centro = c;
			largo = length;
			ancho = width;
			escala = scale;
			terreno = new FaseC(new double[4,3]{{centro.X-length/2,centro.Y,centro.Z+width/2},
			                     {centro.X+length/2,centro.Y,centro.Z+width/2},
			                     {centro.X+length/2,centro.Y,centro.Z-width/2},
			                     {centro.X-length/2,centro.Y,centro.Z-width/2}}, Color.Green);
		}
		
		public void draw(){
			GL.PushMatrix();
			GL.Scale(1.1,1.1,1.1);
			terreno.Draw();
			GL.PopMatrix();
		}
	}
}
