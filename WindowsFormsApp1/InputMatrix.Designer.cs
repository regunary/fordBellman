namespace WindowsFormsApp1
{
    partial class InputMatrix
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.fromInput = new System.Windows.Forms.Button();
            this.showMatrix = new System.Windows.Forms.DataGridView();
            this.randomMatrix = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.addMove = new System.Windows.Forms.Button();
            this.tbWeight = new System.Windows.Forms.TextBox();
            this.cbTailVertex = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tậpTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpMaTrậnTừTệpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lưuMaTrậnRaTệpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbHeadVertex = new System.Windows.Forms.ComboBox();
            this.printLine = new System.Windows.Forms.Button();
            this.tbInputVertices = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.showMatrix)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fromInput
            // 
            this.fromInput.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromInput.ForeColor = System.Drawing.SystemColors.Highlight;
            this.fromInput.Location = new System.Drawing.Point(12, 61);
            this.fromInput.Name = "fromInput";
            this.fromInput.Size = new System.Drawing.Size(93, 41);
            this.fromInput.TabIndex = 1;
            this.fromInput.Text = "Nhập số đỉnh";
            this.fromInput.UseVisualStyleBackColor = true;
            this.fromInput.Click += new System.EventHandler(this.fromInput_Click);
            // 
            // showMatrix
            // 
            this.showMatrix.AllowUserToAddRows = false;
            this.showMatrix.AllowUserToDeleteRows = false;
            this.showMatrix.AllowUserToOrderColumns = true;
            this.showMatrix.AllowUserToResizeColumns = false;
            this.showMatrix.AllowUserToResizeRows = false;
            this.showMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showMatrix.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.showMatrix.DefaultCellStyle = dataGridViewCellStyle1;
            this.showMatrix.Location = new System.Drawing.Point(174, 34);
            this.showMatrix.MultiSelect = false;
            this.showMatrix.Name = "showMatrix";
            this.showMatrix.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.showMatrix.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.showMatrix.RowHeadersVisible = false;
            this.showMatrix.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.showMatrix.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.showMatrix.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.showMatrix.Size = new System.Drawing.Size(426, 336);
            this.showMatrix.TabIndex = 12;
            this.showMatrix.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.showMatrix_CellClick);
            // 
            // randomMatrix
            // 
            this.randomMatrix.Enabled = false;
            this.randomMatrix.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randomMatrix.ForeColor = System.Drawing.SystemColors.Highlight;
            this.randomMatrix.Location = new System.Drawing.Point(12, 266);
            this.randomMatrix.Name = "randomMatrix";
            this.randomMatrix.Size = new System.Drawing.Size(153, 28);
            this.randomMatrix.TabIndex = 39;
            this.randomMatrix.Text = "Ma Trận Ngẫu Nhiên";
            this.randomMatrix.UseVisualStyleBackColor = true;
            this.randomMatrix.Click += new System.EventHandler(this.randomMatrix_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 38;
            this.label4.Text = "với trọng số là";
            // 
            // addMove
            // 
            this.addMove.Enabled = false;
            this.addMove.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMove.ForeColor = System.Drawing.SystemColors.Highlight;
            this.addMove.Location = new System.Drawing.Point(12, 120);
            this.addMove.Name = "addMove";
            this.addMove.Size = new System.Drawing.Size(153, 26);
            this.addMove.TabIndex = 35;
            this.addMove.Text = "Thêm";
            this.addMove.UseVisualStyleBackColor = true;
            this.addMove.Click += new System.EventHandler(this.addMove_Click);
            // 
            // tbWeight
            // 
            this.tbWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbWeight.Location = new System.Drawing.Point(117, 222);
            this.tbWeight.Multiline = true;
            this.tbWeight.Name = "tbWeight";
            this.tbWeight.Size = new System.Drawing.Size(48, 28);
            this.tbWeight.TabIndex = 34;
            // 
            // cbTailVertex
            // 
            this.cbTailVertex.Enabled = false;
            this.cbTailVertex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTailVertex.FormattingEnabled = true;
            this.cbTailVertex.Location = new System.Drawing.Point(117, 187);
            this.cbTailVertex.Name = "cbTailVertex";
            this.cbTailVertex.Size = new System.Drawing.Size(48, 28);
            this.cbTailVertex.TabIndex = 33;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tậpTinToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(612, 24);
            this.menuStrip1.TabIndex = 40;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tậpTinToolStripMenuItem
            // 
            this.tậpTinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhậpMaTrậnTừTệpToolStripMenuItem,
            this.lưuMaTrậnRaTệpToolStripMenuItem});
            this.tậpTinToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tậpTinToolStripMenuItem.Name = "tậpTinToolStripMenuItem";
            this.tậpTinToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.tậpTinToolStripMenuItem.Text = "Tập tin";
            // 
            // nhậpMaTrậnTừTệpToolStripMenuItem
            // 
            this.nhậpMaTrậnTừTệpToolStripMenuItem.Name = "nhậpMaTrậnTừTệpToolStripMenuItem";
            this.nhậpMaTrậnTừTệpToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.nhậpMaTrậnTừTệpToolStripMenuItem.Text = "Nhập ma trận từ tệp";
            this.nhậpMaTrậnTừTệpToolStripMenuItem.Click += new System.EventHandler(this.nhậpMaTrậnTừTệpToolStripMenuItem_Click);
            // 
            // lưuMaTrậnRaTệpToolStripMenuItem
            // 
            this.lưuMaTrậnRaTệpToolStripMenuItem.Name = "lưuMaTrậnRaTệpToolStripMenuItem";
            this.lưuMaTrậnRaTệpToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.lưuMaTrậnRaTệpToolStripMenuItem.Text = "Lưu ma trận ra tệp";
            this.lưuMaTrậnRaTệpToolStripMenuItem.Click += new System.EventHandler(this.lưuMaTrậnRaTệpToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 16);
            this.label1.TabIndex = 41;
            this.label1.Text = "Nhập ma trận thủ công";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 16);
            this.label5.TabIndex = 42;
            this.label5.Text = "đường đi từ đỉnh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 43;
            this.label2.Text = "đến đỉnh";
            // 
            // cbHeadVertex
            // 
            this.cbHeadVertex.Enabled = false;
            this.cbHeadVertex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHeadVertex.FormattingEnabled = true;
            this.cbHeadVertex.Location = new System.Drawing.Point(117, 153);
            this.cbHeadVertex.Name = "cbHeadVertex";
            this.cbHeadVertex.Size = new System.Drawing.Size(48, 28);
            this.cbHeadVertex.TabIndex = 44;
            // 
            // printLine
            // 
            this.printLine.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printLine.ForeColor = System.Drawing.SystemColors.Highlight;
            this.printLine.Location = new System.Drawing.Point(12, 308);
            this.printLine.Name = "printLine";
            this.printLine.Size = new System.Drawing.Size(153, 62);
            this.printLine.TabIndex = 46;
            this.printLine.Text = "Hoàn tất";
            this.printLine.UseVisualStyleBackColor = true;
            this.printLine.Click += new System.EventHandler(this.printLine_Click);
            // 
            // tbInputVertices
            // 
            this.tbInputVertices.Location = new System.Drawing.Point(111, 62);
            this.tbInputVertices.Multiline = true;
            this.tbInputVertices.Name = "tbInputVertices";
            this.tbInputVertices.Size = new System.Drawing.Size(54, 40);
            this.tbInputVertices.TabIndex = 47;
            this.tbInputVertices.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // InputMatrix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 382);
            this.Controls.Add(this.tbInputVertices);
            this.Controls.Add(this.printLine);
            this.Controls.Add(this.cbHeadVertex);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.randomMatrix);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addMove);
            this.Controls.Add(this.tbWeight);
            this.Controls.Add(this.cbTailVertex);
            this.Controls.Add(this.showMatrix);
            this.Controls.Add(this.fromInput);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "InputMatrix";
            this.Text = "nhapmatran";
            this.Load += new System.EventHandler(this.InputMatrix_Load);
            ((System.ComponentModel.ISupportInitialize)(this.showMatrix)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button fromInput;
        private System.Windows.Forms.DataGridView showMatrix;
        private System.Windows.Forms.Button randomMatrix;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addMove;
        private System.Windows.Forms.TextBox tbWeight;
        private System.Windows.Forms.ComboBox cbTailVertex;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbHeadVertex;
        private System.Windows.Forms.Button printLine;
        private System.Windows.Forms.TextBox tbInputVertices;
        private System.Windows.Forms.ToolStripMenuItem tậpTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhậpMaTrậnTừTệpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lưuMaTrậnRaTệpToolStripMenuItem;
    }
}