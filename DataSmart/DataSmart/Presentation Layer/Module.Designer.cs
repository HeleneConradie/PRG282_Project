
namespace DataSmart.Presentation_Layer
{
    partial class frmModule
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
            this.pnlAddModule = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAddModuleHeading = new System.Windows.Forms.Label();
            this.tbModCode = new System.Windows.Forms.TextBox();
            this.tbModName = new System.Windows.Forms.TextBox();
            this.pnlAddModule.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAddModule
            // 
            this.pnlAddModule.Controls.Add(this.tbModName);
            this.pnlAddModule.Controls.Add(this.tbModCode);
            this.pnlAddModule.Controls.Add(this.lblAddModuleHeading);
            this.pnlAddModule.Location = new System.Drawing.Point(13, 13);
            this.pnlAddModule.Name = "pnlAddModule";
            this.pnlAddModule.Size = new System.Drawing.Size(746, 233);
            this.pnlAddModule.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 263);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(746, 233);
            this.panel1.TabIndex = 1;
            // 
            // lblAddModuleHeading
            // 
            this.lblAddModuleHeading.AutoSize = true;
            this.lblAddModuleHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddModuleHeading.Location = new System.Drawing.Point(15, 15);
            this.lblAddModuleHeading.Name = "lblAddModuleHeading";
            this.lblAddModuleHeading.Size = new System.Drawing.Size(74, 13);
            this.lblAddModuleHeading.TabIndex = 0;
            this.lblAddModuleHeading.Text = "Add Module";
            // 
            // tbModCode
            // 
            this.tbModCode.Location = new System.Drawing.Point(18, 49);
            this.tbModCode.Name = "tbModCode";
            this.tbModCode.Size = new System.Drawing.Size(100, 20);
            this.tbModCode.TabIndex = 1;
            // 
            // tbModName
            // 
            this.tbModName.Location = new System.Drawing.Point(18, 97);
            this.tbModName.Name = "tbModName";
            this.tbModName.Size = new System.Drawing.Size(100, 20);
            this.tbModName.TabIndex = 2;
            // 
            // frmModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 547);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlAddModule);
            this.Name = "frmModule";
            this.Text = "Module";
            this.pnlAddModule.ResumeLayout(false);
            this.pnlAddModule.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pnlAddModule;
        private System.Windows.Forms.TextBox tbModName;
        private System.Windows.Forms.TextBox tbModCode;
        private System.Windows.Forms.Label lblAddModuleHeading;
        public System.Windows.Forms.Panel panel1;
    }
}