using AutomationTesting.Classes;
using Microsoft.Exchange.WebServices.Data;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTesting.SharedMethods
{
    public class SharedMethodExamples
    {
        public static Process LaunchNotepad(string filePath = @"C:\WINDOWS\system32\notepad.exe")
        {
            if (File.Exists(filePath))
            {
                Process process = new Process();
                process.StartInfo.FileName = filePath;
                process.Start();
                return process;
            }
            Assert.Fail("File not found. Please check filepath.");
            return null;
        }

        public static void DeleteFile(string filepath)
        {
            if(File.Exists(filepath))
            {
                File.Delete(filepath);
            }
        }

        public static string ParseOutlook(string emailSubject, string uniqueEmailIdentifier, string parsingString, int lengthToParse, int lastIndexLength, int emailsToSearch = 10, int minutesToSearch = 5)
        {
            Playback.Wait(10000); //waits 10 seconds for email to send and inbox to update
            
            ExchangeService exchangeService = new ExchangeService(ExchangeVersion.Exchange2010_SP2)
            {
                Credentials = new NetworkCredential("emailUser", "emailPassword", "domain")
            };
            exchangeService.AutodiscoverUrl("emailAddress");

            //finds specified number of emails
            FindItemsResults<Item> findResults = exchangeService.FindItems(WellKnownFolderName.Inbox, new ItemView(emailsToSearch));

            //parse emails
            foreach(EmailMessage emailMessage in findResults.Items.Cast<EmailMessage>())
            {
                //load email body
                emailMessage.Load(new PropertySet(BasePropertySet.FirstClassProperties) { RequestedBodyType = BodyType.HTML });

                //check subject line
                if(emailMessage.Subject.Contains(emailSubject))
                {
                    DateRange range = new DateRange(DateTime.Now.AddMinutes(-minutesToSearch), DateTime.Now);
                    if(range.Includes(emailMessage.DateTimeReceived))
                    {
                        string emailBody = emailMessage.Body.Text;
                        if(emailBody.Contains(uniqueEmailIdentifier))
                        {
                            //parse email for desired string/link
                            Assert.IsTrue(emailBody.LastIndexOf(parsingString, StringComparison.Ordinal) != -1, $"Failed to find email containing: {parsingString}");
                            string emailString = emailBody.Substring(emailBody.LastIndexOf(parsingString, StringComparison.Ordinal) + lengthToParse, lastIndexLength);
                            return emailString;
                        }
                        if(emailMessage == findResults.Items.Last()) //fail if unique email not found
                        {
                            Assert.Fail($"Failed to find email with the unique identifier: {uniqueEmailIdentifier}");
                        }
                    }
                }
                else if(emailMessage == findResults.Items.Last()) //fail if subject not found
                {
                    Assert.Fail($"Failed to find email with the subject: {emailSubject}");
                }
            }
            return null;
        }
    }
}
