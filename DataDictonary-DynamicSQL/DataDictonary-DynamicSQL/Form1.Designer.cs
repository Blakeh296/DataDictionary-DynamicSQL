namespace DataDictonary_DynamicSQL
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
            this.cbDataBaseNames = new System.Windows.Forms.ComboBox();
            this.dgvTablesView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablesView)).BeginInit();
            this.SuspendLayout();
            // 
            // cbDataBaseNames
            // 
            this.cbDataBaseNames.FormattingEnabled = true;
            this.cbDataBaseNames.Location = new System.Drawing.Point(16, 15);
            this.cbDataBaseNames.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbDataBaseNames.Name = "cbDataBaseNames";
            this.cbDataBaseNames.Size = new System.Drawing.Size(160, 24);
            this.cbDataBaseNames.TabIndex = 0;
            this.cbDataBaseNames.SelectedIndexChanged += new System.EventHandler(this.cbDataBaseNames_SelectedIndexChanged);
            // 
            // dgvTablesView
            // 
            this.dgvTablesView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablesView.Location = new System.Drawing.Point(16, 46);
            this.dgvTablesView.Name = "dgvTablesView";
            this.dgvTablesView.Size = new System.Drawing.Size(294, 356);
            this.dgvTablesView.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 414);
            this.Controls.Add(this.dgvTablesView);
            this.Controls.Add(this.cbDataBaseNames);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablesView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbDataBaseNames;
        private System.Windows.Forms.DataGridView dgvTablesView;
    }
}

