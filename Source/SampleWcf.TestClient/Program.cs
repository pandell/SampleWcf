using System;
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
                Console.WriteLine("Start sending");
                using (var f = new WebChannelFactory<IFileTracker>(new Uri("http://mgardian/samplewcf/Call.svc/FileTracker")))
                {
                    var c = f.CreateChannel();
                    c.Track(new[]
                    {
                        "First.txt",
                        "Second.txt"
                    });
                }
                Console.WriteLine("Done sending");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }

    }

}
