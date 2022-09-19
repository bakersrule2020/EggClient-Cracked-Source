using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MelonLoader;
using UnityEngine;
using VRC.Udon;

namespace EggClient.Eggsploits
{
    internal class UdonDumper
    {
        public static void LogUdon(string instanceID)
        {
            Directory.CreateDirectory(Path.Combine(Environment.CurrentDirectory, $"{instanceID}"));

            File.CreateText($"{instanceID}/UdonLog.txt");
                foreach (var gameObject in Resources.FindObjectsOfTypeAll<VRC.Udon.UdonBehaviour>())
                {
                new WaitForSeconds(1f);
                    File.AppendAllText($"{instanceID}/UdonLog.txt", gameObject.name + gameObject._eventTable + "\n");
              
            }
        }
    }
    
}
