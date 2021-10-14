Namespace WinForms_Dashboard_State_Changed_event

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.dashboardViewer = New DevExpress.DashboardWin.DashboardViewer(Me.components)
            CType((Me.dashboardViewer), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' dashboardViewer
            ' 
            Me.dashboardViewer.Appearance.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((160)))))), (CInt(((CByte((160)))))), (CInt(((CByte((160)))))))
            Me.dashboardViewer.Appearance.Options.UseBackColor = True
            Me.dashboardViewer.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dashboardViewer.Location = New System.Drawing.Point(0, 0)
            Me.dashboardViewer.Name = "dashboardViewer"
            Me.dashboardViewer.Size = New System.Drawing.Size(919, 482)
            Me.dashboardViewer.TabIndex = 0
            Me.dashboardViewer.DashboardLoaded += New DevExpress.DashboardWin.DashboardLoadedEventHandler(AddressOf Me.DashboardViewer_DashboardLoaded)
            Me.dashboardViewer.SetInitialDashboardState += New DevExpress.DashboardWin.SetInitialDashboardStateEventHandler(AddressOf Me.DashboardViewer_SetInitialDashboardState)
            Me.dashboardViewer.DashboardStateChanged += New DevExpress.DashboardWin.DashboardStateChangedEventHandler(AddressOf Me.DashboardViewer_DashboardStateChanged)
            ' 
            ' Form1
            ' 
            Me.ClientSize = New System.Drawing.Size(919, 482)
            Me.Controls.Add(Me.dashboardViewer)
            Me.Name = "Form1"
            AddHandler Me.FormClosing, New System.Windows.Forms.FormClosingEventHandler(AddressOf Me.Form1_FormClosing)
            CType((Me.dashboardViewer), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private dashboardBarAndDockingController1 As DevExpress.DashboardWin.Native.DashboardBarAndDockingController

        Private dashboardBarController1 As DevExpress.DashboardWin.Bars.DashboardBarController

        Private textBoxEditorBarController1 As DevExpress.DashboardWin.Bars.TextBoxEditorBarController

        Private dashboardViewer1 As DevExpress.DashboardWin.DashboardViewer

        Private dashboardViewer As DevExpress.DashboardWin.DashboardViewer
    End Class
End Namespace
