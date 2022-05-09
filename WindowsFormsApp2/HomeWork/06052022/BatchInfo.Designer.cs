namespace WindowsFormsApp2.HomeWork._06052022
{
    partial class BatchInfo
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
            this.lblBatchId = new System.Windows.Forms.Label();
            this.lblBatchName = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblTrainerName = new System.Windows.Forms.Label();
            this.lblLoaction = new System.Windows.Forms.Label();
            this.txtBatchId = new System.Windows.Forms.TextBox();
            this.txtBatchName = new System.Windows.Forms.TextBox();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.txtEndDate = new System.Windows.Forms.TextBox();
            this.txtTrainerName = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.btnBinaryWrite = new System.Windows.Forms.Button();
            this.btnBinaryRead = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBatchId
            // 
            this.lblBatchId.AutoSize = true;
            this.lblBatchId.Location = new System.Drawing.Point(189, 29);
            this.lblBatchId.Name = "lblBatchId";
            this.lblBatchId.Size = new System.Drawing.Size(55, 16);
            this.lblBatchId.TabIndex = 0;
            this.lblBatchId.Text = "Batch Id";
            // 
            // lblBatchName
            // 
            this.lblBatchName.AutoSize = true;
            this.lblBatchName.Location = new System.Drawing.Point(189, 76);
            this.lblBatchName.Name = "lblBatchName";
            this.lblBatchName.Size = new System.Drawing.Size(81, 16);
            this.lblBatchName.TabIndex = 1;
            this.lblBatchName.Text = "Batch Name";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(189, 124);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(66, 16);
            this.lblStartDate.TabIndex = 2;
            this.lblStartDate.Text = "Start Date";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(189, 178);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(63, 16);
            this.lblEndDate.TabIndex = 3;
            this.lblEndDate.Text = "End Date";
            // 
            // lblTrainerName
            // 
            this.lblTrainerName.AutoSize = true;
            this.lblTrainerName.Location = new System.Drawing.Point(189, 232);
            this.lblTrainerName.Name = "lblTrainerName";
            this.lblTrainerName.Size = new System.Drawing.Size(90, 16);
            this.lblTrainerName.TabIndex = 4;
            this.lblTrainerName.Text = "Trainer Name";
            // 
            // lblLoaction
            // 
            this.lblLoaction.AutoSize = true;
            this.lblLoaction.Location = new System.Drawing.Point(189, 282);
            this.lblLoaction.Name = "lblLoaction";
            this.lblLoaction.Size = new System.Drawing.Size(58, 16);
            this.lblLoaction.TabIndex = 5;
            this.lblLoaction.Text = "Location";
            // 
            // txtBatchId
            // 
            this.txtBatchId.Location = new System.Drawing.Point(330, 26);
            this.txtBatchId.Name = "txtBatchId";
            this.txtBatchId.Size = new System.Drawing.Size(243, 22);
            this.txtBatchId.TabIndex = 6;
            // 
            // txtBatchName
            // 
            this.txtBatchName.Location = new System.Drawing.Point(330, 73);
            this.txtBatchName.Name = "txtBatchName";
            this.txtBatchName.Size = new System.Drawing.Size(243, 22);
            this.txtBatchName.TabIndex = 7;
            // 
            // txtStartDate
            // 
            this.txtStartDate.Location = new System.Drawing.Point(330, 121);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(243, 22);
            this.txtStartDate.TabIndex = 8;
            // 
            // txtEndDate
            // 
            this.txtEndDate.Location = new System.Drawing.Point(330, 175);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.Size = new System.Drawing.Size(243, 22);
            this.txtEndDate.TabIndex = 9;
            // 
            // txtTrainerName
            // 
            this.txtTrainerName.Location = new System.Drawing.Point(330, 232);
            this.txtTrainerName.Name = "txtTrainerName";
            this.txtTrainerName.Size = new System.Drawing.Size(243, 22);
            this.txtTrainerName.TabIndex = 10;
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(330, 279);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(243, 22);
            this.txtLocation.TabIndex = 11;
            // 
            // btnBinaryWrite
            // 
            this.btnBinaryWrite.Location = new System.Drawing.Point(158, 366);
            this.btnBinaryWrite.Name = "btnBinaryWrite";
            this.btnBinaryWrite.Size = new System.Drawing.Size(150, 40);
            this.btnBinaryWrite.TabIndex = 12;
            this.btnBinaryWrite.Text = "Binary Write";
            this.btnBinaryWrite.UseVisualStyleBackColor = true;
            this.btnBinaryWrite.Click += new System.EventHandler(this.btnBinaryWrite_Click);
            // 
            // btnBinaryRead
            // 
            this.btnBinaryRead.Location = new System.Drawing.Point(399, 366);
            this.btnBinaryRead.Name = "btnBinaryRead";
            this.btnBinaryRead.Size = new System.Drawing.Size(153, 40);
            this.btnBinaryRead.TabIndex = 13;
            this.btnBinaryRead.Text = "Binary Read";
            this.btnBinaryRead.UseVisualStyleBackColor = true;
            this.btnBinaryRead.Click += new System.EventHandler(this.btnBinaryRead_Click);
            // 
            // BatchInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBinaryRead);
            this.Controls.Add(this.btnBinaryWrite);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.txtTrainerName);
            this.Controls.Add(this.txtEndDate);
            this.Controls.Add(this.txtStartDate);
            this.Controls.Add(this.txtBatchName);
            this.Controls.Add(this.txtBatchId);
            this.Controls.Add(this.lblLoaction);
            this.Controls.Add(this.lblTrainerName);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblBatchName);
            this.Controls.Add(this.lblBatchId);
            this.Name = "BatchInfo";
            this.Text = "Batch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBatchId;
        private System.Windows.Forms.Label lblBatchName;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblTrainerName;
        private System.Windows.Forms.Label lblLoaction;
        private System.Windows.Forms.TextBox txtBatchId;
        private System.Windows.Forms.TextBox txtBatchName;
        private System.Windows.Forms.TextBox txtStartDate;
        private System.Windows.Forms.TextBox txtEndDate;
        private System.Windows.Forms.TextBox txtTrainerName;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Button btnBinaryWrite;
        private System.Windows.Forms.Button btnBinaryRead;
    }
}