using System;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using PZChecklistLibrary;

namespace PZChecklist
{
    public partial class MainForm : Form
    {
        private AppSettings appSettings;
        private FileStreamer fileStreamer;
        private ItemList itemList;
        private List<Item> filteredItems = new List<Item>();

        private string itemCategories;

        private static string DataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "PZChecklist");

        private string pattern { get; set; }
        private Regex regex { get; set; }
        private string currentCategory { get; set; }
        private string selectedItemName { get; set; }
        private List<string> CategoryList { get; set; }

        public MainForm()
        {
            if (!Directory.Exists(DataPath))
            {
                Directory.CreateDirectory(DataPath);
            }

            InitializeComponent();
            fileStreamer = new FileStreamer();

            //Load settings - game files path and mods path
            appSettings = SettingsManager.LoadSettings();

            //Check if game files path and mods path are set. If not, show file selector
            if (string.IsNullOrEmpty(appSettings.GameFilesPath) || string.IsNullOrEmpty(appSettings.ModsPath))
            {
                FilePathSelector filePathSelector = new FilePathSelector();
                if (filePathSelector.ShowDialog() == DialogResult.OK)
                {
                    appSettings.SteamappsPath = filePathSelector.SelectedSteamappsPath;
                    appSettings.GameFilesPath = filePathSelector.SelectedGameFilesPath;
                    appSettings.ModsPath = filePathSelector.SelectedModsPath;
                    appSettings.ModsAllowed = filePathSelector.AllowMods;
                }
                else
                {
                    MessageBox.Show("No game files selected. Exiting.");
                    Environment.Exit(0);
                }
            }

            //Loading items from JSON or game files if JSON doesn't exist
            if (!File.Exists($"{DataPath}\\items.json"))
            {
                itemList = fileStreamer.ParseContent(fileStreamer.ReadFromAllFiles(appSettings.GameFilesPath));
                fileStreamer.SaveToJson(itemList, DataPath);
            }
            else
            {
                itemList = fileStreamer.LoadItemListFromJson(DataPath);
            }

            //Loading categories from JSON or using default ones
            CategoryList = fileStreamer.LoadItemCategoriesFromTxt(DataPath);
            LoadCategoriesButtons();

            LoadFilteredItems();
            InitializeActions();
            
        }

        private void InitializeActions()
        {
            FormClosing += OnClosing;

            checkedListBox.ItemCheck += OnItemCheck;

            checkedListBox.Click += OnItemClick;

            addButton.Click += OnAddButtonClicked;

            editButton.Click += OnEditButtonClicked;

            deleteButton.Click += OnDeleteButtonClicked;

            searchTextBox.TextChanged += OnSearchTextBoxChanged;

            chagneCategoriesButton.Click += OnChangeCategoriesButtonClicked;

            reloadItemsButton.Click += OnReloadItemsButtonClicked;

            settingsButton.Click += OnSettingsButtonClicked;
        }

        private void OnSettingsButtonClicked(object? sender, EventArgs e)
        {
            FilePathSelector filePathSelector = new FilePathSelector(appSettings.SteamappsPath);
            if (filePathSelector.ShowDialog() == DialogResult.OK)
            {
                appSettings.SteamappsPath = filePathSelector.SelectedSteamappsPath;
                appSettings.GameFilesPath = filePathSelector.SelectedGameFilesPath;
                appSettings.ModsPath = filePathSelector.SelectedModsPath;
                if (filePathSelector.AllowMods != appSettings.ModsAllowed)
                {
                    appSettings.ModsAllowed = filePathSelector.AllowMods;
                    ReloadItems();
                }
                    
            }
        }
        private void OnReloadItemsButtonClicked(object? sender, EventArgs e)
        {
            ReloadItems();
        }

        private void ReloadItems()
        {
            //Check if there are new items in game files
            ItemList itemListJson = fileStreamer.LoadItemListFromJson(DataPath);
            ItemList itemListGameFiles = fileStreamer.ParseContent(fileStreamer.ReadFromAllFiles(appSettings.GameFilesPath));
            if (appSettings.ModsAllowed)
            {
                ItemList itemListMods = fileStreamer.ParseContent(fileStreamer.ReadFromModFiles(appSettings.ModsPath));
                itemList = new ItemList
                {
                    Items = itemListJson.Items
                    .Union(itemListGameFiles.Items, new ItemComparer())
                    .Union(itemListMods.Items, new ItemComparer())
                    .ToList()
                };
            }
            else
            {
                itemList = new ItemList
                {
                    Items = itemList.Items
                    .Union(itemListGameFiles.Items, new ItemComparer())
                    .ToList()
                };
            }
            LoadFilteredItems();
        }

        private void LoadCategoriesButtons()
        {
            flowCategoryButtons.Controls.Clear();

            //All Button
            Button allButton = new Button();
            allButton.Text = "All";
            allButton.AutoSize = true;
            flowCategoryButtons.Controls.Add(allButton);
            allButton.Click += OnAllButtonClicked;

            CategoryList.Sort();
            //Category Buttons from List
            foreach (string category in CategoryList)
            {
                Button button = new Button();


                button.Text = category;
                Console.WriteLine(category);
                button.AutoSize = true;

                button.Click += (sender, e) =>
                {
                    LoadFilteredItems(category);
                };
                flowCategoryButtons.Controls.Add(button);
            }
        }

