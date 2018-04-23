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
