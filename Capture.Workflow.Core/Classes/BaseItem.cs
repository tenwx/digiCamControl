﻿using System.Xml.Serialization;
using Capture.Workflow.Core.Interface;

namespace Capture.Workflow.Core.Classes
{
    public class BaseItem
    {
        public PluginInfo PluginInfo { get; set; }
        [XmlAttribute]
        public string Name { get; set; }
        public string SettingData { get; set; }
        public CustomPropertyCollection Properties { get; set; }
    }
}
