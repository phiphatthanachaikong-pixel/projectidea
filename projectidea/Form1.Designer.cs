namespace projectidea
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
            label2 = new Label();
            groupBox1 = new GroupBox();
            ideaid = new TextBox();
            label1 = new Label();
            ideatitle = new TextBox();
            label3 = new Label();
            category = new ComboBox();
            label4 = new Label();
            status = new ComboBox();
            ADD = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 37);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 1;
            label2.Text = "IDEA_ID";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ADD);
            groupBox1.Controls.Add(status);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(category);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(ideatitle);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(ideaid);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(21, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(720, 240);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "โปรแกรมบันทึกไอเดียโครงงาน";
            // 
            // ideaid
            // 
            ideaid.Location = new Point(98, 34);
            ideaid.Name = "ideaid";
            ideaid.Size = new Size(597, 23);
            ideaid.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 74);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 3;
            label1.Text = "IDEA_TITLE";
            // 
            // ideatitle
            // 
            ideatitle.Location = new Point(98, 71);
            ideatitle.Name = "ideatitle";
            ideatitle.Size = new Size(597, 23);
            ideatitle.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 112);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 5;
            label3.Text = "CATEGORY";
            // 
            // category
            // 
            category.FormattingEnabled = true;
            category.Items.AddRange(new object[] { "game", "song", "website", "novel", "fiction", "application" });
            category.Location = new Point(98, 109);
            category.Name = "category";
            category.Size = new Size(597, 23);
            category.TabIndex = 6;
            category.SelectedIndexChanged += category_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 151);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 7;
            label4.Text = "STATUS";
            // 
            // status
            // 
            status.FormattingEnabled = true;
            status.Items.AddRange(new object[] { "new", "in review", "approved" });
            status.Location = new Point(98, 148);
            status.Name = "status";
            status.Size = new Size(597, 23);
            status.TabIndex = 8;
            // 
            // ADD
            // 
            ADD.Location = new Point(188, 193);
            ADD.Name = "ADD";
            ADD.Size = new Size(295, 23);
            ADD.TabIndex = 9;
            ADD.Text = "ADD";
            ADD.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "โปรแกรมบันทึกไอเดียโครงงาน";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label2;
        private GroupBox groupBox1;
        private ComboBox status;
        private Label label4;
        private ComboBox category;
        private Label label3;
        private TextBox ideatitle;
        private Label label1;
        private TextBox ideaid;
        private Button ADD;
    }
}
