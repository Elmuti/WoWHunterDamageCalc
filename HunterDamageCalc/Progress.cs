using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HunterDamageCalc
{
    public partial class Progress : Form
    {
        /// <summary>
        /// The simulation number we are currently running
        /// </summary>
        private int CurrentSimulations = 0;

        /// <summary>
        /// The number of simulations we will be running in total
        /// </summary>
        private readonly int NumSimulations = 1;

        public Progress(int numSimulations)
        {
            this.NumSimulations = numSimulations;
            InitializeComponent();
            SetCurrentSimulations(0);
        }

        public void SetCurrentSimulations(int value)
        {
            this.CurrentSimulations = value;
            
            var invoker = new MethodInvoker(() => progressLabel.Text = $"Running Simulation {CurrentSimulations}/{NumSimulations}");
            if (progressLabel.InvokeRequired)
            {
                progressLabel.Invoke(invoker);
            }
            else
            {
                invoker.Invoke();
            }
        }

        public void SetProgress(int progress)
        {
            // nice threading model I dont even know whats happening
            var invoker = new MethodInvoker(() => this.progressBar.Value = progress);
            if (progressBar.InvokeRequired)
            {
                progressBar.Invoke(invoker);
            }
            else
            {
                invoker.Invoke();
            }
        }
    }
}
