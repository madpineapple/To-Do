namespace To_Do
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.titlePnl = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.addPnl = new System.Windows.Forms.Panel();
            this.addTask = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.checkBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.addTaskTxtBox = new System.Windows.Forms.TextBox();
            this.Month = new System.Windows.Forms.Label();
            this.Day = new System.Windows.Forms.Label();
            this.Year = new System.Windows.Forms.Label();
            this.datePnl = new System.Windows.Forms.Panel();
            this.titlePnl.SuspendLayout();
            this.addPnl.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.datePnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // titlePnl
            // 
            this.titlePnl.BackColor = System.Drawing.Color.Transparent;
            this.titlePnl.Controls.Add(this.Title);
            this.titlePnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePnl.Location = new System.Drawing.Point(426, 0);
            this.titlePnl.Name = "titlePnl";
            this.titlePnl.Size = new System.Drawing.Size(774, 100);
            this.titlePnl.TabIndex = 1;
            this.titlePnl.Paint += new System.Windows.Forms.PaintEventHandler(this.titlePnl_Paint);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Title.Font = new System.Drawing.Font("MV Boli", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(0, 0);
            this.Title.Name = "Title";
            this.Title.Padding = new System.Windows.Forms.Padding(170, 0, 0, 0);
            this.Title.Size = new System.Drawing.Size(633, 105);
            this.Title.TabIndex = 0;
            this.Title.Text = "To-Do List";
            // 
            // addPnl
            // 
            this.addPnl.BackColor = System.Drawing.Color.Black;
            this.addPnl.Controls.Add(this.addTask);
            this.addPnl.Controls.Add(this.addTaskTxtBox);
            this.addPnl.Location = new System.Drawing.Point(442, 242);
            this.addPnl.Name = "addPnl";
            this.addPnl.Size = new System.Drawing.Size(592, 40);
            this.addPnl.TabIndex = 2;
            this.addPnl.Paint += new System.Windows.Forms.PaintEventHandler(this.addPnl_Paint);
            // 
            // addTask
            // 
            this.addTask.BackColor = System.Drawing.Color.Lime;
            this.addTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTask.Location = new System.Drawing.Point(3, 3);
            this.addTask.Name = "addTask";
            this.addTask.Size = new System.Drawing.Size(197, 30);
            this.addTask.TabIndex = 2;
            this.addTask.Text = "Add Task +";
            this.addTask.UseVisualStyleBackColor = false;
            this.addTask.Click += new System.EventHandler(this.addTask_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.Red;
            this.deleteBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.deleteBtn.Location = new System.Drawing.Point(442, 545);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(119, 35);
            this.deleteBtn.TabIndex = 4;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.datePnl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(426, 703);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Mistral", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Rage Italic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkBox});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(442, 300);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Parchment", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Mistral", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(592, 223);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // checkBox
            // 
            this.checkBox.HeaderText = "";
            this.checkBox.MinimumWidth = 6;
            this.checkBox.Name = "checkBox";
            this.checkBox.Width = 539;
            // 
            // addTaskTxtBox
            // 
            this.addTaskTxtBox.Location = new System.Drawing.Point(213, 3);
            this.addTaskTxtBox.Name = "addTaskTxtBox";
            this.addTaskTxtBox.Size = new System.Drawing.Size(376, 30);
            this.addTaskTxtBox.TabIndex = 1;
            this.addTaskTxtBox.TextChanged += new System.EventHandler(this.addTaskTxtBox_TextChanged);
            // 
            // Month
            // 
            this.Month.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Month.AutoSize = true;
            this.Month.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Month.Location = new System.Drawing.Point(31, 0);
            this.Month.Name = "Month";
            this.Month.Size = new System.Drawing.Size(138, 39);
            this.Month.TabIndex = 0;
            this.Month.Text = "January";
            this.Month.Click += new System.EventHandler(this.label1_Click);
            // 
            // Day
            // 
            this.Day.AutoSize = true;
            this.Day.Font = new System.Drawing.Font("Microsoft Sans Serif", 49.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Day.Location = new System.Drawing.Point(33, 39);
            this.Day.Name = "Day";
            this.Day.Size = new System.Drawing.Size(134, 95);
            this.Day.TabIndex = 1;
            this.Day.Text = "00";
            // 
            // Year
            // 
            this.Year.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Year.AutoSize = true;
            this.Year.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Year.Location = new System.Drawing.Point(52, 131);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(93, 39);
            this.Year.TabIndex = 2;
            this.Year.Text = "0000";
            // 
            // datePnl
            // 
            this.datePnl.Controls.Add(this.Month);
            this.datePnl.Controls.Add(this.Year);
            this.datePnl.Controls.Add(this.Day);
            this.datePnl.Location = new System.Drawing.Point(152, 300);
            this.datePnl.Name = "datePnl";
            this.datePnl.Size = new System.Drawing.Size(200, 185);
            this.datePnl.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::To_Do.Properties.Resources._2458748_1536x864__DesktopNexus_com_;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.addPnl);
            this.Controls.Add(this.titlePnl);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1200, 750);
            this.Name = "Form1";
            this.Text = "ToDo";
            this.titlePnl.ResumeLayout(false);
            this.titlePnl.PerformLayout();
            this.addPnl.ResumeLayout(false);
            this.addPnl.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.datePnl.ResumeLayout(false);
            this.datePnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel titlePnl;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel addPnl;
        private System.Windows.Forms.Button addTask;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkBox;
        private System.Windows.Forms.TextBox addTaskTxtBox;
        private System.Windows.Forms.Label Month;
        private System.Windows.Forms.Label Year;
        private System.Windows.Forms.Label Day;
        private System.Windows.Forms.Panel datePnl;
    }
}

