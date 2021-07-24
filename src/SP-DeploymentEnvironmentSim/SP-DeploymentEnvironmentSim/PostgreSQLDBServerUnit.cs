using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SP_DeploymentEnvironmentSim
{
    public partial class PostgreSQLDBServerUnit : UserControl
    {
        PythonScriptRunner pythonScript;
        public PostgreSQLDBServerUnit()
        {
            InitializeComponent();
        }

        private void PostgreStartButton_Click(object sender, EventArgs e)
        {
            pythonScript = new PythonScriptRunner();
            this.PostgreStatusLabel.BackColor = System.Drawing.Color.Green;
            PostgreStartButton.Enabled = false;
            PostgreStopButton.Enabled = true;
            StartPostgreScriptScript();
        }

        private void PostgreStopButton_Click(object sender, EventArgs e)
        {
            this.PostgreStatusLabel.BackColor = System.Drawing.Color.Red;
            PostgreStopButton.Enabled = false;
            PostgreStartButton.Enabled = true;
            pythonScript.StopCmd();
        }
        
        public void StartPostgreScriptScript()
        {
            pythonScript.cmd.StandardInput.WriteLine("cd C:\\Users\\ibrah\\Desktop\\SP-Codes-12-06-2020\\PostgreSQL-Server");
            pythonScript.cmd.StandardInput.WriteLine("node index.js");
        }
    }
}
