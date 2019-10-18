using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ESRI.ArcGIS.SystemUI;
using ESRI.ArcGIS.Controls;

namespace EngineWindowsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calField_Click(object sender, EventArgs e)
        {

            //≤‚ ‘Õ¨≤Ω
        }

        private void btn_addData_Click(object sender, EventArgs e)
        {
            ICommand addData = new ControlsAddDataCommand();
            addData.OnCreate(axMapControl1.Object);
            addData.OnClick();
        }
    }
}