using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EngineWindowsApp
{
    public partial class table : Form
    {
        public table()
        {
            InitializeComponent();
        }
        //通过该方法把参数传进来
        public void setValue(DataTable dt)
        {
            this.dataGridView1.DataSource = dt;
        }

    }
}
