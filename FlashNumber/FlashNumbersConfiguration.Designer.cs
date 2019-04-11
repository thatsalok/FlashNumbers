namespace FlashNumber
{
    partial class FlashNumbersConfiguration
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
            this.lblDisplayText = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNumberOfTime = new System.Windows.Forms.NumericUpDown();
            this.txtInterval = new System.Windows.Forms.NumericUpDown();
            this.txtNumberOfDigit = new System.Windows.Forms.NumericUpDown();
            this.btnStart = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumberOfTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumberOfDigit)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblDisplayText, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.27778F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.72222F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(384, 209);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblDisplayText
            // 
            this.lblDisplayText.AutoSize = true;
            this.lblDisplayText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDisplayText.Font = new System.Drawing.Font("Oswald", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayText.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblDisplayText.Location = new System.Drawing.Point(3, 0);
            this.lblDisplayText.Name = "lblDisplayText";
            this.lblDisplayText.Size = new System.Drawing.Size(378, 31);
            this.lblDisplayText.TabIndex = 0;
            this.lblDisplayText.Text = "DisplayText";
            this.lblDisplayText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtNumberOfTime);
            this.panel1.Controls.Add(this.txtInterval);
            this.panel1.Controls.Add(this.txtNumberOfDigit);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 34);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.panel1.Size = new System.Drawing.Size(378, 172);
            this.panel1.TabIndex = 1;
            // 
            // txtNumberOfSum
            // 
            this.txtNumberOfTime.Font = new System.Drawing.Font("Oswald", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberOfTime.Location = new System.Drawing.Point(111, 38);
            this.txtNumberOfTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtNumberOfTime.Name = "txtNumberOfTime";
            this.txtNumberOfTime.Size = new System.Drawing.Size(236, 27);
            this.txtNumberOfTime.TabIndex = 9;
            this.txtNumberOfTime.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // txtInterval
            // 
            this.txtInterval.Font = new System.Drawing.Font("Oswald", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInterval.Location = new System.Drawing.Point(111, 67);
            this.txtInterval.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.Size = new System.Drawing.Size(236, 27);
            this.txtInterval.TabIndex = 8;
            this.txtInterval.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtNumberOfDigit
            // 
            this.txtNumberOfDigit.Font = new System.Drawing.Font("Oswald", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberOfDigit.Location = new System.Drawing.Point(111, 9);
            this.txtNumberOfDigit.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtNumberOfDigit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtNumberOfDigit.Name = "txtNumberOfDigit";
            this.txtNumberOfDigit.Size = new System.Drawing.Size(236, 27);
            this.txtNumberOfDigit.TabIndex = 7;
            this.txtNumberOfDigit.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnStart.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnStart.Location = new System.Drawing.Point(114, 109);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(161, 48);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Oswald", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Time In Second";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Oswald", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number Of Sum";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Oswald", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number Of Digits";
            
            // 
            // FlashNumbersConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 209);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FlashNumbersConfiguration";
            this.Text = "Configuration";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumberOfTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumberOfDigit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblDisplayText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txtNumberOfTime;
        private System.Windows.Forms.NumericUpDown txtInterval;
        private System.Windows.Forms.NumericUpDown txtNumberOfDigit;
    }
}