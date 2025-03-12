namespace PZChecklist
{
    partial class FilePathSelector
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            textBoxFilePath = new TextBox();
            label2 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            browseButton = new Button();
            acceptButton = new Button();
            modsCheckBox = new CheckBox();
            openFileDialog1 = new OpenFileDialog();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 622F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 95F));
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Controls.Add(textBoxFilePath, 1, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 1, 2);
            tableLayoutPanel1.Controls.Add(modsCheckBox, 1, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 73.77049F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 26.2295074F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 276F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(93, 75);
            label1.Margin = new Padding(10, 0, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(361, 15);
            label1.TabIndex = 0;
            label1.Text = "Select your file path to steamapps (must contain Project Zomboid):";
            // 
            // textBoxFilePath
            // 
            textBoxFilePath.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxFilePath.Location = new Point(88, 94);
            textBoxFilePath.Margin = new Padding(5, 3, 3, 3);
            textBoxFilePath.Name = "textBoxFilePath";
            textBoxFilePath.Size = new Size(614, 23);
            textBoxFilePath.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(25, 98);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 3;
            label2.Text = "File path:";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.Controls.Add(browseButton);
            flowLayoutPanel1.Controls.Add(acceptButton);
            flowLayoutPanel1.Location = new Point(86, 132);
            flowLayoutPanel1.Margin = new Padding(3, 10, 3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(616, 35);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // browseButton
            // 
            browseButton.Location = new Point(3, 3);
            browseButton.Name = "browseButton";
            browseButton.Size = new Size(75, 23);
            browseButton.TabIndex = 0;
            browseButton.Text = "Browse";
            browseButton.UseVisualStyleBackColor = true;
            // 
            // acceptButton
            // 
            acceptButton.Location = new Point(84, 3);
            acceptButton.Name = "acceptButton";
            acceptButton.Size = new Size(75, 23);
            acceptButton.TabIndex = 1;
            acceptButton.Text = "OK";
            acceptButton.UseVisualStyleBackColor = true;
            // 
            // modsCheckBox
            // 
            modsCheckBox.AutoSize = true;
            modsCheckBox.Location = new Point(86, 177);
            modsCheckBox.Name = "modsCheckBox";
            modsCheckBox.Size = new Size(536, 34);
            modsCheckBox.TabIndex = 5;
            modsCheckBox.Text = "Enable items from mods\r\n(Enabling this feature will significantly slow down the program if you have many mods installed.)";
            modsCheckBox.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // FilePathSelector
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "FilePathSelector";
            Text = "Select file path";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private OpenFileDialog openFileDialog1;
        private TextBox textBoxFilePath;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button browseButton;
        private Button acceptButton;
        private CheckBox modsCheckBox;
    }
}