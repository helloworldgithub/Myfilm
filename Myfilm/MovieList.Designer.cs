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
            this.listMovie = new System.Windows.Forms.ListBox();
            this.textName = new System.Windows.Forms.TextBox();
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
            // listMovie
            // 
            this.listMovie.FormattingEnabled = true;
            this.listMovie.ItemHeight = 12;
            this.listMovie.Location = new System.Drawing.Point(14, 71);
            this.listMovie.Name = "listMovie";
            this.listMovie.Size = new System.Drawing.Size(511, 232);
            this.listMovie.TabIndex = 3;
            this.listMovie.SelectedIndexChanged += new System.EventHandler(this.listMovie_SelectedIndexChanged);
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(59, 27);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(279, 21);
            this.textName.TabIndex = 4;
            // 
            // MovieList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 356);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.listMovie);
            this.Controls.Add(this.buttonPub);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.label1);
            this.Name = "MovieList";
            this.Text = "MovieList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonPub;
        private System.Windows.Forms.ListBox listMovie;
        private System.Windows.Forms.TextBox textName;
    }
}