namespace PZChecklist
{
    partial class AddForm
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
            addItemButton = new Button();
            titleLabel = new Label();
            textBox1 = new TextBox();
            categoryLabel = new Label();
            categoryPanel = new FlowLayoutPanel();
            cancelButton = new Button();
            panel1 = new Panel();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.375F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85.625F));
            tableLayoutPanel1.Controls.Add(addItemButton, 1, 2);
            tableLayoutPanel1.Controls.Add(titleLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(textBox1, 1, 0);
            tableLayoutPanel1.Controls.Add(categoryLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(categoryPanel, 1, 1);
            tableLayoutPanel1.Controls.Add(cancelButton, 1, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 39F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // addItemButton
            // 
            addItemButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            addItemButton.AutoSize = true;
            addItemButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            addItemButton.Location = new Point(118, 384);
            addItemButton.Name = "addItemButton";
            addItemButton.Size = new Size(679, 24);
            addItemButton.TabIndex = 4;
            addItemButton.Text = "Add Item";
            addItemButton.UseVisualStyleBackColor = true;
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
            categoryLabel.Size = new Size(109, 331);
            categoryLabel.TabIndex = 2;
            categoryLabel.Text = "Category";
            categoryLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // categoryPanel
            // 
            categoryPanel.Dock = DockStyle.Fill;
            categoryPanel.Location = new Point(118, 53);
            categoryPanel.Name = "categoryPanel";
            categoryPanel.Size = new Size(679, 325);
            categoryPanel.TabIndex = 3;
            // 
            // cancelButton
            // 
            cancelButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cancelButton.AutoSize = true;
            cancelButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            cancelButton.Location = new Point(118, 414);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(679, 25);
            cancelButton.TabIndex = 5;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 1;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "AddForm";
            Text = "Add new item";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label titleLabel;
        private Panel panel1;
        private TextBox textBox1;
        private Label categoryLabel;
        private FlowLayoutPanel categoryPanel;
        private Button addItemButton;
        private Button cancelButton;
    }
}