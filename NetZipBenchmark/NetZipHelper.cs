using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;

namespace NetZipBenchmark
{
    public class NetZipHelper : ZipHelper
    {
        public override void UnzipToLocation(string filePath, string location)
        {
            var outputDirectory = GetOutputDirectory(filePath, location);
            using (var archive = ZipFile.OpenRead(filePath))
            {
                archive.ExtractToDirectory(outputDirectory);
            }
        }
    }
}
