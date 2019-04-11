namespace FlashNumber
{
    partial class FlashNumberApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlashNumberApp));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddition = new System.Windows.Forms.Button();
            this.btnAddSub = new System.Windows.Forms.Button();
            this.btnDecimalAddSub = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnLongMultiply = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.lblFlashNbrs = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(448, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(82, 20);
            this.toolStripMenuItem1.Text = "Information";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblFlashNbrs, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.344828F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.65517F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(448, 630);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnAddition);
            this.flowLayoutPanel1.Controls.Add(this.btnAddSub);
            this.flowLayoutPanel1.Controls.Add(this.btnDecimalAddSub);
            this.flowLayoutPanel1.Controls.Add(this.btnMultiply);
            this.flowLayoutPanel1.Controls.Add(this.btnLongMultiply);
            this.flowLayoutPanel1.Controls.Add(this.btnDivision);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 36);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(442, 591);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnAddition
            // 
            this.btnAddition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddition.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnAddition.Image = global::FlashNumber.Properties.Resources.addition1;
            this.btnAddition.Location = new System.Drawing.Point(8, 8);
            this.btnAddition.Name = "btnAddition";
            this.btnAddition.Size = new System.Drawing.Size(210, 136);
            this.btnAddition.TabIndex = 0;
            this.btnAddition.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddition.UseVisualStyleBackColor = true;
            this.btnAddition.Click += new System.EventHandler(this.btnAddition_Click);
            // 
            // btnAddSub
            // 
            this.btnAddSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSub.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnAddSub.Image = global::FlashNumber.Properties.Resources.addsub;
            this.btnAddSub.Location = new System.Drawing.Point(224, 8);
            this.btnAddSub.Name = "btnAddSub";
            this.btnAddSub.Size = new System.Drawing.Size(210, 136);
            this.btnAddSub.TabIndex = 1;
            this.btnAddSub.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddSub.UseVisualStyleBackColor = true;
            this.btnAddSub.Click += new System.EventHandler(this.btnAddSub_Click);
            // 
            // btnDecimalAddSub
            // 
            this.btnDecimalAddSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecimalAddSub.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnDecimalAddSub.Image = ((System.Drawing.Image)(resources.GetObject("btnDecimalAddSub.Image")));
            this.btnDecimalAddSub.Location = new System.Drawing.Point(8, 150);
            this.btnDecimalAddSub.Name = "btnDecimalAddSub";
            this.btnDecimalAddSub.Size = new System.Drawing.Size(210, 136);
            this.btnDecimalAddSub.TabIndex = 2;
            this.btnDecimalAddSub.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDecimalAddSub.UseVisualStyleBackColor = true;
            this.btnDecimalAddSub.Click += new System.EventHandler(this.btnDecimalAddSub_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiply.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnMultiply.Image = global::FlashNumber.Properties.Resources.multiply;
            this.btnMultiply.Location = new System.Drawing.Point(224, 150);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(210, 136);
            this.btnMultiply.TabIndex = 3;
            this.btnMultiply.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnLongMultiply
            // 
            this.btnLongMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLongMultiply.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLongMultiply.Image = global::FlashNumber.Properties.Resources.multiply;
            this.btnLongMultiply.Location = new System.Drawing.Point(8, 292);
            this.btnLongMultiply.Name = "btnLongMultiply";
            this.btnLongMultiply.Size = new System.Drawing.Size(210, 136);
            this.btnLongMultiply.TabIndex = 4;
            this.btnLongMultiply.Text = "Long";
            this.btnLongMultiply.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLongMultiply.UseVisualStyleBackColor = true;
            this.btnLongMultiply.Click += new System.EventHandler(this.btnLongMultiply_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivision.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDivision.Image = ((System.Drawing.Image)(resources.GetObject("btnDivision.Image")));
            this.btnDivision.Location = new System.Drawing.Point(224, 292);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(210, 136);
            this.btnDivision.TabIndex = 5;
            this.btnDivision.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // lblFlashNbrs
            // 
            this.lblFlashNbrs.AutoSize = true;
            this.lblFlashNbrs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFlashNbrs.Font = new System.Drawing.Font("Oswald", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlashNbrs.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblFlashNbrs.Location = new System.Drawing.Point(3, 0);
            this.lblFlashNbrs.Name = "lblFlashNbrs";
            this.lblFlashNbrs.Size = new System.Drawing.Size(442, 33);
            this.lblFlashNbrs.TabIndex = 1;
            this.lblFlashNbrs.Text = "Flash Numbers";
            this.lblFlashNbrs.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FlashNumberApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(448, 654);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FlashNumberApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flash Numbers";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnAddition;
        private System.Windows.Forms.Button btnAddSub;
        private System.Windows.Forms.Label lblFlashNbrs;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btnDecimalAddSub;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnLongMultiply;
        private System.Windows.Forms.Button btnDivision;
    }
}

