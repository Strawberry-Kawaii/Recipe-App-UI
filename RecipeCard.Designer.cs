namespace Farm_Management_System_UI
{
    partial class RecipeCard
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
            pictureBox = new PictureBox();
            lb1Name = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.Cursor = Cursors.Hand;
            pictureBox.Location = new Point(23, 16);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(199, 179);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            pictureBox.Click += pictureBox_Click;
            // 
            // lb1Name
            // 
            lb1Name.AutoSize = true;
            lb1Name.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb1Name.Location = new Point(23, 212);
            lb1Name.Name = "lb1Name";
            lb1Name.Size = new Size(70, 28);
            lb1Name.TabIndex = 1;
            lb1Name.Text = "label1";
            // 
            // RecipeCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lb1Name);
            Controls.Add(pictureBox);
            Name = "RecipeCard";
            Size = new Size(247, 263);
            Load += RecipeCard_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox;
        private Label lb1Name;
    }
}
