namespace SP_DeploymentEnvironmentSim
{
    partial class PostgreSQLDBServerUnit
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
            this.PostgreStopButton = new System.Windows.Forms.Button();
            this.PostgreStatusLabel = new System.Windows.Forms.Label();
            this.PostgreStartButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PostgreStopButton
            // 
            this.PostgreStopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PostgreStopButton.Location = new System.Drawing.Point(336, 73);
            this.PostgreStopButton.Name = "PostgreStopButton";
            this.PostgreStopButton.Size = new System.Drawing.Size(272, 57);
            this.PostgreStopButton.TabIndex = 7;
            this.PostgreStopButton.Text = "Stop";
            this.PostgreStopButton.UseVisualStyleBackColor = true;
            this.PostgreStopButton.Click += new System.EventHandler(this.PostgreStopButton_Click);
            // 
            // PostgreStatusLabel
            // 
            this.PostgreStatusLabel.AutoSize = true;
            this.PostgreStatusLabel.BackColor = System.Drawing.Color.Red;
            this.PostgreStatusLabel.Location = new System.Drawing.Point(297, 88);
            this.PostgreStatusLabel.MaximumSize = new System.Drawing.Size(30, 30);
            this.PostgreStatusLabel.MinimumSize = new System.Drawing.Size(30, 30);
            this.PostgreStatusLabel.Name = "PostgreStatusLabel";
            this.PostgreStatusLabel.Size = new System.Drawing.Size(30, 30);
            this.PostgreStatusLabel.TabIndex = 6;
            // 
            // PostgreStartButton
            // 
            this.PostgreStartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PostgreStartButton.Location = new System.Drawing.Point(13, 73);
            this.PostgreStartButton.Name = "PostgreStartButton";
            this.PostgreStartButton.Size = new System.Drawing.Size(272, 57);
            this.PostgreStartButton.TabIndex = 5;
            this.PostgreStartButton.Text = "Start";
            this.PostgreStartButton.UseVisualStyleBackColor = true;
            this.PostgreStartButton.Click += new System.EventHandler(this.PostgreStartButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(194, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "PostgreSQL Server";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PostgreSQLDBServerUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.PostgreStopButton);
            this.Controls.Add(this.PostgreStatusLabel);
            this.Controls.Add(this.PostgreStartButton);
            this.Controls.Add(this.label1);
            this.Name = "PostgreSQLDBServerUnit";
            this.Size = new System.Drawing.Size(616, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PostgreStopButton;
        private System.Windows.Forms.Label PostgreStatusLabel;
        private System.Windows.Forms.Button PostgreStartButton;
        private System.Windows.Forms.Label label1;
    }
}
