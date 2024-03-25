namespace IdleGameCodes;

public partial class Form1 : Form
{
    string vrchatLogFileLocation = $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\..\\LocalLow\\VRChat\\VRChat";

    public Form1()
    {
        InitializeComponent();
        logPathTextBox.Text = vrchatLogFileLocation;

        searchTermComboBox.Items.AddRange(new string[]
        {
            "IDLEDEFENSE",
            "IDLEHOME"
        });
        searchTermComboBox.SelectedIndex = 0;

        savesDataGridView.AutoGenerateColumns = false;
        savesDataGridView.Columns.Add(new DataGridViewColumn()
        {
            Name = "SaveDate",
            DataPropertyName = "SaveDate",
            HeaderText = "Save Date",
            Width = savesDataGridView.Width / 4,
            AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
            CellTemplate = new DataGridViewTextBoxCell()
        });
        savesDataGridView.Columns.Add(new DataGridViewColumn()
        {
            Name = "SaveString",
            DataPropertyName = "SaveString",
            HeaderText = "Save String",
            Width = (savesDataGridView.Width / 4) * 3,
            AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
            CellTemplate = new DataGridViewTextBoxCell()
        });
    }

    private void SearchLogFiles()
    {
        List<FileDetails> fileDetails = GetFileDetails();

        string searchTerm = "IDLEDEFENSE";
        if (searchTermComboBox.SelectedItem is not null)
        {
            searchTerm = (string)searchTermComboBox.SelectedItem;
        }

        List<Saves> saves = new List<Saves>();
        foreach (FileDetails file in fileDetails)
        {
            for (int i = file.Lines.Count - 1; i >= 0; i--)
            {
                if (file.Lines[i].Contains(searchTerm))
                {
                    string[] dateParts = file.Lines[i - 1].Split(" ");
                    saves.Add(new Saves()
                    {
                        SaveDate = DateTime.Parse($"{dateParts[0]} {dateParts[1]}"),
                        SaveString = file.Lines[i]
                    });
                }
            }
        }

        savesDataGridView.DataSource = saves.OrderByDescending(x => x.SaveDate).ToList();
    }

    private List<FileDetails> GetFileDetails()
    {
        string[] files = Directory.GetFiles(logPathTextBox.Text, "*.txt", SearchOption.TopDirectoryOnly);

        List<FileDetails> fileDetails = new();
        foreach (string file in files)
        {
            FileDetails details = new(file);
            try
            {
                details.GetFileInfo();
                if (details.FileInfo is null)
                {
                    Console.WriteLine($"Unable to get file info for: {file}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurrred while trying to get the file info for: {file}");
                Console.WriteLine(ex.Message);
            }

            try
            {
                details.ReadFile();
                if (details.Lines.Count <= 0)
                {
                    Console.WriteLine($"Log file is empty: {file}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurrred while trying to read the log file: {file}");
                Console.WriteLine(ex.Message);
            }

            fileDetails.Add(details);
        }

        return fileDetails = fileDetails.OrderBy(x => x.FileInfo?.CreationTime).ToList();
    }

    private void chooseFolderButton_Click(object sender, EventArgs e)
    {
        folderBrowserDialog1.RootFolder = Environment.SpecialFolder.ApplicationData;
        folderBrowserDialog1.InitialDirectory = vrchatLogFileLocation;
        DialogResult dr = folderBrowserDialog1.ShowDialog();
        if (dr == DialogResult.OK)
        {
            logPathTextBox.Text = folderBrowserDialog1.SelectedPath;
        }
    }

    private void findSavesButton_Click(object sender, EventArgs e)
    {
        SearchLogFiles();
    }
}