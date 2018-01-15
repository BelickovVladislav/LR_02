namespace VisualComponent
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
            this.dataGridViewColumn1 = new System.Windows.Forms.DataGridViewColumn();
            this.dataGridViewColumn2 = new System.Windows.Forms.DataGridViewColumn();
            this.dataGridViewColumn3 = new System.Windows.Forms.DataGridViewColumn();
            this.customGrid1 = new ComponentDll.CustomGrid();
            ((System.ComponentModel.ISupportInitialize)(this.customGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewColumn1
            // 
            this.dataGridViewColumn1.HeaderText = "Имя файла";
            this.dataGridViewColumn1.Name = "dataGridViewColumn1";
            this.dataGridViewColumn1.ReadOnly = true;
            // 
            // dataGridViewColumn2
            // 
            this.dataGridViewColumn2.HeaderText = "Размер";
            this.dataGridViewColumn2.Name = "dataGridViewColumn2";
            // 
            // dataGridViewColumn3
            // 
            this.dataGridViewColumn3.HeaderText = "Залупа кентавра";
            this.dataGridViewColumn3.Name = "dataGridViewColumn3";
            // 
            // customGrid1
            // 
            this.customGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customGrid1.Location = new System.Drawing.Point(1, 1);
            this.customGrid1.Name = "customGrid1";
            this.customGrid1.Size = new System.Drawing.Size(695, 349);
            this.customGrid1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 403);
            this.Controls.Add(this.customGrid1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewColumn dataGridViewColumn1;
        private System.Windows.Forms.DataGridViewColumn dataGridViewColumn2;
        private System.Windows.Forms.DataGridViewColumn dataGridViewColumn3;
        private ComponentDll.CustomGrid customGrid1;
    }
}

