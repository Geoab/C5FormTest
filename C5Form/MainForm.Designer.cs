namespace MyTest
{
    partial class MainForm
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.grdPerson = new System.Windows.Forms.DataGridView();
            this.personIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personLasttNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personBirthDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnShufle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(565, 328);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStart.Location = new System.Drawing.Point(12, 328);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "&Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // grdPerson
            // 
            this.grdPerson.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdPerson.AutoGenerateColumns = false;
            this.grdPerson.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.grdPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPerson.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personIdDataGridViewTextBoxColumn,
            this.personCodeDataGridViewTextBoxColumn,
            this.personFirstNameDataGridViewTextBoxColumn,
            this.personLasttNameDataGridViewTextBoxColumn,
            this.personBirthDayDataGridViewTextBoxColumn});
            this.grdPerson.DataSource = this.personBindingSource;
            this.grdPerson.Location = new System.Drawing.Point(12, 29);
            this.grdPerson.Name = "grdPerson";
            this.grdPerson.Size = new System.Drawing.Size(628, 284);
            this.grdPerson.TabIndex = 2;
            // 
            // personIdDataGridViewTextBoxColumn
            // 
            this.personIdDataGridViewTextBoxColumn.DataPropertyName = "PersonId";
            this.personIdDataGridViewTextBoxColumn.HeaderText = "PersonId";
            this.personIdDataGridViewTextBoxColumn.Name = "personIdDataGridViewTextBoxColumn";
            this.personIdDataGridViewTextBoxColumn.Width = 74;
            // 
            // personCodeDataGridViewTextBoxColumn
            // 
            this.personCodeDataGridViewTextBoxColumn.DataPropertyName = "PersonCode";
            this.personCodeDataGridViewTextBoxColumn.HeaderText = "PersonCode";
            this.personCodeDataGridViewTextBoxColumn.Name = "personCodeDataGridViewTextBoxColumn";
            this.personCodeDataGridViewTextBoxColumn.Width = 90;
            // 
            // personFirstNameDataGridViewTextBoxColumn
            // 
            this.personFirstNameDataGridViewTextBoxColumn.DataPropertyName = "PersonFirstName";
            this.personFirstNameDataGridViewTextBoxColumn.HeaderText = "PersonFirstName";
            this.personFirstNameDataGridViewTextBoxColumn.Name = "personFirstNameDataGridViewTextBoxColumn";
            this.personFirstNameDataGridViewTextBoxColumn.Width = 112;
            // 
            // personLasttNameDataGridViewTextBoxColumn
            // 
            this.personLasttNameDataGridViewTextBoxColumn.DataPropertyName = "PersonLasttName";
            this.personLasttNameDataGridViewTextBoxColumn.HeaderText = "PersonLasttName";
            this.personLasttNameDataGridViewTextBoxColumn.Name = "personLasttNameDataGridViewTextBoxColumn";
            this.personLasttNameDataGridViewTextBoxColumn.Width = 116;
            // 
            // personBirthDayDataGridViewTextBoxColumn
            // 
            this.personBirthDayDataGridViewTextBoxColumn.DataPropertyName = "PersonBirthDay";
            this.personBirthDayDataGridViewTextBoxColumn.HeaderText = "PersonBirthDay";
            this.personBirthDayDataGridViewTextBoxColumn.Name = "personBirthDayDataGridViewTextBoxColumn";
            this.personBirthDayDataGridViewTextBoxColumn.Width = 105;
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataSource = typeof(MyTest.InternalClasses.Person);
            // 
            // btnShufle
            // 
            this.btnShufle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnShufle.Location = new System.Drawing.Point(194, 328);
            this.btnShufle.Name = "btnShufle";
            this.btnShufle.Size = new System.Drawing.Size(75, 23);
            this.btnShufle.TabIndex = 3;
            this.btnShufle.Text = "S&hufle";
            this.btnShufle.UseVisualStyleBackColor = true;
            this.btnShufle.Click += new System.EventHandler(this.btnShufle_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 363);
            this.Controls.Add(this.btnShufle);
            this.Controls.Add(this.grdPerson);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnExit);
            this.Name = "MainForm";
            this.Text = "Main Form";
            ((System.ComponentModel.ISupportInitialize)(this.grdPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.DataGridView grdPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn personIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personLasttNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personBirthDayDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource personBindingSource;
        private System.Windows.Forms.Button btnShufle;
    }
}

