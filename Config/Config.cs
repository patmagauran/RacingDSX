using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RacingDSX.Config
{
    public class Config
    {
        public bool DisableAppCheck { get; set; }
        public VerboseLevel VerboseLevel { get; set; } = VerboseLevel.Off;
        public Dictionary<String, Profile> Profiles { get; set; } = new Dictionary<String, Profile>();
        [JsonIgnore]
        public Profile ActiveProfile { get; set; } = null;

        public int DSXPort { get; set; } = 6969; // This sets the default dsx port

        public List<String> DSXIPs { get; set; } = new List<string> { "127.0.0.1" }; // This sets the default dsx ip address

        public int SelectedDSXIP { get; set; } = 0; // This sets the default selected dsx ip address

        public String DefaultProfile { get; set; } = "Forza";
    }
}
