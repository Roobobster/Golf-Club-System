using DatabaseTables;
using InputForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static Emailing.SMPT;
using static FileHandling.Compression;
using static Global_Variables.Global_Variables_class;



namespace Golf_Booking_System
{
    public partial class Mailing : Form
    {

       
        
        public Mailing()
        {
          
            InitializeComponent();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Main_Menu frmMain_Menu = new Main_Menu();
            frmMain_Menu.Show();

            this.Close();
            
            
        }

        
        private void Mailing_Load(object sender, EventArgs e)
        {
            
            AddAttachments();
            CalculateTotalAttachmentsSize();



        }


        //Loads all the attachements the user has selected and checks if the email body/ subject are present.
        private void AddAttachments()
        {
            //Makes a butten labeled body green if the email body has a length meaniing there is a email body and therefore allows the user to easily see if they have put in a body for the email
            if (EmailBody.Length != 0)
            {
                lblBody.BackColor = Color.LightGreen;
            }
            else
            {
                lblBody.BackColor = Color.OrangeRed;
            }

            //This does the same as the above but instead does it for the subject. 
            if (EmailSubject.Length != 0)
            {
                lblSubject.BackColor = Color.LightGreen;
            }
            else
            {
                lblSubject.BackColor = Color.OrangeRed;
            }

            //Clears the list box of attachments to remove the chance of duplicates
            lstAttachments.Items.Clear();

            //Enters all the file attachments into the listboxs
            foreach (string name in AttachedFileNames)
                lstAttachments.Items.Add("- " + name + "  (File)");
            

            //Enters all the Directory attachments into the listboxs
            foreach (string name in AttachedDirectoryNames)          
                lstAttachments.Items.Add("- " + name + "  (Folder)");
            
            
           
        }
        //Displays aa File explorer that allows the user to add a file for the attachments
        private void OpenFileExplorer()
        {
            //Only adds a file if the user selects OK meaning they have picked a file
            if (FileExplorer.ShowDialog() == DialogResult.OK)
            {
                //Adds the file information to a list.
                AttachedFilePaths.AddRange(FileExplorer.FileNames);
                AttachedFileNames.AddRange(FileExplorer.SafeFileNames);
                //As the user is able to select multiple files it means that it will need to loop for every file selected and add them to a list box with some added information
                //like it's a file attachment and it's file name.
                foreach (string file in FileExplorer.SafeFileNames)
                {
                    lstAttachments.Items.Add("- " + file + "  (File)");
                }
                
            }
            
        }

        private void ComposeEmail_Click(object sender, EventArgs e)
        {
            this.Hide();
            Compose_Email frmCompose_Email = new Compose_Email();
        }

        private void AddFolder_Click(object sender, EventArgs e)
        {
            AddFolderAttachment();
            CalculateTotalAttachmentsSize();

        }

        

        private void AddFolderAttachment()
        { 
            //Creates a folderbrowserdialog which allows the user to select folders only 
            FolderBrowserDialog FolderExplorer = new FolderBrowserDialog();

            if (FolderExplorer.ShowDialog() == DialogResult.OK)
            {
                AttachedDirectoryPaths.Add(FolderExplorer.SelectedPath);

                string[] strSplitPath = FolderExplorer.SelectedPath.Split(Path.DirectorySeparatorChar);
                string strFolderName = strSplitPath[strSplitPath.Length - 1];
                AttachedDirectoryNames.Add(strFolderName);

                //Adds attachment to the list box with it's file name and the folder tag to tell the user it's a folder attachment
                lstAttachments.Items.Add(" - " + Path.GetFileName(AttachedDirectoryPaths[AttachedDirectoryPaths.Count-1]) + "  (Folder)");
            }

        }

        private void ComposeEmail_Click_1(object sender, EventArgs e)
        {
            
            Compose_Email frmCompose_Email = new Compose_Email();
            frmCompose_Email.Show();
            this.Close();
        }