        private void OnChangeCategoriesButtonClicked(object? sender, EventArgs e)
        {
            ChangeCategoriesForm categoryForm = new ChangeCategoriesForm(CategoryList);
            categoryForm.CategoriesChanged += OnCategoriesChanged;
            categoryForm.Show();
        }

        private void OnCategoriesChanged(List<string> categories)
        {
            CategoryList = categories;
            fileStreamer.SaveItemCategoriesToTxt(CategoryList, DataPath);
            LoadCategoriesButtons();
        }

        private void OnDeleteButtonClicked(object? sender, EventArgs e)
        {
            Item selectedItem = itemList.Items.Find(i => i.Name == selectedItemName);
            if (selectedItem == null)
            {
                MessageBox.Show("No item selected");
                return;
            }
            checkedListBox.Items.RemoveAt(checkedListBox.SelectedIndex);
            itemList.Items.Remove(selectedItem);
            //LoadFilteredItems(currentCategory);
        }

        private void OnAllButtonClicked(object? sender, EventArgs e)
        {
            checkedListBox.Items.Clear();
            filteredItems = itemList.Items;
            filteredItems.Sort((x, y) => x.Name.CompareTo(y.Name));
            foreach (Item item in filteredItems)
            {
                checkedListBox.Items.Add(item.Name, item.IsObtained);
            }
        }

        private void OnItemClick(object? sender, EventArgs e)
        {
            selectedItemName = filteredItems[checkedListBox.SelectedIndex].Name;
        }

        private void OnAddButtonClicked(object? sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.ItemAdded += AddNewItem;
            addForm.Show();
        }

        private void OnEditButtonClicked(object? sender, EventArgs e)
        {
            Item selectedItem = itemList.Items.Find(i => i.Name == selectedItemName);
            if (selectedItem == null)
            {
                MessageBox.Show("No item selected");
                return;
            }
            EditForm editForm = new EditForm(selectedItem);
            editForm.ItemEdited += new Action<Item>(EditItem);
            editForm.Show();
        }

        private void EditItem(Item updatedItem)
        {
            Item itemToEdit = itemList.Items.Find(i => i.Name == updatedItem.Name);
            if (itemToEdit == null) return;

            itemList.Items.Remove(itemToEdit);
            itemList.Items.Add(updatedItem);
            itemList.Items.Sort((x, y) => x.Name.CompareTo(y.Name));
            LoadFilteredItems(currentCategory);
        }

        private void OnItemCheck(object? sender, ItemCheckEventArgs e)
        {
            filteredItems[e.Index].IsObtained = e.NewValue == CheckState.Checked;
            //itemList.writeToFile($"{DataPath}\\itemList.csv");
            fileStreamer.SaveToJson(itemList, DataPath);
        }

        private void OnClosing(object? sender, FormClosingEventArgs e)
        {
            // Zapisanie stanu zaznaczenia do pliku
            //itemList.writeToFile($"{DataPath}\\itemList.csv");
            fileStreamer.SaveToJson(itemList, DataPath);
            SettingsManager.SaveSettings(appSettings);
        }

        private void LoadFilteredItems()
        {
            currentCategory = "";

            checkedListBox.Items.Clear();
            if (regex == null)
            {
                filteredItems = itemList.Items.ToList();
            }
            else
            {
                filteredItems = itemList.Items.Where(item => regex.IsMatch(item.Name)).ToList();
            }
            filteredItems.Sort((x, y) => x.Name.CompareTo(y.Name));
            foreach (Item item in filteredItems)
            {
                checkedListBox.Items.Add(item.Name, item.IsObtained);
            }
        }

        private void LoadFilteredItems(string category)
        {
            currentCategory = category;

            checkedListBox.Items.Clear();
            if (regex == null)
            {
                filteredItems = itemList.Items.Where(item => Regex.IsMatch(item.Category.ToString(),category)).ToList();
            }
            else
            {
                filteredItems = itemList.Items.Where(item => Regex.IsMatch(item.Category.ToString(), category) && regex.IsMatch(item.Name)).ToList();
            }
            filteredItems.Sort((x, y) => x.Name.CompareTo(y.Name));
            foreach (Item item in filteredItems)
            {
                checkedListBox.Items.Add(item.Name, item.IsObtained);
            }
        }

        private void OnSearchTextBoxChanged(object? sender, EventArgs e)
        {
            pattern = searchTextBox.Text;
            regex = new Regex(pattern, RegexOptions.IgnoreCase);

            filteredItems = itemList.Items.Where(item => regex.IsMatch(item.Name) && Regex.IsMatch(item.Category.ToString(),currentCategory)).ToList();

            checkedListBox.Items.Clear();
            foreach (Item item in filteredItems)
            {
                checkedListBox.Items.Add(item.Name, item.IsObtained);
            }
        }

        private void Form1_Load(object? sender, EventArgs e) { }
        public void AddNewItem(Item item)
        {
            itemList.AddItem(item);
            LoadFilteredItems(currentCategory);
        }

    }
}
