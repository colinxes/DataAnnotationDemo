namespace DataAnnotationDemo.Forms
{
    partial class GenericForm<T>
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
            this.dataLayoutControl = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.layoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl
            // 
            this.dataLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl.Name = "dataLayoutControl";
            this.dataLayoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1136, 213, 450, 400);
            this.dataLayoutControl.Root = this.layoutControlGroup;
            this.dataLayoutControl.Size = new System.Drawing.Size(784, 461);
            this.dataLayoutControl.TabIndex = 0;
            // 
            // layoutControlGroup
            // 
            this.layoutControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup.GroupBordersVisible = false;
            this.layoutControlGroup.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup.Name = "Root";
            this.layoutControlGroup.Size = new System.Drawing.Size(784, 461);
            this.layoutControlGroup.TextVisible = false;
            // 
            // GenericForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.dataLayoutControl);
            this.Name = "GenericForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Spieler bearbeiten";
            this.Load += new System.EventHandler(this.DataLayout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup;
    }
}