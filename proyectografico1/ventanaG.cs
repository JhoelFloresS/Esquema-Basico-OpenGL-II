/*
 * Created by SharpDevelop.
 * User: jhoel
 * Date: 15/10/2021
 * Time: 18:01
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using OpenTK.Input;
using System.Drawing;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace proyectografico1
{
	/// <summary>
	/// Description of Class1.
	/// </summary>
	public class Grafica:GameWindow
	{
		double theta= 0;
		
		
		public Grafica(int widht, int height, string title):base(widht,height,GraphicsMode.Default, title){
		}
		
		protected override void OnUpdateFrame(FrameEventArgs e)
		{
			
			base.OnUpdateFrame(e);
		}
		
		protected override void OnLoad(EventArgs e)
		{	
			GL.ClearColor(0.2f, 0.5f, 0.5f, 0.5f);
			
			GL.Enable(EnableCap.DepthTest);
			GL.Enable(EnableCap.Lighting);
			GL.Enable(EnableCap.ColorMaterial);
			
			float[] ligth_position = {20,40,-20};
			float[] light_diffuse = {1.0f,1.0f,1.0f};
			float[] light_ambient = {1,0f,1.0f,1.0f};
			GL.Light(LightName.Light0,LightParameter.Position,ligth_position);
			GL.Light(LightName.Light0,LightParameter.Diffuse,light_diffuse);
			GL.Light(LightName.Light0,LightParameter.Ambient, light_ambient);
			GL.Enable(EnableCap.Light0);
			base.OnLoad(e);
		}
		
		
		protected override void OnRenderFrame(FrameEventArgs e)
		{	
			GL.LoadIdentity();
			//
			//casa1.draw();
			GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
			
			
		/*	GL.Begin(PrimitiveType.Quads);
			
			GL.Color4(Color.Green);
			GL.Vertex3(-25,25,0);
			GL.Color4(Color.Azure);
			GL.Vertex3(25,25,0);
			GL.Color4(Color.Yellow);
			GL.Vertex3(25,-25,0);
			GL.Vertex3(-25,-25,0);
			GL.End();*/
			GL.Rotate(10.0,1.0,0.0,0.0);	
			GL.Rotate(theta,0.0,1.0,0.0);

			
		//	casa.dimensionar(40,20,20);
		
			//casa.draw();
			string ob = File.ReadAllText("casa.json");
			Objeto casa = JsonConvert.DeserializeObject<Objeto>(ob);
			
			casa.dimensionar(40,20,20);
			casa.draw();
			
			Context.SwapBuffers();
			theta += 1.0;
			base.OnRenderFrame(e);
		}
		
		protected override void OnResize(EventArgs e)
		{
			GL.Viewport(0, 0, Width, Height);
			GL.MatrixMode(MatrixMode.Projection);
			GL.LoadIdentity();
			GL.Ortho(-50.0,50.0,-50.0,50.0,-50.0,50.0);
			//Matrix4 matrix = Matrix4.CreatePerspectiveFieldOfView(1.0f,Width/Height,1.0f,100.0f);
			
			//GL.LoadMatrix(ref matrix);
			//GL.Translate(0.0,0.0,-45.0);
			GL.MatrixMode(MatrixMode.Modelview);
			

			base.OnResize(e);
		}   
		
		
		protected override void OnUnload(EventArgs e)
		{
			base.OnUnload(e);
		}
		
	}
}
