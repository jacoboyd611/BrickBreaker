
namespace BrickBreaker
{
    partial class MainScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.title = new System.Windows.Forms.Label();
            this.playButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Impact", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(201, 71);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(326, 60);
            this.title.TabIndex = 0;
            this.title.Text = "BRICKBREAKER";
            this.title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.playButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.playButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.Font = new System.Drawing.Font("Impact", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.Location = new System.Drawing.Point(286, 174);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(159, 36);
            this.playButton.TabIndex = 1;
            this.playButton.Text = "PLAY";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Impact", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(286, 216);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(159, 36);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(312, 305);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(109, 22);
            this.inputBox.TabIndex = 3;
            this.inputBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.label1.Location = new System.Drawing.Point(286, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter # of Bricks";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(283, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Default 150, Max 308";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.title);
            this.Name = "MainScreen";
            this.Size = new System.Drawing.Size(728, 517);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}
