namespace WindowsFormsApp1
{
    partial class DrawMatrix
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
            this.groupAll = new System.Windows.Forms.Panel();
            this.dShowMatrix = new System.Windows.Forms.DataGridView();
            this.start = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDHeadVertex = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbDTailVertex = new System.Windows.Forms.ComboBox();
            this.lbName = new System.Windows.Forms.Label();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.logShow = new System.Windows.Forms.Label();
            this.printPicture = new System.Windows.Forms.PictureBox();
            this.groupAll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dShowMatrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // groupAll
            // 
            this.groupAll.Controls.Add(this.dShowMatrix);
            this.groupAll.Controls.Add(this.start);
            this.groupAll.Controls.Add(this.label3);
            this.groupAll.Controls.Add(this.cbDHeadVertex);
            this.groupAll.Controls.Add(this.label5);
            this.groupAll.Controls.Add(this.cbDTailVertex);
            this.groupAll.Controls.Add(this.lbName);
            this.groupAll.Location = new System.Drawing.Point(567, 12);
            this.groupAll.Name = "groupAll";
            this.groupAll.Size = new System.Drawing.Size(227, 312);
            this.groupAll.TabIndex = 2;
            // 
            // dShowMatrix
            // 
            this.dShowMatrix.AllowUserToAddRows = false;
            this.dShowMatrix.AllowUserToDeleteRows = false;
            this.dShowMatrix.AllowUserToOrderColumns = true;
            this.dShowMatrix.AllowUserToResizeColumns = false;
            this.dShowMatrix.AllowUserToResizeRows = false;
            this.dShowMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dShowMatrix.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dShowMatrix.DefaultCellStyle = dataGridViewCellStyle1;
            this.dShowMatrix.Location = new System.Drawing.Point(3, 121);
            this.dShowMatrix.MultiSelect = false;
            this.dShowMatrix.Name = "dShowMatrix";
            this.dShowMatrix.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dShowMatrix.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dShowMatrix.RowHeadersVisible = false;
            this.dShowMatrix.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.dShowMatrix.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dShowMatrix.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dShowMatrix.Size = new System.Drawing.Size(221, 188);
            this.dShowMatrix.TabIndex = 51;
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.Location = new System.Drawing.Point(6, 86);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(213, 29);
            this.start.TabIndex = 50;
            this.start.Text = "Bắt đầu";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(108, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 49;
            this.label3.Text = "đến đỉnh";
            // 
            // cbDHeadVertex
            // 
            this.cbDHeadVertex.Enabled = false;
            this.cbDHeadVertex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDHeadVertex.FormattingEnabled = true;
            this.cbDHeadVertex.Location = new System.Drawing.Point(57, 47);
            this.cbDHeadVertex.Name = "cbDHeadVertex";
            this.cbDHeadVertex.Size = new System.Drawing.Size(48, 28);
            this.cbDHeadVertex.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 46;
            this.label5.Text = "từ đỉnh";
            // 
            // cbDTailVertex
            // 
            this.cbDTailVertex.Enabled = false;
            this.cbDTailVertex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDTailVertex.FormattingEnabled = true;
            this.cbDTailVertex.Location = new System.Drawing.Point(171, 47);
            this.cbDTailVertex.Name = "cbDTailVertex";
            this.cbDTailVertex.Size = new System.Drawing.Size(48, 28);
            this.cbDTailVertex.TabIndex = 45;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbName.Location = new System.Drawing.Point(6, 12);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(159, 32);
            this.lbName.TabIndex = 42;
            this.lbName.Text = "Tìm đường đi ngắn nhất\r\nbằng Bellman - Ford";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rtbLog
            // 
            this.rtbLog.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbLog.Location = new System.Drawing.Point(569, 346);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.Size = new System.Drawing.Size(227, 198);
            this.rtbLog.TabIndex = 51;
            this.rtbLog.Text = "";
            // 
            // logShow
            // 
            this.logShow.AutoSize = true;
            this.logShow.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logShow.Location = new System.Drawing.Point(569, 327);
            this.logShow.Name = "logShow";
            this.logShow.Size = new System.Drawing.Size(31, 16);
            this.logShow.TabIndex = 52;
            this.logShow.Text = "Log";
            // 
            // printPicture
            // 
            this.printPicture.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.printPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.printPicture.Location = new System.Drawing.Point(12, 12);
            this.printPicture.Name = "printPicture";
            this.printPicture.Size = new System.Drawing.Size(551, 532);
            this.printPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.printPicture.TabIndex = 54;
            this.printPicture.TabStop = false;
            this.printPicture.MouseClick += new System.Windows.Forms.MouseEventHandler(this.printPicture_MouseClick);
            this.printPicture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.printPicture_MouseMove);
            // 
            // DrawMatrix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 556);
            this.Controls.Add(this.printPicture);
            this.Controls.Add(this.logShow);
            this.Controls.Add(this.groupAll);
            this.Controls.Add(this.rtbLog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DrawMatrix";
            this.Text = "DrawMatrix";
            this.Load += new System.EventHandler(this.DrawMatrix_Load);
            this.groupAll.ResumeLayout(false);
            this.groupAll.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dShowMatrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel groupAll;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label logShow;
        private System.Windows.Forms.DataGridView dShowMatrix;
        public System.Windows.Forms.PictureBox printPicture;
        public System.Windows.Forms.ComboBox cbDHeadVertex;
        public System.Windows.Forms.ComboBox cbDTailVertex;
        public System.Windows.Forms.RichTextBox rtbLog;
    }
}