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
    public partial class ClassificationUnit : UserControl
    {
        PythonScriptRunner pythonScript;
        public ClassificationUnit()
        {
            InitializeComponent();
        }

        private void ClassificationStartButton_Click(object sender, EventArgs e)
        {
            pythonScript = new PythonScriptRunner();
            this.ClassificationStatusLabel.BackColor = System.Drawing.Color.Green;
            ClassificationStartButton.Enabled = false;
            ClassificationStopButton.Enabled = true;
            StartClassificationScriptScript();
        }

        private void ClassificationStopButton_Click(object sender, EventArgs e)
        {
            this.ClassificationStatusLabel.BackColor = System.Drawing.Color.Red;
            ClassificationStopButton.Enabled = false;
            ClassificationStartButton.Enabled = true;
            pythonScript.StopCmd();
        }

        public void StartClassificationScriptScript()
        {
            pythonScript.cmd.StandardInput.WriteLine("cd C:\\Users\\ibrah\\Desktop\\SP-Codes-12-06-2020\\ClassificationServer");
            pythonScript.cmd.StandardInput.WriteLine("EmoDetServerProgram.py");
        }
    }
}
