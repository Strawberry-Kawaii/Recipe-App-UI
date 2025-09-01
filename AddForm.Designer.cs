namespace Farm_Management_System_UI
{
    partial class AddForm
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
            label2 = new Label();
            label3 = new Label();
            txtName = new TextBox();
            btnSave = new Button();
            button2 = new Button();
            label5 = new Label();
            pictureBoxPreview = new PictureBox();
            btnBrowseImage = new Button();
            txtIngredients = new RichTextBox();
            txtInstructions = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPreview).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(369, 47);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 0;
            label1.Text = "Recipe Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(369, 135);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 1;
            label2.Text = "Ingredients:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(369, 290);
            label3.Name = "label3";
            label3.Size = new Size(92, 20);
            label3.TabIndex = 2;
            label3.Text = "Instructions:";
            label3.Click += label3_Click;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Location = new Point(369, 81);
            txtName.Name = "txtName";
            txtName.Size = new Size(214, 27);
            txtName.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(230, 0, 35);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(218, 469);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(132, 43);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(230, 0, 35);
            button2.Location = new Point(369, 469);
            button2.Name = "button2";
            button2.Size = new Size(132, 43);
            button2.TabIndex = 7;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(95, 98);
            label5.Name = "label5";
            label5.Size = new Size(118, 28);
            label5.TabIndex = 9;
            label5.Text = "Add picture";
            // 
            // pictureBoxPreview
            // 
            pictureBoxPreview.Location = new Point(32, 141);
            pictureBoxPreview.Name = "pictureBoxPreview";
            pictureBoxPreview.Size = new Size(264, 237);
            pictureBoxPreview.TabIndex = 10;
            pictureBoxPreview.TabStop = false;
            // 
            // btnBrowseImage
            // 
            btnBrowseImage.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBrowseImage.ForeColor = Color.FromArgb(164, 120, 100);
            btnBrowseImage.Location = new Point(111, 384);
            btnBrowseImage.Name = "btnBrowseImage";
            btnBrowseImage.Size = new Size(107, 40);
            btnBrowseImage.TabIndex = 11;
            btnBrowseImage.Text = "Browse";
            btnBrowseImage.UseVisualStyleBackColor = true;
            btnBrowseImage.Click += btnBrowseImage_Click;
            // 
            // txtIngredients
            // 
            txtIngredients.BorderStyle = BorderStyle.FixedSingle;
            txtIngredients.Location = new Point(369, 158);
            txtIngredients.Name = "txtIngredients";
            txtIngredients.Size = new Size(231, 105);
            txtIngredients.TabIndex = 12;
            txtIngredients.Text = "";
            // 
            // txtInstructions
            // 
            txtInstructions.BorderStyle = BorderStyle.FixedSingle;
            txtInstructions.Location = new Point(369, 313);
            txtInstructions.Name = "txtInstructions";
            txtInstructions.Size = new Size(231, 105);
            txtInstructions.TabIndex = 13;
            txtInstructions.Text = "";
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 563);
            Controls.Add(txtInstructions);
            Controls.Add(txtIngredients);
            Controls.Add(btnBrowseImage);
            Controls.Add(pictureBoxPreview);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(btnSave);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddForm";
            Load += AddForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxPreview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtName;
        private Button btnSave;
        private Button button2;
        private Label label5;
        private PictureBox pictureBoxPreview;
        private Button btnBrowseImage;
        private RichTextBox txtIngredients;
        private RichTextBox txtInstructions;
    }
}