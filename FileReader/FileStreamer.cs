using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Text.Json;

namespace PZChecklistLibrary
{
    public class FileStreamer
    {
        public FileStreamer(){}

        public string ReadFromAllFiles(string DirectoryPath)
        {
            string[] files = Directory.GetFiles(DirectoryPath);
            string content = "";

            foreach (string file in files)
            {
                content += File.ReadAllText(file);
            }

            return content;
        }

        public List<string> GetModPaths(string DirectoryPath)
        {
            List<string> modPaths = Directory
                .GetFiles(DirectoryPath, "*.txt", SearchOption.AllDirectories)
                .AsParallel()
                .Where(path => IsWithinMediaScripts(path))
                .ToList();
            return modPaths;
        }

        /*public string ReadFromModFiles(string DirectoryPath)
        {
            List<string> modPaths = GetModPaths(DirectoryPath);
            string content = "";
            foreach (string path in modPaths)
            {
                content += File.ReadAllText(path);
            }
            return content;
        }*/

        public string ReadFromModFiles(string directoryPath)
        {
            List<string> modPaths = GetModPaths(directoryPath);
            StringBuilder contentBuilder = new StringBuilder();

            // Użycie Parallel.ForEach do równoległego przetwarzania
            Parallel.ForEach(modPaths, path =>
            {
                string fileContent = File.ReadAllText(path);

                // Synchronizacja dostępu do StringBuilder
                lock (contentBuilder)
                {
                    contentBuilder.Append(fileContent);
                }
            });

            return contentBuilder.ToString();
        }

        private bool IsWithinMediaScripts(string filePath)
        {
            string lowerPath = filePath.ToLower();
            return lowerPath.Contains(@"\media\scripts");
        }

        public void SaveToJson(ItemList items, string DirectoryPath)
        {
            var json = JsonSerializer.Serialize(items, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText($"{DirectoryPath}\\items.json", json);
        }

        public ItemList LoadItemListFromJson(string dataPath)
        {
            string path = $"{dataPath}\\items.json";
            if (!File.Exists(path))
            {
                File.WriteAllText(path, "");
                return new ItemList();
            }
            var json = File.ReadAllText(path);
            ItemList items = new ItemList(JsonSerializer.Deserialize<List<Item>>(json) ?? new List<Item>());

            return items;
        }

        public List<string> LoadItemCategoriesFromTxt(string dataPath)
        {
            string path = dataPath + "\\categories.txt";
            string[] baseCategories = {
                "Material",
                "Maintenance",
                "SkillBook",
                "Weapon",
                "Tool",
                "Weapon",
                "Other"
            };
            if (!File.Exists(path))
            {
                File.WriteAllLines(path, baseCategories);
                return new List<string>(baseCategories);
            }
            string categories = File.ReadAllText(path);
            string[] categoriesArray = categories.Split("\r\n");

            //Removing empty strings
            categoriesArray = categoriesArray.Where(x => !string.IsNullOrEmpty(x)).ToArray();

            return new List<string>(categoriesArray);
        }

        public void SaveItemCategoriesToTxt(List<string> categories, string dataPath)
        {
            string path = dataPath + "\\categories.txt";
            File.WriteAllLines(path, categories);
        }

        public ItemList ParseContent(string content)
        {
            ItemList items = new ItemList();

            string itemPattern = @"item\s+([\w\d_]+)\s*\{([\s\S]*?)\}";
            string categoryPattern = @"DisplayCategory\s*=\s*([\w\d]+)";
            string namePattern = @"DisplayName\s*=\s*(.+?)(,|\s*$)";

            var matches = Regex.Matches(content, itemPattern);

            foreach (Match match in matches)
            {
                string itemBlock = match.Groups[2].Value;

                var categoryMatch = Regex.Match(itemBlock, categoryPattern);
                string categoryString = categoryMatch.Success ? categoryMatch.Groups[1].Value : "Unknown";
                ItemCategory category = Enum.TryParse(categoryString, true, out ItemCategory parsedCategory)
                    ? parsedCategory
                    : ItemCategory.Unknown;

                var nameMatch = Regex.Match(itemBlock, namePattern);
                string name = nameMatch.Success ? nameMatch.Groups[1].Value : "Unnamed";

                items.AddItem(new Item(category,name));
            }
            return items;
        }
    }
}
