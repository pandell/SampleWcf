using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel.Web;

using SampleWcf.TestClient.SampleWcfCall;

namespace SampleWcf.TestClient
{

    /// <summary>
    /// </summary>
    public static class Program
    {

        /// <summary>
        /// </summary>
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Gathering files");
                var files = new List<FileDescriptor>();
                if (args != null)
                {
                    files.AddRange(
                        args
                        .Where(File.Exists)
                        .Select(a => new FileDescriptor { Name = a, Contents = File.ReadAllBytes(a) }));
                }

                Console.WriteLine("Send files");
                using (var f = new WebChannelFactory<IFileTracker>(new Uri("http://localhost/samplewcf/Call.svc/FileTracker")))
                {
                    var c = f.CreateChannel();
                    var i = c.Track(files.ToArray());
                    Console.WriteLine("Server said:");
                    Console.Write(i);
                }
                Console.WriteLine("Done");
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.ResetColor();
            }
        }

    }

}
