using EgguWare;
using EgguWare.Utilities;
using SDG.Framework.Modules;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace EgguWare
{
    public class Load : IModuleNexus
    {
        public static GameObject CO;
        public static void Start()
        {
            //create new gameobject
            CO = new GameObject();
            UnityEngine.Object.DontDestroyOnLoad(CO);
            //let manager use the unity functions
            CO.AddComponent<Manager>();
        }

        public void initialize()
        {
            Start();
        }

        public void shutdown()
        {
        }
    }
}