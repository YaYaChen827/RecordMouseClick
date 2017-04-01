namespace RecordMouseClick
{
    partial class mainform
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.open = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.record = new System.Windows.Forms.Button();
            this.play = new System.Windows.Forms.Button();
            this.recordTimer = new System.Windows.Forms.Timer(this.components);
            this.playTimer = new System.Windows.Forms.Timer(this.components);
            this.dgvCursor = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursor)).BeginInit();
            this.SuspendLayout();
            // 
            // open
            // 
            this.open.Location = new System.Drawing.Point(12, 71);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(75, 23);
            this.open.TabIndex = 0;
            this.open.Text = "open";
            this.open.UseVisualStyleBackColor = true;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(12, 42);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 1;
            this.save.Text = "save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // record
            // 
            this.record.Location = new System.Drawing.Point(12, 12);
            this.record.Name = "record";
            this.record.Size = new System.Drawing.Size(75, 23);
            this.record.TabIndex = 2;
            this.record.Text = "record";
            this.record.UseVisualStyleBackColor = true;
            this.record.Click += new System.EventHandler(this.record_Click);
            // 
            // play
            // 
            this.play.Location = new System.Drawing.Point(12, 102);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(75, 23);
            this.play.TabIndex = 3;
            this.play.Text = "play";
            this.play.UseVisualStyleBackColor = true;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // recordTimer
            // 
            this.recordTimer.Tick += new System.EventHandler(this.recordTimer_Tick);
            // 
            // playTimer
            // 
            this.playTimer.Tick += new System.EventHandler(this.playTimer_Tick);
            // 
            // dgvCursor
            // 
            this.dgvCursor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCursor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y});
            this.dgvCursor.Location = new System.Drawing.Point(102, 12);
            this.dgvCursor.Name = "dgvCursor";
            this.dgvCursor.RowTemplate.Height = 27;
            this.dgvCursor.Size = new System.Drawing.Size(268, 231);
            this.dgvCursor.TabIndex = 5;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.Name = "X";
            // 
            // Y
            // 
            this.Y.HeaderText = "Y";
            this.Y.Name = "Y";
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 251);
            this.Controls.Add(this.dgvCursor);
            this.Controls.Add(this.play);
            this.Controls.Add(this.record);
            this.Controls.Add(this.save);
            this.Controls.Add(this.open);
            this.Name = "mainform";
            this.Text = "Kunman Calling";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button open;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button record;
        private System.Windows.Forms.Button play;
        private System.Windows.Forms.Timer recordTimer;
        private System.Windows.Forms.Timer playTimer;
        private System.Windows.Forms.DataGridView dgvCursor;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
    }
}

