using System.IO.Compression;
using System.Linq;

namespace FolderMerger
{
    public partial class Form1 : Form
    {
        private static string? _source1FolderName;
        private static string? _source2FolderName;
        private static string? _destinationFolderPath;
        private static Dictionary<string,List<string>> _sourceFolders = new Dictionary<string, List<string>>();
        private readonly SynchronizationContext synchronizationContext;
        public Form1()
        {
            InitializeComponent();
            synchronizationContext = SynchronizationContext.Current;
        }

        private void SelectSrc1_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    Source1Path.Text = fbd.SelectedPath;
                    _source1FolderName = fbd.SelectedPath.Substring(fbd.SelectedPath.LastIndexOf("\\")+1);
                    string[] folders = Directory.GetDirectories(fbd.SelectedPath);
                    _sourceFolders.Add(_source1FolderName,new List<string>());
                    _sourceFolders[_source1FolderName] = folders.ToList();
                }
            }
        }

        private void SelectSrc2_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    Source2Path.Text = fbd.SelectedPath;
                    _source2FolderName = fbd.SelectedPath.Substring(fbd.SelectedPath.LastIndexOf("\\") + 1);
                    string[] folders = Directory.GetDirectories(fbd.SelectedPath);
                    _sourceFolders.Add(_source2FolderName, new List<string>());
                    _sourceFolders[_source2FolderName] = folders.ToList();
                }
            }
        }

        private void SelectDestBtn_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {    
                    DestPath.Text = fbd.SelectedPath;
                    _destinationFolderPath = fbd.SelectedPath;
                }
            }
        }

        private async void Merge_Click(object sender, EventArgs e)
        {
            if(_sourceFolders.Count == 0 || string.IsNullOrEmpty(_source1FolderName)|| string.IsNullOrEmpty(_source2FolderName))
            {
                MessageBox.Show("Please set the paths appropriately");
                return;
            }
            bool result = false;
            List<string> source1Folders = _sourceFolders[_source1FolderName].ToList();
            List<string> source2Folders = _sourceFolders[_source2FolderName].ToList();
            int count = 0;

            LogBox.Text += String.Format(DateTime.Now.ToString()+ ": Merging of folders has started." + Environment.NewLine+ "The Source 1 path is :{0} " + Environment.NewLine + "The Source 2 path is : {1} " + Environment.NewLine + "The Destination path is : {2} "+ Environment.NewLine+"", Source1Path.Text, Source2Path.Text, DestPath.Text);

            foreach(string folder in source1Folders)
            {
                if (source2Folders.FindAll(x => x.Substring(x.LastIndexOf("\\") + 1) == folder.Substring(folder.LastIndexOf("\\") + 1)).Count() > 0)
                    count++;
            }
            progressBar.Minimum = 1;
            progressBar.Maximum = (count * 2)-1;
            progressBar.Step = 1;
            progressBar.Visible = true;


            foreach (string source1Folder in source1Folders)
            {
                foreach (string source2Folder in source2Folders)
                {
                    if (source1Folder.Substring(source1Folder.LastIndexOf("\\") + 1).ToLower() == (source2Folder.Substring(source2Folder.LastIndexOf("\\") + 1)).ToLower())
                    {
                        await CopyFilesRecursively(source1Folder, source2Folder);
                    }
                }
            }

            MessageBox.Show("Merge Complete");
            LogBox.Text += DateTime.Now.ToString() + ": Merging of folders complete, clearing the set paths." + Environment.NewLine+"";
            Thread.Sleep(2000);
            progressBar.Hide();
            ClearItems();
        }

            
        private async Task CopyFilesRecursively(string source1, string source2)
        {
            try
            {
                await Task.Run(() =>
                {
                    string newPath = _destinationFolderPath + "\\" + (source1.Substring(source1.LastIndexOf("\\") + 1));
                    DirectoryInfo source1Dir = new DirectoryInfo(source1);
                    DirectoryInfo source2Dir = new DirectoryInfo(source2);
                    DirectoryInfo targetDir = new DirectoryInfo(newPath);
                    FileInfo[] Filenames = source1Dir.GetFiles();
                    string folderName = source1.Substring(source1.LastIndexOf("\\")+1);
                    //Now Create all of the directories
                    Directory.CreateDirectory(newPath);
                    
                    //Copy all the files & Replaces any files with the same name
                    foreach (FileInfo file in source1Dir.GetFiles())
                    {
                        FileInfo[] existingFile = targetDir.GetFiles(file.Name);
                        if (existingFile.Count() == 0)
                            file.CopyTo(Path.Combine(targetDir.FullName, file.Name), true);
                    }
                    UpdateUI(String.Format(DateTime.Now.ToString() + ": Copied {0} files from {1} to {2}" + Environment.NewLine + "", source1Dir.GetFiles().Length, Source1Path.Text + "\\" + folderName, DestPath.Text + "\\" + folderName));
                    foreach (FileInfo file in source2Dir.GetFiles())
                    {
                        FileInfo[] existingFile = targetDir.GetFiles(file.Name);
                        if (existingFile.Count() == 0)
                            file.CopyTo(Path.Combine(targetDir.FullName, file.Name), true);
                    }
                    folderName = source2.Substring(source2.LastIndexOf("\\") + 1);
                    UpdateUI(String.Format(DateTime.Now.ToString() + ": Copied {0} files from {1} to {2}" + Environment.NewLine + "", source2Dir.GetFiles().Length, Source2Path.Text+ "\\" + folderName, DestPath.Text + "\\" + folderName));

                });

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during merging..");
            }
        }
        private void ClearItems()
        {
            Source1Path.Text = string.Empty;
            Source2Path.Text = string.Empty;
            DestPath.Text = string.Empty;   
            _source1FolderName = string.Empty;
            _source2FolderName = string.Empty;
            _destinationFolderPath = string.Empty;
            _sourceFolders.Clear();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        public void UpdateUI(string value)
        {
            synchronizationContext.Post(new SendOrPostCallback(o =>
            {
                LogBox.Text += value;
                progressBar.PerformStep();
            }), value);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LogBox.Text=String.Empty;
        }
    }
}