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
        public void Track(IEnumerable<FileDescriptor> files)
        {
            Debugger.Log(0, null, string.Concat("--- Received files:", Environment.NewLine));
            if (files != null)
            {
                foreach (var file in files)
                {
                    Debugger.Log(0, null, string.Concat("File: \"", file.Name, "\" has length ", file.Contents == null ? 0 : file.Contents.Length, Environment.NewLine));
                }
            }
            Debugger.Log(0, null, string.Concat("--- Received files end", Environment.NewLine));
        }

    }

}
