namespace ProcessSuspend
{
    partial class frmOptions
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
            this.label1 = new System.Windows.Forms.Label();
            this.grpNewProcessOptions = new System.Windows.Forms.GroupBox();
            this.radNewYes = new System.Windows.Forms.RadioButton();
            this.radNewNo = new System.Windows.Forms.RadioButton();
            this.btnCheckUpdates = new System.Windows.Forms.Button();
            this.btnOpenSave = new System.Windows.Forms.Button();
            this.grpNewProcessOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Save new process names?";
            // 
            // grpNewProcessOptions
            // 
            this.grpNewProcessOptions.Controls.Add(this.radNewYes);
            this.grpNewProcessOptions.Controls.Add(this.radNewNo);
            this.grpNewProcessOptions.Location = new System.Drawing.Point(16, 30);
            this.grpNewProcessOptions.Name = "grpNewProcessOptions";
            this.grpNewProcessOptions.Size = new System.Drawing.Size(132, 44);
            this.grpNewProcessOptions.TabIndex = 1;
            this.grpNewProcessOptions.TabStop = false;
            this.grpNewProcessOptions.Text = "Options";
            // 
            // radNewYes
            // 
            this.radNewYes.AutoSize = true;
            this.radNewYes.Location = new System.Drawing.Point(51, 19);
            this.radNewYes.Name = "radNewYes";
            this.radNewYes.Size = new System.Drawing.Size(43, 17);
            this.radNewYes.TabIndex = 1;
            this.radNewYes.Text = "Yes";
            this.radNewYes.UseVisualStyleBackColor = true;
            this.radNewYes.CheckedChanged += new System.EventHandler(this.radNewYes_CheckedChanged);
            // 
            // radNewNo
            // 
            this.radNewNo.AutoSize = true;
            this.radNewNo.Checked = true;
            this.radNewNo.Location = new System.Drawing.Point(6, 19);
            this.radNewNo.Name = "radNewNo";
            this.radNewNo.Size = new System.Drawing.Size(39, 17);
            this.radNewNo.TabIndex = 0;
            this.radNewNo.TabStop = true;
            this.radNewNo.Text = "No";
            this.radNewNo.UseVisualStyleBackColor = true;
            this.radNewNo.CheckedChanged += new System.EventHandler(this.radNewNo_CheckedChanged);
            // 
            // btnCheckUpdates
            // 
            this.btnCheckUpdates.Location = new System.Drawing.Point(13, 276);
            this.btnCheckUpdates.Name = "btnCheckUpdates";
            this.btnCheckUpdates.Size = new System.Drawing.Size(104, 23);
            this.btnCheckUpdates.TabIndex = 2;
            this.btnCheckUpdates.Text = "Check for updates";
            this.btnCheckUpdates.UseVisualStyleBackColor = true;
            this.btnCheckUpdates.Click += new System.EventHandler(this.btnCheckUpdates_Click);
            // 
            // btnOpenSave
            // 
            this.btnOpenSave.Location = new System.Drawing.Point(123, 276);
            this.btnOpenSave.Name = "btnOpenSave";
            this.btnOpenSave.Size = new System.Drawing.Size(96, 23);
            this.btnOpenSave.TabIndex = 3;
            this.btnOpenSave.Text = "Open save folder";
            this.btnOpenSave.UseVisualStyleBackColor = true;
            this.btnOpenSave.Click += new System.EventHandler(this.btnOpenSave_Click);
            // 
            // frmOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 311);
            this.Controls.Add(this.btnOpenSave);
            this.Controls.Add(this.btnCheckUpdates);
            this.Controls.Add(this.grpNewProcessOptions);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOptions";
            this.Load += new System.EventHandler(this.frmOptions_Load);
            this.grpNewProcessOptions.ResumeLayout(false);
            this.grpNewProcessOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpNewProcessOptions;
        private System.Windows.Forms.RadioButton radNewYes;
        private System.Windows.Forms.RadioButton radNewNo;
        private System.Windows.Forms.Button btnCheckUpdates;
        private System.Windows.Forms.Button btnOpenSave;
    }
}