        private void Email_Click(object sender, EventArgs e)
        {
            if (lblLoadBar.Width != 401)
            {
                string strEmail = "";
                InputBox.CreateInputBox("Email", "Enter Email Address", ref strEmail);

                string strPassword = "";
                InputBox.CreateInputBox("Email", "Enter Email Password", ref strPassword);

                //Checks to see if the user has inputted a subject for the email, although it doesn't check if the email has a body as it is not needed,
                //as the user may just want to send attachments that explain everything therefore it would be pointless to force the user to input a body for the email 
                if (EmailSubject.Length != 0)
                {
                    //Checks to see if at least one membership type has been selected
                    if (ckbCommon.Checked || ckbPremium.Checked || ckbSupreme.Checked)
                    {
                        List<string> strSelectedMemberships = new List<string>();

                        //Checks to see what membership types are selected so it can be used to able to sent it to specific membership types.
                        if (ckbCommon.Checked)                     
                            strSelectedMemberships.Add("Common");                   
                        if (ckbPremium.Checked)                   
                            strSelectedMemberships.Add("Premium");           
                        if (ckbSupreme.Checked)                       
                            strSelectedMemberships.Add("Supreme");
                        
                        List<string> strAttachmentPaths = new List<string>();
                        //Adds all the attachment paths into a single array to be used by the "SendEmail" procedure so it can do one simple loop for adding attachments.
                        strAttachmentPaths.AddRange(AttachedDirectoryPaths);
                        strAttachmentPaths.AddRange(AttachedFilePaths);

                        //Adds all the member emails to a single list
                        List<string> strMailingList = AddSelectedMembers(strSelectedMemberships);

                        SendEmail(strMailingList, strEmail, strPassword, EmailSubject, EmailBody, strAttachmentPaths);

                        
                        
                        MessageBox.Show("Sent");
                        bool isDeleted = false;
                        while (!isDeleted)
                        {
                            try
                            {
                                DeleteFilesInDirectory(ZipDirectoryPath, true);
                                isDeleted = true;
                            }
                            catch (Exception)
                            {
                                isDeleted = false;
                            }
                        }
                       
                        
                        lstAttachments.Items.Clear();

                    }
                    else
                    {
                        MessageBox.Show("Please Select The Membership Type You Want To Email");
                    }
                }
                else
                {
                    MessageBox.Show("Please Compose A Email Subject Before Sending The Email");
                }
            }
            else
            {
                MessageBox.Show("The Attachments Selected Are Too Large And Therefore Can't Be Emailed");
            }
            
           
            




        }

        private List<string> AddSelectedMembers(List<string> IncludedMemberships)
        {
            List<string> EmailList = new List<string>();
            //Loads all the member details
            Member MemberDatabase = Member.LoadMembers();

            //Loops through all the membership types
            for (int Member = 0; Member < MemberDatabase.strMembershipType.Count; Member++)
            {
                //Loops for each of the membership types that the user wants to send the email to 
                foreach (string Membership in IncludedMemberships)
                {
                    //This checks each membership type selected to see if the member needs to be added to the mailing list 
                    if (MemberDatabase.strMembershipType[Member] == Membership)
                    {
                        //If member is one of the selected membership types they are added to email list.
                        EmailList.Add(MemberDatabase.strEmail[Member]);
                    }
                }
                
            }

            return EmailList;
        }
        //Zips all the attachments selected by the user.
        private void ZipAllAttachemnts()
        {

            //Keeps track of what file and folders already been zipped         
            int intFileIndex = 0;
            int intFolderIndex = 0;
            string[] ZippedAttachments = new string[lstAttachments.Items.Count];

            //Loops for every attachment in the list box
            foreach (string attachment in lstAttachments.Items)
            {
                //if the attachment contains the string "(File)" then it will mean it's a file attachment
                if (attachment.Contains("(File)"))
                {
                    //It won't do anything if it contains .zip as that will mean it's already zipped and won't need to zip it again
                    if (!(attachment.Contains(".zip")))
                    {
                        ZipSingleFile(AttachedFilePaths[intFileIndex]);
                        
                    }
                    intFileIndex++;

                }
                //Does the same as the above but instead it is altered to cater for directories
                else if (attachment.Contains("(Folder)"))
                {
                    if (!(attachment.Contains(".zip")))
                    {
                        ZipFolder(AttachedDirectoryPaths[intFolderIndex]);
                       
                    }
                    intFolderIndex++;

                }                           
                    
            }
           
        }


        //Gets the total size of all the attachements by looking at every file in the directories.
        private void CalculateTotalAttachmentsSize()
        {
            long bytes = 0;

            //Loops for every path in the file paths ( for every file attachement)
            //Adds the size of the file to the total
            foreach (string path in AttachedFilePaths)                           
                bytes += GetAttachedFileSize(path);


            //Loops for every direcrory path ( for every folder attached)
            //Adds the size of the directory files to the total
            foreach (string path in AttachedDirectoryPaths)                         
                bytes += GetAttachedDirectorySize(path);
            

            //Turns the total size into mb to be more user friendly
            float megaBytes = (bytes / 1000f) / 1000f;

            lblTotalSize.Text = "Total Size:" + megaBytes.ToString() + " MB";

            
            //Gets the percentage of how big total attachements are compared to max amount of space and then calculates the supposed length of the bar.
            float fltSpaceLeftPercentage = (megaBytes / 10) * 400;

            //This stops the bar from being extremely large in one direction and moving out of the area designated for the loading bar
            if (megaBytes >= 10f)
                lblLoadBar.Width = 401;
            else
                lblLoadBar.Width = (int)fltSpaceLeftPercentage;


            //The label bar will be green if the space used is below 40%
            if (lblLoadBar.Width < 400*0.4)
            {
                lblLoadBar.BackColor = Color.Green;
            }
            //The label bar will be orange if the space used is below 80%
            else if (lblLoadBar.Width < 400*0.8)
            {
                lblLoadBar.BackColor = Color.Orange;
            }
            else
            {
                lblLoadBar.BackColor = Color.Maroon;
            }

        }

