﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PRM.Core.Properties;
using PRM.Core.Protocol.Runner;

namespace PRM.Core.Protocol
{
    public class ProtocolConfig
    {
        public string SelectedRunnerName { get; set; }
        public List<Runner.Runner> Runners { get; set; }



        [JsonIgnore]
        public Type ProtocolType { get; private set; }

        /// <summary>
        /// All macros name
        /// </summary>
        [JsonIgnore]
        public List<string> MarcoNames { get; private set; }
        /// <summary>
        /// All macros Descriptions
        /// </summary>
        [JsonIgnore]
        public List<string> MarcoDescriptions { get; private set; }

        /// <summary>
        /// Descriptions like:
        /// What A is -> %MarcoName1%
        /// What B is -> %MarcoName2%
        /// </summary>
        [JsonIgnore]
        public string GetAllDescriptions
        {
            get
            {
                var sb = new StringBuilder();
                for (int i = 0; i < MarcoNames.Count; i++)
                {
                    sb.AppendLine($@"%{MarcoDescriptions[i]}%      ->      {MarcoNames[i]}");
                }
                return sb.ToString();
            }
        }
        

        public ProtocolConfig()
        {
            Runners = new List<Runner.Runner>();
        }

        public void Init(List<string> marcoNames, List<string> marcoDescriptions, Type protocolType)
        {
            MarcoNames = marcoNames;
            MarcoDescriptions = marcoDescriptions;
            ProtocolType = protocolType;
        }
    }
}
