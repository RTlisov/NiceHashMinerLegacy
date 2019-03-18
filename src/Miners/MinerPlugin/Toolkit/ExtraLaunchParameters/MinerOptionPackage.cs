using NiceHashMinerLegacy.Common.Enums;
using System;
using System.Collections.Generic;

namespace MinerPlugin.Toolkit.ExtraLaunchParameters
{
    public class MinerOptionPackage
    {
        public bool OverrideUserSettings;
        public List<MinerOption> GeneralOptions;
        public List<MinerOption> TemperatureOptions;

        public MinerOptionPackage(bool iOverrideSettings, List<MinerOption> iGeneralOptions, List<MinerOption> iTemperatureOptions)
        {
            OverrideUserSettings = iOverrideSettings;
            GeneralOptions = iGeneralOptions;
            TemperatureOptions = iTemperatureOptions;
        }

        public MinerOptionPackage(List<MinerOption> iGeneralOptions)
            : this(false, iGeneralOptions, new List<MinerOption>()) //default override is false?
        { }

        // For JSON deserialization
        public MinerOptionPackage()
        { }
    }
}
