namespace lista
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
            input = new NumericUpDown();
            label1 = new Label();
            addfirst_button = new Button();
            addlast_button = new Button();
            text1 = new Label();
            text2 = new Label();
            arraytext = new TextBox();
            stringtext = new TextBox();
            ((System.ComponentModel.ISupportInitialize)input).BeginInit();
            SuspendLayout();
            // 
            // input
            // 
            input.Location = new Point(328, 78);
            input.Name = "input";
            input.Size = new Size(120, 23);
            input.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(328, 60);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 1;
            label1.Text = "LICZBA do dodania";
            // 
            // addfirst_button
            // 
            addfirst_button.Location = new Point(281, 119);
            addfirst_button.Name = "addfirst_button";
            addfirst_button.Size = new Size(97, 44);
            addfirst_button.TabIndex = 2;
            addfirst_button.Text = "Dodaj na poczatek";
            addfirst_button.UseVisualStyleBackColor = true;
            addfirst_button.Click += addfirst_button_Click;
            // 
            // addlast_button
            // 
            addlast_button.Location = new Point(402, 119);
            addlast_button.Name = "addlast_button";
            addlast_button.Size = new Size(84, 44);
            addlast_button.TabIndex = 3;
            addlast_button.Text = "Dodaj na koniec";
            addlast_button.UseVisualStyleBackColor = true;
            addlast_button.Click += addlast_button_Click;
            // 
            // text1
            // 
            text1.AutoSize = true;
            text1.Location = new Point(362, 284);
            text1.Name = "text1";
            text1.Size = new Size(43, 15);
            text1.TabIndex = 4;
            text1.Text = "ARRAY";
            // 
            // text2
            // 
            text2.AutoSize = true;
            text2.Location = new Point(359, 353);
            text2.Name = "text2";
            text2.Size = new Size(46, 15);
            text2.TabIndex = 5;
            text2.Text = "STRING";
            // 
            // arraytext
            // 
            arraytext.Location = new Point(137, 302);
            arraytext.Name = "arraytext";
            arraytext.ReadOnly = true;
            arraytext.Size = new Size(500, 23);
            arraytext.TabIndex = 6;
            // 
            // stringtext
            // 
            stringtext.Location = new Point(137, 371);
            stringtext.Name = "stringtext";
            stringtext.ReadOnly = true;
            stringtext.Size = new Size(500, 23);
            stringtext.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(stringtext);
            Controls.Add(arraytext);
            Controls.Add(text2);
            Controls.Add(text1);
            Controls.Add(addlast_button);
            Controls.Add(addfirst_button);
            Controls.Add(label1);
            Controls.Add(input);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)input).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown input;
        private Label label1;
        private Button addfirst_button;
        private Button addlast_button;
        private Label text1;
        private Label text2;
        private TextBox arraytext;
        private TextBox stringtext;
    }
}
