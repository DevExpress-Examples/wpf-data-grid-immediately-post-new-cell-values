# How to make GridControl immediately save changes in a cell after editing


<p>This example shows how to update GridControl's data source right after a cell editor value has been changed. To implement this scenario, we created a custom helper class exposing the <strong>Commit</strong><strong>Helper</strong><strong>.CommitOnValueChanged</strong> attached property.<br /><br /><em>This example uses the same idea as the one demonstrated in the <a href="https://www.devexpress.com/Support/Center/p/E1801">E1801 - How to post values to the DXGrid DataSource immediately after changing a cell value</a> thread. If you don't want to use custom helpers, check the solution from the E1801 example instead.<br /><br /><strong>UPDATE:</strong> Starting with version 15.1, you can use the <strong>DataViewBase.EnableImmediatePosting</strong> property to post values to a data source without leaving an edited cell.<br /></em></p>

<br/>


