using DevExpress.DashboardCommon;
using DevExpress.DashboardWin;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinForms_Dashboard_State_Changed_event {
    public partial class Form1: Form {
        DashboardState state = new DashboardState();
        const string path = "../../Dashboards/dashboard1.xml";
        public Form1() {
            InitializeComponent();
            dashboardViewer.LoadDashboard(path);
        }

        private void DashboardViewer_DashboardStateChanged(object sender, DashboardStateChangedEventArgs e) {
            state = dashboardViewer.GetDashboardState();
            state.SaveToXml();            
        }

        private void DashboardViewer_SetInitialDashboardState(object sender, SetInitialDashboardStateEventArgs e) {
            e.InitialState = state;
        }
        private void DashboardViewer_DashboardLoaded(object sender, DashboardLoadedEventArgs e) {
            XElement data = e.Dashboard.UserData;
            if(data != null) {
                if(data.Element("DashboardState") != null) {
                    state.LoadFromXml(XDocument.Parse(data.Element("DashboardState").Value));
                }
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            XElement userData = new XElement("Root",
            new XElement("DashboardState", state.SaveToXml().ToString(SaveOptions.DisableFormatting)));
            dashboardViewer.Dashboard.UserData = userData;
            dashboardViewer.Dashboard.SaveToXml(path);
        }
    }
}
