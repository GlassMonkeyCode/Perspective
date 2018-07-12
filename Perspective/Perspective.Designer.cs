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
            this.components = new System.ComponentModel.Container();
            this.picMain = new System.Windows.Forms.PictureBox();
            this.tbXTransform = new System.Windows.Forms.TrackBar();
            this.tbXRotate = new System.Windows.Forms.TrackBar();
            this.tbYTransform = new System.Windows.Forms.TrackBar();
            this.tbYRotate = new System.Windows.Forms.TrackBar();
            this.tbZTransform = new System.Windows.Forms.TrackBar();
            this.tbZRotate = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tbLength = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbXTransform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbXRotate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbYTransform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbYRotate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbZTransform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbZRotate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.SuspendLayout();
            // 
            // picMain
            // 
            this.picMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picMain.Location = new System.Drawing.Point(0, 0);
            this.picMain.Name = "picMain";
            this.picMain.Size = new System.Drawing.Size(1328, 615);
            this.picMain.TabIndex = 0;
            this.picMain.TabStop = false;
            // 
            // tbXTransform
            // 
            this.tbXTransform.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbXTransform.AutoSize = false;
            this.tbXTransform.Location = new System.Drawing.Point(0, 616);
            this.tbXTransform.Maximum = 1900;
            this.tbXTransform.Name = "tbXTransform";
            this.tbXTransform.Size = new System.Drawing.Size(329, 23);
            this.tbXTransform.TabIndex = 1;
            this.tbXTransform.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbXTransform.Scroll += new System.EventHandler(this.tbXTransform_Scroll);
            // 
            // tbXRotate
            // 
            this.tbXRotate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbXRotate.AutoSize = false;
            this.tbXRotate.Location = new System.Drawing.Point(0, 645);
            this.tbXRotate.Maximum = 360;
            this.tbXRotate.Name = "tbXRotate";
            this.tbXRotate.Size = new System.Drawing.Size(329, 23);
            this.tbXRotate.TabIndex = 1;
            this.tbXRotate.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbXRotate.Scroll += new System.EventHandler(this.tbXRotate_Scroll);
            // 
            // tbYTransform
            // 
            this.tbYTransform.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbYTransform.AutoSize = false;
            this.tbYTransform.Location = new System.Drawing.Point(335, 616);
            this.tbYTransform.Maximum = 1000;
            this.tbYTransform.Name = "tbYTransform";
            this.tbYTransform.Size = new System.Drawing.Size(329, 23);
            this.tbYTransform.TabIndex = 1;
            this.tbYTransform.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbYTransform.Scroll += new System.EventHandler(this.tbYTransform_Scroll);
            // 
            // tbYRotate
            // 
            this.tbYRotate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbYRotate.AutoSize = false;
            this.tbYRotate.Location = new System.Drawing.Point(335, 645);
            this.tbYRotate.Maximum = 360;
            this.tbYRotate.Name = "tbYRotate";
            this.tbYRotate.Size = new System.Drawing.Size(329, 23);
            this.tbYRotate.TabIndex = 1;
            this.tbYRotate.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbYRotate.Scroll += new System.EventHandler(this.tbYRotate_Scroll);
            // 
            // tbZTransform
            // 
            this.tbZTransform.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbZTransform.AutoSize = false;
            this.tbZTransform.Location = new System.Drawing.Point(670, 616);
            this.tbZTransform.Maximum = 1000;
            this.tbZTransform.Name = "tbZTransform";
            this.tbZTransform.Size = new System.Drawing.Size(329, 23);
            this.tbZTransform.TabIndex = 1;
            this.tbZTransform.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // tbZRotate
            // 
            this.tbZRotate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbZRotate.AutoSize = false;
            this.tbZRotate.Location = new System.Drawing.Point(670, 645);
            this.tbZRotate.Maximum = 360;
            this.tbZRotate.Name = "tbZRotate";
            this.tbZRotate.Size = new System.Drawing.Size(329, 23);
            this.tbZRotate.TabIndex = 1;
            this.tbZRotate.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbZRotate.Scroll += new System.EventHandler(this.tbZRotate_Scroll);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 634);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(358, 634);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Y";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(697, 634);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Z";
            // 
            // tbLength
            // 
            this.tbLength.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbLength.AutoSize = false;
            this.tbLength.Location = new System.Drawing.Point(1005, 616);
            this.tbLength.Maximum = 500;
            this.tbLength.Minimum = 10;
            this.tbLength.Name = "tbLength";
            this.tbLength.Size = new System.Drawing.Size(329, 23);
            this.tbLength.TabIndex = 1;
            this.tbLength.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbLength.Value = 10;
            this.tbLength.Scroll += new System.EventHandler(this.tbLength_Scroll);
            // 
            // trackBar2
            // 
            this.trackBar2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackBar2.AutoSize = false;
            this.trackBar2.Location = new System.Drawing.Point(1005, 645);
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(329, 23);
            this.trackBar2.TabIndex = 1;
            this.trackBar2.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar2.Scroll += new System.EventHandler(this.tbZRotate_Scroll);
            // 
            // Perspective
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 667);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.tbLength);
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
            this.Resize += new System.EventHandler(this.Perspective_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbXTransform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbXRotate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbYTransform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbYRotate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbZTransform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbZRotate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picMain;
        private System.Windows.Forms.TrackBar tbXTransform;
        private System.Windows.Forms.TrackBar tbXRotate;
        private System.Windows.Forms.TrackBar tbYTransform;
        private System.Windows.Forms.TrackBar tbYRotate;
        private System.Windows.Forms.TrackBar tbZTransform;
        private System.Windows.Forms.TrackBar tbZRotate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar tbLength;
        private System.Windows.Forms.TrackBar trackBar2;
    }
}

