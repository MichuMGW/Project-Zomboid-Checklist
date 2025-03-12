namespace PZChecklist
{
    partial class EditForm
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
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            titleLabel = new Label();
            textBox1 = new TextBox();
            categoryLabel = new Label();
            categoryPanel = new FlowLayoutPanel();
            editItemButton = new Button();
            cancelButton = new Button();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.375F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85.625F));
            tableLayoutPanel1.Controls.Add(titleLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(textBox1, 1, 0);
            tableLayoutPanel1.Controls.Add(categoryLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(categoryPanel, 1, 1);
            tableLayoutPanel1.Controls.Add(editItemButton, 1, 2);
            tableLayoutPanel1.Controls.Add(cancelButton, 1, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Dock = DockStyle.Fill;
            titleLabel.Location = new Point(3, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(109, 50);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Title";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(118, 13);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(679, 23);
            textBox1.TabIndex = 1;
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Dock = DockStyle.Fill;
            categoryLabel.Location = new Point(3, 50);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(109, 334);
            categoryLabel.TabIndex = 2;
            categoryLabel.Text = "Category";
            categoryLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // categoryPanel
            // 
            categoryPanel.Dock = DockStyle.Fill;
            categoryPanel.Location = new Point(118, 53);
            categoryPanel.Name = "categoryPanel";
            categoryPanel.Size = new Size(679, 328);
            categoryPanel.TabIndex = 3;
            // 
            // editItemButton
            // 
            editItemButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            editItemButton.AutoSize = true;
            editItemButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            editItemButton.Location = new Point(118, 387);
            editItemButton.Name = "editItemButton";
            editItemButton.Size = new Size(679, 24);
            editItemButton.TabIndex = 4;
            editItemButton.Text = "Edit Item";
            editItemButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            cancelButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cancelButton.AutoSize = true;
            cancelButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            cancelButton.Location = new Point(118, 417);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(679, 25);
            cancelButton.TabIndex = 5;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "EditForm";
            Text = "Edit selected item";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label titleLabel;
        private TextBox textBox1;
        private Label categoryLabel;
        private FlowLayoutPanel categoryPanel;
        private Button editItemButton;
        private Button cancelButton;
    }
}