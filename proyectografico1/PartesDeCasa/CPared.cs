/*
 * Created by SharpDevelop.
 * User: jhoel
 * Date: 16/10/2021
 * Time: 4:14
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
	/// Description of CPared.
	/// </summary>
	public class CPared
	{
		CVertice centro;
		double ancho;
		double alto;
		FaseC muro;
		FaseC puerta;
		
		public CPared(double x, double y, double z,double width, double heigh)
		{
			centro = new CVertice();
			centro.X = x;
			centro.Y = y;
			centro.Z = z;
			ancho = width;
			alto = heigh;
			
			
			
		}
		
		public void drawFrente(){
			GL.PushMatrix();
			puerta = new FaseC(new double[4,3]{{centro.X-ancho*0.2,centro.Y,centro.Z},
			                     		  {centro.X+ancho*0.2,centro.Y,centro.Z},
			                    		  {centro.X+ancho*0.2,centro.Y+alto*0.6,centro.Z},
			                     		  {centro.X-ancho*0.2,centro.Y+alto*0.6,centro.Z}}, Color.Brown);
			puerta.Draw();
			muro = new FaseC(new double[4,3]{{centro.X-ancho/2,centro.Y,centro.Z},
			                     		  {centro.X+ancho/2,centro.Y,centro.Z},
			                    		  {centro.X+ancho/2,centro.Y+alto,centro.Z},
			                     		  {centro.X-ancho/2,centro.Y+alto,centro.Z}}, Color.Silver);
			muro.Draw();
			
		
			GL.PopMatrix();
		}
		
		public void drawAtras(){
			GL.PushMatrix();
			muro = new FaseC(new double[4,3]{{centro.X-ancho/2,centro.Y,centro.Z},
			                     		  {centro.X+ancho/2,centro.Y,centro.Z},
			                    		  {centro.X+ancho/2,centro.Y+alto,centro.Z},
			                     		  {centro.X-ancho/2,centro.Y+alto,centro.Z}}, Color.Silver);
			muro.Draw();
			GL.PopMatrix();
		}
		
		public void drawPDerecha(){
			
			
			GL.PushMatrix();
			GL.Translate(centro.X*0.25,centro.Y,centro.Z);
			
			GL.Rotate(90.0,0.0,1.0,0.0);
			
			muro = new FaseC(new double[4,3]{{centro.X-ancho/2,centro.Y,centro.Z},
			                     		  {centro.X+ancho/2,centro.Y,centro.Z},
			                    		  {centro.X+ancho/2,centro.Y+alto,centro.Z},
			                     		  {centro.X-ancho/2,centro.Y+alto,centro.Z}}, Color.Silver);
			muro.Draw();
			GL.PopMatrix();
		}
		
		public void drawPIzquierda(){
			GL.PushMatrix();
			
			muro = new FaseC(new double[4,3]{{centro.X-ancho/2,centro.Y,centro.Z},
			                     		  {centro.X+ancho/2,centro.Y,centro.Z},
			                    		  {centro.X+ancho/2,centro.Y+alto,centro.Z},
			                     		  {centro.X-ancho/2,centro.Y+alto,centro.Z}}, Color.Silver);
			muro.Draw();
			GL.PopMatrix();
		}
	}
}
