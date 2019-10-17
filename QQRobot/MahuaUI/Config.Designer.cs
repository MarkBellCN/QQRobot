namespace QQRobot.MahuaUI
{
    partial class Config
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.addConfig = new System.Windows.Forms.Button();
            this.configBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.群号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.开始时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.结束时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.监听长度 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.回复内容 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.configBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.群号,
            this.开始时间,
            this.结束时间,
            this.监听长度,
            this.回复内容,
            this.edit,
            this.delete});
            this.dataGridView.Location = new System.Drawing.Point(12, 53);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.Size = new System.Drawing.Size(812, 385);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // addConfig
            // 
            this.addConfig.Location = new System.Drawing.Point(749, 24);
            this.addConfig.Name = "addConfig";
            this.addConfig.Size = new System.Drawing.Size(75, 23);
            this.addConfig.TabIndex = 1;
            this.addConfig.Text = "添加配置";
            this.addConfig.UseVisualStyleBackColor = true;
            this.addConfig.Click += new System.EventHandler(this.addConfig_Click);
            // 
            // configBindingSource
            // 
            this.configBindingSource.DataSource = typeof(QQRobot.MahuaUI.Config);
            // 
            // 群号
            // 
            this.群号.DataPropertyName = "groupId";
            this.群号.Frozen = true;
            this.群号.HeaderText = "群号";
            this.群号.Name = "群号";
            this.群号.ReadOnly = true;
            this.群号.Width = 150;
            // 
            // 开始时间
            // 
            this.开始时间.DataPropertyName = "startTime";
            this.开始时间.Frozen = true;
            this.开始时间.HeaderText = "开始时间";
            this.开始时间.MinimumWidth = 10;
            this.开始时间.Name = "开始时间";
            this.开始时间.ReadOnly = true;
            this.开始时间.Width = 150;
            // 
            // 结束时间
            // 
            this.结束时间.DataPropertyName = "endTime";
            this.结束时间.Frozen = true;
            this.结束时间.HeaderText = "结束时间";
            this.结束时间.Name = "结束时间";
            this.结束时间.ReadOnly = true;
            this.结束时间.Width = 150;
            // 
            // 监听长度
            // 
            this.监听长度.DataPropertyName = "msgLen";
            this.监听长度.Frozen = true;
            this.监听长度.HeaderText = "监听长度";
            this.监听长度.Name = "监听长度";
            this.监听长度.ReadOnly = true;
            this.监听长度.Width = 80;
            // 
            // 回复内容
            // 
            this.回复内容.DataPropertyName = "replyContent";
            this.回复内容.FillWeight = 200F;
            this.回复内容.Frozen = true;
            this.回复内容.HeaderText = "回复内容";
            this.回复内容.Name = "回复内容";
            this.回复内容.ReadOnly = true;
            // 
            // edit
            // 
            this.edit.Frozen = true;
            this.edit.HeaderText = "编辑";
            this.edit.Name = "edit";
            this.edit.ReadOnly = true;
            this.edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.edit.Text = "编辑";
            this.edit.UseColumnTextForButtonValue = true;
            this.edit.Width = 70;
            // 
            // delete
            // 
            this.delete.Frozen = true;
            this.delete.HeaderText = "删除";
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.delete.Text = "删除";
            this.delete.UseColumnTextForButtonValue = true;
            this.delete.Width = 70;
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 450);
            this.Controls.Add(this.addConfig);
            this.Controls.Add(this.dataGridView);
            this.Name = "Config";
            this.Text = "配置列表";
            this.Load += new System.EventHandler(this.Config_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.configBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button addConfig;
        private System.Windows.Forms.BindingSource configBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn 群号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 开始时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn 结束时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn 监听长度;
        private System.Windows.Forms.DataGridViewTextBoxColumn 回复内容;
        private System.Windows.Forms.DataGridViewButtonColumn edit;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
    }
}