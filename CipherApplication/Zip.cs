using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CipherApplication
{
    class Zip
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ArchivePath">Путь к архиву</param>
        /// <param name="ExtractDestinationPath">Путь к папке для извлечения</param>
        public static string ExtractFilesFromZip(string ArchivePath, string ExtractDestinationPath)
        {
            try
            {
                using (FileStream zipToRead = new FileStream(ArchivePath, FileMode.Open))
                {
                    using (ZipArchive archive = new ZipArchive(zipToRead, ZipArchiveMode.Read))
                    {
                        archive.ExtractToDirectory(ExtractDestinationPath);
                    }
                }
                return "Success!";
            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.Message);
                return "So bad";
            }

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filename">Имя файла для извлечения</param>
        /// <param name="ArchivePath">Путь к архиву</param>
        /// <param name="ExtractDestinationPath">Путь к папке для извлечения</param>
        /// <returns></returns>
        public static string ExtractFilesFromZip(string filename, string ArchivePath, string ExtractDestinationPath)
        {
            try
            {
                using (FileStream zipToRead = new FileStream(ArchivePath, FileMode.Open))
                {
                    using (ZipArchive archive = new ZipArchive(zipToRead, ZipArchiveMode.Read))
                    {
                        foreach (ZipArchiveEntry entry in archive.Entries)
                        {
                            if (entry.FullName.Equals(filename, StringComparison.OrdinalIgnoreCase))
                            {
                                // Gets the full path to ensure that relative segments are removed.
                                string destinationPath = Path.GetFullPath(Path.Combine(ExtractDestinationPath, entry.FullName));

                                // Ordinal match is safest, case-sensitive volumes can be mounted within volumes that
                                // are case-insensitive.
                                if (destinationPath.StartsWith(ExtractDestinationPath, StringComparison.Ordinal))
                                { 
                                    entry.ExtractToFile(destinationPath); 
                                }
                                   
                            }
                        }
                    }
                    return "Success!";
                }
            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.Message);
                return "So bad";
            }

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="zipPath">Путь к архиву </param>
        /// <returns></returns>
        public static List<string> GetZipFiles(string zipPath)
        {
            List<string> result = new List<string>();
            using (ZipArchive archive = ZipFile.OpenRead(zipPath))
            {
                foreach (ZipArchiveEntry entery in archive.Entries)
                {
                    result.Add(entery.Name);
                }
            }
            return result;
        }

        public static string SaveFileToZip(string filename, string saveFileName, string archivePath)
        {
            try
            {
                using (FileStream zipToOpen = new FileStream(archivePath, FileMode.OpenOrCreate))
                {
                    using (ZipArchive archive = new ZipArchive(zipToOpen, ZipArchiveMode.Update))
                    {
                        archive.CreateEntryFromFile(filename, saveFileName);
                    }
                }
                return "Success!";
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return "So bad";
            }

        }
    }

}
