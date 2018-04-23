Imports System.Collections.ObjectModel
Imports System.Windows

Namespace UpdateOnPropertyChanged
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window
		Public Sub New()
			DataContext = New ViewModel()
			InitializeComponent()
		End Sub
	End Class

	Public Class ViewModel
		Public Property Tasks() As ObservableCollection(Of Task)

		Public Sub New()
			Tasks = New ObservableCollection(Of Task)()
			For i As Integer = 0 To 4
				Tasks.Add(New Task() With {.Name = "Task " & i, .ID = i})
			Next i
		End Sub
	End Class
End Namespace
