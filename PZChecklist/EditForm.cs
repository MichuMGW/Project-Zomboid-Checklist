using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PZChecklistLibrary;

namespace PZChecklist
{
    public partial class EditForm : Form
    {
        public event Action<Item> ItemEdited;
        Item editedItem;
        ItemCategory categorySelected;
        public EditForm(Item item)
        {
            editedItem = item;

            InitializeComponent();

            textBox1.Text = item.Name;

            foreach (ItemCategory category in Enum.GetValues(typeof(ItemCategory)))
            {
                Button button = new Button();
                button.Text = category.ToString();

                button.Click += (sender, e) => {
                    categorySelected = category;
                };
                categoryPanel.Controls.Add(button);
            }

            editItemButton.Click += OnButtonClick;
            cancelButton.Click += (sender, e) => this.Close();
        }

        private void OnButtonClick(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            editedItem.Name = name;
            if (categorySelected != 0)
            {
                editedItem.Category = categorySelected;
            }
            ItemEdited?.Invoke(editedItem);
            this.Close();
        }
    }
}
