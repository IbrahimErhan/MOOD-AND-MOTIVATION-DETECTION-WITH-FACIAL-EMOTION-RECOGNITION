namespace SP_DeploymentEnvironmentSim
{
    partial class MongoDBServerUnit
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
            this.label1 = new System.Windows.Forms.Label();
            this.MongoStartButton = new System.Windows.Forms.Button();
            this.MongoStatusLabel = new System.Windows.Forms.Label();
            this.MongoStopButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(195, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "MongoDB Server";
            // 
            // MongoStartButton
            // 
            this.MongoStartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MongoStartButton.Location = new System.Drawing.Point(14, 74);
            this.MongoStartButton.Name = "MongoStartButton";
            this.MongoStartButton.Size = new System.Drawing.Size(272, 57);
            this.MongoStartButton.TabIndex = 1;
            this.MongoStartButton.Text = "Start";
            this.MongoStartButton.UseVisualStyleBackColor = true;
            this.MongoStartButton.Click += new System.EventHandler(this.MongoStartButton_Click);
            // 
            // MongoStatusLabel
            // 
            this.MongoStatusLabel.AutoSize = true;
            this.MongoStatusLabel.BackColor = System.Drawing.Color.Red;
            this.MongoStatusLabel.Location = new System.Drawing.Point(298, 89);
            this.MongoStatusLabel.MaximumSize = new System.Drawing.Size(30, 30);
            this.MongoStatusLabel.MinimumSize = new System.Drawing.Size(30, 30);
            this.MongoStatusLabel.Name = "MongoStatusLabel";
            this.MongoStatusLabel.Size = new System.Drawing.Size(30, 30);
            this.MongoStatusLabel.TabIndex = 2;
            // 
            // MongoStopButton
            // 
            this.MongoStopButton.Enabled = false;
            this.MongoStopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MongoStopButton.Location = new System.Drawing.Point(337, 74);
            this.MongoStopButton.Name = "MongoStopButton";
            this.MongoStopButton.Size = new System.Drawing.Size(272, 57);
            this.MongoStopButton.TabIndex = 3;
            this.MongoStopButton.Text = "Stop";
            this.MongoStopButton.UseVisualStyleBackColor = true;
            this.MongoStopButton.Click += new System.EventHandler(this.MongoStopButton_Click);
            // 
            // MongoDBServerUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.MongoStopButton);
            this.Controls.Add(this.MongoStatusLabel);
            this.Controls.Add(this.MongoStartButton);
            this.Controls.Add(this.label1);
            this.Name = "MongoDBServerUnit";
            this.Size = new System.Drawing.Size(620, 154);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button MongoStartButton;
        private System.Windows.Forms.Label MongoStatusLabel;
        private System.Windows.Forms.Button MongoStopButton;
    }
}
