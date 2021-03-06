﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.IO;
using BepInEx;
using SideLoader;
using HarmonyLib;

namespace SharedModConfig
{
    [BepInPlugin(GUID, ModName, ModVersion)]
    [BepInDependency(SLPlugin.GUID, BepInDependency.DependencyFlags.HardDependency)]
    public class SharedModConfig : BaseUnityPlugin
    {
        public const string GUID = "com.sinai.SharedModConfig";
        public const string ModName = "SharedModConfig";
        public const string ModVersion = "2.0";

        internal void Awake()
        {
            var obj = new GameObject(ModName);
            GameObject.DontDestroyOnLoad(obj);

            obj.AddComponent<ConfigManager>();
            obj.AddComponent<ModMenuManager>();

            var harmony = new Harmony(GUID);
            harmony.PatchAll();
        }
    }
}
