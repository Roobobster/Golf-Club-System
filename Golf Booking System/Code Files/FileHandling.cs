using System;
using System.IO;
using System.IO.Compression;

namespace FileHandling
{
    public  class Compression
    {
        public static string ZipDirectoryPath = AppDomain.CurrentDomain.BaseDirectory.Replace(@"\bin\Debug", "") + @"\ZippedFiles";


        public static void ZipSingleFile(string FilePath)
        {
            //Gets the name of the file
            string strFileName = Path.GetFileName(FilePath);

            //Sets the Final directory path to be the name of the file
            string strFinalDirectory = ZipDirectoryPath + @"\" + strFileName;

            //Creates a directory to put the file into
            DirectoryInfo tempDirectory = Directory.CreateDirectory(strFinalDirectory);

            //Copies file into tempary directory
            File.Copy(FilePath, strFinalDirectory + @"\" + strFileName);

            //Since the file is not in a direcory it can be zipped 
            ZipFolder(strFinalDirectory);

            DeleteFilesInDirectory(strFinalDirectory);

            Directory.Delete(strFinalDirectory);
        }

        //Gets a Folder And Zips all of it's content to make it use less storage, making it able to be send larger files over email.
        //Although this doesn't zip the orginal folder it creates a copy and puts that copied folder, that is now zipped, into a designated folder.
        public static void ZipFolder( string directoryPath)
        {
            string[] strAddress = directoryPath.Split(Path.DirectorySeparatorChar);

            string strDirectoryName = strAddress[strAddress.Length - 1];

            string startPath = directoryPath;
            string zipPath = ZipDirectoryPath +  @"\" + strDirectoryName + ".zip";        
            
            ZipFile.CreateFromDirectory(startPath, zipPath);
        }

        //This makes it so that all the zips that are created for sending via email are deleted as they are no longer needed after the email has sent.
        public static void DeleteFilesInDirectory(string directoryPath = "default", bool IncludeZips = false)
        {
            if (directoryPath == "default")
            {
                directoryPath = ZipDirectoryPath;
            }

            DirectoryInfo BaseDirectory = new DirectoryInfo(directoryPath);

            foreach (FileInfo file in BaseDirectory.GetFiles())
            {
                //It will only delete the file if the file isn't a zip unless the method is specified to delete them. 
                if (IncludeZips || file.Extension != ".zip")
                {

                    file.Delete();

                }
                
            }
            foreach (DirectoryInfo subDirectory in BaseDirectory.GetDirectories())
            {
                subDirectory.Delete(true);
            }
        }

        //It will delete a single zip file.
        public static void DeleteZipFile(string FileName)
        {

            //Get the Directory that all the zips are put into
            DirectoryInfo BaseDirectory = new DirectoryInfo(ZipDirectoryPath);
           
            //Loops for every file in the Dirtory
            foreach (FileInfo file in BaseDirectory.GetFiles())
            {
                //It will then delete the file if it's the same as the inputted value. And since Zips count as files they can be deleted this way.
                if (file.Name == FileName)
                {
                    file.Delete();
                }
                    


            }
        }




        public static long GetAttachedFileSize(string filePath)
        {
            //Gets the size of a file by using the path of the file and then assign the file data to a variable and then getting the length property that returns the size of the file. 
            long lngFileSize = new FileInfo(filePath).Length;

            return lngFileSize;
        }


        public static long GetAttachedDirectorySize(string directoryPath)
        {

            long lngDirectorySize = 0;
            DirectoryInfo baseDirectory = new DirectoryInfo(directoryPath);

            //Gets all the files in the base directory and stores them into an array of FileInfo which contain the file sizes.
            FileInfo[] filesInBaseDirectory = baseDirectory.GetFiles();
            

            //Loops for each file in the base directory and adds the size of each file to the total directory size.
            foreach (FileInfo file in filesInBaseDirectory)
                lngDirectorySize += file.Length;

            //Gets all the directories in the base file and adds them to an array of directoryinfos that contain the fileInfo in each directory.
            DirectoryInfo[] subDirectories = baseDirectory.GetDirectories();

            foreach (DirectoryInfo directory in subDirectories)
                lngDirectorySize += GetAttachedDirectorySize(directoryPath + @"\" + directory.Name);

            return lngDirectorySize;
        }
    }
        


    
         
}