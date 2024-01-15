using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace cri_MVVM_MCLG__.VistaModelo
{
	internal class Page1VM : BaseViewModel
	{
		#region VARIABLES
		string _Texto;
		string _nombre;
		bool _alto;
		bool _listo;
		bool _raro;
		bool _chaparro;
		bool _estravagante;
		bool _grande;
		bool _esHombre;
		string _critica;

		#endregion
		#region CONSTRUCTOR
		public Page1VM(INavigation navigation)
		{
			Navigation = navigation;
		}
		#endregion
		#region OBJETOS
		public string Texto
		{
			get { return _Texto; }
			set { SetValue(ref _Texto, value); }
		}

		public string nombre
		{
			get { return _nombre; }
			set { SetValue(ref _nombre, value); }
		}
		public bool alto
		{
			get { return _alto; }
			set { SetValue(ref _alto, value); }
		}
		public bool listo
		{
			get { return _listo; }
			set { SetValue(ref _listo, value); }
		}
		public bool raro
		{
			get { return _raro; }
			set { SetValue(ref _raro, value); }
		}
		public bool extravagante
		{
			get { return _estravagante; }
			set { SetValue(ref _estravagante, value); }
		}
		public bool grande
		{
			get { return _grande; }
			set { SetValue(ref _grande, value); }
		}
		public bool chaparro
		{
			get { return _chaparro; }
			set { SetValue(ref _chaparro, value); }
		}
		public bool esHombre
		{
			get { return _esHombre; }
			set { SetValue(ref _esHombre, value); }
		}
		public string critica
		{
			get { return _critica; }
			set { SetValue(ref _critica, value); }
		}
		#endregion
		#region PROCESOS
		public async Task ProcesoAsyncrono()
		{
			await DisplayAlert("Titulo", "Mensaje", "Ok");
		}
		public void ProcesoSimple()
		{
			if (!string.IsNullOrEmpty(nombre))
			{
				var nombrePersona = nombre;
				List<string> atributoPersona = new List<string>();

				if (esHombre == false)
				{
					if (alto == true)
					{
						atributoPersona.Add("alta");
					}
					if (listo == true)
					{
						atributoPersona.Add("lista");
					}
					
					if (raro == true)
					{
						atributoPersona.Add("rara");
					}
					if (chaparro == true)
					{
						atributoPersona.Add("chaparra");
					}

				}
				else
				{
					if (alto == true)
					{
						atributoPersona.Add("alto");
					}
					if (listo == true)
					{
						atributoPersona.Add("listo");
					}
					
					if (raro == true)
					{
						atributoPersona.Add("raro");
					}
					if (chaparro == true)
					{
						atributoPersona.Add("chaparro");
					}
				}
				
				if (extravagante == true)
				{
					atributoPersona.Add("extravagante");
				}
				if (grande == true)
				{
					atributoPersona.Add("grande");
				}
				
				int lonfitud = atributoPersona.Count;
				if (lonfitud == 0)
				{
					DisplayAlert("Atributos", "seleccione al menos un atributo", "Ok");
				}
				else if(lonfitud == 1)
				{

					var cadena = string.Join(", ", atributoPersona);
					critica = $"{nombrePersona} es {cadena}";
				}
				else{

					var cadena = string.Join(", ", atributoPersona.Take(lonfitud - 1));
					string ultimo = atributoPersona[lonfitud - 1];
					critica = $"{nombrePersona} es {cadena} y {ultimo}";
				}
				
			}
			else
			{
				DisplayAlert("Datos erroneos", "Por favor, llena la información que se solicita", "Ok");
			}
		}
		#endregion
		#region COMANDOS
		public ICommand ProcesoAsyncommand => new Command(async () => await ProcesoAsyncrono());
		public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
		#endregion
	}

}
