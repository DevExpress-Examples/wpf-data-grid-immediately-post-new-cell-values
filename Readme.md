<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128651842/12.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4155)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [CommitHelper.cs](./CS/UpdateOnPropertyChanged/CommitHelper.cs) (VB: [CommitHelper.vb](./VB/UpdateOnPropertyChanged/CommitHelper.vb))
* [MainWindow.xaml](./CS/UpdateOnPropertyChanged/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/UpdateOnPropertyChanged/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/UpdateOnPropertyChanged/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/UpdateOnPropertyChanged/MainWindow.xaml.vb))
* [Task.cs](./CS/UpdateOnPropertyChanged/Task.cs) (VB: [Task.vb](./VB/UpdateOnPropertyChanged/Task.vb))
<!-- default file list end -->
# How to make GridControl immediately save changes in a cell after editing


<p>This example shows how to update GridControl's data source right after a cell editor value has been changed. To implement this scenario, we created a custom helper class exposing the <strong>Commit</strong><strong>Helper</strong><strong>.CommitOnValueChanged</strong> attached property.<br /><br /><em>This example uses the same idea as the one demonstrated in the <a href="https://www.devexpress.com/Support/Center/p/E1801">E1801 - How to post values to the DXGrid DataSource immediately after changing a cell value</a> thread. If you don't want to use custom helpers, check the solution from the E1801 example instead.<br /><br /><strong>UPDATE:</strong> Starting with version 15.1, you can use the <strong>DataViewBase.EnableImmediatePosting</strong> property to post values to a data source without leaving an edited cell.<br /></em></p>

<br/>


