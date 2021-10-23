/*
 * Created by SharpDevelop.
 * User: jhoel
 * Date: 15/10/2021
 * Time: 23:27
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using Microsoft;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using proyectografico1;

namespace proyectografico1.PartesDeCasa
{
	/// <summary>
	/// Description of Class2.
	/// </summary>
	
	
	public class FaseC
	{	
		List<CVertice> vertices;
		
		public FaseC()
		{	
			vertices = new List<CVertice>();
		}
		
		public FaseC(double[,] vertis){
			vertices = new List<CVertice>();
			for( int i = 0; i<4; i++){
				CVertice v = new CVertice(vertis[i,0],vertis[i,1],vertis[i,2]);
				vertices.Add(v);
			}
		}
		
		public FaseC(double[,] vertis, Color col){
			vertices = new List<CVertice>();
			for( int i = 0; i<4; i++){
				CVertice v = new CVertice(vertis[i,0],vertis[i,1],vertis[i,2],col);
				vertices.Add(v);
			}
		}
		
		public FaseC(double[,] vertis, Color[] col){
			vertices = new List<CVertice>();
			for( int i = 0; i<4; i++){
				CVertice v = new CVertice(vertis[i,0],vertis[i,1],vertis[i,2],col[i]);
				vertices.Add(v);
			}
		}
		
		public void Draw(){
			
			
			GL.Begin(PrimitiveType.Quads);
			
			GL.Color4(vertices[0].color);
			GL.Vertex3(vertices[0].X,vertices[0].Y,vertices[0].Z);
			GL.Color4(vertices[1].color);
			GL.Vertex3(vertices[1].X,vertices[1].Y,vertices[1].Z);
			GL.Color4(vertices[2].color);
			GL.Vertex3(vertices[2].X,vertices[2].Y,vertices[2].Z);
			GL.Color4(vertices[3].color);
			GL.Vertex3(vertices[3].X,vertices[3].Y,vertices[3].Z);
			
			GL.End();
			
		}
	}
}
