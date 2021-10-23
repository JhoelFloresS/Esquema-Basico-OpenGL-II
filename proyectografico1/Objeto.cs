/*
 * Created by SharpDevelop.
 * User: jhoel
 * Date: 17/10/2021
 * Time: 13:28
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using OpenTK;

namespace proyectografico1
{
	/// <summary>
	/// Objeto tridimensional.
	/// </summary>
	/// 

	public class Objeto
	{
		private List<Face> _faces;
		private Vector3d _centro;
		private double _largo;
		private double _ancho;
		private double _alto;
		
		public double centroX{
			get{return _centro.X;}
			
			set{_centro.X = value;}
		}
		
		public double centroY{
			get{return _centro.Y;}
			
			set{_centro.Y = value;}
		}
		
		public double centroZ{
			get{return _centro.Z;}
			
			set{_centro.Z= value;}
		}
		
		
		public Face[] faces{
			get{return _faces.ToArray();}
			
			set{_faces = new List<Face>(value);}
		}
		
		
	
		
		public Objeto()
		{
			_faces= new List<Face>();
			_centro = new Vector3d(0.0,0.0,0.0);
			_largo = 1;
			_ancho = 1;
			_alto = 1;
			
		}
		
		/// <summary>
		/// Constructor de la clase objeto con 4 parametros.
		/// </summary>
		/// <param name="centro">Centro del objeto.</param>
		/// <param name="ancho">Ancho del objeto.</param>
		/// <param name="largo">Largo del objeto.</param>
		/// <param name="alto">Alto del objeto.</param>
		/// <remarks></remarks>
		public Objeto(Vector3d centro){
			_faces = new List<Face>();
			_centro = new Vector3d(centro);
			
		}
		public Objeto(Objeto obj) {
			_faces = new List<Face>(obj._faces.Count);
			obj._faces.ForEach((item) =>
			{
				this._faces.Add(new Face(item));
			});
			_centro = new Vector3d(obj._centro);
		}
		public Objeto(Vector3d centro, List<Face> faces){
			_faces = new List<Face>(faces.Count);
			faces.ForEach((item)=>{
			   	_faces.Add(new Face(item));
			});
			
			_centro = centro;
			
		}
		
		public void dimensionar(double ancho, double largo, double alto){
			this._largo = largo;
			this._ancho = ancho;
			this._alto = alto;
		}
		public void add(Face cara){
			_faces.Add(cara);
		}
		
		public void draw(){
			if (_faces != null)
			{
				foreach (Face item in _faces)
				{
					item.draw(_centro,_ancho, _largo, _alto);
				}
			}
		}
	}
		
		
		
	
}
