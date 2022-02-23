// Este codigo ha sido generado por el modulo psexport 20180802-w32 de PSeInt.
// Es posible que el codigo generado no sea completamente correcto. Si encuentra
// errores por favor reportelos en el foro (http://pseint.sourceforge.net).

using System;

namespace PSeInt {
	class encuestadeportesinvierno {

		static void Main(string[] args) {
			int i;
			int[,] encuestados = new int[5,4];
			for (i=1;i<=5;i++) {
				Console.WriteLine("Encuestado Nº "+i+": ");
				Console.WriteLine("---------------------------------------");
				Console.Write("¿Qué edad tienes?: ");
				encuestados[i-1,0] = int.Parse(Console.ReadLine());
				Console.WriteLine("(1) Esqui");
				Console.WriteLine("(2) Snowboard");
				Console.WriteLine("(3) Esquí de fondo");
				Console.WriteLine("(4) Patinaje");
				Console.Write("Selecciona tú deporte favorito (1 al 4)...");
				encuestados[i-1,1] = int.Parse(Console.ReadLine());
				Console.Write("¿Cuántas horas lo practicas?: ");
				encuestados[i-1,2] = int.Parse(Console.ReadLine());
				Console.Write("¿Eres: (1) Hombre o (2) Mujer?....(1 al 2)");
				encuestados[i-1,3] = int.Parse(Console.ReadLine());
			}
			horasejercicio(encuestados);
			tipoypromedades(encuestados);
			hombreomujer(encuestados);
		}

		static void horasejercicio(double[,] matriz) {
			int horasa;
			int horasm;
			int i;
			horasm = 0;
			horasa = 0;
			for (i=1;i<=5;i++) {
				if (matriz[i-1,0]<18) {
					horasm = horasm+matriz[i-1,2];
				} else {
					horasa = horasa+matriz[i-1,2];
				}
			}
			Console.WriteLine("");
			Console.WriteLine("Horas de práctica de deporte = "+(horasm+horasa));
			Console.WriteLine("  De Menores de edad = "+horasm);
			Console.WriteLine("  De Adultos = "+horasa);
		}

		static void tipoypromedades(double[,] matriz) {
			int edade;
			int edadef;
			int edadpa;
			int edadsn;
			int edadt;
			int ejere;
			int ejeref;
			int ejerpa;
			int ejersn;
			int ejert;
			int i;
			edade = 0;
			edadsn = 0;
			edadef = 0;
			edadpa = 0;
			edadt = 0;
			ejere = 0;
			ejersn = 0;
			ejeref = 0;
			ejerpa = 0;
			ejert = 0;
			for (i=1;i<=5;i++) {
				if (matriz[i-1,1]==1) {
					ejere = ejere+1;
					edade = edade+matriz[i-1,0];
				}
				if (matriz[i-1,1]==2) {
					ejersn = ejersn+1;
					edadsn = edadsn+matriz[i-1,0];
				}
				if (matriz[i-1,1]==3) {
					ejeref = ejeref+1;
					edadef = edadef+matriz[i-1,0];
				}
				if (matriz[i-1,1]==4) {
					ejerpa = ejerpa+1;
					edadpa = edadpa+matriz[i-1,0];
				}
				edadt = edadt+matriz[i-1,0];
			}
			Console.WriteLine("");
			Console.WriteLine("Personas por deporte:");
			Console.WriteLine("  Esqui = "+ejere);
			Console.WriteLine("  Snowboard = "+ejersn);
			Console.WriteLine("  Esqui de fondo = "+ejeref);
			Console.WriteLine("  Patinaje = "+ejerpa);
			Console.WriteLine("");
			Console.WriteLine("Promedio de edad de encuestados es: "+edadt/5+" años");
			Console.WriteLine("La edad media por deporte es:");
			Console.WriteLine("  Esqui = "+edade/ejere+" años");
			Console.WriteLine("  Snowboard = "+edadsn/ejersn+" años");
			Console.WriteLine("  Esqui de fondo = "+edadef/ejeref+" años");
			Console.WriteLine("  Patinaje = "+edadpa/ejerpa+" años");
		}

		static void hombreomujer(double[,] matriz) {
			int hombre;
			int i;
			int mujer;
			hombre = 0;
			mujer = 0;
			for (i=1;i<=5;i++) {
				if (matriz[i-1,3]==1) {
					hombre = hombre+1;
				}
				if (matriz[i-1,3]==2) {
					mujer = mujer+1;
				}
			}
			Console.WriteLine("");
			Console.WriteLine("Deportistas");
			Console.WriteLine("Hombres = "+hombre);
			Console.WriteLine("Mujeres = "+mujer);
		}

	}

}

