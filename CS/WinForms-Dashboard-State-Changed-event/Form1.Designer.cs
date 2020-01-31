namespace WinForms_Dashboard_State_Changed_event {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.dashboardViewer = new DevExpress.DashboardWin.DashboardViewer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dashboardViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // dashboardViewer
            // 
            this.dashboardViewer.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.dashboardViewer.Appearance.Options.UseBackColor = true;
            this.dashboardViewer.DashboardSource = new System.Uri("D:\\examples\\WinForms-Dashboard-State-Changed-event\\WinForms-Dashboard-State-Chang" +
        "ed-event\\Dashboards\\dashboard1.xml", System.UriKind.Absolute);
            this.dashboardViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboardViewer.Location = new System.Drawing.Point(0, 0);
            this.dashboardViewer.Name = "dashboardViewer";
            this.dashboardViewer.Size = new System.Drawing.Size(919, 482);
            this.dashboardViewer.TabIndex = 0;
            this.dashboardViewer.DashboardLoaded += new DevExpress.DashboardWin.DashboardLoadedEventHandler(this.DashboardViewer_DashboardLoaded);
            this.dashboardViewer.SetInitialDashboardState += new DevExpress.DashboardWin.SetInitialDashboardStateEventHandler(this.DashboardViewer_SetInitialDashboardState);
            this.dashboardViewer.DashboardStateChanged += new DevExpress.DashboardWin.DashboardStateChangedEventHandler(this.DashboardViewer_DashboardStateChanged);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(919, 482);
            this.Controls.Add(this.dashboardViewer);
            this.Name = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dashboardViewer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.DashboardWin.Native.DashboardBarAndDockingController dashboardBarAndDockingController1;
        private DevExpress.DashboardWin.Bars.DashboardBarController dashboardBarController1;
        private DevExpress.DashboardWin.Bars.TextBoxEditorBarController textBoxEditorBarController1;
        private DevExpress.DashboardWin.DashboardViewer dashboardViewer1;
        private DevExpress.DashboardWin.DashboardViewer dashboardViewer;
    }
}