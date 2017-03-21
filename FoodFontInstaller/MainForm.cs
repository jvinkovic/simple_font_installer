using Microsoft.Win32;
using System;
using System.Drawing.Text;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FoodFontInstaller
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void InstallFont(string fontPath)
        {
            Shell32.Shell shell = new Shell32.Shell();
            Shell32.Folder fontFolder = shell.NameSpace(0x14);
            fontFolder.CopyHere(fontPath);
        }

        [DllImport("gdi32", EntryPoint = "AddFontResource")]
        public static extern int AddFontResourceA(string lpFileName);

        [DllImport("gdi32.dll")]
        private static extern int AddFontResource(string lpszFilename);

        [DllImport("gdi32.dll")]
        private static extern int CreateScalableFontResource(uint fdwHidden, string
        lpszFontRes, string lpszFontFile, string lpszCurrentPath);

        /// <summary>
        /// Installs font on the user's system and adds it to the registry so it's available on the next session
        /// </summary>
        /// <param name="contentFontName">Your font to be passed as a resource (i.e. "myfont.tff")</param>
        private static void RegisterFont(string fontPath, string contentFontName)
        {
            // Creates the full path where your font will be installed
            var fontDestination = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), contentFontName);

            if (!File.Exists(fontDestination))
            {
                // Copies font to destination
                File.Copy(fontPath, fontDestination);

                // Retrieves font name
                // Makes sure you reference System.Drawing
                PrivateFontCollection fontCol = new PrivateFontCollection();
                fontCol.AddFontFile(fontDestination);
                var actualFontName = fontCol.Families[0].Name;

                //Add font
                AddFontResource(fontDestination);
                //Add registry entry
                Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Fonts", actualFontName, contentFontName, RegistryValueKind.String);
            }
        }

        private void label_Click(object sender, EventArgs e)
        {
            label.Visible = false;
            labelInstalling.Visible = true;

            foreach (var f in Directory.GetFiles("Fonts"))
                RegisterFont(f, f.Substring(f.LastIndexOf("\\") + 1));

            MessageBox.Show("Fonts installed!");
            Close();
        }
    }
}