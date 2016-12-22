using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetZipBenchmark
{
    class Program
    {
        public static void Main(string[] args)
        {
            var netHelper = new NetZipHelper();
            var sharpHelper = new SharpZipLibHelper();

            var zipPath = @"./AppData/Fullfeed-100.zip";
            var outputLocation = @"./temp";

            sharpHelper.UnzipToLocation(zipPath, outputLocation + "/SharpZip");
            netHelper.UnzipToLocation(zipPath, outputLocation + "/NetZip");

            //Directory.Delete(outputLocation);
        }
    }
}
