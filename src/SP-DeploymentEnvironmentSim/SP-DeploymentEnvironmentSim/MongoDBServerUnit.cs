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
    public partial class MongoDBServerUnit : UserControl
    {
        PythonScriptRunner pythonScript;
        public MongoDBServerUnit()
        {
            InitializeComponent();
        }

        private void MongoStartButton_Click(object sender, EventArgs e)
        {
            pythonScript = new PythonScriptRunner();
            this.MongoStatusLabel.BackColor = System.Drawing.Color.Green;
            MongoStartButton.Enabled = false;
            MongoStopButton.Enabled = true;
            StartMongoScriptScript();
        }

        private void MongoStopButton_Click(object sender, EventArgs e)
        {
            this.MongoStatusLabel.BackColor = System.Drawing.Color.Red;
            MongoStopButton.Enabled = false;
            MongoStartButton.Enabled = true;
            pythonScript.StopCmd();
        }
        public void StartMongoScriptScript()
        {
            pythonScript.cmd.StandardInput.WriteLine("cd C:\\Users\\ibrah\\Desktop\\SP-Codes-12-06-2020\\MongoDB-Server");
            pythonScript.cmd.StandardInput.WriteLine("node server.js");
        }
    }
}
