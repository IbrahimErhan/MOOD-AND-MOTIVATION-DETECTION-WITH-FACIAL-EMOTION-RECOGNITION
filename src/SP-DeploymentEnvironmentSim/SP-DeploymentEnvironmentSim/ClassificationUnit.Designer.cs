namespace SP_DeploymentEnvironmentSim
{
    partial class ClassificationUnit
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
            this.ClassificationStopButton = new System.Windows.Forms.Button();
            this.ClassificationStatusLabel = new System.Windows.Forms.Label();
            this.ClassificationStartButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ClassificationStopButton
            // 
            this.ClassificationStopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ClassificationStopButton.Location = new System.Drawing.Point(334, 73);
            this.ClassificationStopButton.Name = "ClassificationStopButton";
            this.ClassificationStopButton.Size = new System.Drawing.Size(272, 57);
            this.ClassificationStopButton.TabIndex = 11;
            this.ClassificationStopButton.Text = "Stop";
            this.ClassificationStopButton.UseVisualStyleBackColor = true;
            this.ClassificationStopButton.Click += new System.EventHandler(this.ClassificationStopButton_Click);
            // 
            // ClassificationStatusLabel
            // 
            this.ClassificationStatusLabel.AutoSize = true;
            this.ClassificationStatusLabel.BackColor = System.Drawing.Color.Red;
            this.ClassificationStatusLabel.Location = new System.Drawing.Point(295, 88);
            this.ClassificationStatusLabel.MaximumSize = new System.Drawing.Size(30, 30);
            this.ClassificationStatusLabel.MinimumSize = new System.Drawing.Size(30, 30);
            this.ClassificationStatusLabel.Name = "ClassificationStatusLabel";
            this.ClassificationStatusLabel.Size = new System.Drawing.Size(30, 30);
            this.ClassificationStatusLabel.TabIndex = 10;
            // 
            // ClassificationStartButton
            // 
            this.ClassificationStartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ClassificationStartButton.Location = new System.Drawing.Point(11, 73);
            this.ClassificationStartButton.Name = "ClassificationStartButton";
            this.ClassificationStartButton.Size = new System.Drawing.Size(272, 57);
            this.ClassificationStartButton.TabIndex = 9;
            this.ClassificationStartButton.Text = "Start";
            this.ClassificationStartButton.UseVisualStyleBackColor = true;
            this.ClassificationStartButton.Click += new System.EventHandler(this.ClassificationStartButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(192, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 36);
            this.label1.TabIndex = 8;
            this.label1.Text = "Classification Server";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ClassificationUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.ClassificationStopButton);
            this.Controls.Add(this.ClassificationStatusLabel);
            this.Controls.Add(this.ClassificationStartButton);
            this.Controls.Add(this.label1);
            this.Name = "ClassificationUnit";
            this.Size = new System.Drawing.Size(612, 146);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ClassificationStopButton;
        private System.Windows.Forms.Label ClassificationStatusLabel;
        private System.Windows.Forms.Button ClassificationStartButton;
        private System.Windows.Forms.Label label1;
    }
}
