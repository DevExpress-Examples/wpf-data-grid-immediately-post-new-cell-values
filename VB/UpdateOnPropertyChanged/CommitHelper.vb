Imports System
Imports System.Windows
Imports System.Windows.Threading
Imports DevExpress.Xpf.Grid

Namespace UpdateOnPropertyChanged
	Friend Class CommitHelper
		Public Shared ReadOnly CommitOnValueChangedProperty As DependencyProperty = DependencyProperty.RegisterAttached("CommitOnValueChanged", GetType(Boolean), GetType(CommitHelper), New PropertyMetadata(AddressOf CommitOnValueChangedPropertyChanged))

		Public Shared Sub SetCommitOnValueChanged(ByVal element As GridColumn, ByVal value As Boolean)
			element.SetValue(CommitOnValueChangedProperty, value)
		End Sub

		Public Shared Function GetCommitOnValueChanged(ByVal element As GridColumn) As Boolean
			Return CBool(element.GetValue(CommitOnValueChangedProperty))
		End Function

		Private Shared Sub CommitOnValueChangedPropertyChanged(ByVal source As DependencyObject, ByVal e As DependencyPropertyChangedEventArgs)
			Dim col As GridColumn = TryCast(source, GridColumn)
			If col.View Is Nothing Then
				Dispatcher.CurrentDispatcher.BeginInvoke(New Action(Of GridColumn, Boolean)(Sub(column, subscribe)
																								ToggleCellValueChanging(column, subscribe)
																							End Sub), col, CBool(e.NewValue))
			Else
				ToggleCellValueChanging(col, CBool(e.NewValue))
			End If
		End Sub

		Private Shared Sub ToggleCellValueChanging(ByVal col As GridColumn, ByVal subscribe As Boolean)
			Dim view As TableView = TryCast(col.View, TableView)
			If view Is Nothing Then
				Return
			End If

			If subscribe Then
				AddHandler view.CellValueChanging, AddressOf view_CellValueChanging
			Else
				RemoveHandler view.CellValueChanging, AddressOf view_CellValueChanging
			End If
		End Sub

		Private Shared Sub view_CellValueChanging(ByVal sender As Object, ByVal e As CellValueChangedEventArgs)
			Dim view As TableView = TryCast(sender, TableView)
			If CBool(e.Column.GetValue(CommitOnValueChangedProperty)) Then
				view.PostEditor()
			End If
		End Sub
	End Class
End Namespace
