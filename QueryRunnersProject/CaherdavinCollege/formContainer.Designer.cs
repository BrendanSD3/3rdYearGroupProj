namespace CaherdavinCollege
{
    partial class formContainer
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
            this.SuspendLayout();
            // 
            // formContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 838);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1500, 780);
            this.Name = "formContainer";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Caherdavin College";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.Shown += new System.EventHandler(this.formContainer_Shown);
            this.ResumeLayout(false);

        }

        #endregion
    }
}