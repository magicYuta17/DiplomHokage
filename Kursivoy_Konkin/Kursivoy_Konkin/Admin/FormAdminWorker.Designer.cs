namespace Kursivoy_Konkin
{
    partial class FormAdminWorker
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdminWorker));
            this.dgvWorkers = new System.Windows.Forms.DataGridView();
            this.cmsWorker = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkers)).BeginInit();
            this.cmsWorker.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvWorkers
            // 
            this.dgvWorkers.AllowUserToAddRows = false;
            this.dgvWorkers.AllowUserToDeleteRows = false;
            this.dgvWorkers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvWorkers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvWorkers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvWorkers.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWorkers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvWorkers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorkers.EnableHeadersVisualStyles = false;
            this.dgvWorkers.Location = new System.Drawing.Point(13, 26);
            this.dgvWorkers.Name = "dgvWorkers";
            this.dgvWorkers.ReadOnly = true;
            this.dgvWorkers.RowHeadersVisible = false;
            this.dgvWorkers.RowHeadersWidth = 51;
            this.dgvWorkers.RowTemplate.Height = 24;
            this.dgvWorkers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWorkers.Size = new System.Drawing.Size(1322, 476);
            this.dgvWorkers.TabIndex = 0;
            // 
            // cmsWorker
            // 
            this.cmsWorker.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsWorker.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAdd,
            this.tsmiEdit,
            this.tsmiDelete});
            this.cmsWorker.Name = "contextMenuStrip1";
            this.cmsWorker.Size = new System.Drawing.Size(181, 76);
            // 
            // tsmiAdd
            // 
            this.tsmiAdd.Name = "tsmiAdd";
            this.tsmiAdd.Size = new System.Drawing.Size(180, 24);
            this.tsmiAdd.Text = "Добавить";
            this.tsmiAdd.Click += new System.EventHandler(this.tsmiAdd_Click_1);
            // 
            // tsmiEdit
            // 
            this.tsmiEdit.Name = "tsmiEdit";
            this.tsmiEdit.Size = new System.Drawing.Size(180, 24);
            this.tsmiEdit.Text = "Редактировать";
            this.tsmiEdit.Click += new System.EventHandler(this.tsmiEdit_Click_1);
            // 
            // tsmiDelete
            // 
            this.tsmiDelete.Name = "tsmiDelete";
            this.tsmiDelete.Size = new System.Drawing.Size(180, 24);
            this.tsmiDelete.Text = "Удалить";
            this.tsmiDelete.Click += new System.EventHandler(this.tsmiDelete_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.btnBack.Font = new System.Drawing.Font("Comic Sans MS", 20.25F);
            this.btnBack.Location = new System.Drawing.Point(13, 536);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(322, 85);
            this.btnBack.TabIndex = 28;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FormAdminWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1347, 634);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvWorkers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAdminWorker";
            this.Text = "Сотрудники - Админ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAdminWorker_FormClosing);
            this.Load += new System.EventHandler(this.FormAdminWorker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkers)).EndInit();
            this.cmsWorker.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvWorkers;
        private System.Windows.Forms.Button buttonAddWorker;
        private System.Windows.Forms.ContextMenuStrip cmsWorker;
        private System.Windows.Forms.ToolStripMenuItem tsmiAdd;
        private System.Windows.Forms.ToolStripMenuItem tsmiEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
        private System.Windows.Forms.Button btnBack;
    }
}