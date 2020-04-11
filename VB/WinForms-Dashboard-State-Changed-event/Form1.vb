Imports DevExpress.DashboardCommon
Imports DevExpress.DashboardWin
Imports System.Windows.Forms
Imports System.Xml.Linq

Namespace WinForms_Dashboard_State_Changed_event
	Partial Public Class Form1
		Inherits Form

		Private state As New DashboardState()
		Private Const path As String = "..\..\Dashboards\dashboard1.xml"
		Public Sub New()
			InitializeComponent()
			dashboardViewer.LoadDashboard(path)
		End Sub

		Private Sub DashboardViewer_DashboardStateChanged(ByVal sender As Object, ByVal e As DashboardStateChangedEventArgs) Handles dashboardViewer.DashboardStateChanged
			state = dashboardViewer.GetDashboardState()
			state.SaveToXml()
		End Sub

		Private Sub DashboardViewer_SetInitialDashboardState(ByVal sender As Object, ByVal e As SetInitialDashboardStateEventArgs) Handles dashboardViewer.SetInitialDashboardState
			e.InitialState = state
		End Sub
		Private Sub DashboardViewer_DashboardLoaded(ByVal sender As Object, ByVal e As DashboardLoadedEventArgs) Handles dashboardViewer.DashboardLoaded
			Dim data As XElement = e.Dashboard.UserData
			If data IsNot Nothing Then
				If data.Element("DashboardState") IsNot Nothing Then
					state.LoadFromXml(XDocument.Parse(data.Element("DashboardState").Value))
				End If
			End If
		End Sub
		Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
			Dim userData As New XElement("Root", New XElement("DashboardState", state.SaveToXml().ToString(SaveOptions.DisableFormatting)))
			dashboardViewer.Dashboard.UserData = userData
			dashboardViewer.Dashboard.SaveToXml(path)
		End Sub
	End Class
End Namespace