        private void OpenAttachment_Click(object sender, EventArgs e)
        {
            OpenFileExplorer();
            CalculateTotalAttachmentsSize();
        }


        private void Zip_Click(object sender, EventArgs e)
        {
            
            //This deletes any files that may already be in the folder, not uncluding zips as then it would be zipping files that are aleady been zipped.
            DeleteFilesInDirectory();
            //zips all the current attachments into a designated zip folder.
            ZipAllAttachemnts();
            
            for (int i = 0; i < AttachedFilePaths.Count; i++)
            {
                
                //If the last 4 character of the path is ".zip" then it already has been zipped and doesn't need to do anything
                if (AttachedFilePaths[i].Substring(AttachedFilePaths[i].Length - 4) != ".zip")
                {
                    MessageBox.Show("Changed");
                    AttachedFileNames[i] += ".zip";
                    AttachedFilePaths[i] = ZipDirectoryPath + @"\" + AttachedFileNames[i];
                    
                }
               
            }

            for (int i = 0; i < AttachedDirectoryPaths.Count ; i++)
            {
                
                if (AttachedDirectoryPaths[i].Substring(AttachedDirectoryPaths[i].Length -4) != ".zip")
                {
                    //As when you zip a folder the zipped outcome is a file therefore the path needs to be in the attached files instead of directories
                    AttachedFilePaths.Add(ZipDirectoryPath + @"\" + Path.GetFileName(AttachedDirectoryPaths[i]) + ".zip");
                    AttachedFileNames.Add(Path.GetFileName(AttachedDirectoryPaths[i]) + ".zip");
                }
               
            }

            //Practically resets the form.
            AttachedDirectoryPaths.Clear();
            AttachedDirectoryNames.Clear();

            lstAttachments.Items.Clear();
            AddAttachments();

            CalculateTotalAttachmentsSize();
        }

        private void RemoveSelectedAttachment(object sender, EventArgs e)
        {
            //Gets the index of the selected attachment in the listbox

            int intSelectedAttachment = lstAttachments.SelectedIndex;
            //If the item index is -1 then no attachment is selected
            if (intSelectedAttachment != -1)
            {
                int FolderIndex = 0;
                int FileIndex = 0;
                //Loops for for every attachment up to the selected attachment so that it can keep count of the file and folder index
                //This way the file and folder index can be used to remove it from the list without having to store the actual files manually,
                //meaning less space is needed to run the program.
                for (int i = 0; i <= intSelectedAttachment; i++)
                {
                    string strAttachment = lstAttachments.Items[i].ToString();

                    if (strAttachment.Contains("(File)") | strAttachment.Contains(".zip"))
                    {

                        if (i == intSelectedAttachment )
                        {
                            
                            if (strAttachment.Contains(".zip"))
                            {
                                MessageBox.Show("Delete");
                                MessageBox.Show(AttachedFileNames[FileIndex]);
                                //Deletes the zip file if the attachment index is the same as the counter and it contains .zip which saves space on the disk 
                                DeleteZipFile(AttachedFileNames[FileIndex]);
                                
                            }
                            //Removes the details for that attachment as it's no longer needed
                            AttachedFileNames.RemoveAt(FileIndex);
                            AttachedFilePaths.RemoveAt(FileIndex);
                        }
                        FileIndex++;
                    }
                    //This is the same as the above but instead it uses a folder counter and doesn't delete directories as directories can't be zips therefore it will
                    //delete the orignal folder as it will be in the AttachedFilePaths if it's a zip attachement.
                    else if (strAttachment.Contains("(Folder)"))
                    {

                        if (i == intSelectedAttachment)
                        {
                            AttachedDirectoryNames.RemoveAt(FolderIndex);
                            AttachedDirectoryPaths.RemoveAt(FolderIndex);
                        }
                        FolderIndex++;
                    }



                }
                //Removes the attachment from the list box once all other details associated with it have gone.
                lstAttachments.Items.RemoveAt(intSelectedAttachment);

                //Re-calculates the total for the attachments as the file will be deleted 
                CalculateTotalAttachmentsSize();
            }
            else
            {
                MessageBox.Show("Select An Attachment First");
            }

        }

        #region Moveable Form Code

        //This region of code is responsible for the movement of the form as it doesn't have a border style which means it doesn't have the inbuild movement features        
        private bool mouseDown;
        private Point lastLocation;

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            //Gets the location of the mouse when mouse button 1 is clicked
            lastLocation = e.Location;
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            //Will only run if the mouse has been pressed down and is still being pressed down.
            if (mouseDown)
            {
                //Moves the form by betting the location of the mouse when it was clicked and taking that away from the location of the form to get the offset
                //Then it gets the position of the mouse and adds that to the offset to get the new postion for the form
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                //This is needed to prevent the flickering of the form.
                this.Update();
            }
        }

        private void Form_MouseUp(object sender, MouseEventArgs e)
        {

            //This is just makes it so that when the user isn't clicking the form it doesn't move the form.
            mouseDown = false;
        }


        #endregion
    }
}
