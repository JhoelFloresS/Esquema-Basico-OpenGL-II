/*
 * Created by SharpDevelop.
 * User: jhoel
 * Date: 15/10/2021
 * Time: 18:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Collections.Generic;
using OpenTK;
using proyectografico1;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using System.Drawing;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;


namespace proyectografico1
{

	
class Program
	{
		
	public static void Main(string[] args)
		{
			/*string ob = JsonConvert.SerializeObject(casa,Formatting.Indented);
			File.WriteAllText("casa.json",ob);*/
			using (Grafica nw = new Grafica(800, 600, "prueba"))
            {
				nw.Run(60.0);
			}


				
			//}

		}
	}
}	