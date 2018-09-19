using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DotNetBrowser;
using DotNetBrowser.WinForms;

namespace TestMap
{
    public partial class Form1 : Form
    {
        private WinFormsBrowserView browserView;
        public Form1()
        {
            InitializeComponent();
            browserView = new WinFormsBrowserView() { Dock = DockStyle.Fill };
            Controls.Add((Control)browserView);
            //local 
            //browserView.Browser.LoadURL("C:\\users\\mbruce\\desktop\\ESRI_Leaflet.html");
            //from web
            browserView.Browser.LoadURL("https://developers.arcgis.com/javascript/latest/sample-code/intro-sceneview/live/index.html");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
