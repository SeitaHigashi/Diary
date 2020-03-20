namespace Diary
{
    partial class Diary
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.timeTable = new System.Windows.Forms.CheckedListBox();
            this.classTime = new System.Windows.Forms.ComboBox();
            this.todaysPlansLabel = new System.Windows.Forms.Label();
            this.todaysPlans = new System.Windows.Forms.TextBox();
            this.taskLabel = new System.Windows.Forms.Label();
            this.tomorrowsPlan = new System.Windows.Forms.TextBox();
            this.tomorrowsPlansLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDiaryMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newDiaryMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveButton = new System.Windows.Forms.Button();
            this.shutdownButton = new System.Windows.Forms.Button();
            this.performanceLabel = new System.Windows.Forms.Label();
            this.performance = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.customTimeLabel = new System.Windows.Forms.Label();
            this.Task = new System.Windows.Forms.TextBox();
            this.customTime = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customTime)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // timeTable
            // 
            this.timeTable.CheckOnClick = true;
            this.timeTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeTable.FormattingEnabled = true;
            this.timeTable.Items.AddRange(new object[] {
            "1限",
            "2限",
            "3限",
            "4限"});
            this.timeTable.Location = new System.Drawing.Point(3, 28);
            this.timeTable.Name = "timeTable";
            this.timeTable.Size = new System.Drawing.Size(220, 60);
            this.timeTable.TabIndex = 1;
            // 
            // classTime
            // 
            this.classTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.classTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.classTime.FormattingEnabled = true;
            this.classTime.Items.AddRange(new object[] {
            "通常授業",
            "80分授業",
            "その他"});
            this.classTime.Location = new System.Drawing.Point(3, 94);
            this.classTime.Name = "classTime";
            this.classTime.Size = new System.Drawing.Size(220, 20);
            this.classTime.TabIndex = 2;
            this.classTime.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // todaysPlansLabel
            // 
            this.todaysPlansLabel.AutoSize = true;
            this.todaysPlansLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.todaysPlansLabel.Location = new System.Drawing.Point(3, 154);
            this.todaysPlansLabel.Name = "todaysPlansLabel";
            this.todaysPlansLabel.Size = new System.Drawing.Size(220, 12);
            this.todaysPlansLabel.TabIndex = 9;
            this.todaysPlansLabel.Text = "予定";
            // 
            // todaysPlans
            // 
            this.todaysPlans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.todaysPlans.Location = new System.Drawing.Point(3, 169);
            this.todaysPlans.Name = "todaysPlans";
            this.todaysPlans.ReadOnly = true;
            this.todaysPlans.Size = new System.Drawing.Size(220, 19);
            this.todaysPlans.TabIndex = 6;
            this.todaysPlans.TabStop = false;
            // 
            // taskLabel
            // 
            this.taskLabel.AutoSize = true;
            this.taskLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taskLabel.Location = new System.Drawing.Point(3, 228);
            this.taskLabel.Name = "taskLabel";
            this.taskLabel.Size = new System.Drawing.Size(220, 12);
            this.taskLabel.TabIndex = 5;
            this.taskLabel.Text = "課題";
            // 
            // tomorrowsPlan
            // 
            this.tomorrowsPlan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tomorrowsPlan.Location = new System.Drawing.Point(3, 280);
            this.tomorrowsPlan.Name = "tomorrowsPlan";
            this.tomorrowsPlan.Size = new System.Drawing.Size(220, 19);
            this.tomorrowsPlan.TabIndex = 4;
            // 
            // tomorrowsPlansLabel
            // 
            this.tomorrowsPlansLabel.AutoSize = true;
            this.tomorrowsPlansLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tomorrowsPlansLabel.Location = new System.Drawing.Point(3, 265);
            this.tomorrowsPlansLabel.Name = "tomorrowsPlansLabel";
            this.tomorrowsPlansLabel.Size = new System.Drawing.Size(220, 12);
            this.tomorrowsPlansLabel.TabIndex = 7;
            this.tomorrowsPlansLabel.Text = "次回の予定";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(226, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openDiaryMenuItem,
            this.newDiaryMenuItem,
            this.exitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.FileToolStripMenuItem.Text = "ファイル";
            // 
            // openDiaryMenuItem
            // 
            this.openDiaryMenuItem.Name = "openDiaryMenuItem";
            this.openDiaryMenuItem.Size = new System.Drawing.Size(183, 22);
            this.openDiaryMenuItem.Text = "日誌を開く";
            // 
            // newDiaryMenuItem
            // 
            this.newDiaryMenuItem.Name = "newDiaryMenuItem";
            this.newDiaryMenuItem.Size = new System.Drawing.Size(183, 22);
            this.newDiaryMenuItem.Text = "日誌を新規に作成する";
            this.newDiaryMenuItem.Click += new System.EventHandler(this.newDiaryMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.exitToolStripMenuItem.Text = "閉じる";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.閉じるToolStripMenuItem_Click);
            // 
            // saveButton
            // 
            this.saveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saveButton.Location = new System.Drawing.Point(3, 3);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(107, 24);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "保存";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // shutdownButton
            // 
            this.shutdownButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shutdownButton.Location = new System.Drawing.Point(116, 3);
            this.shutdownButton.Name = "shutdownButton";
            this.shutdownButton.Size = new System.Drawing.Size(107, 24);
            this.shutdownButton.TabIndex = 1;
            this.shutdownButton.Text = "保存&&シャットダウン";
            this.shutdownButton.UseVisualStyleBackColor = true;
            // 
            // performanceLabel
            // 
            this.performanceLabel.AutoSize = true;
            this.performanceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.performanceLabel.Location = new System.Drawing.Point(3, 191);
            this.performanceLabel.Name = "performanceLabel";
            this.performanceLabel.Size = new System.Drawing.Size(220, 12);
            this.performanceLabel.TabIndex = 12;
            this.performanceLabel.Text = "実績";
            // 
            // performance
            // 
            this.performance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.performance.Location = new System.Drawing.Point(3, 206);
            this.performance.Name = "performance";
            this.performance.Size = new System.Drawing.Size(220, 19);
            this.performance.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.date, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.timeTable, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.classTime, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.customTimeLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.todaysPlans, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.tomorrowsPlan, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.todaysPlansLabel, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.performanceLabel, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.performance, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.taskLabel, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.Task, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.tomorrowsPlansLabel, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.customTime, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 13;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(226, 494);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // date
            // 
            this.date.Dock = System.Windows.Forms.DockStyle.Fill;
            this.date.Location = new System.Drawing.Point(3, 3);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(220, 19);
            this.date.TabIndex = 0;
            // 
            // customTimeLabel
            // 
            this.customTimeLabel.AutoSize = true;
            this.customTimeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customTimeLabel.Location = new System.Drawing.Point(3, 117);
            this.customTimeLabel.Name = "customTimeLabel";
            this.customTimeLabel.Size = new System.Drawing.Size(220, 12);
            this.customTimeLabel.TabIndex = 13;
            this.customTimeLabel.Text = "カスタム時間 (分)";
            // 
            // Task
            // 
            this.Task.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Task.Location = new System.Drawing.Point(3, 243);
            this.Task.Name = "Task";
            this.Task.Size = new System.Drawing.Size(220, 19);
            this.Task.TabIndex = 5;
            // 
            // customTime
            // 
            this.customTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customTime.Enabled = false;
            this.customTime.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.customTime.Location = new System.Drawing.Point(3, 132);
            this.customTime.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.customTime.Name = "customTime";
            this.customTime.Size = new System.Drawing.Size(220, 19);
            this.customTime.TabIndex = 14;
            this.customTime.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.saveButton, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.shutdownButton, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 488);
            this.tableLayoutPanel3.MaximumSize = new System.Drawing.Size(0, 30);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(226, 30);
            this.tableLayoutPanel3.TabIndex = 16;
            // 
            // Diary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(226, 518);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(242, 39);
            this.Name = "Diary";
            this.Text = "Diary";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customTime)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckedListBox timeTable;
        private System.Windows.Forms.ComboBox classTime;
        private System.Windows.Forms.Label todaysPlansLabel;
        private System.Windows.Forms.TextBox todaysPlans;
        private System.Windows.Forms.Label taskLabel;
        private System.Windows.Forms.TextBox tomorrowsPlan;
        private System.Windows.Forms.Label tomorrowsPlansLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openDiaryMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button shutdownButton;
        private System.Windows.Forms.Label performanceLabel;
        private System.Windows.Forms.TextBox performance;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label customTimeLabel;
        private System.Windows.Forms.TextBox Task;
        private System.Windows.Forms.NumericUpDown customTime;
        private System.Windows.Forms.ToolStripMenuItem newDiaryMenuItem;
    }
}

