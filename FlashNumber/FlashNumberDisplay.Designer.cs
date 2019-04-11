namespace FlashNumber
{
    partial class FlashNumberDisplay
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.scPanels = new System.Windows.Forms.SplitContainer();
            this.lblNumber = new System.Windows.Forms.Label();
            this.grpEndGame = new System.Windows.Forms.GroupBox();
            this.btnStartAgain = new System.Windows.Forms.Button();
            this.btnCheckAnswer = new System.Windows.Forms.Button();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripNoIoFAttempts = new System.Windows.Forms.ToolStripStatusLabel();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.btnStart = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scPanels)).BeginInit();
            this.scPanels.Panel1.SuspendLayout();
            this.scPanels.Panel2.SuspendLayout();
            this.scPanels.SuspendLayout();
            this.grpEndGame.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.639004F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.36099F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(427, 405);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Showing Numbers";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.scPanels);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 373);
            this.panel1.TabIndex = 1;
            // 
            // scPanels
            // 
            this.scPanels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scPanels.Location = new System.Drawing.Point(0, 0);
            this.scPanels.Name = "scPanels";
            // 
            // scPanels.Panel1
            // 
            this.scPanels.Panel1.Controls.Add(this.btnStart);
            this.scPanels.Panel1.Controls.Add(this.lblNumber);
            // 
            // scPanels.Panel2
            // 
            this.scPanels.Panel2.Controls.Add(this.grpEndGame);
            this.scPanels.Panel2Collapsed = true;
            this.scPanels.Size = new System.Drawing.Size(421, 373);
            this.scPanels.SplitterDistance = 202;
            this.scPanels.TabIndex = 4;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Bernard MT Condensed", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNumber.Location = new System.Drawing.Point(105, 96);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNumber.Size = new System.Drawing.Size(192, 114);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = "000";
            this.lblNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpEndGame
            // 
            this.grpEndGame.Controls.Add(this.btnStartAgain);
            this.grpEndGame.Controls.Add(this.btnCheckAnswer);
            this.grpEndGame.Controls.Add(this.txtAnswer);
            this.grpEndGame.Controls.Add(this.label2);
            this.grpEndGame.Location = new System.Drawing.Point(7, 14);
            this.grpEndGame.Name = "grpEndGame";
            this.grpEndGame.Size = new System.Drawing.Size(403, 179);
            this.grpEndGame.TabIndex = 4;
            this.grpEndGame.TabStop = false;
            this.grpEndGame.Visible = false;
            // 
            // btnStartAgain
            // 
            this.btnStartAgain.Font = new System.Drawing.Font("Oswald", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartAgain.Location = new System.Drawing.Point(111, 141);
            this.btnStartAgain.Name = "btnStartAgain";
            this.btnStartAgain.Size = new System.Drawing.Size(191, 32);
            this.btnStartAgain.TabIndex = 6;
            this.btnStartAgain.Text = "Start Again";
            this.btnStartAgain.UseVisualStyleBackColor = true;
            this.btnStartAgain.Click += btnStartAgain_Click;
            // 
            // btnCheckAnswer
            // 
            this.btnCheckAnswer.Font = new System.Drawing.Font("Oswald", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckAnswer.Location = new System.Drawing.Point(111, 76);
            this.btnCheckAnswer.Name = "btnCheckAnswer";
            this.btnCheckAnswer.Size = new System.Drawing.Size(191, 32);
            this.btnCheckAnswer.TabIndex = 5;
            this.btnCheckAnswer.Text = "Check Answer";
            this.btnCheckAnswer.UseVisualStyleBackColor = true;
            this.btnCheckAnswer.Click += btnCheckAnswer_Click;
            // 
            // txtAnswer
            // 
            this.txtAnswer.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer.Location = new System.Drawing.Point(111, 39);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(191, 31);
            this.txtAnswer.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Oswald", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(140, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter your Answer";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripNoIoFAttempts});
            this.statusStrip1.Location = new System.Drawing.Point(0, 383);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(427, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripNoIoFAttempts
            // 
            this.toolStripNoIoFAttempts.Name = "toolStripNoIoFAttempts";
            this.toolStripNoIoFAttempts.Size = new System.Drawing.Size(13, 17);
            this.toolStripNoIoFAttempts.Text = "0";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnStart.Location = new System.Drawing.Point(124, 14);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(143, 31);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start Game";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // FlashNumberDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 405);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FlashNumberDisplay";
            this.Text = "FlashNumberDisplay";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.scPanels.Panel1.ResumeLayout(false);
            this.scPanels.Panel1.PerformLayout();
            this.scPanels.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scPanels)).EndInit();
            this.scPanels.ResumeLayout(false);
            this.grpEndGame.ResumeLayout(false);
            this.grpEndGame.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripNoIoFAttempts;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.SplitContainer scPanels;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.GroupBox grpEndGame;
        private System.Windows.Forms.Button btnStartAgain;
        private System.Windows.Forms.Button btnCheckAnswer;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStart;
    }
}