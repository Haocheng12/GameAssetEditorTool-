namespace GameAssetEditor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstItems = new ListBox();
            label1 = new Label();
            label2 = new Label();
            txtName = new TextBox();
            txtType = new TextBox();
            txtDescription = new TextBox();
            label3 = new Label();
            numValue = new NumericUpDown();
            label4 = new Label();
            btnLoad = new Button();
            btnSave = new Button();
            btnApply = new Button();
            btnAdd = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)numValue).BeginInit();
            SuspendLayout();
            // 
            // lstItems
            // 
            lstItems.FormattingEnabled = true;
            lstItems.ItemHeight = 17;
            lstItems.Location = new Point(36, 59);
            lstItems.Name = "lstItems";
            lstItems.Size = new Size(175, 259);
            lstItems.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(252, 59);
            label1.Name = "label1";
            label1.Size = new Size(43, 17);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(252, 105);
            label2.Name = "label2";
            label2.Size = new Size(36, 17);
            label2.TabIndex = 2;
            label2.Text = "Type";
            // 
            // txtName
            // 
            txtName.Location = new Point(252, 79);
            txtName.Name = "txtName";
            txtName.Size = new Size(180, 23);
            txtName.TabIndex = 3;
            // 
            // txtType
            // 
            txtType.Location = new Point(252, 125);
            txtType.Name = "txtType";
            txtType.Size = new Size(180, 23);
            txtType.TabIndex = 4;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(252, 214);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(368, 104);
            txtDescription.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(252, 151);
            label3.Name = "label3";
            label3.Size = new Size(40, 17);
            label3.TabIndex = 5;
            label3.Text = "Value";
            // 
            // numValue
            // 
            numValue.Location = new Point(252, 171);
            numValue.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numValue.Name = "numValue";
            numValue.Size = new Size(94, 23);
            numValue.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(252, 197);
            label4.Name = "label4";
            label4.Size = new Size(74, 17);
            label4.TabIndex = 8;
            label4.Text = "Description";
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(342, 344);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(75, 23);
            btnLoad.TabIndex = 9;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(438, 344);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnApply
            // 
            btnApply.Location = new Point(545, 344);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(75, 23);
            btnApply.TabIndex = 11;
            btnApply.Text = "Apply";
            btnApply.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(36, 324);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(136, 324);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 398);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(btnApply);
            Controls.Add(btnSave);
            Controls.Add(btnLoad);
            Controls.Add(label4);
            Controls.Add(numValue);
            Controls.Add(txtDescription);
            Controls.Add(label3);
            Controls.Add(txtType);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstItems);
            Name = "Form1";
            Text = "Game Asset Editor Tool";
            ((System.ComponentModel.ISupportInitialize)numValue).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstItems;
        private Label label1;
        private Label label2;
        private TextBox txtName;
        private TextBox txtType;
        private TextBox txtDescription;
        private Label label3;
        private NumericUpDown numValue;
        private Label label4;
        private Button btnLoad;
        private Button btnSave;
        private Button btnApply;
        private Button btnAdd;
        private Button btnDelete;
    }
}
