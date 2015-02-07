//      *********    NE PAS MODIFIER CE FICHIER     *********
//      Ce fichier est régénéré par un outil de création.Modifier
// .     ce fichier peut provoquer des erreurs.
namespace Blend.SampleData.SampleDataSource
{
	using System; 
	using System.ComponentModel;

// Pour réduire de façon significative le volume des données échantillons dans votre application de production, vous pouvez définir
// la constante de compilation conditionnelle DISABLE_SAMPLE_DATA et désactiver les données échantillons lors de l'exécution.
#if DISABLE_SAMPLE_DATA
	internal class SampleDataSource { }
#else

	public class SampleDataSource : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		public SampleDataSource()
		{
			try
			{
				Uri resourceUri = new Uri("ms-appx:/SampleData/SampleDataSource/SampleDataSource.xaml", UriKind.RelativeOrAbsolute);
				Windows.UI.Xaml.Application.LoadComponent(this, resourceUri);
			}
			catch
			{
			}
		}

		private GroupCollection _Groups = new GroupCollection();

		public GroupCollection Groups
		{
			get
			{
				return this._Groups;
			}
		}
	}

	public class Group : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		private string _Property1 = string.Empty;

		public string Property1
		{
			get
			{
				return this._Property1;
			}

			set
			{
				if (this._Property1 != value)
				{
					this._Property1 = value;
					this.OnPropertyChanged("Property1");
				}
			}
		}

		private string _Property2 = string.Empty;

		public string Property2
		{
			get
			{
				return this._Property2;
			}

			set
			{
				if (this._Property2 != value)
				{
					this._Property2 = value;
					this.OnPropertyChanged("Property2");
				}
			}
		}

		private Windows.UI.Xaml.Media.ImageSource _Property3 = null;

		public Windows.UI.Xaml.Media.ImageSource Property3
		{
			get
			{
				return this._Property3;
			}

			set
			{
				if (this._Property3 != value)
				{
					this._Property3 = value;
					this.OnPropertyChanged("Property3");
				}
			}
		}

		private ItemCollection _Items = new ItemCollection();

		public ItemCollection Items
		{
			get
			{
				return this._Items;
			}
		}
	}

	public class Item : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		private string _Property1 = string.Empty;

		public string Property1
		{
			get
			{
				return this._Property1;
			}

			set
			{
				if (this._Property1 != value)
				{
					this._Property1 = value;
					this.OnPropertyChanged("Property1");
				}
			}
		}

		private string _Property2 = string.Empty;

		public string Property2
		{
			get
			{
				return this._Property2;
			}

			set
			{
				if (this._Property2 != value)
				{
					this._Property2 = value;
					this.OnPropertyChanged("Property2");
				}
			}
		}

		private Windows.UI.Xaml.Media.ImageSource _Property3 = null;

		public Windows.UI.Xaml.Media.ImageSource Property3
		{
			get
			{
				return this._Property3;
			}

			set
			{
				if (this._Property3 != value)
				{
					this._Property3 = value;
					this.OnPropertyChanged("Property3");
				}
			}
		}
	}

	public class ItemCollection : System.Collections.ObjectModel.ObservableCollection<Item>
	{ 
	}

	public class GroupCollection : System.Collections.ObjectModel.ObservableCollection<Group>
	{ 
	}
#endif
}
