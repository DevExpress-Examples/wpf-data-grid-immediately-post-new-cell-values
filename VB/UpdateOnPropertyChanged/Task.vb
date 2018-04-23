Imports System.ComponentModel

Namespace UpdateOnPropertyChanged
	Public Class Task
		Implements INotifyPropertyChanged
		Private fId As Integer
		Private fName As String

		Public Property ID() As Integer
			Get
				Return fId
			End Get
			Set(ByVal value As Integer)
				If fId = value Then
					Return
				End If

				fId = value
				RaisePropertyChanged("ID")
			End Set
		End Property

		Public Property Name() As String
			Get
				Return fName
			End Get
			Set(ByVal value As String)
				If fName = value Then
					Return
				End If

				fName = value
				RaisePropertyChanged("Name")
			End Set
		End Property

		Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
		Protected Sub RaisePropertyChanged(ByVal propertyName As String)
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End Sub
	End Class
End Namespace
