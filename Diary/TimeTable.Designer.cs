namespace Diary
{
    partial class TimeTable
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

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.timeTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.firstPeriodCheckBox = new System.Windows.Forms.CheckBox();
            this.secondPeriodCheckBox = new System.Windows.Forms.CheckBox();
            this.thirdPeriodCheckBox = new System.Windows.Forms.CheckBox();
            this.fourthPeriodCheckBox = new System.Windows.Forms.CheckBox();
            this.timeTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // timeTableLayoutPanel
            // 
            this.timeTableLayoutPanel.AutoSize = true;
            this.timeTableLayoutPanel.ColumnCount = 1;
            this.timeTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.timeTableLayoutPanel.Controls.Add(this.firstPeriodCheckBox, 0, 0);
            this.timeTableLayoutPanel.Controls.Add(this.secondPeriodCheckBox, 0, 1);
            this.timeTableLayoutPanel.Controls.Add(this.thirdPeriodCheckBox, 0, 2);
            this.timeTableLayoutPanel.Controls.Add(this.fourthPeriodCheckBox, 0, 3);
            this.timeTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.timeTableLayoutPanel.Name = "timeTableLayoutPanel";
            this.timeTableLayoutPanel.RowCount = 4;
            this.timeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.timeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.timeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.timeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.timeTableLayoutPanel.Size = new System.Drawing.Size(150, 93);
            this.timeTableLayoutPanel.TabIndex = 0;
            // 
            // firstPeriodCheckBox
            // 
            this.firstPeriodCheckBox.AutoSize = true;
            this.firstPeriodCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.firstPeriodCheckBox.Location = new System.Drawing.Point(3, 3);
            this.firstPeriodCheckBox.Name = "firstPeriodCheckBox";
            this.firstPeriodCheckBox.Size = new System.Drawing.Size(144, 16);
            this.firstPeriodCheckBox.TabIndex = 0;
            this.firstPeriodCheckBox.Text = "1限";
            this.firstPeriodCheckBox.UseVisualStyleBackColor = true;
            // 
            // secondPeriodCheckBox
            // 
            this.secondPeriodCheckBox.AutoSize = true;
            this.secondPeriodCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.secondPeriodCheckBox.Location = new System.Drawing.Point(3, 25);
            this.secondPeriodCheckBox.Name = "secondPeriodCheckBox";
            this.secondPeriodCheckBox.Size = new System.Drawing.Size(144, 16);
            this.secondPeriodCheckBox.TabIndex = 1;
            this.secondPeriodCheckBox.Text = "2限";
            this.secondPeriodCheckBox.UseVisualStyleBackColor = true;
            // 
            // thirdPeriodCheckBox
            // 
            this.thirdPeriodCheckBox.AutoSize = true;
            this.thirdPeriodCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thirdPeriodCheckBox.Location = new System.Drawing.Point(3, 47);
            this.thirdPeriodCheckBox.Name = "thirdPeriodCheckBox";
            this.thirdPeriodCheckBox.Size = new System.Drawing.Size(144, 16);
            this.thirdPeriodCheckBox.TabIndex = 2;
            this.thirdPeriodCheckBox.Text = "3限";
            this.thirdPeriodCheckBox.UseVisualStyleBackColor = true;
            // 
            // fourthPeriodCheckBox
            // 
            this.fourthPeriodCheckBox.AutoSize = true;
            this.fourthPeriodCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fourthPeriodCheckBox.Location = new System.Drawing.Point(3, 69);
            this.fourthPeriodCheckBox.Name = "fourthPeriodCheckBox";
            this.fourthPeriodCheckBox.Size = new System.Drawing.Size(144, 21);
            this.fourthPeriodCheckBox.TabIndex = 3;
            this.fourthPeriodCheckBox.Text = "4限";
            this.fourthPeriodCheckBox.UseVisualStyleBackColor = true;
            // 
            // TimeTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.timeTableLayoutPanel);
            this.Name = "TimeTable";
            this.Size = new System.Drawing.Size(150, 93);
            this.timeTableLayoutPanel.ResumeLayout(false);
            this.timeTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel timeTableLayoutPanel;
        private System.Windows.Forms.CheckBox firstPeriodCheckBox;
        private System.Windows.Forms.CheckBox secondPeriodCheckBox;
        private System.Windows.Forms.CheckBox thirdPeriodCheckBox;
        private System.Windows.Forms.CheckBox fourthPeriodCheckBox;
    }
}
