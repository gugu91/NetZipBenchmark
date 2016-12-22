using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICSharpCode.SharpZipLib.Zip;

namespace NetZipBenchmark
{
    public class SharpZipLibHelper : ZipHelper
    {
        public override void UnzipToLocation(string filePath, string location)
        {
            var fastZip = new FastZip();
            var outputDirectory = GetOutputDirectory(filePath, location);
            fastZip.ExtractZip(filePath, outputDirectory, null);
        }
    }
}
