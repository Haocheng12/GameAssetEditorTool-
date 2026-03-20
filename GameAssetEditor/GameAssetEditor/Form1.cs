using System.Text.Json;
using System.Text.Json.Serialization;

namespace GameAssetEditor
{
    public partial class Form1 : Form
    {
        private List<GameItem> items = new List<GameItem>();
        private string currentFilePath = "items.json";
        public Form1()
        {
            InitializeComponent();
            lstItems.SelectedIndexChanged += LstItems_SelectedIndexChanged;
            btnLoad.Click += btnLoad_Click;
            btnSave.Click += btnSave_Click;
            btnApply.Click += BtnApply_Click;
            btnAdd.Click += btnAdd_Click;
            btnDelete.Click += btnDelete_Click;
        }

        private void btnLoad_Click(object? sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(currentFilePath))
                {
                    MessageBox.Show($"Could not find {currentFilePath}");
                    return;
                }
                string json = File.ReadAllText(currentFilePath);
                items = JsonSerializer.Deserialize<List<GameItem>>(json) ?? new List<GameItem>();
                RefreshItemList();
                if (items.Count > 0)
                {
                    lstItems.SelectedIndex = 0;
                }
                MessageBox.Show("Item load Successfully");

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error Loading File: " + ex.Message);
            }
        }

       

        private void btnSave_Click(object? sender, EventArgs e)
        {
            try
            {
                string json = JsonSerializer.Serialize(items, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(currentFilePath, json);
                MessageBox.Show("Items saved successfully.");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error saving File: " + ex.Message);
            }
        }

        private void BtnApply_Click(object? sender, EventArgs e)
        {
            if (lstItems.SelectedIndex < 0 || lstItems.SelectedIndex >= items.Count)
            {
                MessageBox.Show("Please select an item first.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Name cannot be empty.");
                return;
            }
            GameItem selectItem = items[lstItems.SelectedIndex];
            selectItem.Name = txtName.Text.Trim();
            selectItem.Type = txtType.Text.Trim();
            selectItem.Value = (int)numValue.Value;
            selectItem.Description = txtDescription.Text.Trim();

            RefreshItemList();
            lstItems.SelectedIndex = items.IndexOf(selectItem);
            MessageBox.Show("Changes applied.");

        }
        private void btnAdd_Click(object? sender, EventArgs e)
        {
            GameItem newItem = new GameItem
            {
                Name = "New Item",
                Type = "Unknown",
                Value = 0,
                Description = ""
            };

            items.Add(newItem);
            RefreshItemList();
            lstItems.SelectedIndex = items.Count - 1;
        }
        private void btnDelete_Click(object? sender, EventArgs e)
        {
            if (lstItems.SelectedIndex < 0 || lstItems.SelectedIndex >= items.Count)
            {
                MessageBox.Show("Please select an item to delete.");
                return;
            }

            var result = MessageBox.Show(
                "Are you sure you want to delete this item?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
            {
                return;
            }

            int selectedIndex = lstItems.SelectedIndex;
            items.RemoveAt(selectedIndex);

            RefreshItemList();

            if (items.Count > 0)
            {
                lstItems.SelectedIndex = Math.Min(selectedIndex, items.Count - 1);
            }
            else
            {
                txtName.Text = "";
                txtType.Text = "";
                numValue.Value = numValue.Minimum;
                txtDescription.Text = "";
            }
        }
        private void LstItems_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (lstItems.SelectedIndex < 0 || lstItems.SelectedIndex >= items.Count)
            {
                return;
            }

            GameItem selectedItem = items[lstItems.SelectedIndex];
            txtName.Text = selectedItem.Name;
            txtType.Text = selectedItem.Type;
            numValue.Value = selectedItem.Value;
            txtDescription.Text = selectedItem.Description;
        }
        
        private void RefreshItemList()
        {
            lstItems.DataSource = null;
            lstItems.DataSource = items;
        }
    }
}
