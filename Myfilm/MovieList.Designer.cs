namespace Myfilm
{
    partial class MovieList
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonPub = new System.Windows.Forms.Button();
            this.textName = new System.Windows.Forms.TextBox();
            this.dataMovieList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataMovieList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "查询：";
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(344, 25);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(42, 23);
            this.buttonOk.TabIndex = 1;
            this.buttonOk.Text = "确定";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonPub
            // 
            this.buttonPub.Location = new System.Drawing.Point(429, 321);
            this.buttonPub.Name = "buttonPub";
            this.buttonPub.Size = new System.Drawing.Size(75, 23);
            this.buttonPub.TabIndex = 2;
            this.buttonPub.Text = "新片发布";
            this.buttonPub.UseVisualStyleBackColor = true;
            this.buttonPub.Click += new System.EventHandler(this.buttonPub_Click);
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(59, 27);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(279, 21);
            this.textName.TabIndex = 4;
            // 
            // dataMovieList
            // 
            this.dataMovieList.AllowUserToAddRows = false;
            this.dataMovieList.AllowUserToDeleteRows = false;
            this.dataMovieList.AllowUserToResizeColumns = false;
            this.dataMovieList.AllowUserToResizeRows = false;
            this.dataMovieList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataMovieList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataMovieList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataMovieList.DataMember = "Table";
            this.dataMovieList.Location = new System.Drawing.Point(12, 63);
            this.dataMovieList.MultiSelect = false;
            this.dataMovieList.Name = "dataMovieList";
            this.dataMovieList.ReadOnly = true;
            this.dataMovieList.RowHeadersVisible = false;
            this.dataMovieList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataMovieList.RowTemplate.Height = 23;
            this.dataMovieList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataMovieList.ShowEditingIcon = false;
            this.dataMovieList.Size = new System.Drawing.Size(492, 252);
            this.dataMovieList.TabIndex = 5;
            this.dataMovieList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataMovieList_CellClick);
            this.dataMovieList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataMovieList_CellContentClick);
            this.dataMovieList.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataMovieList_CellContentDoubleClick);
            // 
            // MovieList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 356);
            this.Controls.Add(this.dataMovieList);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.buttonPub);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.label1);
            this.Name = "MovieList";
            this.Text = "MovieList";
            ((System.ComponentModel.ISupportInitialize)(this.dataMovieList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonPub;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.DataGridView dataMovieList;
    }
}