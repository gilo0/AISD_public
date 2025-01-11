namespace sortowania
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
            list = new TextBox();
            label1 = new Label();
            label2 = new Label();
            sorted = new TextBox();
            button_bubble = new Button();
            addButton = new Button();
            addBox = new NumericUpDown();
            button_insert = new Button();
            button_quick = new Button();
            clearArray = new Button();
            button_counting = new Button();
            label3 = new Label();
            button_merge = new Button();
            ((System.ComponentModel.ISupportInitialize)addBox).BeginInit();
            SuspendLayout();
            // 
            // list
            // 
            list.Location = new Point(372, 43);
            list.Name = "list";
            list.ReadOnly = true;
            list.Size = new Size(416, 23);
            list.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(753, 22);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 1;
            label1.Text = "LISTA";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(667, 111);
            label2.Name = "label2";
            label2.Size = new Size(121, 15);
            label2.TabIndex = 2;
            label2.Text = "WYNIK SORTOWANIA";
            // 
            // sorted
            // 
            sorted.Location = new Point(372, 138);
            sorted.Name = "sorted";
            sorted.ReadOnly = true;
            sorted.Size = new Size(416, 23);
            sorted.TabIndex = 3;
            // 
            // button_bubble
            // 
            button_bubble.Location = new Point(38, 378);
            button_bubble.Name = "button_bubble";
            button_bubble.Size = new Size(153, 48);
            button_bubble.TabIndex = 4;
            button_bubble.Text = "bubble sort";
            button_bubble.UseVisualStyleBackColor = true;
            button_bubble.Click += button_bubble_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(691, 201);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 40);
            addButton.TabIndex = 6;
            addButton.Text = "dodaj do listy";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // addBox
            // 
            addBox.Location = new Point(667, 172);
            addBox.Name = "addBox";
            addBox.Size = new Size(120, 23);
            addBox.TabIndex = 7;
            // 
            // button_insert
            // 
            button_insert.Location = new Point(197, 379);
            button_insert.Name = "button_insert";
            button_insert.Size = new Size(134, 47);
            button_insert.TabIndex = 8;
            button_insert.Text = "insert sort";
            button_insert.UseVisualStyleBackColor = true;
            button_insert.Click += button_insert_Click;
            // 
            // button_quick
            // 
            button_quick.Location = new Point(337, 379);
            button_quick.Name = "button_quick";
            button_quick.Size = new Size(128, 47);
            button_quick.TabIndex = 9;
            button_quick.Text = "quick sort";
            button_quick.UseVisualStyleBackColor = true;
            button_quick.Click += button_quick_Click;
            // 
            // clearArray
            // 
            clearArray.Location = new Point(372, 170);
            clearArray.Name = "clearArray";
            clearArray.Size = new Size(106, 23);
            clearArray.TabIndex = 10;
            clearArray.Text = "wyczysc tablice";
            clearArray.UseVisualStyleBackColor = true;
            clearArray.Click += clearArray_Click;
            // 
            // button_counting
            // 
            button_counting.Location = new Point(471, 379);
            button_counting.Name = "button_counting";
            button_counting.Size = new Size(144, 47);
            button_counting.TabIndex = 11;
            button_counting.Text = "counting sort";
            button_counting.UseVisualStyleBackColor = true;
            button_counting.Click += button_counting_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(-4, 26);
            label3.Name = "label3";
            label3.Size = new Size(370, 286);
            label3.TabIndex = 12;
            label3.Text = "top 1 sortownik w tej czesci robit";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button_merge
            // 
            button_merge.Location = new Point(621, 378);
            button_merge.Name = "button_merge";
            button_merge.Size = new Size(145, 48);
            button_merge.TabIndex = 13;
            button_merge.Text = "merge sort";
            button_merge.UseVisualStyleBackColor = true;
            button_merge.Click += button_merge_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_merge);
            Controls.Add(label3);
            Controls.Add(button_counting);
            Controls.Add(clearArray);
            Controls.Add(button_quick);
            Controls.Add(button_insert);
            Controls.Add(addBox);
            Controls.Add(addButton);
            Controls.Add(button_bubble);
            Controls.Add(sorted);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(list);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)addBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox list;
        private Label label1;
        private Label label2;
        private TextBox sorted;
        private Button button_bubble;
        private Button addButton;
        private NumericUpDown addBox;
        private Button button_insert;
        private Button button_quick;
        private Button clearArray;
        private Button button_counting;
        private Label label3;
        private Button button_merge;
    }
}
