namespace Puzzle_Game_2._0
{
    partial class Highscore
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puzzle1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puzzle2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puzzle3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puzzle4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puzzle5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puzzle6DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.highscoreeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.puzzleDataSet = new Puzzle_Game_2._0.puzzleDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.usernameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puzzle1DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puzzle2DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puzzle3DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puzzle4DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puzzle5DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puzzle6DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.highscoremBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.puzzleDataSet1 = new Puzzle_Game_2._0.puzzleDataSet1();
            this.highscore_eTableAdapter = new Puzzle_Game_2._0.puzzleDataSetTableAdapters.highscore_eTableAdapter();
            this.highscore_mTableAdapter = new Puzzle_Game_2._0.puzzleDataSet1TableAdapters.highscore_mTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.highscoreeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.puzzleDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.highscoremBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.puzzleDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(236, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "High Scores";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usernameDataGridViewTextBoxColumn,
            this.puzzle1DataGridViewTextBoxColumn,
            this.puzzle2DataGridViewTextBoxColumn,
            this.puzzle3DataGridViewTextBoxColumn,
            this.puzzle4DataGridViewTextBoxColumn,
            this.puzzle5DataGridViewTextBoxColumn,
            this.puzzle6DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.highscoreeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(693, 218);
            this.dataGridView1.TabIndex = 1;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // puzzle1DataGridViewTextBoxColumn
            // 
            this.puzzle1DataGridViewTextBoxColumn.DataPropertyName = "puzzle1";
            this.puzzle1DataGridViewTextBoxColumn.HeaderText = "puzzle1";
            this.puzzle1DataGridViewTextBoxColumn.Name = "puzzle1DataGridViewTextBoxColumn";
            // 
            // puzzle2DataGridViewTextBoxColumn
            // 
            this.puzzle2DataGridViewTextBoxColumn.DataPropertyName = "puzzle2";
            this.puzzle2DataGridViewTextBoxColumn.HeaderText = "puzzle2";
            this.puzzle2DataGridViewTextBoxColumn.Name = "puzzle2DataGridViewTextBoxColumn";
            // 
            // puzzle3DataGridViewTextBoxColumn
            // 
            this.puzzle3DataGridViewTextBoxColumn.DataPropertyName = "puzzle3";
            this.puzzle3DataGridViewTextBoxColumn.HeaderText = "puzzle3";
            this.puzzle3DataGridViewTextBoxColumn.Name = "puzzle3DataGridViewTextBoxColumn";
            // 
            // puzzle4DataGridViewTextBoxColumn
            // 
            this.puzzle4DataGridViewTextBoxColumn.DataPropertyName = "puzzle4";
            this.puzzle4DataGridViewTextBoxColumn.HeaderText = "puzzle4";
            this.puzzle4DataGridViewTextBoxColumn.Name = "puzzle4DataGridViewTextBoxColumn";
            // 
            // puzzle5DataGridViewTextBoxColumn
            // 
            this.puzzle5DataGridViewTextBoxColumn.DataPropertyName = "puzzle5";
            this.puzzle5DataGridViewTextBoxColumn.HeaderText = "puzzle5";
            this.puzzle5DataGridViewTextBoxColumn.Name = "puzzle5DataGridViewTextBoxColumn";
            // 
            // puzzle6DataGridViewTextBoxColumn
            // 
            this.puzzle6DataGridViewTextBoxColumn.DataPropertyName = "puzzle6";
            this.puzzle6DataGridViewTextBoxColumn.HeaderText = "puzzle6";
            this.puzzle6DataGridViewTextBoxColumn.Name = "puzzle6DataGridViewTextBoxColumn";
            // 
            // highscoreeBindingSource
            // 
            this.highscoreeBindingSource.DataMember = "highscore_e";
            this.highscoreeBindingSource.DataSource = this.puzzleDataSet;
            // 
            // puzzleDataSet
            // 
            this.puzzleDataSet.DataSetName = "puzzleDataSet";
            this.puzzleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "3*3 puzzle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "4*4 puzzle";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usernameDataGridViewTextBoxColumn1,
            this.puzzle1DataGridViewTextBoxColumn1,
            this.puzzle2DataGridViewTextBoxColumn1,
            this.puzzle3DataGridViewTextBoxColumn1,
            this.puzzle4DataGridViewTextBoxColumn1,
            this.puzzle5DataGridViewTextBoxColumn1,
            this.puzzle6DataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.highscoremBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 385);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(693, 218);
            this.dataGridView2.TabIndex = 4;
            // 
            // usernameDataGridViewTextBoxColumn1
            // 
            this.usernameDataGridViewTextBoxColumn1.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn1.HeaderText = "username";
            this.usernameDataGridViewTextBoxColumn1.Name = "usernameDataGridViewTextBoxColumn1";
            // 
            // puzzle1DataGridViewTextBoxColumn1
            // 
            this.puzzle1DataGridViewTextBoxColumn1.DataPropertyName = "puzzle1";
            this.puzzle1DataGridViewTextBoxColumn1.HeaderText = "puzzle1";
            this.puzzle1DataGridViewTextBoxColumn1.Name = "puzzle1DataGridViewTextBoxColumn1";
            // 
            // puzzle2DataGridViewTextBoxColumn1
            // 
            this.puzzle2DataGridViewTextBoxColumn1.DataPropertyName = "puzzle2";
            this.puzzle2DataGridViewTextBoxColumn1.HeaderText = "puzzle2";
            this.puzzle2DataGridViewTextBoxColumn1.Name = "puzzle2DataGridViewTextBoxColumn1";
            // 
            // puzzle3DataGridViewTextBoxColumn1
            // 
            this.puzzle3DataGridViewTextBoxColumn1.DataPropertyName = "puzzle3";
            this.puzzle3DataGridViewTextBoxColumn1.HeaderText = "puzzle3";
            this.puzzle3DataGridViewTextBoxColumn1.Name = "puzzle3DataGridViewTextBoxColumn1";
            // 
            // puzzle4DataGridViewTextBoxColumn1
            // 
            this.puzzle4DataGridViewTextBoxColumn1.DataPropertyName = "puzzle4";
            this.puzzle4DataGridViewTextBoxColumn1.HeaderText = "puzzle4";
            this.puzzle4DataGridViewTextBoxColumn1.Name = "puzzle4DataGridViewTextBoxColumn1";
            // 
            // puzzle5DataGridViewTextBoxColumn1
            // 
            this.puzzle5DataGridViewTextBoxColumn1.DataPropertyName = "puzzle5";
            this.puzzle5DataGridViewTextBoxColumn1.HeaderText = "puzzle5";
            this.puzzle5DataGridViewTextBoxColumn1.Name = "puzzle5DataGridViewTextBoxColumn1";
            // 
            // puzzle6DataGridViewTextBoxColumn1
            // 
            this.puzzle6DataGridViewTextBoxColumn1.DataPropertyName = "puzzle6";
            this.puzzle6DataGridViewTextBoxColumn1.HeaderText = "puzzle6";
            this.puzzle6DataGridViewTextBoxColumn1.Name = "puzzle6DataGridViewTextBoxColumn1";
            // 
            // highscoremBindingSource
            // 
            this.highscoremBindingSource.DataMember = "highscore_m";
            this.highscoremBindingSource.DataSource = this.puzzleDataSet1;
            // 
            // puzzleDataSet1
            // 
            this.puzzleDataSet1.DataSetName = "puzzleDataSet1";
            this.puzzleDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // highscore_eTableAdapter
            // 
            this.highscore_eTableAdapter.ClearBeforeFill = true;
            // 
            // highscore_mTableAdapter
            // 
            this.highscore_mTableAdapter.ClearBeforeFill = true;
            // 
            // Highscore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(717, 657);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Highscore";
            this.Text = "Highscore";
            this.Load += new System.EventHandler(this.Highscore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.highscoreeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.puzzleDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.highscoremBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.puzzleDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private puzzleDataSet puzzleDataSet;
        private System.Windows.Forms.BindingSource highscoreeBindingSource;
        private puzzleDataSetTableAdapters.highscore_eTableAdapter highscore_eTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn puzzle1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn puzzle2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn puzzle3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn puzzle4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn puzzle5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn puzzle6DataGridViewTextBoxColumn;
        private puzzleDataSet1 puzzleDataSet1;
        private System.Windows.Forms.BindingSource highscoremBindingSource;
        private puzzleDataSet1TableAdapters.highscore_mTableAdapter highscore_mTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn puzzle1DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn puzzle2DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn puzzle3DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn puzzle4DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn puzzle5DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn puzzle6DataGridViewTextBoxColumn1;
    }
}