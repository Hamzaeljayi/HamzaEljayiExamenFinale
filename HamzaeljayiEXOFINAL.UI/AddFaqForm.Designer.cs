namespace HamzaeljayiEXOFINAL.UI
{
    partial class AddFaqForm
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
            txtQuestion = new TextBox();
            label2 = new Label();
            txtAnswer = new TextBox();
            label3 = new Label();
            cmbCategory = new ComboBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 59);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 0;
            label1.Text = "Question :";
            // 
            // txtQuestion
            // 
            txtQuestion.Location = new Point(143, 52);
            txtQuestion.Name = "txtQuestion";
            txtQuestion.Size = new Size(143, 27);
            txtQuestion.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 153);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 2;
            label2.Text = "Reponse :";
            // 
            // txtAnswer
            // 
            txtAnswer.Location = new Point(143, 153);
            txtAnswer.Name = "txtAnswer";
            txtAnswer.Size = new Size(143, 27);
            txtAnswer.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 270);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 4;
            label3.Text = "Categorie :";
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(143, 267);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(151, 28);
            cmbCategory.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(177, 358);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(147, 29);
            btnSave.TabIndex = 6;
            btnSave.Text = "Enregistrer";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click_1;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(554, 358);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(137, 29);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Annuler";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click_1;
            // 
            // AddFaqForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(cmbCategory);
            Controls.Add(label3);
            Controls.Add(txtAnswer);
            Controls.Add(label2);
            Controls.Add(txtQuestion);
            Controls.Add(label1);
            Name = "AddFaqForm";
            Text = "AddFaqForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtQuestion;
        private Label label2;
        private TextBox txtAnswer;
        private Label label3;
        private ComboBox cmbCategory;
        private Button btnSave;
        private Button btnCancel;
    }
}