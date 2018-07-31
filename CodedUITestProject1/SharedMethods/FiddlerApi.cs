using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Net;
using System.Reflection;
using System.Text;

namespace AutomationTesting.SharedMethods
{
    /// <summary>
    /// This page is a stub for reference use only. These methods were initially created by a colleague and later widely refactored by myself, Kris Barbe
    /// </summary>
    class FiddlerApi
    {
        private string getUrl { get; set; }
        private string soapUrl { get; set; }
        private string postUrl { get; set; }
        private string str;
        private string submitMethod { get; set; } = "<default>"; //xml, soap
        public string requestMethod { get; set; } = "POST";
        private static string body;
        private static string result { get; set; }

        public string switchParameter = null; //used to parse different responses


        public string SubmitFiddler(bool resultExpected = true)
        {
            SetUrls();
            MakeGetRequest();
            MakePostRequest();

            if(!resultExpected)
            {
                return null;
            }

            result = GetFiddlerResult();
            if(result == null)
            {
                Assert.Fail("Failed to submit fiddler");
            }
            return result;
        }
        
        public void SetUrls()
        {
            getUrl = CreateGetUrl();

            if (submitMethod.ToUpper() == "SOAP")
            {
                soapUrl = CreateSoapUrl();
            }

            postUrl = CreatePostUrl();
        }

        private void MakeGetRequest()
        {
            HttpWebResponse response;
            if(GetRequest(out response))
            {
                response.Close();
            }
        }

        private void MakePostRequest()
        {
            HttpWebResponse response;
            if(PostRequest(out response))
            {
                response.Close();
            }
        }

        private static string CreateGetUrl()
        {
            //condition statements can be used to return different urls
            return "<url string>";
        }

        private static string CreateSoapUrl()
        {
            //condition statements can be used to return different urls
            return "<url string>";
        }

        private static string CreatePostUrl()
        {
            //condition statements can be used to return different urls
            return "<url string>";
        }

        private bool GetRequest(out HttpWebResponse response)
        {
            response = null;
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(getUrl);
                request.UserAgent = "Fiddler";
                request.Headers.Add("<header>");
                response = (HttpWebResponse)request.GetResponse();
                ProcessResponse(response);
            }
            catch(WebException webException)
            {
                //extra logging can be added here
                throw webException;
            }
            catch(Exception ex)
            {
                //extra logging can be added here
                throw ex;
            }

            return true;
        }

        public static void GeneratePostBody(string fileName = null, string postFile = null, string embeddedResourcePath = null)
        {
            if(fileName != null && embeddedResourcePath == null)
            {
                body = ReadToEnd("<defaultResourcePath>"+ fileName);
            }
            else if(fileName != null && embeddedResourcePath != null)
            {
                body = ReadToEnd(embeddedResourcePath + fileName);
            }
            else
            {
                body = postFile;
            }
        }

        private bool PostRequest(out HttpWebResponse response)
        {
            response = null;
            str = null;

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(postUrl);
                request.UserAgent = "Fiddler";
                request.ContentType = "text/xml;charset=utf-8";
                request.Headers.Add("<header>");
                request.Method = requestMethod;
                request.ServicePoint.Expect100Continue = false;

                byte[] postBytes = Encoding.UTF8.GetBytes(body);
                request.ContentLength = postBytes.Length;
                using (Stream stream = request.GetRequestStream())
                {
                    stream.Write(postBytes, 0, postBytes.Length);
                }

                response = (HttpWebResponse)request.GetResponse();
                ProcessResponse(response);
            }
            catch (WebException webException)
            {
                //extra logging can be added here
                throw webException;
            }
            catch (Exception ex)
            {
                //extra logging can be added here
                throw ex;
            }

            return true;
        }

        public string GetFiddlerResult()
        {
            string startTag;
            string endTag;

            switch (switchParameter)
            {
                case "TagSet1":
                    startTag = "<startTag1>";
                    endTag = "</startTag1>";
                    break;
                case "TagSet2":
                    startTag = "<startTag2>";
                    endTag = "</startTag2>";
                    break;
                default:
                    startTag = "<Tag>";
                    endTag = "</Tag>";
                    break;
            }

            int startIndex = str.IndexOf(startTag, StringComparison.Ordinal) + startTag.Length;
            int endIndex = str.IndexOf(endTag, startIndex, StringComparison.Ordinal);
            result = str.Substring(startIndex, endIndex - startIndex);
            return result;
        }

        private void ProcessResponse(HttpWebResponse response)
        {
            using (Stream stream = response.GetResponseStream())
            {
                Encoding encode = Encoding.GetEncoding("utf-8");
                if(stream != null)
                {
                    using (StreamReader streamReader = new StreamReader(stream, encode))
                    {
                        char[] read = new char[2048];
                        int count = streamReader.Read(read, 0, 2048);

                        while(count>0)
                        {
                            str = new string(read, 0, count);
                            count = streamReader.Read(read, 0, 2048);
                        }
                    }
                }
            }
        }

        private static string ReadToEnd(string source)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();

            using (Stream stream = assembly.GetManifestResourceStream(source))
            {
                if(stream != null)
                {
                    using (StreamReader streamReader = new StreamReader(stream))
                    {
                        return streamReader.ReadToEnd();
                    }
                }
            }

            throw new Exception($"Error while reading stream from {source}");
        }
    }
}
