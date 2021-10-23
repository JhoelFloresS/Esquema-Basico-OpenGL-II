/*
 * Created by SharpDevelop.
 * User: jhoel
 * Date: 16/10/2021
 * Time: 0:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using proyectografico1;
using proyectografico1.PartesDeCasa;
namespace proyectografico1
{
	/// <summary>
	/// Description of CasaG.
	/// </summary>
	/// 
	
	
	public class CasaG
	{
		 
		CVertice centro;
		double escala;
		const double largo = 40;
		const double ancho = 20;
		const double alto = 10;
		
		BaseCasa terrenoBase;
		CPared paredFrente;
		CPared paredAtras;
		CPared paredDerecha;
		CPared paredIzquierda;
		public CasaG(double cx, double cy,double cz, double es)
		{
			centro = new CVertice();
			centro.X = cx;
			centro.Y = cy;
			centro.Z = cz;
			escala = es;
			terrenoBase = new BaseCasa(centro,largo,ancho);
			paredFrente = new CPared(centro.X,centro.Y,centro.Z+ancho/2,ancho,alto);
			paredAtras = new CPared(centro.X,centro.Y,centro.Z-ancho/2,ancho,alto);
			paredDerecha = new CPared(centro.X-largo/2,centro.Y,centro.Z,ancho,alto);
			paredIzquierda = new CPared(centro.X+largo/2,centro.Y,centro.Z,ancho,alto);
		}
		
		public void draw(){
			
			terrenoBase.draw();
			
			paredFrente.drawFrente();
			paredAtras.drawAtras();
			paredDerecha.drawPDerecha();
			paredIzquierda.drawPIzquierda();
			
		}
		
	}
}
