using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DummyDataGenerator
{
    public partial class MainForm : Form
    {
        private string[] files;
        private List<Dictionary<string, string>> parsedObjects;


        public MainForm()
        {
            InitializeComponent();
            ReadJsonFiles();
            SetVisibility(false);
        }

        private void ReadJsonFiles()
        {
            string documents = Path.Combine(
                     Path.GetDirectoryName(Application.ExecutablePath),
                     "JsonData"
                   );
            if (documents != string.Empty)
            {
                try
                {
                    files = Directory.GetFiles(documents);
                    parsedObjects = ConvertHelper.GetProperties(files);
                    if (parsedObjects != null)
                        GenerateCheckboxList();
                }
                catch (DirectoryNotFoundException)
                {
                    MessageBox.Show("could't find the directory");
                }
            }
        }

        private void GenerateCheckboxList()
        {
            if (parsedObjects.Count != 0)
            {
                var data = parsedObjects.SelectMany(p => p).Select(p => p.Key).Distinct();
                if (data.Any())
                {
                    List<CheckboxModel> chkList = new List<CheckboxModel>();
                    foreach (var item in data.ToList())
                    {
                        chkList.Add(
                            new CheckboxModel() { DisplayMember = item, ValueMember = item }
                            );
                    }
                    ((ListBox)this.chkJsonModels).DataSource = chkList;
                    ((ListBox)this.chkJsonModels).DisplayMember = "DisplayMember";
                    ((ListBox)this.chkJsonModels).ValueMember = "ValueMember";
                }
            }
        }

        private void chkIncludeKey_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIncludeKey.Checked)
            {
                radioGUID.Checked = true;
                SetVisibility(true);
            }
            else
            {
                radioGUID.Checked = false;
                SetVisibility(false);
            }
        }

        private void SetVisibility(bool isVisible)
        {
            radioGUID.Visible = isVisible;
            radioINT.Visible = isVisible;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == global::DummyDataGenerator.Properties.Settings.Default.SQLScript)
            {
                List<Dictionary<string, string>> objectsToSend = new List<Dictionary<string, string>>();
                if (txtTableName.Text != string.Empty && numAmount.Value != 0 && chkJsonModels.CheckedItems.Count != 0)
                {
                    for (int i = 0; i < chkJsonModels.CheckedIndices.Count; i++)
                    {
                        var indexi = chkJsonModels.CheckedIndices[i];
                        objectsToSend.AddRange(parsedObjects.Where(p => p.Keys.Contains((chkJsonModels.Items[indexi] as CheckboxModel).ValueMember)).ToList());
                    }
                    IExportType type = DataGenerator.GenerateSQLData(objectsToSend, Int32.Parse(numAmount.Value.ToString()), txtTableName.Text, chkIncludeInsert.Checked, radioGUID.Checked, radioINT.Checked);
                    SaveFile(type, "SQL Files | *.sql");
                }
                else
                    MessageBox.Show("Please make sure table name & amount text is valid & selections");
            }
            else
            {
                List<Dictionary<string, string>> objectsToSend = new List<Dictionary<string, string>>();
                if (numAmount.Value != 0 && chkJsonModels.CheckedItems.Count != 0)
                {
                    for (int i = 0; i < chkJsonModels.CheckedIndices.Count; i++)
                    {
                        var indexi = chkJsonModels.CheckedIndices[i];
                        objectsToSend.AddRange(parsedObjects.Where(p => p.Keys.Contains((chkJsonModels.Items[indexi] as CheckboxModel).ValueMember)).ToList());
                    }
                    IExportType type = DataGenerator.GenerateJsonData(objectsToSend, Int32.Parse(numAmount.Value.ToString()));
                    SaveFile(type, "JSON Files | *.json");
                }
                else
                    MessageBox.Show("amount text is valid & selections");
            }
        }

        private void SaveFile(IExportType saveData, string extension)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = extension;
                saveFileDialog.ShowDialog();
                File.WriteAllText(saveFileDialog.FileName, saveData.FileData);
            }
        }
    }
}
