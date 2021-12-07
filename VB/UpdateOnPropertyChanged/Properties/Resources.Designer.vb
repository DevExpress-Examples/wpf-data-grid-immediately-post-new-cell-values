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
'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.269
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------
Namespace UpdateOnPropertyChanged.Properties

    ''' <summary>
    '''   A strongly-typed resource class, for looking up localized strings, etc.
    ''' </summary>
    ' This class was auto-generated by the StronglyTypedResourceBuilder
    ' class via a tool like ResGen or Visual Studio.
    ' To add or remove a member, edit your .ResX file then rerun ResGen
    ' with the /str option, or rebuild your VS project.
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")>
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>
    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>
    Friend Class Resources

        Private Shared resourceMan As Global.System.Resources.ResourceManager

        Private Shared resourceCulture As Global.System.Globalization.CultureInfo

        <Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")>
        Friend Sub New()
        End Sub

        ''' <summary>
        '''   Returns the cached ResourceManager instance used by this class.
        ''' </summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>
        Friend Shared ReadOnly Property ResourceManager As Global.System.Resources.ResourceManager
            Get
                If(UpdateOnPropertyChanged.Properties.Resources.resourceMan Is Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("Resources", GetType(UpdateOnPropertyChanged.Properties.Resources).Assembly)
                    UpdateOnPropertyChanged.Properties.Resources.resourceMan = temp
                End If

                Return UpdateOnPropertyChanged.Properties.Resources.resourceMan
            End Get
        End Property

        ''' <summary>
        '''   Overrides the current thread's CurrentUICulture property for all
        '''   resource lookups using this strongly typed resource class.
        ''' </summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>
        Friend Shared Property Culture As Global.System.Globalization.CultureInfo
            Get
                Return UpdateOnPropertyChanged.Properties.Resources.resourceCulture
            End Get

            Set(ByVal value As Global.System.Globalization.CultureInfo)
                UpdateOnPropertyChanged.Properties.Resources.resourceCulture = value
            End Set
        End Property
    End Class
End Namespace
