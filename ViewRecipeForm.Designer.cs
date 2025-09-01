namespace Farm_Management_System_UI
{
    partial class ViewRecipeForm
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
            lb1Name = new Label();
            pictureBox = new PictureBox();
            txtIngredients = new RichTextBox();
            label4 = new Label();
            txtInstructions = new RichTextBox();
            label3 = new Label();
            btnEdit = new Button();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // lb1Name
            // 
            lb1Name.AutoSize = true;
            lb1Name.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb1Name.Location = new Point(60, 65);
            lb1Name.Name = "lb1Name";
            lb1Name.Size = new Size(70, 28);
            lb1Name.TabIndex = 3;
            lb1Name.Text = "label1";
            // 
            // pictureBox
            // 
            pictureBox.Cursor = Cursors.Hand;
            pictureBox.Location = new Point(60, 96);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(391, 272);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 2;
            pictureBox.TabStop = false;
            pictureBox.Click += pictureBox_Click;
            // 
            // txtIngredients
            // 
            txtIngredients.BackColor = SystemColors.HighlightText;
            txtIngredients.BorderStyle = BorderStyle.FixedSingle;
            txtIngredients.Location = new Point(60, 420);
            txtIngredients.Name = "txtIngredients";
            txtIngredients.ReadOnly = true;
            txtIngredients.ScrollBars = RichTextBoxScrollBars.Vertical;
            txtIngredients.Size = new Size(236, 156);
            txtIngredients.TabIndex = 19;
            txtIngredients.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(60, 397);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 18;
            label4.Text = "Ingredients";
            // 
            // txtInstructions
            // 
            txtInstructions.BorderStyle = BorderStyle.FixedSingle;
            txtInstructions.Location = new Point(562, 119);
            txtInstructions.Name = "txtInstructions";
            txtInstructions.ReadOnly = true;
            txtInstructions.ScrollBars = RichTextBoxScrollBars.Vertical;
            txtInstructions.Size = new Size(460, 457);
            txtInstructions.TabIndex = 21;
            txtInstructions.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(562, 96);
            label3.Name = "label3";
            label3.Size = new Size(92, 20);
            label3.TabIndex = 20;
            label3.Text = "Instructions:";
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = Color.FromArgb(230, 0, 35);
            btnEdit.Location = new Point(575, 595);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(107, 43);
            btnEdit.TabIndex = 23;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click_1;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(164, 120, 100);
            button1.Location = new Point(448, 595);
            button1.Name = "button1";
            button1.Size = new Size(109, 43);
            button1.TabIndex = 22;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(928, 12);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 24;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ViewRecipeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(1101, 688);
            Controls.Add(button2);
            Controls.Add(btnEdit);
            Controls.Add(button1);
            Controls.Add(txtInstructions);
            Controls.Add(label3);
            Controls.Add(txtIngredients);
            Controls.Add(label4);
            Controls.Add(lb1Name);
            Controls.Add(pictureBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewRecipeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewRecipeForm";
            Load += ViewRecipeForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb1Name;
        private PictureBox pictureBox;
        private RichTextBox txtIngredients;
        private Label label4;
        private RichTextBox txtInstructions;
        private Label label3;
        private Button btnEdit;
        private Button button1;
        private Button button2;
    }
}