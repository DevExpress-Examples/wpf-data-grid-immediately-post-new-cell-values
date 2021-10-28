Imports DevExpress.Mvvm
Imports System.Collections.ObjectModel
Imports System.Linq

Namespace UpdateOnPropertyChanged

    Public Class Item
        Inherits BindableBase

        Public Property ID As Integer
            Get
                Return GetValue(Of Integer)()
            End Get

            Set(ByVal value As Integer)
                SetValue(value)
            End Set
        End Property

        Public Property Name As String
            Get
                Return GetValue(Of String)()
            End Get

            Set(ByVal value As String)
                SetValue(value)
            End Set
        End Property
    End Class

    Public Class MainViewModel
        Inherits ViewModelBase

        Public Property Items As ObservableCollection(Of Item)
            Get
                Return GetValue(Of ObservableCollection(Of Item))()
            End Get

            Set(ByVal value As ObservableCollection(Of Item))
                SetValue(value)
            End Set
        End Property

        Public Property SelectedItem As Item
            Get
                Return GetValue(Of Item)()
            End Get

            Set(ByVal value As Item)
                SetValue(value)
            End Set
        End Property

        Public Sub New()
            Items = GetData()
        End Sub

        Private Shared Function GetData() As ObservableCollection(Of Item)
            Dim collection = Enumerable.Range(0, 5).[Select](Function(x) New Item With {.ID = x, .Name = "Name" & x})
            Return New ObservableCollection(Of Item)(collection)
        End Function
    End Class
End Namespace
