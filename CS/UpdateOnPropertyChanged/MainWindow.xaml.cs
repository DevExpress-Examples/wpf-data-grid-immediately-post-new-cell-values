using System.Collections.ObjectModel;
using System.Windows;

namespace UpdateOnPropertyChanged
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			DataContext = new ViewModel();
			InitializeComponent();
		}
	}

	public class ViewModel
	{
		public ObservableCollection<Task> Tasks { get; set; }

		public ViewModel()
		{
			Tasks = new ObservableCollection<Task>();
			for ( int i = 0; i < 5; i++ )
				Tasks.Add(new Task() { Name = "Task " + i, ID = i });
		}
	}
}
