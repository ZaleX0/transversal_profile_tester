
namespace koleiny
{
    partial class MainForm
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
            this.fileBrowserButton = new System.Windows.Forms.Button();
            this.filesListBox = new System.Windows.Forms.ListBox();
            this.laneSideGroupBox = new System.Windows.Forms.GroupBox();
            this.rightRadioButton = new System.Windows.Forms.RadioButton();
            this.leftRadioButton = new System.Windows.Forms.RadioButton();
            this.positionLabel = new System.Windows.Forms.Label();
            this.upButton = new System.Windows.Forms.Button();
            this.DownButton = new System.Windows.Forms.Button();
            this.scaleXTextBox = new System.Windows.Forms.TextBox();
            this.scaleYTextBox = new System.Windows.Forms.TextBox();
            this.scaleXLabel = new System.Windows.Forms.Label();
            this.scaleYLabel = new System.Windows.Forms.Label();
            this.laneSideGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileBrowserButton
            // 
            this.fileBrowserButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fileBrowserButton.Location = new System.Drawing.Point(273, 12);
            this.fileBrowserButton.Name = "fileBrowserButton";
            this.fileBrowserButton.Size = new System.Drawing.Size(75, 23);
            this.fileBrowserButton.TabIndex = 0;
            this.fileBrowserButton.Text = "Open Files";
            this.fileBrowserButton.UseVisualStyleBackColor = true;
            this.fileBrowserButton.Click += new System.EventHandler(this.fileBrowserButton_Click);
            // 
            // filesListBox
            // 
            this.filesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filesListBox.FormattingEnabled = true;
            this.filesListBox.Location = new System.Drawing.Point(12, 12);
            this.filesListBox.Name = "filesListBox";
            this.filesListBox.Size = new System.Drawing.Size(255, 433);
            this.filesListBox.TabIndex = 0;
            this.filesListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.filesListBox_MouseDoubleClick);
            // 
            // laneSideGroupBox
            // 
            this.laneSideGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.laneSideGroupBox.Controls.Add(this.rightRadioButton);
            this.laneSideGroupBox.Controls.Add(this.leftRadioButton);
            this.laneSideGroupBox.Location = new System.Drawing.Point(276, 173);
            this.laneSideGroupBox.Name = "laneSideGroupBox";
            this.laneSideGroupBox.Size = new System.Drawing.Size(75, 75);
            this.laneSideGroupBox.TabIndex = 0;
            this.laneSideGroupBox.TabStop = false;
            this.laneSideGroupBox.Text = "Lane Side";
            // 
            // rightRadioButton
            // 
            this.rightRadioButton.AutoSize = true;
            this.rightRadioButton.Location = new System.Drawing.Point(6, 42);
            this.rightRadioButton.Name = "rightRadioButton";
            this.rightRadioButton.Size = new System.Drawing.Size(50, 17);
            this.rightRadioButton.TabIndex = 4;
            this.rightRadioButton.Text = "Right";
            this.rightRadioButton.UseVisualStyleBackColor = true;
            // 
            // leftRadioButton
            // 
            this.leftRadioButton.AutoSize = true;
            this.leftRadioButton.Checked = true;
            this.leftRadioButton.Location = new System.Drawing.Point(6, 19);
            this.leftRadioButton.Name = "leftRadioButton";
            this.leftRadioButton.Size = new System.Drawing.Size(43, 17);
            this.leftRadioButton.TabIndex = 3;
            this.leftRadioButton.TabStop = true;
            this.leftRadioButton.Text = "Left";
            this.leftRadioButton.UseVisualStyleBackColor = true;
            this.leftRadioButton.CheckedChanged += new System.EventHandler(this.leftRadioButton_CheckedChanged);
            // 
            // positionLabel
            // 
            this.positionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.positionLabel.AutoSize = true;
            this.positionLabel.Location = new System.Drawing.Point(347, 54);
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(56, 13);
            this.positionLabel.TabIndex = 0;
            this.positionLabel.Text = "Position: 0";
            // 
            // upButton
            // 
            this.upButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.upButton.Location = new System.Drawing.Point(397, 92);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(75, 75);
            this.upButton.TabIndex = 5;
            this.upButton.Text = "Up";
            this.upButton.UseVisualStyleBackColor = true;
            this.upButton.Click += new System.EventHandler(this.upButton_Click);
            // 
            // DownButton
            // 
            this.DownButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DownButton.Location = new System.Drawing.Point(397, 173);
            this.DownButton.Name = "DownButton";
            this.DownButton.Size = new System.Drawing.Size(75, 75);
            this.DownButton.TabIndex = 6;
            this.DownButton.Text = "Down";
            this.DownButton.UseVisualStyleBackColor = true;
            this.DownButton.Click += new System.EventHandler(this.DownButton_Click);
            // 
            // scaleXTextBox
            // 
            this.scaleXTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.scaleXTextBox.Location = new System.Drawing.Point(324, 92);
            this.scaleXTextBox.Name = "scaleXTextBox";
            this.scaleXTextBox.Size = new System.Drawing.Size(37, 20);
            this.scaleXTextBox.TabIndex = 1;
            this.scaleXTextBox.Text = "1";
            this.scaleXTextBox.TextChanged += new System.EventHandler(this.scaleXTextBox_TextChanged);
            // 
            // scaleYTextBox
            // 
            this.scaleYTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.scaleYTextBox.Location = new System.Drawing.Point(324, 118);
            this.scaleYTextBox.Name = "scaleYTextBox";
            this.scaleYTextBox.Size = new System.Drawing.Size(37, 20);
            this.scaleYTextBox.TabIndex = 2;
            this.scaleYTextBox.Text = "1";
            this.scaleYTextBox.TextChanged += new System.EventHandler(this.scaleYTextBox_TextChanged);
            // 
            // scaleXLabel
            // 
            this.scaleXLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.scaleXLabel.AutoSize = true;
            this.scaleXLabel.Location = new System.Drawing.Point(273, 95);
            this.scaleXLabel.Name = "scaleXLabel";
            this.scaleXLabel.Size = new System.Drawing.Size(44, 13);
            this.scaleXLabel.TabIndex = 0;
            this.scaleXLabel.Text = "Scale X";
            // 
            // scaleYLabel
            // 
            this.scaleYLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.scaleYLabel.AutoSize = true;
            this.scaleYLabel.Location = new System.Drawing.Point(274, 121);
            this.scaleYLabel.Name = "scaleYLabel";
            this.scaleYLabel.Size = new System.Drawing.Size(44, 13);
            this.scaleYLabel.TabIndex = 0;
            this.scaleYLabel.Text = "Scale Y";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.scaleYLabel);
            this.Controls.Add(this.scaleXLabel);
            this.Controls.Add(this.scaleYTextBox);
            this.Controls.Add(this.scaleXTextBox);
            this.Controls.Add(this.DownButton);
            this.Controls.Add(this.upButton);
            this.Controls.Add(this.positionLabel);
            this.Controls.Add(this.laneSideGroupBox);
            this.Controls.Add(this.filesListBox);
            this.Controls.Add(this.fileBrowserButton);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.laneSideGroupBox.ResumeLayout(false);
            this.laneSideGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fileBrowserButton;
        private System.Windows.Forms.ListBox filesListBox;
        private System.Windows.Forms.GroupBox laneSideGroupBox;
        private System.Windows.Forms.RadioButton rightRadioButton;
        private System.Windows.Forms.RadioButton leftRadioButton;
        private System.Windows.Forms.Label positionLabel;
        private System.Windows.Forms.Button upButton;
        private System.Windows.Forms.Button DownButton;
        private System.Windows.Forms.TextBox scaleXTextBox;
        private System.Windows.Forms.TextBox scaleYTextBox;
        private System.Windows.Forms.Label scaleXLabel;
        private System.Windows.Forms.Label scaleYLabel;
    }
}

