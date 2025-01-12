namespace huffmanlepszy
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            InputBox = new TextBox();
            textBox2 = new TextBox();
            ResetButton = new Button();
            GenerateButton = new Button();
            TreeDisplay = new TreeView();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(152, 331);
            button1.Name = "button1";
            button1.Size = new Size(88, 38);
            button1.TabIndex = 0;
            button1.Text = "Dodaj znak";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // InputBox
            // 
            InputBox.Location = new Point(246, 340);
            InputBox.Name = "InputBox";
            InputBox.Size = new Size(48, 23);
            InputBox.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(240, 12);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(290, 23);
            textBox2.TabIndex = 2;
            // 
            // ResetButton
            // 
            ResetButton.Location = new Point(600, 375);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(88, 38);
            ResetButton.TabIndex = 3;
            ResetButton.Text = "Resetuj drzewo";
            ResetButton.UseVisualStyleBackColor = true;
            ResetButton.Click += button2_Click;
            // 
            // GenerateButton
            // 
            GenerateButton.Location = new Point(395, 331);
            GenerateButton.Name = "GenerateButton";
            GenerateButton.Size = new Size(135, 38);
            GenerateButton.TabIndex = 4;
            GenerateButton.Text = "Generuj drzewo";
            GenerateButton.UseVisualStyleBackColor = true;
            GenerateButton.Click += button3_Click;
            // 
            // TreeDisplay
            // 
            TreeDisplay.Location = new Point(152, 40);
            TreeDisplay.Name = "TreeDisplay";
            TreeDisplay.Size = new Size(378, 285);
            TreeDisplay.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(152, 15);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 6;
            label1.Text = "Czestotliwosci";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 422);
            Controls.Add(label1);
            Controls.Add(TreeDisplay);
            Controls.Add(GenerateButton);
            Controls.Add(ResetButton);
            Controls.Add(textBox2);
            Controls.Add(InputBox);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Huffman";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.TreeView TreeDisplay;
        private Label label1;
    }
}

