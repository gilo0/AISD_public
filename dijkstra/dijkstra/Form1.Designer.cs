namespace GrafApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button addNodeButton;
        private System.Windows.Forms.Button addEdgeButton;
        private System.Windows.Forms.Button dijkstraButton;
        private System.Windows.Forms.Panel graphDisplay;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            addNodeButton = new Button();
            addEdgeButton = new Button();
            dijkstraButton = new Button();
            graphDisplay = new Panel();
            ResetButton = new Button();
            SuspendLayout();
            // 
            // addNodeButton
            // 
            addNodeButton.Location = new Point(10, 12);
            addNodeButton.Name = "addNodeButton";
            addNodeButton.Size = new Size(122, 42);
            addNodeButton.TabIndex = 0;
            addNodeButton.Text = "Dodaj Węzeł";
            addNodeButton.Click += AddNodeButton_Click;
            // 
            // addEdgeButton
            // 
            addEdgeButton.Location = new Point(10, 74);
            addEdgeButton.Name = "addEdgeButton";
            addEdgeButton.Size = new Size(122, 47);
            addEdgeButton.TabIndex = 1;
            addEdgeButton.Text = "Dodaj Krawędź";
            addEdgeButton.Click += AddEdgeButton_Click;
            // 
            // dijkstraButton
            // 
            dijkstraButton.Location = new Point(12, 378);
            dijkstraButton.Name = "dijkstraButton";
            dijkstraButton.Size = new Size(120, 94);
            dijkstraButton.TabIndex = 4;
            dijkstraButton.Text = "COMMENCE THE DIJKSTRA";
            dijkstraButton.Click += DijkstraButton_Click;
            // 
            // graphDisplay
            // 
            graphDisplay.BackColor = Color.White;
            graphDisplay.Location = new Point(138, 12);
            graphDisplay.Name = "graphDisplay";
            graphDisplay.Size = new Size(650, 460);
            graphDisplay.TabIndex = 5;
            graphDisplay.Paint += GraphPanel_Paint;
            // 
            // ResetButton
            // 
            ResetButton.Location = new Point(12, 147);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(120, 44);
            ResetButton.TabIndex = 6;
            ResetButton.Text = "Resetuj";
            ResetButton.UseVisualStyleBackColor = true;
            ResetButton.Click += ResetButton_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(800, 501);
            Controls.Add(ResetButton);
            Controls.Add(addNodeButton);
            Controls.Add(addEdgeButton);
            Controls.Add(dijkstraButton);
            Controls.Add(graphDisplay);
            Name = "Form1";
            Text = "Graf - Dijkstra";
            ResumeLayout(false);
        }

        private Button ResetButton;
    }
}
