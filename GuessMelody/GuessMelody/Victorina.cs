using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace GuessMelody
{
    static class Victorina
    {
        static public List<string> list = new List<string>();
        static public int gameDuration = 60;
        static public int timeForAnswer = 10;
        static public int musicDuration = 10;
        static public bool ransomStart = false;
        static public string lastFoder = "";
        static public bool allDirectories = false;
        private static string redKeyName = "Software\\MyCompany\\Guessthemelody";
        static public string answer = "";

        static public void ReadMusic()
        {
            try
            {
                string[] music_list = System.IO.Directory.GetFiles(lastFoder, "*.mp3",
                    allDirectories ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
                list.Clear();
                list.AddRange(music_list);
            }
            catch
            {
            }
        }

        public static void WriteParams()
        {
            RegistryKey rk = null;
            try
            {
                rk = Registry.CurrentUser.CreateSubKey(redKeyName);

                if(rk==null)
                    return;
                rk.SetValue("LastFolder", lastFoder);
                rk.SetValue("RandomStart", ransomStart);
                rk.SetValue("GameDuration", gameDuration);
                rk.SetValue("MusicDuration", musicDuration);
                rk.SetValue("AllDirectories", allDirectories);
                rk.SetValue("TimeForAnswer", timeForAnswer);

            }
            finally 
            {
                if(rk!=null)
                    rk.Close();
            }
        }

        public static void ReadParams()
        {
            RegistryKey rk = null;
            try
            {
                rk = Registry.CurrentUser.OpenSubKey(redKeyName);

                if (rk != null)
                {
                    lastFoder = (string)rk.GetValue("LastFolder");
                    ransomStart = Convert.ToBoolean(rk.GetValue("RandomStart"));
                    gameDuration = (int)rk.GetValue("GameDuration");
                    musicDuration = (int)rk.GetValue("MusicDuration");
                    timeForAnswer = (int)rk.GetValue("TimeForAnswer");
                    allDirectories = Convert.ToBoolean(rk.GetValue("AllDirectories"));
                }
               

            }
            finally
            {
                if (rk != null)
                    rk.Close();
            }
        }
    }
}
