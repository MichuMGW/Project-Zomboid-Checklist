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
    public partial class ChangeCategoriesForm : Form
    {
        public event Action<List<string>> CategoriesChanged;

        public ChangeCategoriesForm(List<string> categories)
        {
            InitializeComponent();

            foreach (string category in categories)
            {
                checkedListBox1.Items.Add(category, true);
            }
            foreach(string category in Enum.GetNames(typeof(ItemCategory)))
            {
                if (!categories.Contains(category))
                {
                    checkedListBox1.Items.Add(category, false);
                }
            }

            saveChangesButton.Click += OnSaveButtonClick;

            cancelButton.Click += (sender, e) => this.Close();


        }
        public void OnSaveButtonClick(object sender, EventArgs e)
        {
            List<string> categories = new List<string>();
            foreach (string category in checkedListBox1.CheckedItems)
            {
                categories.Add(category);
            }
            CategoriesChanged?.Invoke(categories);
            this.Close();
        }

    }

    
}
