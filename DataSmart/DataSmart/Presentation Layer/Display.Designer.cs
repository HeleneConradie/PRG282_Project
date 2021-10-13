
namespace DataSmart.Presentation_Layer
{
    partial class frmDisplay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDisplay));
            this.dgvDisplay = new System.Windows.Forms.DataGridView();
            this.pbLogoDisplay = new System.Windows.Forms.PictureBox();
            this.pnlDisplay = new System.Windows.Forms.Panel();
            this.btnBackDisplay = new System.Windows.Forms.Button();
            this.pbStudentImageShow = new System.Windows.Forms.PictureBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.dgvDisplayModStud = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoDisplay)).BeginInit();
            this.pnlDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStudentImageShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayModStud)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDisplay
            // 
            this.dgvDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplay.Location = new System.Drawing.Point(0, 147);
            this.dgvDisplay.Name = "dgvDisplay";
            this.dgvDisplay.RowTemplate.Height = 30;
            this.dgvDisplay.Size = new System.Drawing.Size(568, 376);
            this.dgvDisplay.TabIndex = 0;
            this.dgvDisplay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDisplay_CellClick);
            // 
            // pbLogoDisplay
            // 
            this.pbLogoDisplay.Image = ((System.Drawing.Image)(resources.GetObject("pbLogoDisplay.Image")));
            this.pbLogoDisplay.Location = new System.Drawing.Point(0, 0);
            this.pbLogoDisplay.Name = "pbLogoDisplay";
            this.pbLogoDisplay.Size = new System.Drawing.Size(186, 147);
            this.pbLogoDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogoDisplay.TabIndex = 1;
            this.pbLogoDisplay.TabStop = false;
            // 
            // pnlDisplay
            // 
            this.pnlDisplay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlDisplay.BackgroundImage")));
            this.pnlDisplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlDisplay.Controls.Add(this.btnBackDisplay);
            this.pnlDisplay.Controls.Add(this.pbStudentImageShow);
            this.pnlDisplay.Controls.Add(this.btnSearch);
            this.pnlDisplay.Controls.Add(this.lblSearch);
            this.pnlDisplay.Controls.Add(this.tbSearch);
            this.pnlDisplay.Controls.Add(this.pbLogoDisplay);
            this.pnlDisplay.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDisplay.Location = new System.Drawing.Point(0, 0);
            this.pnlDisplay.Name = "pnlDisplay";
            this.pnlDisplay.Size = new System.Drawing.Size(1136, 147);
            this.pnlDisplay.TabIndex = 2;
            // 
            // btnBackDisplay
            // 
            this.btnBackDisplay.BackColor = System.Drawing.Color.Transparent;
            this.btnBackDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackDisplay.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackDisplay.ForeColor = System.Drawing.Color.White;
            this.btnBackDisplay.Location = new System.Drawing.Point(1058, 106);
            this.btnBackDisplay.Name = "btnBackDisplay";
            this.btnBackDisplay.Size = new System.Drawing.Size(75, 32);
            this.btnBackDisplay.TabIndex = 6;
            this.btnBackDisplay.Text = "Back";
            this.btnBackDisplay.UseVisualStyleBackColor = false;
            this.btnBackDisplay.Click += new System.EventHandler(this.btnBackDisplay_Click);
            // 
            // pbStudentImageShow
            // 
            this.pbStudentImageShow.Location = new System.Drawing.Point(192, 56);
            this.pbStudentImageShow.Name = "pbStudentImageShow";
            this.pbStudentImageShow.Size = new System.Drawing.Size(120, 82);
            this.pbStudentImageShow.TabIndex = 5;
            this.pbStudentImageShow.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Red;
            this.btnSearch.Location = new System.Drawing.Point(376, 56);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.Transparent;
            this.lblSearch.Location = new System.Drawing.Point(317, 22);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(44, 13);
            this.lblSearch.TabIndex = 3;
            this.lblSearch.Text = "Search:";
            // 
            // tbSearch
            // 
            this.tbSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSearch.Location = new System.Drawing.Point(376, 20);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(164, 20);
            this.tbSearch.TabIndex = 2;
            // 
            // dgvDisplayModStud
            // 
            this.dgvDisplayModStud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplayModStud.Location = new System.Drawing.Point(568, 147);
            this.dgvDisplayModStud.Name = "dgvDisplayModStud";
            this.dgvDisplayModStud.Size = new System.Drawing.Size(568, 376);
            this.dgvDisplayModStud.TabIndex = 3;
            // 
            // frmDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 523);
            this.Controls.Add(this.dgvDisplayModStud);
            this.Controls.Add(this.pnlDisplay);
            this.Controls.Add(this.dgvDisplay);
            this.Name = "frmDisplay";
            this.Text = "Display";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDisplay_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoDisplay)).EndInit();
            this.pnlDisplay.ResumeLayout(false);
            this.pnlDisplay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStudentImageShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayModStud)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDisplay;
        private System.Windows.Forms.PictureBox pbLogoDisplay;
        private System.Windows.Forms.Panel pnlDisplay;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnBackDisplay;
        private System.Windows.Forms.DataGridView dgvDisplayModStud;
        public System.Windows.Forms.PictureBox pbStudentImageShow;
    }
}