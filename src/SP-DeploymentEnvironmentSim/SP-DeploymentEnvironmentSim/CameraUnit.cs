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
    public partial class CameraUnit : UserControl
    {
        private bool cameraRunningState = false;
        PythonScriptRunner pythonScript;
        public CameraUnit()
        {
            InitializeComponent();
        }

        private void StartStopCamera_Click(object sender, EventArgs e)
        {
            if (cameraRunningState == false)
            {
                pythonScript = new PythonScriptRunner();
                StartCameraScript();
                this.statusLightLabel.BackColor = System.Drawing.Color.Green;
                cameraRunningState = true;
            }
            else
            {
                pythonScript.StopCmd();
                this.statusLightLabel.BackColor = System.Drawing.Color.Red;
                cameraRunningState = false;
            }
        }

        public void StartCameraScript()
        {
            pythonScript.cmd.StandardInput.WriteLine("cd C:\\Users\\ibrah\\Desktop\\SP-Codes-12-06-2020\\CameraControllerSide");
            pythonScript.cmd.StandardInput.WriteLine("CCProgram.py");
        }
    }
}
