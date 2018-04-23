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

Imports System
Imports System.Windows
Imports System.Windows.Threading
Imports DevExpress.Xpf.Grid
Imports DevExpress.Xpf.Grid.TreeList

Namespace UpdateOnPropertyChanged
    Friend Class CommitHelper
        Public Shared ReadOnly CommitOnValueChangedProperty As DependencyProperty = DependencyProperty.RegisterAttached("CommitOnValueChanged", GetType(Boolean), GetType(CommitHelper), New PropertyMetadata(AddressOf CommitOnValueChangedPropertyChanged))

        Public Shared Sub SetCommitOnValueChanged(ByVal element As GridColumnBase, ByVal value As Boolean)
            element.SetValue(CommitOnValueChangedProperty, value)
        End Sub

        Public Shared Function GetCommitOnValueChanged(ByVal element As GridColumnBase) As Boolean
            Return CBool(element.GetValue(CommitOnValueChangedProperty))
        End Function

        Private Shared Sub CommitOnValueChangedPropertyChanged(ByVal source As DependencyObject, ByVal e As DependencyPropertyChangedEventArgs)
            Dim col As GridColumnBase = TryCast(source, GridColumnBase)
            If col.View Is Nothing Then
                Dispatcher.CurrentDispatcher.BeginInvoke(New Action(Of GridColumnBase, Boolean)(Sub(column, subscribe) ToggleCellValueChanging(column, subscribe)), col, DirectCast(e.NewValue, Boolean))
            Else
                ToggleCellValueChanging(col, DirectCast(e.NewValue, Boolean))
            End If
        End Sub

        Private Shared Sub ToggleCellValueChanging(ByVal col As GridColumnBase, ByVal subscribe As Boolean)
            If Not(TypeOf col.View Is DataViewBase) Then
                Return
            End If

            If subscribe Then
                If TypeOf col.View Is TreeListView Then
                    AddHandler TryCast(col.View, TreeListView).CellValueChanging, AddressOf TreeCellValueChanging
                Else
                    AddHandler TryCast(col.View, GridViewBase).CellValueChanging, AddressOf GridCellValueChanging
                End If
            Else
                If TypeOf col.View Is TreeListView Then
                    RemoveHandler TryCast(col.View, TreeListView).CellValueChanging, AddressOf TreeCellValueChanging
                Else
                    RemoveHandler TryCast(col.View, GridViewBase).CellValueChanging, AddressOf GridCellValueChanging
                End If
            End If
        End Sub

        Private Shared Sub TreeCellValueChanging(ByVal sender As Object, ByVal e As TreeListCellValueChangedEventArgs)
            If CBool(e.Column.GetValue(CommitOnValueChangedProperty)) Then
                TryCast(sender, DataViewBase).PostEditor()
                e.Handled = True
            End If
        End Sub

        Private Shared Sub GridCellValueChanging(ByVal sender As Object, ByVal e As CellValueChangedEventArgs)
            If CBool(e.Column.GetValue(CommitOnValueChangedProperty)) Then
                TryCast(sender, DataViewBase).PostEditor()
                e.Handled = True
            End If
        End Sub
    End Class
End Namespace
