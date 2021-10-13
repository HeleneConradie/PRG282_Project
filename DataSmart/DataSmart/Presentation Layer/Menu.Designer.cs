
namespace DataSmart.Presentation_Layer
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.pnlBackMenu = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnContinue = new System.Windows.Forms.Button();
            this.gbOption = new System.Windows.Forms.GroupBox();
            this.rbtnViewAll = new System.Windows.Forms.RadioButton();
            this.rbtnSearch = new System.Windows.Forms.RadioButton();
            this.rbtnAdd = new System.Windows.Forms.RadioButton();
            this.rbtnModify = new System.Windows.Forms.RadioButton();
            this.gbType = new System.Windows.Forms.GroupBox();
            this.rbtnStudent = new System.Windows.Forms.RadioButton();
            this.rbtnModule = new System.Windows.Forms.RadioButton();
            this.pbLogoMenu = new System.Windows.Forms.PictureBox();
            this.pnlBackMenu.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.gbOption.SuspendLayout();
            this.gbType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBackMenu
            // 
            this.pnlBackMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlBackMenu.BackgroundImage")));
            this.pnlBackMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlBackMenu.Controls.Add(this.pnlMenu);
            this.pnlBackMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBackMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlBackMenu.Name = "pnlBackMenu";
            this.pnlBackMenu.Size = new System.Drawing.Size(679, 478);
            this.pnlBackMenu.TabIndex = 2;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.Transparent;
            this.pnlMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlMenu.BackgroundImage")));
            this.pnlMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMenu.Controls.Add(this.btnContinue);
            this.pnlMenu.Controls.Add(this.gbOption);
            this.pnlMenu.Controls.Add(this.gbType);
            this.pnlMenu.Controls.Add(this.pbLogoMenu);
            this.pnlMenu.Location = new System.Drawing.Point(124, 55);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(421, 375);
            this.pnlMenu.TabIndex = 0;
            // 
            // btnContinue
            // 
            this.btnContinue.BackColor = System.Drawing.Color.Transparent;
            this.btnContinue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnContinue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinue.Location = new System.Drawing.Point(132, 309);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(154, 41);
            this.btnContinue.TabIndex = 3;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = false;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // gbOption
            // 
            this.gbOption.BackColor = System.Drawing.Color.Transparent;
            this.gbOption.Controls.Add(this.rbtnViewAll);
            this.gbOption.Controls.Add(this.rbtnSearch);
            this.gbOption.Controls.Add(this.rbtnAdd);
            this.gbOption.Controls.Add(this.rbtnModify);
            this.gbOption.Location = new System.Drawing.Point(222, 158);
            this.gbOption.Name = "gbOption";
            this.gbOption.Size = new System.Drawing.Size(180, 115);
            this.gbOption.TabIndex = 2;
            this.gbOption.TabStop = false;
            // 
            // rbtnViewAll
            // 
            this.rbtnViewAll.AutoSize = true;
            this.rbtnViewAll.Location = new System.Drawing.Point(20, 89);
            this.rbtnViewAll.Name = "rbtnViewAll";
            this.rbtnViewAll.Size = new System.Drawing.Size(59, 17);
            this.rbtnViewAll.TabIndex = 3;
            this.rbtnViewAll.TabStop = true;
            this.rbtnViewAll.Text = "ViewAll";
            this.rbtnViewAll.UseVisualStyleBackColor = true;
            // 
            // rbtnSearch
            // 
            this.rbtnSearch.AutoSize = true;
            this.rbtnSearch.Location = new System.Drawing.Point(20, 65);
            this.rbtnSearch.Name = "rbtnSearch";
            this.rbtnSearch.Size = new System.Drawing.Size(59, 17);
            this.rbtnSearch.TabIndex = 2;
            this.rbtnSearch.TabStop = true;
            this.rbtnSearch.Text = "Search";
            this.rbtnSearch.UseVisualStyleBackColor = true;
            // 
            // rbtnAdd
            // 
            this.rbtnAdd.AutoSize = true;
            this.rbtnAdd.Location = new System.Drawing.Point(20, 43);
            this.rbtnAdd.Name = "rbtnAdd";
            this.rbtnAdd.Size = new System.Drawing.Size(44, 17);
            this.rbtnAdd.TabIndex = 1;
            this.rbtnAdd.TabStop = true;
            this.rbtnAdd.Text = "Add";
            this.rbtnAdd.UseVisualStyleBackColor = true;
            // 
            // rbtnModify
            // 
            this.rbtnModify.AutoSize = true;
            this.rbtnModify.Location = new System.Drawing.Point(20, 19);
            this.rbtnModify.Name = "rbtnModify";
            this.rbtnModify.Size = new System.Drawing.Size(56, 17);
            this.rbtnModify.TabIndex = 0;
            this.rbtnModify.TabStop = true;
            this.rbtnModify.Text = "Modify";
            this.rbtnModify.UseVisualStyleBackColor = true;
            // 
            // gbType
            // 
            this.gbType.Controls.Add(this.rbtnStudent);
            this.gbType.Controls.Add(this.rbtnModule);
            this.gbType.Location = new System.Drawing.Point(14, 158);
            this.gbType.Name = "gbType";
            this.gbType.Size = new System.Drawing.Size(172, 115);
            this.gbType.TabIndex = 1;
            this.gbType.TabStop = false;
            // 
            // rbtnStudent
            // 
            this.rbtnStudent.AutoSize = true;
            this.rbtnStudent.Location = new System.Drawing.Point(6, 42);
            this.rbtnStudent.Name = "rbtnStudent";
            this.rbtnStudent.Size = new System.Drawing.Size(62, 17);
            this.rbtnStudent.TabIndex = 1;
            this.rbtnStudent.TabStop = true;
            this.rbtnStudent.Text = "Student";
            this.rbtnStudent.UseVisualStyleBackColor = true;
            // 
            // rbtnModule
            // 
            this.rbtnModule.AutoSize = true;
            this.rbtnModule.Location = new System.Drawing.Point(6, 19);
            this.rbtnModule.Name = "rbtnModule";
            this.rbtnModule.Size = new System.Drawing.Size(60, 17);
            this.rbtnModule.TabIndex = 0;
            this.rbtnModule.TabStop = true;
            this.rbtnModule.Text = "Module";
            this.rbtnModule.UseVisualStyleBackColor = true;
            // 
            // pbLogoMenu
            // 
            this.pbLogoMenu.Image = ((System.Drawing.Image)(resources.GetObject("pbLogoMenu.Image")));
            this.pbLogoMenu.Location = new System.Drawing.Point(112, 0);
            this.pbLogoMenu.Name = "pbLogoMenu";
            this.pbLogoMenu.Size = new System.Drawing.Size(190, 152);
            this.pbLogoMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogoMenu.TabIndex = 0;
            this.pbLogoMenu.TabStop = false;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 478);
            this.Controls.Add(this.pnlBackMenu);
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMenu_FormClosing);
            this.pnlBackMenu.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.gbOption.ResumeLayout(false);
            this.gbOption.PerformLayout();
            this.gbType.ResumeLayout(false);
            this.gbType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBackMenu;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.GroupBox gbType;
        private System.Windows.Forms.RadioButton rbtnStudent;
        private System.Windows.Forms.RadioButton rbtnModule;
        private System.Windows.Forms.PictureBox pbLogoMenu;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.GroupBox gbOption;
        private System.Windows.Forms.RadioButton rbtnViewAll;
        private System.Windows.Forms.RadioButton rbtnSearch;
        private System.Windows.Forms.RadioButton rbtnAdd;
        private System.Windows.Forms.RadioButton rbtnModify;
    }
}