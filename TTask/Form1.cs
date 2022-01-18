using System.Windows.Forms;
using TTask.Nav;
using TTask.Pages;
using TTask.Library;
namespace TTask
{
    public partial class Form1 : Form
    {
        INav currentPage;
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
            ChangePage(new ToStartPage());
        }

        private void CurrentPage_NewMsg(NavMsg obj)
        {
            ChangePage(obj);
        }

        public void ChangePage(NavMsg navMsg)
        {
            if (currentPage != null)
            {
                currentPage.NewMsg -= CurrentPage_NewMsg;
            }

            UserControl page = null; ;
            if (navMsg is ToStartPage)
            {
                page = new TaskDescriptionPage();
            }
            else if (navMsg is ToAlgorithmPage)
            {
                page = new AlgorithmPage();
            }
            else if (navMsg is ToResultPage resultPage)
            {
                page = new ResultPage(resultPage.Output);
            }

            currentPage = page as INav;
            currentPage.NewMsg += CurrentPage_NewMsg;

            ChangePageInHost(page);
        }

        private void ChangePageInHost(UserControl userControl)
        {
            pageHost.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            pageHost.Controls.Add(userControl);
        }
    }
}
