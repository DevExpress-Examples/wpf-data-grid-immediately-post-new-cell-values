using System.ComponentModel;

namespace UpdateOnPropertyChanged
{
	public class Task : INotifyPropertyChanged
	{
		int fId;
		string fName;

		public int ID
		{
			get { return fId; }
			set
			{
				if ( fId == value )
					return;
				
				fId = value;
				RaisePropertyChanged("ID");
			}
		}

		public string Name
		{
			get { return fName; }
			set
			{
				if ( fName == value )
					return;
				
				fName = value;
				RaisePropertyChanged("Name");
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;
		protected void RaisePropertyChanged(string propertyName)
		{
			if ( PropertyChanged != null )
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
