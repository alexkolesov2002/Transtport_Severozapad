using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TTask.Nav;

namespace TTask.Pages
{
    public partial class TaskDescriptionPage : UserControl, INav
    {
        public TaskDescriptionPage()
        {
            InitializeComponent();
        }

        public event Action<NavMsg> NewMsg;

        private void ToAlgBtn_Click(object sender, EventArgs e)
        {
            NewMsg?.Invoke(new ToAlgorithmPage());
        }
    }
}
