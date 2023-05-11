namespace Book_Store
{
    partial class Form_cat
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
            this.button2 = new System.Windows.Forms.Button();
            this.TXT_CATG = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Cursor = System.Windows.Forms.Cursors.Default;
            this.button2.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(118, 266);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(248, 39);
            this.button2.TabIndex = 9;
            this.button2.Text = "Add Categorie";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TXT_CATG
            // 
            this.TXT_CATG.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXT_CATG.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TXT_CATG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TXT_CATG.HintForeColor = System.Drawing.Color.Empty;
            this.TXT_CATG.HintText = "";
            this.TXT_CATG.isPassword = false;
            this.TXT_CATG.LineFocusedColor = System.Drawing.Color.Blue;
            this.TXT_CATG.LineIdleColor = System.Drawing.Color.Gray;
            this.TXT_CATG.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TXT_CATG.LineThickness = 3;
            this.TXT_CATG.Location = new System.Drawing.Point(50, 150);
            this.TXT_CATG.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_CATG.Name = "TXT_CATG";
            this.TXT_CATG.Size = new System.Drawing.Size(376, 46);
            this.TXT_CATG.TabIndex = 8;
            this.TXT_CATG.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(144, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 39);
            this.label1.TabIndex = 7;
            this.label1.Text = "Add Categorie";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form_cat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 383);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TXT_CATG);
            this.Controls.Add(this.label1);
            this.Name = "Form_cat";
            this.Text = "Add Categorie ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TXT_CATG;
        private System.Windows.Forms.Label label1;
    }
}