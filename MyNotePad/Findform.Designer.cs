namespace MyNotePad
{
    partial class Findform
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
            this.findClose = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.findStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.findTarget = new System.Windows.Forms.TextBox();
            this.findNext = new System.Windows.Forms.Button();
            this.findCount = new System.Windows.Forms.Button();
            this.findReplace = new System.Windows.Forms.Button();
            this.findReplaceTarget = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // findClose
            // 
            this.findClose.Location = new System.Drawing.Point(289, 125);
            this.findClose.Name = "findClose";
            this.findClose.Size = new System.Drawing.Size(112, 23);
            this.findClose.TabIndex = 0;
            this.findClose.Text = "Close";
            this.findClose.UseVisualStyleBackColor = true;
            this.findClose.Click += new System.EventHandler(this.findClose_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 151);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(413, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // findStatus
            // 
            this.findStatus.Name = "findStatus";
            this.findStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Find what :";
            // 
            // findTarget
            // 
            this.findTarget.Location = new System.Drawing.Point(121, 35);
            this.findTarget.Name = "findTarget";
            this.findTarget.Size = new System.Drawing.Size(142, 21);
            this.findTarget.TabIndex = 3;
            // 
            // findNext
            // 
            this.findNext.Location = new System.Drawing.Point(289, 33);
            this.findNext.Name = "findNext";
            this.findNext.Size = new System.Drawing.Size(112, 23);
            this.findNext.TabIndex = 4;
            this.findNext.Text = "Find Next";
            this.findNext.UseVisualStyleBackColor = true;
            this.findNext.Click += new System.EventHandler(this.findNext_Click);
            // 
            // findCount
            // 
            this.findCount.Location = new System.Drawing.Point(289, 62);
            this.findCount.Name = "findCount";
            this.findCount.Size = new System.Drawing.Size(112, 23);
            this.findCount.TabIndex = 6;
            this.findCount.Text = "Count";
            this.findCount.UseVisualStyleBackColor = true;
            this.findCount.Click += new System.EventHandler(this.findCount_Click);
            // 
            // findReplace
            // 
            this.findReplace.Location = new System.Drawing.Point(289, 91);
            this.findReplace.Name = "findReplace";
            this.findReplace.Size = new System.Drawing.Size(112, 23);
            this.findReplace.TabIndex = 7;
            this.findReplace.Text = "Replace";
            this.findReplace.UseVisualStyleBackColor = true;
            this.findReplace.Click += new System.EventHandler(this.findReplace_Click);
            // 
            // findReplaceTarget
            // 
            this.findReplaceTarget.Location = new System.Drawing.Point(121, 88);
            this.findReplaceTarget.Name = "findReplaceTarget";
            this.findReplaceTarget.Size = new System.Drawing.Size(142, 21);
            this.findReplaceTarget.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "Replace with :";
            // 
            // Findform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 173);
            this.Controls.Add(this.findReplaceTarget);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.findReplace);
            this.Controls.Add(this.findCount);
            this.Controls.Add(this.findNext);
            this.Controls.Add(this.findTarget);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.findClose);
            this.Name = "Findform";
            this.Text = "Find";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button findClose;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel findStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox findTarget;
        private System.Windows.Forms.Button findNext;
        private System.Windows.Forms.Button findCount;
        private System.Windows.Forms.Button findReplace;
        private System.Windows.Forms.TextBox findReplaceTarget;
        private System.Windows.Forms.Label label2;
    }
}