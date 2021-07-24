namespace SP_DeploymentEnvironmentSim
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.classificationUnit1 = new SP_DeploymentEnvironmentSim.ClassificationUnit();
            this.postgreSQLDBServerUnit1 = new SP_DeploymentEnvironmentSim.PostgreSQLDBServerUnit();
            this.mongoDBServerUnit1 = new SP_DeploymentEnvironmentSim.MongoDBServerUnit();
            this.cameraUnit5 = new SP_DeploymentEnvironmentSim.CameraUnit();
            this.cameraUnit4 = new SP_DeploymentEnvironmentSim.CameraUnit();
            this.cameraUnit3 = new SP_DeploymentEnvironmentSim.CameraUnit();
            this.cameraUnit2 = new SP_DeploymentEnvironmentSim.CameraUnit();
            this.cameraUnit1 = new SP_DeploymentEnvironmentSim.CameraUnit();
            this.SuspendLayout();
            // 
            // classificationUnit1
            // 
            this.classificationUnit1.BackColor = System.Drawing.SystemColors.Desktop;
            this.classificationUnit1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.classificationUnit1.Location = new System.Drawing.Point(131, 634);
            this.classificationUnit1.Name = "classificationUnit1";
            this.classificationUnit1.Size = new System.Drawing.Size(612, 146);
            this.classificationUnit1.TabIndex = 7;
            // 
            // postgreSQLDBServerUnit1
            // 
            this.postgreSQLDBServerUnit1.BackColor = System.Drawing.SystemColors.Desktop;
            this.postgreSQLDBServerUnit1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.postgreSQLDBServerUnit1.Location = new System.Drawing.Point(129, 478);
            this.postgreSQLDBServerUnit1.Name = "postgreSQLDBServerUnit1";
            this.postgreSQLDBServerUnit1.Size = new System.Drawing.Size(616, 150);
            this.postgreSQLDBServerUnit1.TabIndex = 6;
            // 
            // mongoDBServerUnit1
            // 
            this.mongoDBServerUnit1.BackColor = System.Drawing.SystemColors.Desktop;
            this.mongoDBServerUnit1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mongoDBServerUnit1.Location = new System.Drawing.Point(126, 316);
            this.mongoDBServerUnit1.Name = "mongoDBServerUnit1";
            this.mongoDBServerUnit1.Size = new System.Drawing.Size(620, 154);
            this.mongoDBServerUnit1.TabIndex = 5;
            // 
            // cameraUnit5
            // 
            this.cameraUnit5.BackColor = System.Drawing.SystemColors.Desktop;
            this.cameraUnit5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cameraUnit5.Location = new System.Drawing.Point(708, 12);
            this.cameraUnit5.Name = "cameraUnit5";
            this.cameraUnit5.Size = new System.Drawing.Size(168, 298);
            this.cameraUnit5.TabIndex = 4;
            // 
            // cameraUnit4
            // 
            this.cameraUnit4.BackColor = System.Drawing.SystemColors.Desktop;
            this.cameraUnit4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cameraUnit4.Location = new System.Drawing.Point(534, 12);
            this.cameraUnit4.Name = "cameraUnit4";
            this.cameraUnit4.Size = new System.Drawing.Size(168, 298);
            this.cameraUnit4.TabIndex = 3;
            // 
            // cameraUnit3
            // 
            this.cameraUnit3.BackColor = System.Drawing.SystemColors.Desktop;
            this.cameraUnit3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cameraUnit3.Location = new System.Drawing.Point(360, 12);
            this.cameraUnit3.Name = "cameraUnit3";
            this.cameraUnit3.Size = new System.Drawing.Size(168, 298);
            this.cameraUnit3.TabIndex = 2;
            // 
            // cameraUnit2
            // 
            this.cameraUnit2.BackColor = System.Drawing.SystemColors.Desktop;
            this.cameraUnit2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cameraUnit2.Location = new System.Drawing.Point(186, 12);
            this.cameraUnit2.Name = "cameraUnit2";
            this.cameraUnit2.Size = new System.Drawing.Size(168, 298);
            this.cameraUnit2.TabIndex = 1;
            // 
            // cameraUnit1
            // 
            this.cameraUnit1.BackColor = System.Drawing.SystemColors.Desktop;
            this.cameraUnit1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cameraUnit1.Location = new System.Drawing.Point(12, 12);
            this.cameraUnit1.Name = "cameraUnit1";
            this.cameraUnit1.Size = new System.Drawing.Size(168, 298);
            this.cameraUnit1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(889, 789);
            this.Controls.Add(this.classificationUnit1);
            this.Controls.Add(this.postgreSQLDBServerUnit1);
            this.Controls.Add(this.mongoDBServerUnit1);
            this.Controls.Add(this.cameraUnit5);
            this.Controls.Add(this.cameraUnit4);
            this.Controls.Add(this.cameraUnit3);
            this.Controls.Add(this.cameraUnit2);
            this.Controls.Add(this.cameraUnit1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private CameraUnit cameraUnit1;
        private CameraUnit cameraUnit2;
        private CameraUnit cameraUnit3;
        private CameraUnit cameraUnit4;
        private CameraUnit cameraUnit5;
        private MongoDBServerUnit mongoDBServerUnit1;
        private PostgreSQLDBServerUnit postgreSQLDBServerUnit1;
        private ClassificationUnit classificationUnit1;
    }
}

