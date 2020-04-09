*Files to look at*:

* [Form1.cs](./CS/WinForms-Dashboard-State-Changed-event/Form1.cs) (VB: [Form1.vb](./VB/WinForms-Dashboard-State-Changed-event/Form1.vb))

# How to Use the DashboardStateChanged Event to Manage the Dashboard State.

This example demonstrates how to manage the dashboard state to save and restore user interactions.

The [DashboardViewer.GetDashboardState](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardViewer.GetDashboardState) method obtains a dashboard's state object every time the dashboard state changes (when the [DashboardStateChanged](http://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardViewer.DashboardStateChanged?v=20.1) event is raised). The state is serialized to XML and added to the **XElement** object stored in the [Dashboard.UserData](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.Dashboard.UserData). When a user closes the application, the dashboard state is saved to a dashboard definition.

When the application starts, the DashboardViewer control loads the dashboard. The [DashboardViewer.DashboardLoaded](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardViewer.DashboardLoaded) event is raised and the DashboardState object is deserialized.

The [DashboardViewer.SetDashboardState](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardViewer.SetDashboardState) method restores the dashboard state when the [DashboardViewer.SetInitialDashboardState](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardViewer.SetInitialDashboardState) event is raised.

The following API is used in this example:
* [DashboardStateChanged](http://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardViewer.DashboardStateChanged?v=20.1)
* [DashboardViewer.GetDashboardState](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardViewer.GetDashboardState)
* [Dashboard.UserData](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.Dashboard.UserData)
* [DashboardViewer.DashboardLoaded](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardViewer.DashboardLoaded)
* [DashboardViewer.SetDashboardState](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardViewer.SetDashboardState)
* [DashboardViewer.SetInitialDashboardState](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardViewer.SetInitialDashboardState)