using System;
using WSDL.mensajes;

namespace WSDL.operaciones {
	public class Operaciones : Mensajes {
		List<string> saludadores = new List<string>();
		public string Saludar (string nombre){
			string msj = "hola " + nombre;
			saludadores.Add(nombre);
			return msj;
		}

		public string Mostrar (string id){
			return saludadores[Int32.Parse(id)];
		}
	}
}
