/*
 * Created by SharpDevelop.
 * User: jhoel
 * Date: 16/10/2021
 * Time: 2:50
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
namespace proyectografico1.PartesDeCasa
{
	/// <summary>
	/// Description of Class1.
	/// </summary>
	public class CVertice
	{
		double _x;
		double _y;
		double _z;
		Color _color;
		
		public double X{
			get{return _x;}
			
			set{_x = value;}
		}
		
		public double Y{
			get{return _y;}
			
			set{_y=value;}
		}
		
		public double Z{
			get{return _z;}
			
			set{_z=value;}
		}
		
		public Color color{
			get{return _color;}
			
			set{_color = value;}
		}
		public CVertice()
		{
			_x = 0.0;
			_y = 0.0;
			_z = 0.0;
		}
		
		public CVertice(double x, double y, double z){
			_x = x;
			_y = y;
			_z = z;
			_color = Color.Transparent;
		}
		
		public CVertice(double x, double y, double z,Color col){
			_x = x;
			_y = y;
			_z = z;
			_color = col;
		}
	}
}
