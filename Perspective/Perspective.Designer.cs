namespace Perspective
{
    partial class Perspective
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
            this.picMain = new System.Windows.Forms.PictureBox();
            this.tbXTransform = new System.Windows.Forms.TrackBar();
            this.tbXRotate = new System.Windows.Forms.TrackBar();
            this.tbYTransform = new System.Windows.Forms.TrackBar();
            this.tbYRotate = new System.Windows.Forms.TrackBar();
            this.tbZTransform = new System.Windows.Forms.TrackBar();
            this.tbZRotate = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbXTransform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbXRotate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbYTransform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbYRotate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbZTransform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbZRotate)).BeginInit();
            this.SuspendLayout();
            // 
            // picMain
            // 
            this.picMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picMain.Location = new System.Drawing.Point(0, 0);
            this.picMain.Name = "picMain";
            this.picMain.Size = new System.Drawing.Size(1021, 546);
            this.picMain.TabIndex = 0;
            this.picMain.TabStop = false;
            // 
            // tbXTransform
            // 
            this.tbXTransform.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbXTransform.AutoSize = false;
            this.tbXTransform.Location = new System.Drawing.Point(0, 547);
            this.tbXTransform.Name = "tbXTransform";
            this.tbXTransform.Size = new System.Drawing.Size(329, 23);
            this.tbXTransform.TabIndex = 1;
            this.tbXTransform.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // tbXRotate
            // 
            this.tbXRotate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbXRotate.AutoSize = false;
            this.tbXRotate.Location = new System.Drawing.Point(0, 576);
            this.tbXRotate.Name = "tbXRotate";
            this.tbXRotate.Size = new System.Drawing.Size(329, 23);
            this.tbXRotate.TabIndex = 1;
            this.tbXRotate.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // tbYTransform
            // 
            this.tbYTransform.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbYTransform.AutoSize = false;
            this.tbYTransform.Location = new System.Drawing.Point(335, 547);
            this.tbYTransform.Name = "tbYTransform";
            this.tbYTransform.Size = new System.Drawing.Size(329, 23);
            this.tbYTransform.TabIndex = 1;
            this.tbYTransform.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // tbYRotate
            // 
            this.tbYRotate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbYRotate.AutoSize = false;
            this.tbYRotate.Location = new System.Drawing.Point(335, 576);
            this.tbYRotate.Name = "tbYRotate";
            this.tbYRotate.Size = new System.Drawing.Size(329, 23);
            this.tbYRotate.TabIndex = 1;
            this.tbYRotate.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // tbZTransform
            // 
            this.tbZTransform.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbZTransform.AutoSize = false;
            this.tbZTransform.Location = new System.Drawing.Point(670, 547);
            this.tbZTransform.Name = "tbZTransform";
            this.tbZTransform.Size = new System.Drawing.Size(329, 23);
            this.tbZTransform.TabIndex = 1;
            this.tbZTransform.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // tbZRotate
            // 
            this.tbZRotate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbZRotate.AutoSize = false;
            this.tbZRotate.Location = new System.Drawing.Point(670, 576);
            this.tbZRotate.Name = "tbZRotate";
            this.tbZRotate.Size = new System.Drawing.Size(329, 23);
            this.tbZRotate.TabIndex = 1;
            this.tbZRotate.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // Perspective
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 598);
            this.Controls.Add(this.tbZRotate);
            this.Controls.Add(this.tbZTransform);
            this.Controls.Add(this.tbYRotate);
            this.Controls.Add(this.tbYTransform);
            this.Controls.Add(this.tbXRotate);
            this.Controls.Add(this.tbXTransform);
            this.Controls.Add(this.picMain);
            this.Name = "Perspective";
            this.Text = "Perspective";
            this.Load += new System.EventHandler(this.Perspective_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbXTransform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbXRotate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbYTransform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbYRotate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbZTransform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbZRotate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picMain;
        private System.Windows.Forms.TrackBar tbXTransform;
        private System.Windows.Forms.TrackBar tbXRotate;
        private System.Windows.Forms.TrackBar tbYTransform;
        private System.Windows.Forms.TrackBar tbYRotate;
        private System.Windows.Forms.TrackBar tbZTransform;
        private System.Windows.Forms.TrackBar tbZRotate;
    }
}

