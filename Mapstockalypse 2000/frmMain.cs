using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Windows.Forms;

using ToxicRagers.Carmageddon.Helpers;
using ToxicRagers.Carmageddon2.Formats;

namespace Mapstockalypse_2000
{
    public partial class frmMain : Form
    {
        readonly List<string> tagLines = new List<string>
        {
            "Toxic Ragers?  Never heard of 'em",
            "Built with love by the one and only Toxic Ranger",
            "I bet you don't have the guts to click this",
            "Elephants?"
        };

        string currentRoot;
        string race;
        string mod;
        RacesTXT races;
        readonly List<RaceDetails> mods = new List<RaceDetails>();
        readonly Dictionary<int, string> modZips = new Dictionary<int, string>();

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblVersion.Text = $"v{Application.ProductVersion}";

            reloadUI(Directory.GetCurrentDirectory());
        }

        private void reloadUI(string root)
        {
            currentRoot = root;

            mods.Clear();
            modZips.Clear();
            lstRaces.Items.Clear();
            lstMods.Items.Clear();
            llToxicRagers.Text = tagLines[new Random().Next(tagLines.Count)];
            txtPath.Text = root;
            btnInstall.Text = "select a mod and a map to replace, then click here!";
            btnInstall.Enabled = false;

            string twtFile = Path.Combine(txtPath.Text, "data.twt");

            if (File.Exists(twtFile))
            {
                TWT twt = TWT.Load(twtFile);

                foreach (TWTEntry entry in twt.Contents)
                {
                    twt.Extract(entry, Path.Combine(txtPath.Text, "data"));
                }

                File.Move(twtFile, Path.Combine(txtPath.Text, "data.twat"));
            }

            string racesTXT = Path.Combine(txtPath.Text, "data", "races.txt");

            if (File.Exists(racesTXT))
            {
                races = RacesTXT.Load(Path.Combine(txtPath.Text, "data", "races.txt"));

                foreach (RaceDetails race in races.Races)
                {
                    if (!race.BoundaryRace) { lstRaces.Items.Add(race.Name); }
                }
            }

            string mapModDir = Path.Combine(txtPath.Text, ".mods", "maps");

            if (Directory.Exists(mapModDir))
            {
                foreach (string file in Directory.GetFiles(mapModDir, "*.zip"))
                {
                    using (FileStream fs = new FileStream(file, FileMode.Open))
                    using (ZipArchive archive = new ZipArchive(fs, ZipArchiveMode.Read))
                    {
                        if (archive.Entries.Any(f => f.Name.EndsWith(".c2t", StringComparison.InvariantCultureIgnoreCase)) &&
                            archive.Entries.Any(f => f.Name == "" && f.FullName.ToLower() == @"data/races/"))
                        {
                            ZipArchiveEntry entry = archive.Entries.First(f => f.Name.EndsWith(".c2t", StringComparison.InvariantCultureIgnoreCase));

                            using (MemoryStream ms = new MemoryStream())
                            using (BinaryReader br = new BinaryReader(ms))
                            {
                                entry.Open().CopyTo(ms);

                                ms.Seek(0, SeekOrigin.Begin);

                                RaceDetails details = RaceDetails.Load(new DocumentParser(br));

                                int index = lstMods.Items.Add(details.Name);

                                modZips.Add(index, file);
                                mods.Add(details);
                            }
                        }
                    }
                }
            }

            foreach (string file in Directory.GetFiles(txtPath.Text, "*.c2t"))
            {
                RaceDetails details = RaceDetails.Load(new DocumentParser(file));

                if (!mods.Any(m => m.Name == details.Name))
                {
                    lstMods.Items.Add(details.Name);
                    mods.Add(details);
                }
            }
        }

        private void updateAction()
        {
            btnInstall.Text = $"replace {race} with {mod}";

            if (!string.IsNullOrEmpty(race) && !string.IsNullOrEmpty(mod))
            {
                btnInstall.Enabled = true;
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (fbdBrowse.ShowDialog() == DialogResult.OK && Directory.Exists(fbdBrowse.SelectedPath))
            {
                reloadUI(fbdBrowse.SelectedPath);
            }
        }

        private void lstRaces_SelectedIndexChanged(object sender, EventArgs e)
        {
            race = lstRaces.GetItemText(lstRaces.SelectedItem);

            updateAction();
        }

        private void lstMods_SelectedIndexChanged(object sender, EventArgs e)
        {
            mod = lstMods.GetItemText(lstMods.SelectedItem);

            updateAction();
        }

        private void llToxicRagers_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            llToxicRagers.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.toxic-ragers.co.uk");
        }

        private void btnInstall_Click(object sender, EventArgs e)
        {
            bool success = false;

            RaceDetails oldRace = races.Races[lstRaces.SelectedIndex];
            RaceDetails newRace = mods[lstMods.SelectedIndex];

            string oldRaceName = Path.GetFileNameWithoutExtension(oldRace.RaceFilename);
            string newRaceName = Path.GetFileNameWithoutExtension(newRace.RaceFilename);

            // extract archive (if installing from one)
            if (modZips.ContainsKey(lstMods.SelectedIndex))
            {
                using (ZipArchive archive = ZipFile.OpenRead(modZips[lstMods.SelectedIndex]))
                {
                    foreach (ZipArchiveEntry entry in archive.Entries)
                    {
                        if (entry.Name == "") { continue; }

                        string destinationPath = Path.GetFullPath(Path.Combine(txtPath.Text, entry.FullName));

                        if (destinationPath.StartsWith(txtPath.Text, StringComparison.Ordinal)) 
                        {
                            if (File.Exists(destinationPath)) { File.Delete(destinationPath); }

                            entry.ExtractToFile(destinationPath); 
                        }
                    }
                }
            }

            // validate installation by checking MapFilename exists
            if (Directory.Exists(Path.Combine(txtPath.Text, "data", "races", newRaceName)))
            {
                success = File.Exists(Path.Combine(txtPath.Text, "data", "races", newRaceName, $"{newRaceName}.txt"));
            }
            else
            {
                if (File.Exists(Path.Combine(txtPath.Text, "data", "races", $"{newRaceName}.twt")))
                {
                    TWT twt = TWT.Load(Path.Combine(txtPath.Text, "data", "races", $"{newRaceName}.twt"));

                    success = twt.Contents.Any(entry => string.Compare(entry.Name, $"{newRaceName}.txt", true) == 0);
                }
            }

            if (success)
            {
                // create c2t file for track to be replaced
                using (DocumentWriter dw = new DocumentWriter(Path.Combine(txtPath.Text, $"{oldRaceName}.c2t")))
                {
                    oldRace.Write(dw);
                }

                // update races.txt
                races.Races[lstRaces.SelectedIndex] = newRace;
                File.Delete(Path.Combine(txtPath.Text, "data", "races.old"));
                File.Move(Path.Combine(txtPath.Text, "data", "races.txt"), Path.Combine(txtPath.Text, "data", "races.old"));
                races.Save(Path.Combine(txtPath.Text, "data", "races.txt"));

                reloadUI(currentRoot);
            }
        }
    }
}
