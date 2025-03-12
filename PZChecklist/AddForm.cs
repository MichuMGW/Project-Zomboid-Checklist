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
    public partial class AddForm : Form
    {
        public event Action<Item> ItemAdded;
        int Id { get; set; }
        ItemCategory categorySelected;
        public AddForm()
        {
            InitializeComponent();

            foreach (ItemCategory category in Enum.GetValues(typeof(ItemCategory)))
            {
                Button button = new Button();
                button.Text = category.ToString();
                button.AutoSize = true;

                button.Click += (sender, e) => {
                    categorySelected = category;
                };
                categoryPanel.Controls.Add(button);
            }

            addItemButton.Click += OnButtonClick;
            cancelButton.Click += (sender, e) => this.Close();
        }

        private void OnButtonClick(object sender, EventArgs e)
        {
            string title = textBox1.Text;
            if(title == "" || categorySelected == 0)
            {
                MessageBox.Show("Fill in all fields.");
                return;
            }
            Item item = new Item(categorySelected, title);
            ItemAdded?.Invoke(item);
            this.Close();
        }
    }
}
