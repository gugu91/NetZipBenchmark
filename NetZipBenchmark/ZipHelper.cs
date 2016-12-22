using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetZipBenchmark
{
    public abstract class ZipHelper
    {
        public abstract void UnzipToLocation(string filePath, string location);

        protected string GetOutputDirectory(string filePath, string directoryName)
        {
            directoryName += "/" + Path.GetFileNameWithoutExtension(filePath);

            if (!string.IsNullOrEmpty(directoryName))
            {
                Directory.CreateDirectory(directoryName);
            }

            return directoryName;
        }
    }
}
