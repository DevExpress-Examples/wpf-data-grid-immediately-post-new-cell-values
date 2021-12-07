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
Imports System.Windows

Namespace UpdateOnPropertyChanged

    ''' <summary>
    ''' Interaction logic for App.xaml
    ''' </summary>
    Public Partial Class App
        Inherits Application

    End Class
End Namespace
