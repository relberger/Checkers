namespace Checkers
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
            this.darkSquare = new System.Windows.Forms.PictureBox();
            this.liteSquare = new System.Windows.Forms.PictureBox();
            this.nudBoardSize = new System.Windows.Forms.NumericUpDown();
            this.pnlBoard = new System.Windows.Forms.Panel();
            this.lblLocation = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.darkSquare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liteSquare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBoardSize)).BeginInit();
            this.SuspendLayout();
            // 
            // darkSquare
            // 
            this.darkSquare.Image = global::Checkers.Properties.Resources.dark_square;
            this.darkSquare.Location = new System.Drawing.Point(422, 319);
            this.darkSquare.Name = "darkSquare";
            this.darkSquare.Size = new System.Drawing.Size(50, 50);
            this.darkSquare.TabIndex = 2;
            this.darkSquare.TabStop = false;
            this.darkSquare.Visible = false;
            // 
            // liteSquare
            // 
            this.liteSquare.Image = global::Checkers.Properties.Resources.lite_square;
            this.liteSquare.Location = new System.Drawing.Point(422, 253);
            this.liteSquare.Name = "liteSquare";
            this.liteSquare.Size = new System.Drawing.Size(50, 50);
            this.liteSquare.TabIndex = 1;
            this.liteSquare.TabStop = false;
            this.liteSquare.Visible = false;
            // 
            // nudBoardSize
            // 
            this.nudBoardSize.Location = new System.Drawing.Point(378, -1);
            this.nudBoardSize.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudBoardSize.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudBoardSize.Name = "nudBoardSize";
            this.nudBoardSize.Size = new System.Drawing.Size(94, 20);
            this.nudBoardSize.TabIndex = 3;
            this.nudBoardSize.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudBoardSize.ValueChanged += new System.EventHandler(this.nudBoardSize_ValueChanged);
            // 
            // pnlBoard
            // 
            this.pnlBoard.Location = new System.Drawing.Point(12, 12);
            this.pnlBoard.Name = "pnlBoard";
            this.pnlBoard.Size = new System.Drawing.Size(337, 319);
            this.pnlBoard.TabIndex = 4;
            this.pnlBoard.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBoard_MouseDown);
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(12, 345);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(35, 13);
            this.lblLocation.TabIndex = 5;
            this.lblLocation.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 383);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.pnlBoard);
            this.Controls.Add(this.nudBoardSize);
            this.Controls.Add(this.darkSquare);
            this.Controls.Add(this.liteSquare);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.darkSquare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liteSquare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBoardSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox liteSquare;
        private System.Windows.Forms.PictureBox darkSquare;
        private System.Windows.Forms.NumericUpDown nudBoardSize;
        private System.Windows.Forms.Panel pnlBoard;
        private System.Windows.Forms.Label lblLocation;
    }
}

