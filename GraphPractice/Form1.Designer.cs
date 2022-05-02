namespace GraphPractice
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
            this.tbCurrentEdges = new System.Windows.Forms.TextBox();
            this.btnTravelOnEdge = new System.Windows.Forms.Button();
            this.cbDestination = new System.Windows.Forms.ComboBox();
            this.lblCurrentNode = new System.Windows.Forms.Label();
            this.lblCurrentEdges = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbCurrentEdges
            // 
            this.tbCurrentEdges.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCurrentEdges.Location = new System.Drawing.Point(524, 67);
            this.tbCurrentEdges.Multiline = true;
            this.tbCurrentEdges.Name = "tbCurrentEdges";
            this.tbCurrentEdges.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbCurrentEdges.Size = new System.Drawing.Size(775, 768);
            this.tbCurrentEdges.TabIndex = 0;
            this.tbCurrentEdges.WordWrap = false;
            // 
            // btnTravelOnEdge
            // 
            this.btnTravelOnEdge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTravelOnEdge.Location = new System.Drawing.Point(24, 806);
            this.btnTravelOnEdge.Name = "btnTravelOnEdge";
            this.btnTravelOnEdge.Size = new System.Drawing.Size(311, 55);
            this.btnTravelOnEdge.TabIndex = 1;
            this.btnTravelOnEdge.Text = "Travel";
            this.btnTravelOnEdge.UseVisualStyleBackColor = true;
            this.btnTravelOnEdge.Click += new System.EventHandler(this.btnTravelOnEdge_Click);
            // 
            // cbDestination
            // 
            this.cbDestination.FormattingEnabled = true;
            this.cbDestination.Location = new System.Drawing.Point(12, 67);
            this.cbDestination.Name = "cbDestination";
            this.cbDestination.Size = new System.Drawing.Size(364, 49);
            this.cbDestination.TabIndex = 2;
            // 
            // lblCurrentNode
            // 
            this.lblCurrentNode.AutoSize = true;
            this.lblCurrentNode.Location = new System.Drawing.Point(12, 9);
            this.lblCurrentNode.Name = "lblCurrentNode";
            this.lblCurrentNode.Size = new System.Drawing.Size(199, 41);
            this.lblCurrentNode.TabIndex = 3;
            this.lblCurrentNode.Text = "Current Node";
            // 
            // lblCurrentEdges
            // 
            this.lblCurrentEdges.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrentEdges.AutoSize = true;
            this.lblCurrentEdges.Location = new System.Drawing.Point(1201, 9);
            this.lblCurrentEdges.Name = "lblCurrentEdges";
            this.lblCurrentEdges.Size = new System.Drawing.Size(98, 41);
            this.lblCurrentEdges.TabIndex = 4;
            this.lblCurrentEdges.Text = "Edges";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 876);
            this.Controls.Add(this.lblCurrentEdges);
            this.Controls.Add(this.lblCurrentNode);
            this.Controls.Add(this.cbDestination);
            this.Controls.Add(this.btnTravelOnEdge);
            this.Controls.Add(this.tbCurrentEdges);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbCurrentEdges;
        private Button btnTravelOnEdge;
        private ComboBox cbDestination;
        private Label lblCurrentNode;
        private Label lblCurrentEdges;
    }
}