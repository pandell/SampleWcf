using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.ServiceModel.Activation;

namespace SampleWcf.Web
{

    /// <summary>
    /// </summary>
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class Call : IFileTracker
    {

        //**************************************************
        //* Interface IFileTracker implementation
        //**************************************************

        //--------------------------------------------------
        /// <summary>
        /// </summary>
        public void Track(IEnumerable<string> files)
        {
            Debugger.Log(0, null, string.Concat("--- Received files:", Environment.NewLine));
            if (files != null)
            {
                foreach (var file in files)
                {
                    Debugger.Log(0, null, string.Concat("File: \"", file, "\"", Environment.NewLine));
                }
            }
            Debugger.Log(0, null, string.Concat("--- Received files end", Environment.NewLine));
        }

    }

}
