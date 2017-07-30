namespace ProcessSuspend
{
    partial class frmHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHelp));
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabHelp = new System.Windows.Forms.TabControl();
            this.tabInformation = new System.Windows.Forms.TabPage();
            this.lblInformation = new System.Windows.Forms.Label();
            this.tabHowToUse = new System.Windows.Forms.TabPage();
            this.lblHowToUse = new System.Windows.Forms.Label();
            this.tabHowToUpdate = new System.Windows.Forms.TabPage();
            this.lblHowToUpdate = new System.Windows.Forms.Label();
            this.tabErrorsBugs = new System.Windows.Forms.TabPage();
            this.lblErrorsBugs = new System.Windows.Forms.Label();
            this.tabReportFeedback = new System.Windows.Forms.TabPage();
            this.lblReportingBugs = new System.Windows.Forms.Label();
            this.tabHelp.SuspendLayout();
            this.tabInformation.SuspendLayout();
            this.tabHowToUse.SuspendLayout();
            this.tabHowToUpdate.SuspendLayout();
            this.tabErrorsBugs.SuspendLayout();
            this.tabReportFeedback.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(13, 375);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(84, 23);
            this.btnPrevious.TabIndex = 0;
            this.btnPrevious.Text = "Previous Page";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(339, 375);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(84, 23);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next Page";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(103, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "DO NOT DISTRIBUTE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabHelp
            // 
            this.tabHelp.Controls.Add(this.tabInformation);
            this.tabHelp.Controls.Add(this.tabHowToUse);
            this.tabHelp.Controls.Add(this.tabHowToUpdate);
            this.tabHelp.Controls.Add(this.tabErrorsBugs);
            this.tabHelp.Controls.Add(this.tabReportFeedback);
            this.tabHelp.Location = new System.Drawing.Point(13, 13);
            this.tabHelp.Name = "tabHelp";
            this.tabHelp.SelectedIndex = 0;
            this.tabHelp.Size = new System.Drawing.Size(410, 356);
            this.tabHelp.TabIndex = 3;
            this.tabHelp.Tag = "";
            // 
            // tabInformation
            // 
            this.tabInformation.Controls.Add(this.lblInformation);
            this.tabInformation.Location = new System.Drawing.Point(4, 22);
            this.tabInformation.Name = "tabInformation";
            this.tabInformation.Padding = new System.Windows.Forms.Padding(3);
            this.tabInformation.Size = new System.Drawing.Size(402, 330);
            this.tabInformation.TabIndex = 0;
            this.tabInformation.Text = "Information";
            this.tabInformation.UseVisualStyleBackColor = true;
            // 
            // lblInformation
            // 
            this.lblInformation.Location = new System.Drawing.Point(6, 3);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(390, 324);
            this.lblInformation.TabIndex = 0;
            this.lblInformation.Text = resources.GetString("lblInformation.Text");
            this.lblInformation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabHowToUse
            // 
            this.tabHowToUse.Controls.Add(this.lblHowToUse);
            this.tabHowToUse.Location = new System.Drawing.Point(4, 22);
            this.tabHowToUse.Name = "tabHowToUse";
            this.tabHowToUse.Padding = new System.Windows.Forms.Padding(3);
            this.tabHowToUse.Size = new System.Drawing.Size(402, 330);
            this.tabHowToUse.TabIndex = 1;
            this.tabHowToUse.Text = "How to use";
            this.tabHowToUse.UseVisualStyleBackColor = true;
            // 
            // lblHowToUse
            // 
            this.lblHowToUse.Location = new System.Drawing.Point(6, 3);
            this.lblHowToUse.Name = "lblHowToUse";
            this.lblHowToUse.Size = new System.Drawing.Size(390, 324);
            this.lblHowToUse.TabIndex = 0;
            this.lblHowToUse.Text = resources.GetString("lblHowToUse.Text");
            // 
            // tabHowToUpdate
            // 
            this.tabHowToUpdate.Controls.Add(this.lblHowToUpdate);
            this.tabHowToUpdate.Location = new System.Drawing.Point(4, 22);
            this.tabHowToUpdate.Name = "tabHowToUpdate";
            this.tabHowToUpdate.Padding = new System.Windows.Forms.Padding(3);
            this.tabHowToUpdate.Size = new System.Drawing.Size(402, 330);
            this.tabHowToUpdate.TabIndex = 2;
            this.tabHowToUpdate.Text = "How to update";
            this.tabHowToUpdate.UseVisualStyleBackColor = true;
            // 
            // lblHowToUpdate
            // 
            this.lblHowToUpdate.Location = new System.Drawing.Point(6, 3);
            this.lblHowToUpdate.Name = "lblHowToUpdate";
            this.lblHowToUpdate.Size = new System.Drawing.Size(390, 324);
            this.lblHowToUpdate.TabIndex = 0;
            this.lblHowToUpdate.Text = resources.GetString("lblHowToUpdate.Text");
            // 
            // tabErrorsBugs
            // 
            this.tabErrorsBugs.Controls.Add(this.lblErrorsBugs);
            this.tabErrorsBugs.Location = new System.Drawing.Point(4, 22);
            this.tabErrorsBugs.Name = "tabErrorsBugs";
            this.tabErrorsBugs.Padding = new System.Windows.Forms.Padding(3);
            this.tabErrorsBugs.Size = new System.Drawing.Size(402, 330);
            this.tabErrorsBugs.TabIndex = 3;
            this.tabErrorsBugs.Text = "Errors/bugs";
            this.tabErrorsBugs.UseVisualStyleBackColor = true;
            // 
            // lblErrorsBugs
            // 
            this.lblErrorsBugs.Location = new System.Drawing.Point(6, 3);
            this.lblErrorsBugs.Name = "lblErrorsBugs";
            this.lblErrorsBugs.Size = new System.Drawing.Size(390, 324);
            this.lblErrorsBugs.TabIndex = 0;
            this.lblErrorsBugs.Text = resources.GetString("lblErrorsBugs.Text");
            // 
            // tabReportFeedback
            // 
            this.tabReportFeedback.Controls.Add(this.lblReportingBugs);
            this.tabReportFeedback.Location = new System.Drawing.Point(4, 22);
            this.tabReportFeedback.Name = "tabReportFeedback";
            this.tabReportFeedback.Padding = new System.Windows.Forms.Padding(3);
            this.tabReportFeedback.Size = new System.Drawing.Size(402, 330);
            this.tabReportFeedback.TabIndex = 4;
            this.tabReportFeedback.Text = "Reporting bugs";
            this.tabReportFeedback.UseVisualStyleBackColor = true;
            // 
            // lblReportingBugs
            // 
            this.lblReportingBugs.Location = new System.Drawing.Point(6, 3);
            this.lblReportingBugs.Name = "lblReportingBugs";
            this.lblReportingBugs.Size = new System.Drawing.Size(390, 324);
            this.lblReportingBugs.TabIndex = 0;
            this.lblReportingBugs.Text = resources.GetString("lblReportingBugs.Text");
            // 
            // frmHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 410);
            this.Controls.Add(this.tabHelp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHelp";
            this.Text = "ProcessSuspend - Release 1.0";
            this.tabHelp.ResumeLayout(false);
            this.tabInformation.ResumeLayout(false);
            this.tabHowToUse.ResumeLayout(false);
            this.tabHowToUpdate.ResumeLayout(false);
            this.tabErrorsBugs.ResumeLayout(false);
            this.tabReportFeedback.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabHelp;
        private System.Windows.Forms.TabPage tabInformation;
        private System.Windows.Forms.Label lblInformation;
        private System.Windows.Forms.TabPage tabHowToUse;
        private System.Windows.Forms.TabPage tabHowToUpdate;
        private System.Windows.Forms.TabPage tabErrorsBugs;
        private System.Windows.Forms.TabPage tabReportFeedback;
        private System.Windows.Forms.Label lblHowToUse;
        private System.Windows.Forms.Label lblHowToUpdate;
        private System.Windows.Forms.Label lblErrorsBugs;
        private System.Windows.Forms.Label lblReportingBugs;
    }
}