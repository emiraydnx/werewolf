namespace werewolf
{
    partial class UserControl1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            checkedListBox1 = new CheckedListBox();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            button4 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            resources.ApplyResources(button2, "button2");
            button2.Name = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            resources.ApplyResources(button3, "button3");
            button3.Name = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // checkedListBox1
            // 
            checkedListBox1.AccessibleRole = AccessibleRole.MenuBar;
            checkedListBox1.BorderStyle = BorderStyle.None;
            resources.ApplyResources(checkedListBox1, "checkedListBox1");
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { resources.GetString("checkedListBox1.Items"), resources.GetString("checkedListBox1.Items1"), resources.GetString("checkedListBox1.Items2"), resources.GetString("checkedListBox1.Items3"), resources.GetString("checkedListBox1.Items4"), resources.GetString("checkedListBox1.Items5"), resources.GetString("checkedListBox1.Items6") });
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // richTextBox1
            // 
            resources.ApplyResources(richTextBox1, "richTextBox1");
            richTextBox1.BackColor = Color.White;
            richTextBox1.BorderStyle = BorderStyle.FixedSingle;
            richTextBox1.Name = "richTextBox1";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.BackColor = Color.Transparent;
            label1.Name = "label1";
            // 
            // button4
            // 
            button4.Cursor = Cursors.Hand;
            resources.ApplyResources(button4, "button4");
            button4.Name = "button4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label2
            // 
            label2.AllowDrop = true;
            resources.ApplyResources(label2, "label2");
            label2.BackColor = Color.Transparent;
            label2.Name = "label2";
            label2.Click += label2_Click;
            // 
            // UserControl1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(label2);
            Controls.Add(button4);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Controls.Add(checkedListBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            ForeColor = Color.Black;
            Name = "UserControl1";
            Tag = "Roles";
            Load += UserControl1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private CheckedListBox checkedListBox1;
        private RichTextBox richTextBox1;
        private Label label1;
        private Button button4;
        private Label label2;
    }
}
