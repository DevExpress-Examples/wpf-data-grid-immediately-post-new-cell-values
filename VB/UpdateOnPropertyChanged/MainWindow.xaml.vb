' Developer Express Code Central Example:
' How to make GridControl immediately save changes in a cell after editing
' 
' This example shows how to update GridControl's data source right after a cell
' editor value has been changed. To implement this scenario, we created a custom
' helper class exposing the CommitHelper.CommitOnValueChanged attached
' property.
' 
' This example uses the same idea as the one demonstrated in the
' http://www.devexpress.com/scid=E1801 thread. If you don't want to use custom
' helpers, check the solution from the E1801 example instead.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E4155

' Developer Express Code Central Example:
' How to make GridControl immediately save changes in a cell after editing
' 
' This example shows how to update GridControl DataSource right after a cell
' editor value has been changed. To implement this scenario, we have introduced
' the CommitHelper.CommitOnValueChanged attached property.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E4155

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
                Tasks.Add(New Task() With { _
                    .Name = "Task " & i, _
                    .ID = i _
                })
            Next i
        End Sub
    End Class
End Namespace
