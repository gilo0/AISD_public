namespace drzewooo
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
            treeView1 = new TreeView();
            input = new NumericUpDown();
            label1 = new Label();
            removebutton = new Button();
            addbutton = new Button();
            resetbutton = new Button();
            ((System.ComponentModel.ISupportInitialize)input).BeginInit();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.AllowDrop = true;
            treeView1.Location = new Point(173, 85);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(432, 353);
            treeView1.TabIndex = 0;
            // 
            // input
            // 
            input.Location = new Point(330, 27);
            input.Name = "input";
            input.Size = new Size(120, 23);
            input.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(370, 9);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 2;
            label1.Text = "Liczba";
            // 
            // removebutton
            // 
            removebutton.Location = new Point(263, 56);
            removebutton.Name = "removebutton";
            removebutton.Size = new Size(75, 23);
            removebutton.TabIndex = 3;
            removebutton.Text = "Usun";
            removebutton.UseVisualStyleBackColor = true;
            removebutton.Click += removebutton_Click;
            // 
            // addbutton
            // 
            addbutton.Location = new Point(443, 56);
            addbutton.Name = "addbutton";
            addbutton.Size = new Size(75, 23);
            addbutton.TabIndex = 4;
            addbutton.Text = "Dodaj";
            addbutton.UseVisualStyleBackColor = true;
            addbutton.Click += addbutton_Click;
            // 
            // resetbutton
            // 
            resetbutton.Location = new Point(692, 415);
            resetbutton.Name = "resetbutton";
            resetbutton.Size = new Size(96, 23);
            resetbutton.TabIndex = 5;
            resetbutton.Text = "Reset drzewa";
            resetbutton.UseVisualStyleBackColor = true;
            resetbutton.Click += resetbutton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(resetbutton);
            Controls.Add(addbutton);
            Controls.Add(removebutton);
            Controls.Add(label1);
            Controls.Add(input);
            Controls.Add(treeView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)input).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView treeView1;
        private NumericUpDown input;
        private Label label1;
        private Button removebutton;
        private Button addbutton;
        private Button resetbutton;
    }
}
