using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CollegeLayer;

namespace CaherdavinCollege
{
    public partial class formAdministrator : MetroFramework.Forms.MetroForm
    {
        private IModel Model;
        private formContainer fc;

        public formAdministrator(formContainer parent, IModel Model)
        {
            InitializeComponent();
            MdiParent = parent;
            fc = parent;
            this.Model = Model;
        }
    }
}
