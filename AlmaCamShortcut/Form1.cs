using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlmaCamShortcut
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            List<string> shortcutslist = Import_Tools.GetShortcutList();
            this.LB_Server_List.DataSource = shortcutslist;
        }

        private void BT_open_WPM_Click(object sender, EventArgs e)
        {
            string almacamPath = Import_Tools.GetAlmaCamPath();

            Process.Start(@almacamPath + "\\wpm.ini");
        }

        private void BT_open_AlmaCam_Click(object sender, EventArgs e)
        {

            string almacamPath = Import_Tools.GetAlmaCamPath();

            Import_Tools.serverSubstitute(this.LB_Server_List.SelectedItem.ToString());

            Process.Start(almacamPath + "\\Wpm.Implement.Editor.exe");

        }
    }


    static class Import_Tools
    {
        public static string GetAlmaCamPath()
        {  // a faire
            //get infos from registry Ordinateur\HKEY_CURRENT_USER\Software\Alma\ACSE\Settings
            return @"C:\AlmaCAM\Bin";
        }
        public static List<string> GetShortcutList()
        {
            List<string> servers = new List<string>();
            string wpmpath= Import_Tools.GetAlmaCamPath()+"\\wpm.ini";
            using (StreamReader wpmini = new StreamReader(@wpmpath))
            {
                while (!wpmini.EndOfStream)
                {
                    string line = wpmini.ReadLine();
                    if (line.Contains("##SHORTCUT:")){
                        
                      
                        if (line.Split(':').Count() == 4) {
                            servers.Add(line.Split(':')[1].Trim()+":"+ line.Split(':')[2].Trim());
                        }
                    }
                        
                }

            }

                return servers;
        }
        public static void serverSubstitute(string selected_server)
        {
            //utiliser les ini /// mùais c'est chiant de le refaire.. prendre ma lib si besoin
          
            string wpmpath = Import_Tools.GetAlmaCamPath() + "\\wpm.ini";
            string newserver = selected_server.Split(':')[0];
            string portnumber = selected_server.Split(':')[1];
            if (File.Exists(wpmpath + ".tmp"))
            {
                File.Delete(wpmpath+".tmp");
            }
            if (File.Exists(wpmpath))
            {
                File.Copy(wpmpath, wpmpath + ".tmp");
                File.Delete(wpmpath);
            }

            using (var input = File.OpenText(wpmpath + ".tmp"))
                
            using (var output = new StreamWriter(wpmpath))
            {
                string line;
                while (null != (line = input.ReadLine()))
                {
                    // optionally modify line.

                    if (line.StartsWith("Name="))
                    {


                        if (line.Split('=').Count() == 2)
                        {
                            output.WriteLine("Name=" + newserver);

                        }



                    }
                    else if(line.StartsWith("Port="))
                    {
                        output.WriteLine("Port=" + portnumber);
                    }
                    else
                    {

                        output.WriteLine(line.Trim());
                    }

                }

            }

           





        }
        

    }
}
