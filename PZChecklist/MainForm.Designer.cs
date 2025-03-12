namespace PZChecklist
{
    partial class MainForm
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
            mainPanel = new Panel();
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            checkedListBox = new CheckedListBox();
            searchTextBox = new TextBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            addButton = new Button();
            editButton = new Button();
            deleteButton = new Button();
            chagneCategoriesButton = new Button();
            reloadItemsButton = new Button();
            settingsButton = new Button();
            panel2 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            flowCategoryButtons = new FlowLayoutPanel();
            allButton = new Button();
            materialButton = new Button();
            maintenanceButton = new Button();
            skillbookButton = new Button();
            toolButton = new Button();
            weaponButton = new Button();
            otherButton = new Button();
            mainPanel.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            flowCategoryButtons.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.AutoSize = true;
            mainPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mainPanel.Controls.Add(label1);
            mainPanel.Controls.Add(tableLayoutPanel2);
            mainPanel.Controls.Add(panel2);
            mainPanel.Controls.Add(tableLayoutPanel1);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(800, 450);
            mainPanel.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 88);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 13;
            label1.Text = "Search:";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Controls.Add(checkedListBox, 0, 1);
            tableLayoutPanel2.Controls.Add(searchTextBox, 0, 0);
            tableLayoutPanel2.Controls.Add(flowLayoutPanel2, 1, 1);
            tableLayoutPanel2.Location = new Point(0, 106);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(800, 343);
            tableLayoutPanel2.TabIndex = 12;
            // 
            // checkedListBox
            // 
            checkedListBox.Dock = DockStyle.Fill;
            checkedListBox.FormattingEnabled = true;
            checkedListBox.Location = new Point(3, 33);
            checkedListBox.Name = "checkedListBox";
            checkedListBox.Size = new Size(634, 307);
            checkedListBox.TabIndex = 0;
            // 
            // searchTextBox
            // 
            searchTextBox.Dock = DockStyle.Fill;
            searchTextBox.Location = new Point(3, 3);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(634, 23);
            searchTextBox.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            flowLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel2.Controls.Add(addButton);
            flowLayoutPanel2.Controls.Add(editButton);
            flowLayoutPanel2.Controls.Add(deleteButton);
            flowLayoutPanel2.Controls.Add(chagneCategoriesButton);
            flowLayoutPanel2.Controls.Add(reloadItemsButton);
            flowLayoutPanel2.Controls.Add(settingsButton);
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(643, 33);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(154, 307);
            flowLayoutPanel2.TabIndex = 3;
            // 
            // addButton
            // 
            addButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            addButton.AutoSize = true;
            addButton.Location = new Point(3, 3);
            addButton.Name = "addButton";
            addButton.Size = new Size(125, 25);
            addButton.TabIndex = 1;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            // 
            // editButton
            // 
            editButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            editButton.AutoSize = true;
            editButton.Location = new Point(3, 34);
            editButton.Name = "editButton";
            editButton.Size = new Size(125, 25);
            editButton.TabIndex = 2;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            deleteButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            deleteButton.AutoSize = true;
            deleteButton.Location = new Point(3, 65);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(125, 25);
            deleteButton.TabIndex = 3;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            // 
            // chagneCategoriesButton
            // 
            chagneCategoriesButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            chagneCategoriesButton.AutoSize = true;
            chagneCategoriesButton.Location = new Point(3, 143);
            chagneCategoriesButton.Margin = new Padding(3, 50, 3, 3);
            chagneCategoriesButton.Name = "chagneCategoriesButton";
            chagneCategoriesButton.Size = new Size(125, 45);
            chagneCategoriesButton.TabIndex = 4;
            chagneCategoriesButton.Text = "Change categories";
            chagneCategoriesButton.UseVisualStyleBackColor = true;
            // 
            // reloadItemsButton
            // 
            reloadItemsButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            reloadItemsButton.AutoSize = true;
            reloadItemsButton.Location = new Point(3, 194);
            reloadItemsButton.Name = "reloadItemsButton";
            reloadItemsButton.Size = new Size(125, 25);
            reloadItemsButton.TabIndex = 5;
            reloadItemsButton.Text = "Check for new items";
            reloadItemsButton.UseVisualStyleBackColor = true;
            // 
            // settingsButton
            // 
            settingsButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            settingsButton.AutoSize = true;
            settingsButton.Location = new Point(3, 225);
            settingsButton.Name = "settingsButton";
            settingsButton.Size = new Size(125, 25);
            settingsButton.TabIndex = 6;
            settingsButton.Text = "Settings";
            settingsButton.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.AutoSize = true;
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.Location = new Point(23, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(0, 0);
            panel2.TabIndex = 10;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(flowCategoryButtons, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(800, 85);
            tableLayoutPanel1.TabIndex = 11;
            // 
            // flowCategoryButtons
            // 
            flowCategoryButtons.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            flowCategoryButtons.AutoSize = true;
            flowCategoryButtons.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowCategoryButtons.Controls.Add(allButton);
            flowCategoryButtons.Controls.Add(materialButton);
            flowCategoryButtons.Controls.Add(maintenanceButton);
            flowCategoryButtons.Controls.Add(skillbookButton);
            flowCategoryButtons.Controls.Add(toolButton);
            flowCategoryButtons.Controls.Add(weaponButton);
            flowCategoryButtons.Controls.Add(otherButton);
            flowCategoryButtons.Location = new Point(112, 3);
            flowCategoryButtons.Name = "flowCategoryButtons";
            flowCategoryButtons.Padding = new Padding(0, 20, 0, 0);
            flowCategoryButtons.Size = new Size(576, 79);
            flowCategoryButtons.TabIndex = 3;
            // 
            // allButton
            // 
            allButton.Location = new Point(3, 23);
            allButton.Name = "allButton";
            allButton.Size = new Size(75, 23);
            allButton.TabIndex = 4;
            allButton.Text = "All";
            allButton.UseVisualStyleBackColor = true;
            // 
            // materialButton
            // 
            materialButton.Location = new Point(84, 23);
            materialButton.Name = "materialButton";
            materialButton.Size = new Size(75, 23);
            materialButton.TabIndex = 8;
            materialButton.Text = "Material";
            materialButton.UseVisualStyleBackColor = true;
            // 
            // maintenanceButton
            // 
            maintenanceButton.Location = new Point(165, 23);
            maintenanceButton.Name = "maintenanceButton";
            maintenanceButton.Size = new Size(84, 23);
            maintenanceButton.TabIndex = 7;
            maintenanceButton.Text = "Maintenance";
            maintenanceButton.UseVisualStyleBackColor = true;
            // 
            // skillbookButton
            // 
            skillbookButton.Location = new Point(255, 23);
            skillbookButton.Name = "skillbookButton";
            skillbookButton.Size = new Size(75, 23);
            skillbookButton.TabIndex = 1;
            skillbookButton.Text = "Skillbook";
            skillbookButton.UseVisualStyleBackColor = true;
            // 
            // toolButton
            // 
            toolButton.Location = new Point(336, 23);
            toolButton.Name = "toolButton";
            toolButton.Size = new Size(75, 23);
            toolButton.TabIndex = 6;
            toolButton.Text = "Tool";
            toolButton.UseVisualStyleBackColor = true;
            // 
            // weaponButton
            // 
            weaponButton.Location = new Point(417, 23);
            weaponButton.Name = "weaponButton";
            weaponButton.Size = new Size(75, 23);
            weaponButton.TabIndex = 5;
            weaponButton.Text = "Weapon";
            weaponButton.UseVisualStyleBackColor = true;
            // 
            // otherButton
            // 
            otherButton.Location = new Point(498, 23);
            otherButton.Name = "otherButton";
            otherButton.Size = new Size(75, 23);
            otherButton.TabIndex = 3;
            otherButton.Text = "Other";
            otherButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mainPanel);
            Name = "MainForm";
            Text = "PZ Checklist";
            Load += Form1_Load;
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowCategoryButtons.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel mainPanel;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel2;
        private CheckedListBox checkedListBox;
        private TextBox searchTextBox;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button addButton;
        private Button editButton;
        private Button deleteButton;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowCategoryButtons;
        private Button skillbookButton;
        private Button otherButton;
        private Panel panel2;
        private Button allButton;
        private Button weaponButton;
        private Button toolButton;
        private Button materialButton;
        private Button maintenanceButton;
        private Button chagneCategoriesButton;
        private Button reloadItemsButton;
        private Button settingsButton;
    }
}
