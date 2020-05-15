using CollegeLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaherdavinCollege
{
    public partial class formITTechnician : MetroFramework.Forms.MetroForm
    {
        private IModel Model;
        private formContainer fc;

        public formITTechnician(formContainer parent, IModel Model)
        {
            InitializeComponent();
            MdiParent = parent;
            fc = parent;
            this.Model = Model;
        }
    }
}
