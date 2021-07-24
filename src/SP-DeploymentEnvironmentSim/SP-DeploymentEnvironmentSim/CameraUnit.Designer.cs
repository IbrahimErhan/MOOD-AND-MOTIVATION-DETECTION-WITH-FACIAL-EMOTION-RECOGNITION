namespace SP_DeploymentEnvironmentSim
{
    partial class CameraUnit
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CameraUnit));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusLightLabel = new System.Windows.Forms.Label();
            this.StartStopCameraButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cameraIDTextBox = new System.Windows.Forms.TextBox();
            this.clusterIDTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 111);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // statusLightLabel
            // 
            this.statusLightLabel.AutoSize = true;
            this.statusLightLabel.BackColor = System.Drawing.Color.Red;
            this.statusLightLabel.Location = new System.Drawing.Point(70, 208);
            this.statusLightLabel.MaximumSize = new System.Drawing.Size(30, 30);
            this.statusLightLabel.MinimumSize = new System.Drawing.Size(30, 30);
            this.statusLightLabel.Name = "statusLightLabel";
            this.statusLightLabel.Size = new System.Drawing.Size(30, 30);
            this.statusLightLabel.TabIndex = 1;
            // 
            // StartStopCameraButton
            // 
            this.StartStopCameraButton.Location = new System.Drawing.Point(14, 251);
            this.StartStopCameraButton.Name = "StartStopCameraButton";
            this.StartStopCameraButton.Size = new System.Drawing.Size(142, 39);
            this.StartStopCameraButton.TabIndex = 2;
            this.StartStopCameraButton.Text = "Camera Start/Stop";
            this.StartStopCameraButton.UseVisualStyleBackColor = true;
            this.StartStopCameraButton.Click += new System.EventHandler(this.StartStopCamera_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(11, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "CameraID : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(11, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "ClusterID : ";
            // 
            // cameraIDTextBox
            // 
            this.cameraIDTextBox.Location = new System.Drawing.Point(88, 126);
            this.cameraIDTextBox.Name = "cameraIDTextBox";
            this.cameraIDTextBox.Size = new System.Drawing.Size(68, 22);
            this.cameraIDTextBox.TabIndex = 5;
            // 
            // clusterIDTextBox
            // 
            this.clusterIDTextBox.Location = new System.Drawing.Point(88, 164);
            this.clusterIDTextBox.Name = "clusterIDTextBox";
            this.clusterIDTextBox.Size = new System.Drawing.Size(68, 22);
            this.clusterIDTextBox.TabIndex = 6;
            this.clusterIDTextBox.Text = "1";
            // 
            // CameraUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.clusterIDTextBox);
            this.Controls.Add(this.cameraIDTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StartStopCameraButton);
            this.Controls.Add(this.statusLightLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CameraUnit";
            this.Size = new System.Drawing.Size(168, 298);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label statusLightLabel;
        private System.Windows.Forms.Button StartStopCameraButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cameraIDTextBox;
        private System.Windows.Forms.TextBox clusterIDTextBox;
    }
}
