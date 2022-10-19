using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThunderTodo
{
    public partial class TaskForm : DevExpress.XtraEditors.XtraForm
    {
        public TaskForm()
        {
            InitializeComponent();
        }

        public void Init(Domain.Task task = null) 
        {
            if (task != null) 
            {

            }
        }
    }
}