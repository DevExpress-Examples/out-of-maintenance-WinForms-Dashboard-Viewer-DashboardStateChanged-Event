<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/254371771/20.1.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T901540)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# Dashboard for WinForms - How to Use the DashboardStateChanged Event to Manage the Dashboard State

This example demonstrates how to manage the dashboard state to save and restore user interactions.

The [DashboardViewer.GetDashboardState](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardViewer.GetDashboardState) method obtains a dashboard's state object every time the dashboard state changes (when the [DashboardStateChanged](http://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardViewer.DashboardStateChanged?v=20.1) event is raised). The state is serialized to XML and added to the **XElement** object stored in the [CustomProperties](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.CustomProperties) collection. When a user closes the application, the dashboard state is saved to a dashboard definition.

When the application starts, the DashboardViewer control loads the dashboard. The [DashboardViewer.DashboardLoaded](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardViewer.DashboardLoaded) event is raised and the DashboardState object is deserialized.

The [DashboardViewer.SetDashboardState](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardViewer.SetDashboardState) method restores the dashboard state when the [DashboardViewer.SetInitialDashboardState](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardViewer.SetInitialDashboardState) event is raised.

The following API is used in this example:
* [DashboardStateChanged](http://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardViewer.DashboardStateChanged?v=20.1)
* [DashboardViewer.GetDashboardState](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardViewer.GetDashboardState)
* [CustomProperties.GetValue](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.CustomProperties.GetValue(System.String))
* [DashboardViewer.DashboardLoaded](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardViewer.DashboardLoaded)
* [CustomProperties.SetValue](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.CustomProperties.SetValue(System.String-System.String))
* [DashboardViewer.SetInitialDashboardState](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardViewer.SetInitialDashboardState)

<!-- default file list -->
## Files to look at

* [Form1.cs](./CS/WinForms-Dashboard-State-Changed-event/Form1.cs) (VB: [Form1.vb](./VB/WinForms-Dashboard-State-Changed-event/Form1.vb))
<!-- default file list end -->

## More Examples

**WinForms Dashboard Designer:**
- [How to Set the Initial Dashboard State](https://github.com/DevExpress-Examples/winforms-designer-save-and-apply-dashboard-state)

- [How to Clear Filter Values in a Dashboard State](https://github.com/DevExpress-Examples/How-to-Clear-Filter-Values-in-a-Dashboard-State-)

**WinForms Dashboard Viewer:**

- [How to Save and Restore the Dashboard State](https://github.com/DevExpress-Examples/winforms-dashboard-save-restore-dashboard-state)

- [How to Set the Initial Dashboard State](https://github.com/DevExpress-Examples/winforms-viewer-save-and-apply-dashboard-state)

**WPF Dashboard:**

- [How to Use the DashboardStateChanged Event to Display User Interactions](https://github.com/DevExpress-Examples/wpf-dashboard-viewer-DashboardStateChanged-event)

- [How to Set the Initial Dashboard State](https://github.com/DevExpress-Examples/wpf-dashboard-how-to-set-initial-dashboard-state)
