using ReusableLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    /// <summary>
    /// This app uses the ReUsable Library for Delegate example in WinForms application
    /// </summary>

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnCreateStudent_Click(object sender, EventArgs e)
        {
            DataProgress csvFileProgress = new DataProgress();
            csvFileProgress.updateUi+= ShowProgress;
            await Task.Run(()=>csvFileProgress.Upload());
        }

      public void ShowProgress(string message)
        {
            lblCount.Invoke(new Action(() =>lblCount.Text = message));
          
        }

       
    }
}
