namespace ExSystem
{
    partial class Form1
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
            this.close = new System.Windows.Forms.Button();
            this.navPanel = new System.Windows.Forms.Panel();
            this.size = new System.Windows.Forms.Button();
            this.hide = new System.Windows.Forms.Button();
            this.navPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.close.Location = new System.Drawing.Point(762, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(38, 34);
            this.close.TabIndex = 1;
            this.close.Text = "X";
            this.close.UseVisualStyleBackColor = true;
            // 
            // navPanel
            // 
            this.navPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.navPanel.Controls.Add(this.hide);
            this.navPanel.Controls.Add(this.size);
            this.navPanel.Controls.Add(this.close);
            this.navPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.navPanel.Location = new System.Drawing.Point(0, 0);
            this.navPanel.Name = "navPanel";
            this.navPanel.Size = new System.Drawing.Size(800, 34);
            this.navPanel.TabIndex = 2;
            // 
            // size
            // 
            this.size.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.size.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.size.Location = new System.Drawing.Point(725, 0);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(38, 34);
            this.size.TabIndex = 3;
            this.size.Text = "[]]";
            this.size.UseVisualStyleBackColor = true;
            // 
            // hide
            // 
            this.hide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hide.Location = new System.Drawing.Point(689, 0);
            this.hide.Name = "hide";
            this.hide.Size = new System.Drawing.Size(37, 34);
            this.hide.TabIndex = 3;
            this.hide.Text = "_";
            this.hide.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.navPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.navPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Panel navPanel;
        private System.Windows.Forms.Button hide;
        private System.Windows.Forms.Button size;
    }
}

