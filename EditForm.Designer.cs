namespace Farm_Management_System_UI
{
    partial class EditForm
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
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnUpdate = new Button();
            btnCancel = new Button();
            btnBrowseImage = new Button();
            PictureBox = new PictureBox();
            label5 = new Label();
            txtName = new TextBox();
            txtIngredients = new RichTextBox();
            txtInstructions = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)PictureBox).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(369, 47);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 0;
            label1.Text = "Recipe Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(369, 287);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 2;
            label3.Text = "Instructions";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(369, 134);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 3;
            label4.Text = "Ingredients";
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(230, 0, 35);
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(218, 469);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(132, 43);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click_1;
            // 
            // btnCancel
            // 
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.FromArgb(230, 0, 35);
            btnCancel.Location = new Point(369, 472);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(132, 40);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click_1;
            // 
            // btnBrowseImage
            // 
            btnBrowseImage.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBrowseImage.ForeColor = Color.FromArgb(164, 120, 100);
            btnBrowseImage.Location = new Point(111, 384);
            btnBrowseImage.Name = "btnBrowseImage";
            btnBrowseImage.Size = new Size(107, 40);
            btnBrowseImage.TabIndex = 14;
            btnBrowseImage.Text = "Browse";
            btnBrowseImage.UseVisualStyleBackColor = true;
            btnBrowseImage.Click += btnBrowseImage_Click;
            // 
            // PictureBox
            // 
            PictureBox.Location = new Point(32, 141);
            PictureBox.Name = "PictureBox";
            PictureBox.Size = new Size(264, 237);
            PictureBox.TabIndex = 13;
            PictureBox.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(95, 98);
            label5.Name = "label5";
            label5.Size = new Size(115, 28);
            label5.TabIndex = 12;
            label5.Text = "Edit picture";
            // 
            // txtName
            // 
            txtName.BackColor = SystemColors.HighlightText;
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Location = new Point(369, 70);
            txtName.Name = "txtName";
            txtName.Size = new Size(214, 27);
            txtName.TabIndex = 15;
            // 
            // txtIngredients
            // 
            txtIngredients.BackColor = SystemColors.HighlightText;
            txtIngredients.BorderStyle = BorderStyle.FixedSingle;
            txtIngredients.Location = new Point(369, 157);
            txtIngredients.Name = "txtIngredients";
            txtIngredients.Size = new Size(231, 105);
            txtIngredients.TabIndex = 17;
            txtIngredients.Text = "";
            // 
            // txtInstructions
            // 
            txtInstructions.BackColor = SystemColors.HighlightText;
            txtInstructions.BorderStyle = BorderStyle.FixedSingle;
            txtInstructions.Location = new Point(369, 313);
            txtInstructions.Name = "txtInstructions";
            txtInstructions.Size = new Size(231, 105);
            txtInstructions.TabIndex = 18;
            txtInstructions.Text = "";
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 563);
            Controls.Add(txtInstructions);
            Controls.Add(txtIngredients);
            Controls.Add(txtName);
            Controls.Add(btnBrowseImage);
            Controls.Add(PictureBox);
            Controls.Add(label5);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditForm";
            Load += EditForm_Load;
            ((System.ComponentModel.ISupportInitialize)PictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private Button btnUpdate;
        private Button btnCancel;
        private Button btnBrowseImage;
        private PictureBox PictureBox;
        private Label label5;
        private TextBox txtName;
        private RichTextBox txtIngredients;
        private RichTextBox txtInstructions;
    }
}