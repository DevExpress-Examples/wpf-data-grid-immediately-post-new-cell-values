<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128651842/21.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4155)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/UpdateOnPropertyChanged/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/UpdateOnPropertyChanged/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/UpdateOnPropertyChanged/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/UpdateOnPropertyChanged/MainWindow.xaml.vb))
* [MainViewModel.cs](./CS/UpdateOnPropertyChanged/MainViewModel.cs) (VB: [MainViewModel.vb](./VB/UpdateOnPropertyChanged/MainViewModel.vb))
<!-- default file list end -->
# How to make GridControl immediately save changes in a cell after editing


This example shows how to update GridControl's data source right after a cell editor value has been changed. Starting with version 15.1, you can use the <strong>DataViewBase.EnableImmediatePosting</strong> property to post values to a data source without leaving an edited cell.
