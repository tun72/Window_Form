using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JobPortal
{
    public class Utils
    {
        static public bool IsValidExtension(string fileName, bool isDocument=false)
        {
            bool isValid = false;
            string[] fileExtensions = { ".jpg", ".jpeg", ".png" };

            if(isDocument )
            {
                fileExtensions = new string[] { ".doc", ".docx", ".pdf" };
            }
            


            isValid = fileExtensions.Where(stringToCheck => fileName.Contains(stringToCheck)).Any();
            Console.WriteLine(isValid);
            return isValid;

        }


       
    }
}