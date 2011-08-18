using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.ServiceModel.Activation;
using System.Text;

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
        public string Track(IEnumerable<FileDescriptor> files)
        {
            Debugger.Log(0, null, string.Concat("Running IFileTracker.Track", Environment.NewLine));

            var b = new StringBuilder(512);
            b.AppendLine("* Begin received files:");
            if (files != null)
            {
                foreach (var file in files)
                {
                    b.AppendLine(string.Concat("* - File \"", file.Name, "\", length ", file.Contents == null ? 0 : file.Contents.Length, " bytes"));
                }
            }
            b.AppendLine("* End received files:");
            return b.ToString();
        }

    }

}
