using DevExpress.DashboardCommon;
using DevExpress.DashboardWin;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinForms_Dashboard_State_Changed_event {
    public partial class Form1: Form {
        DashboardState state = new DashboardState();
        public static readonly string PropertyName = "DashboardState";
        const string path = @"..\..\Dashboards\dashboard1.xml";
        public Form1() {
            InitializeComponent();
            dashboardViewer.LoadDashboard(path);
        }

        private void DashboardViewer_DashboardStateChanged(object sender, DashboardStateChangedEventArgs e) {
            state = dashboardViewer.GetDashboardState();
            var stateValue = state.SaveToXml().ToString(SaveOptions.DisableFormatting);
            dashboardViewer.Dashboard.CustomProperties.SetValue("DashboardState", stateValue);
        }

        private void DashboardViewer_SetInitialDashboardState(object sender, SetInitialDashboardStateEventArgs e) {
            e.InitialState = state;
        }

        void GetDataFromString(string customPropertyValue) {
            if(!string.IsNullOrEmpty(customPropertyValue)) {
                var xmlStateEl = XDocument.Parse(customPropertyValue);
                state.LoadFromXml(xmlStateEl);
            }
        }
        private void DashboardViewer_DashboardLoaded(object sender, DashboardLoadedEventArgs e) {
            GetDataFromString(dashboardViewer.Dashboard.CustomProperties.GetValue(PropertyName));
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            dashboardViewer.Dashboard.SaveToXml(path);
        }
    }
}
