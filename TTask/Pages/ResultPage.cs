using System;
using System.Windows.Forms;
using TTask.Library;
using TTask.Nav;

namespace TTask.Pages
{
    public partial class ResultPage : UserControl, INav
    {
        private readonly Output output;
        private int iter = 0;
        public ResultPage(Output output)
        {
            InitializeComponent();
            this.output = output;
            ShowIteration();
        }

        public event Action<NavMsg> NewMsg;

        private void ToHomeBtn_Click(object sender, EventArgs e)
        {
            NewMsg?.Invoke(new ToStartPage());
        }

        private void ShowResBtn_Click(object sender, EventArgs e)
        {
            resTxb.Text = output.Format;
        }

        private void IterBtn_Click(object sender, EventArgs e)
        {
            resTxb.Text = output.GetIterFormat(iter);
            iter++;
            ShowIteration();
            if (iter == output.Iterations.Length)
            {
                iterBtn.Enabled = false;
            }
        }

        private void ShowIteration()
        {
            iterLbl.Text = $"{iter} / {output.Iterations.Length}";
        }
    }
}
