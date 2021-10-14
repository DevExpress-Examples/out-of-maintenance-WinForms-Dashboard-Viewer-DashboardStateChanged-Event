Imports DevExpress.DashboardCommon
Imports DevExpress.DashboardWin
Imports System.Windows.Forms
Imports System.Xml.Linq

Namespace WinForms_Dashboard_State_Changed_event

    Public Partial Class Form1
        Inherits Form

        Private state As DashboardState = New DashboardState()

        Public Shared ReadOnly PropertyName As String = "DashboardState"

        Const path As String = "..\..\Dashboards\dashboard1.xml"

        Public Sub New()
            InitializeComponent()
            dashboardViewer.LoadDashboard(path)
        End Sub

        Private Sub DashboardViewer_DashboardStateChanged(ByVal sender As Object, ByVal e As DashboardStateChangedEventArgs)
            state = dashboardViewer.GetDashboardState()
            Dim stateValue = state.SaveToXml().ToString(SaveOptions.DisableFormatting)
            dashboardViewer.Dashboard.CustomProperties.SetValue("DashboardState", stateValue)
        End Sub

        Private Sub DashboardViewer_SetInitialDashboardState(ByVal sender As Object, ByVal e As SetInitialDashboardStateEventArgs)
            e.InitialState = state
        End Sub

        Private Sub GetDataFromString(ByVal customPropertyValue As String)
            If Not String.IsNullOrEmpty(customPropertyValue) Then
                Dim xmlStateEl = XDocument.Parse(customPropertyValue)
                state.LoadFromXml(xmlStateEl)
            End If
        End Sub

        Private Sub DashboardViewer_DashboardLoaded(ByVal sender As Object, ByVal e As DashboardLoadedEventArgs)
            GetDataFromString(dashboardViewer.Dashboard.CustomProperties.GetValue(PropertyName))
        End Sub

        Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs)
            dashboardViewer.Dashboard.SaveToXml(path)
        End Sub
    End Class
End Namespace
