using System;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Runtime.Serialization.Formatters.Binary;

namespace Doom_Manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Check if gzdoom next to launcher and at least one iwad
            if(File.Exists("gzdoom.exe") == false)
            {
                MessageBox.Show("No gzdoom.exe in launcher directory. Exiting...");
                System.Windows.Forms.Application.Exit();
            }
            else if(check_iwad_presence() == false)
            {
                MessageBox.Show("No iwads in launcher directory. Exiting...");
                System.Windows.Forms.Application.Exit();
            }
            //get all wad files that arent iwads into wad list
            string[] wad_files = System.IO.Directory.GetFiles(System.IO.Path.GetDirectoryName(Application.ExecutablePath), "*.wad");
            foreach (string wad in wad_files)
            {
                if(check_if_iwad(wad) == false)
                {
                    wad_list.Items.Add(Path.GetFileName(wad));
                }
            }
            //get all pk3 files into pk3 list
            string[] pk3_files = System.IO.Directory.GetFiles(System.IO.Path.GetDirectoryName(Application.ExecutablePath), "*.pk3");
            foreach (string pk3 in pk3_files)
            {
                if (check_if_iwad(pk3) == false)
                {
                    pk3_list.Items.Add(Path.GetFileName(pk3));
                }
            }
            //get all config files into list
            string[] config_files = System.IO.Directory.GetFiles(System.IO.Path.GetDirectoryName(Application.ExecutablePath), "*.config_dl");
            foreach (string config in config_files)
            {
                config_list.Items.Add(Path.GetFileName(config));
            }
            //everything is loaded
  
        }

        private bool check_iwad_presence()
        {
            string[] files = System.IO.Directory.GetFiles(System.IO.Path.GetDirectoryName(Application.ExecutablePath), "*.wad");
            foreach (string filepath in files)
            {
                if (check_if_iwad(filepath))
                {
                    return true;
                }
            }
            return false;
        }
        private bool check_if_iwad(string filepath)
        { 
            //ok so here instead of loading the entire file and then checking just the first 4 letters (cuz thats innefective)
            //I load only 4 first bytes and then check if once converted to utf they match with 'iwad'
            using (FileStream fileStream = new FileStream(filepath, FileMode.Open))
            {
                byte[] chunk = new byte[4];
                fileStream.Read(chunk, 0, 4);
                string Letters = System.Text.Encoding.UTF8.GetString(chunk);
                if (Letters == "IWAD")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private void wad_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            //update wad item movement buttons after clicking the list
            Wad_up.Enabled = (wad_list.SelectedIndex > 0);
            Wad_down.Enabled = (wad_list.SelectedIndex < wad_list.Items.Count - 1);
        }

        private void Wad_up_Click(object sender, EventArgs e)
        {
            int index = wad_list.SelectedIndex;
            object item = wad_list.SelectedItem;
            wad_list.Items.RemoveAt(wad_list.SelectedIndex);
            wad_list.Items.Insert(index - 1, item);
            wad_list.SelectedIndex = index - 1;
        }

        private void Wad_down_Click(object sender, EventArgs e)
        {
            int index = wad_list.SelectedIndex;
            object item = wad_list.SelectedItem;
            wad_list.Items.RemoveAt(wad_list.SelectedIndex);
            wad_list.Items.Insert(index + 1, item);
            wad_list.SelectedIndex = index + 1;
        }

        private void pk3_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            //update pk3 movement buttons after list click
            pk3_up.Enabled = (pk3_list.SelectedIndex > 0);
            pk3_down.Enabled = (pk3_list.SelectedIndex < pk3_list.Items.Count - 1);
        }

        private void pk3_up_Click(object sender, EventArgs e)
        {
            int index = pk3_list.SelectedIndex;
            object item = pk3_list.SelectedItem;
            pk3_list.Items.RemoveAt(pk3_list.SelectedIndex);
            pk3_list.Items.Insert(index - 1, item);
            pk3_list.SelectedIndex = index - 1;
        }

        private void pk3_down_Click(object sender, EventArgs e)
        {
            int index = pk3_list.SelectedIndex;
            object item = pk3_list.SelectedItem;
            pk3_list.Items.RemoveAt(pk3_list.SelectedIndex);
            pk3_list.Items.Insert(index + 1, item);
            pk3_list.SelectedIndex = index + 1;
        }

        private void save_Click(object sender, EventArgs e)
        {
            SaveConfig(config_input.Text);

            config_list.Items.Clear();

            //get all config files into list
            string[] config_files = System.IO.Directory.GetFiles(System.IO.Path.GetDirectoryName(Application.ExecutablePath), "*.config_dl");
            foreach (string config in config_files)
            {
                config_list.Items.Add(Path.GetFileName(config));
            }
        }

        private void Launch_Click_1(object sender, EventArgs e)
        {
            //User wants to launch gzdoom, time to check what addons he chose
            object[] pk3_files_ob = pk3_list.CheckedItems.OfType<object>().ToArray();
            string pk3_files = "";
            foreach (object o in pk3_files_ob)
            {
                pk3_files = pk3_files + " " + o.ToString();
            }

            object[] wad_files_ob = wad_list.CheckedItems.OfType<object>().ToArray();
            string wad_files = "";
            foreach (object o in wad_files_ob)
            {
                wad_files = wad_files + " " + o.ToString();
            }

            string files = pk3_files + " " + wad_files;

            if (Demo.Checked)
            {
                files = files + " -record " + DateTime.Now.ToString("dd:MMM:HH:mm:ss").Replace(":", "") + ".lmp";
            }

            if (Host.Checked)
            {
                files = files + " -host " + Number_players.Value.ToString();
            }

            if (Join.Checked)
            {
                files = files + " -join " + Ip_box.Text;
            }

            files = files + " " + commands.Text;

            SaveConfig("auto");

            Process.Start("gzdoom.exe", "-file " + files);
        }

        private void SaveConfig(string name)
        {
            object[] pk3_files_ob = pk3_list.CheckedItems.OfType<object>().ToArray();
            string pk3_files = "";
            foreach (object o in pk3_files_ob)
            {
                pk3_files = pk3_files  + o.ToString() + ";";
            }

            object[] wad_files_ob = wad_list.CheckedItems.OfType<object>().ToArray();
            string wad_files = "";
            foreach (object o in wad_files_ob)
            {
                wad_files = wad_files  + o.ToString() + ";";
            }

            string selected = pk3_files + "," + wad_files;

            pk3_files_ob = pk3_list.Items.OfType<object>().ToArray();
            pk3_files = "";
            foreach (object o in pk3_files_ob)
            {
                pk3_files = pk3_files  + o.ToString() + ";";
            }

            wad_files_ob = wad_list.Items.OfType<object>().ToArray();
            wad_files = "";
            foreach (object o in wad_files_ob)
            {
                wad_files = wad_files + o.ToString() + ";";
            }

            string general = pk3_files + "," + wad_files;

            string Data = general + "/" + selected;

            BinaryFormatter bf = new BinaryFormatter();
            using (MemoryStream ms = new MemoryStream())
            {
                bf.Serialize(ms, Data);
                File.WriteAllBytes(name+ ".config_dl", ms.ToArray());
            }

            
        }

        private void config_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            object item = config_list.SelectedItem;
            if(item == null)
            {
                return;
            }
            byte[] Data = File.ReadAllBytes(item.ToString());
            BinaryFormatter bf = new BinaryFormatter();
            string[] data_de = { };
            using (MemoryStream ms = new MemoryStream(Data))
            {
                data_de = ((string)bf.Deserialize(ms)).Split('/');
            }
   
            wad_list.Items.Clear();
            pk3_list.Items.Clear();
            string[] general = data_de[0].Split(',');
            string[] selected = data_de[1].Split(',');
            string[] pk3_items = general[0].Split(';');
            string[] wad_items = general[1].Split(';');
            string[] pk3_selected = selected[0].Split(';');
            string[] wad_selected = selected[1].Split(';');

            foreach (string wad_item in wad_items)
            {
                if(wad_item != "" && file_exists(wad_item))
                {
                    wad_list.Items.Add(wad_item, wad_selected.Contains(wad_item));
                }
                
            }
            foreach (string pk3_item in pk3_items)
            {
                if(pk3_item != "" && file_exists(pk3_item))
                {
                    pk3_list.Items.Add(pk3_item, pk3_selected.Contains(pk3_item));
                }
                
            }
            string[] wad_files = System.IO.Directory.GetFiles(System.IO.Path.GetDirectoryName(Application.ExecutablePath), "*.wad");
            foreach (string wad in wad_files)
            {
                if (check_if_iwad(wad) == false && wad_items.Contains(Path.GetFileName(wad)) == false)
                {
                    wad_list.Items.Add(Path.GetFileName(wad));
                }
            }
            //get all pk3 files into pk3 list
            string[] pk3_files = System.IO.Directory.GetFiles(System.IO.Path.GetDirectoryName(Application.ExecutablePath), "*.pk3");
            foreach (string pk3 in pk3_files)
            {
                if (check_if_iwad(pk3) == false && pk3_items.Contains(Path.GetFileName(pk3)) == false)
                {
                    pk3_list.Items.Add(Path.GetFileName(pk3));
                }
            }

        }

        private bool file_exists(string name)
        {
            string[] paths = Directory.GetFiles(System.IO.Path.GetDirectoryName(Application.ExecutablePath));
            foreach (string path in paths)
            {
                if(Path.GetFileName(path) == name)
                {
                    return true;
                }

            }
            return false;
        }

        private void Join_CheckedChanged(object sender, EventArgs e)
        {
            players_label.Visible = false;
            Number_players.Visible = false;
            Host.Checked = false;
            if(Join.Checked == true)
            {
                ip_label.Visible = true;
                Ip_box.Visible = true;
            }
            else
            {
                ip_label.Visible = false;
                Ip_box.Visible = false;
            }
        }

        private void Host_CheckedChanged(object sender, EventArgs e)
        {
            ip_label.Visible = false;
            Ip_box.Visible = false;
            Join.Checked = false;
            if (Host.Checked == true)
            {
                players_label.Visible = true;
                Number_players.Visible = true;
            }
            else
            {
                players_label.Visible = false;
                Number_players.Visible = false;
            }
        }
    }
}
