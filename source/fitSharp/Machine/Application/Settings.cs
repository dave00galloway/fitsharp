// Copyright � 2013 Syterra Software Inc. All rights reserved.
// The use and distribution terms for this software are covered by the Common Public License 1.0 (http://opensource.org/licenses/cpl.php)
// which can be found in the file license.txt at the root of this distribution. By using this software in any fashion, you are agreeing
// to be bound by the terms of this license. You must not remove this notice, or any other, from this software.

using System.Configuration;
using fitSharp.Machine.Model;

namespace fitSharp.Machine.Application {
    public class Settings: Copyable {
        private static readonly string appSettingsBehavior;
        static Settings() {
            appSettingsBehavior = ConfigurationManager.AppSettings["fitVersion"];
        }

        private const int DefaultCodePage = 1252;

        public string ApartmentState { get; set; }
        public string CodePage { get; set; }
        public string InputFolder { get; set; }
        public string OutputFolder { get; set; }
        public string Runner { get; set; }
        public string XmlOutput { get; set; }
        public string Behavior { get; set; }
        public bool DryRun { get; set; }
        public string TagList { get; set; }
        public int WaitTime { get; set; }

        public int CodePageNumber {
            get {
                int result = DefaultCodePage;
                if (CodePage != null) int.TryParse(CodePage, out result);
                return result;
            }
        }

        public bool IsStandard { get { return BehaviorHas("std"); } }

        public bool BehaviorHas(string keyword) {
            return Behavior != null && Behavior.ToLower().IndexOf(keyword) >= 0;
        }

        public Settings() {
            Behavior = appSettingsBehavior;
        }

        public Settings(Settings other) {
            ApartmentState = other.ApartmentState;
            Behavior = other.Behavior;
            CodePage = other.CodePage;
            InputFolder = other.InputFolder;
            OutputFolder = other.OutputFolder;
            Runner = other.Runner;
            XmlOutput = other.XmlOutput;
            DryRun = other.DryRun;
            TagList = other.TagList;
            WaitTime = other.WaitTime;
        }

        public Copyable Copy() {
            return new Settings(this);
        }
    }
}
