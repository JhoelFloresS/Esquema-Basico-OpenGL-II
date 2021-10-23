/*
 * Created by SharpDevelop.
 * User: jhoel
 * Date: 17/10/2021
 * Time: 13:17
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using System.Collections.Generic;

namespace proyectografico1
{
	/// <summary>
	/// Description of Class1.
	/// </summary>
	/// 
	public class Face
	{
		private List<Double[]> _vertices;
		private Color _color;
		private PrimitiveType _primitiType;
		private	byte[] _normal;
		
		public Double[][] vertices {
			
			get{ return _vertices.ToArray(); }
			
			set{ _vertices = new List<Double[]>(value); }
		}

		public Color color {
			get{ return _color; }
			
			set{ _color = value; }
		}
		
		public PrimitiveType primitiType {
			get{ return _primitiType; }
			
			set{ _primitiType = value; }
		}
		
		public Face()
		{
			_vertices = new List<Double[]>();
			_color = Color.Transparent;
			_primitiType = PrimitiveType.Polygon;
			
		}
		
		public Face(Face face)
		{
			_vertices = new List<Double[]>(face._vertices.Count);
			face._vertices.ForEach((item) => {
				this._vertices.Add(new double[] { item[0], item[1], item[2] });
			});
			
			this._color = face._color;
			this._primitiType = face._primitiType;
		}
		
		public Face(List<Double[]> vertices)
		{
			_vertices = new List<Double[]>(vertices.Count);
			vertices.ForEach((item) => {
				_vertices.Add(new double[] { item[0], item[1], item[2] });
			});
			_color = Color.Transparent;
			_primitiType = PrimitiveType.Polygon;
			
		}
		
		public Face(List<Double[]> vertices, Color color)
		{
			_vertices = new List<Double[]>(vertices.Count);
			vertices.ForEach((item) => {
				_vertices.Add(new double[] { item[0], item[1], item[2] });
			});
			_color = color;
			_primitiType = PrimitiveType.Polygon;
			
		}
		
		public Face(List<Double[]> vertices, Color color, PrimitiveType primitiType)
		{
			_vertices = new List<Double[]>(vertices.Count);
			vertices.ForEach((item) => {
				_vertices.Add(new double[] { item[0], item[1], item[2] });
			});
			_color = color;
			_primitiType = primitiType;
			_normal = new byte[]{ 1, 1, 0 };
		}
		
		public Face(List<Double[]> vertices, Color color, PrimitiveType primitiType, byte[] normal)
		{
			_vertices = new List<Double[]>(vertices.Count);
			vertices.ForEach((item) => {
				_vertices.Add(new double[] { item[0], item[1], item[2] });
			});
			_color = color;
			_primitiType = primitiType;
			this._normal = new byte[3];
			normal.CopyTo(_normal, 0);
		}
		
		public Face(Color color, PrimitiveType primitiType, byte[] normal)
		{
			_vertices = new List<Double[]>();
			_color = color;
			_primitiType = primitiType;
			_normal = new byte[3];
			normal.CopyTo(_normal, 0);
			
		}
		public Face(Color color, PrimitiveType primitiType)
		{
			_vertices = new List<Double[]>();
			_color = color;
			_primitiType = primitiType;
			_normal = new byte[3]{ 1, 0, 0 };
			
		}
		
		
		public void draw(Vector3d centro, double ancho, double largo, double alto)
		{
			
			GL.Begin(_primitiType);
			GL.Color4(_color);
			//		GL.Normal3(_normal[0], _normal[1], _normal[2]);
			foreach (Double[] vertice in _vertices) {
				GL.Vertex3(centro.X + vertice[0] * ancho, centro.Y + vertice[1] * alto, centro.Z + vertice[2] * largo);
			}
			GL.End();
			
		}
		
		public void add(Double[] vertice)
		{
			_vertices.Add(new double[] { vertice[0], vertice[1], vertice[2] });
		}
		
	}
}
