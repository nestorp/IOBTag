using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace IOBTag
{
    public class Post
    {
        public String originalString { get; set; }

        public String Body { get; set; }

        public int Wordlen { get; set; }

        public String[] Words { get; set; }

        public String[] POS { get; set; }

        public String[] IOBS { get; set; }

        public String ADR { get; set; }


        public Post()
        {

        }

        public Post(String line, Tuple<int?, int?, int?, int?, int?, int?> colIndex)
        {
            originalString = line;
            String[] cols = line.Split('|');
            Body = cols.ElementAt((int)colIndex.Item1);
            Wordlen = Convert.ToInt32(Convert.ToDouble(cols.ElementAt((int)colIndex.Item2)));
            Words = processList(cols.ElementAt((int)colIndex.Item3));
            POS = processList(cols.ElementAt((int)colIndex.Item4));

            if (colIndex.Item5 != null)
            {
                var iobs = cols.ElementAt((int)colIndex.Item5);

                if (iobs!=null && iobs!= String.Empty)
                {
                    IOBS = processList(cols.ElementAt((int)colIndex.Item5));
                }
                
            }
            if (colIndex.Item6 != null)
            {
                ADR = cols.ElementAt((int)colIndex.Item6);
            }

        }

        public String getString()
        {
            String IOBString = String.Empty;
            String isADR = String.Empty;
            String wordsString = String.Join("~", Words);
            String posString = String.Join("~", POS);

            if (IOBS != null)
            {
                IOBString = String.Join("~", IOBS);
                if (IOBString.Contains("ADR"))
                {
                    isADR = "1";
                } else
                {
                    isADR = "0";
                }
            }

            
            return Body + "|" + Wordlen + "|" + wordsString + "|" + posString + "|" + IOBString + "|" + isADR;
            //return originalString + "|" + IOBString + "|" + isADR;
        }

        protected String[] processList(String strList)
        {
            string[] stringSeparators = new string[] { "~" };
            String[] procList = strList.Split(stringSeparators, StringSplitOptions.None);
            //String[] procList = strList.Split(',');
            for (int i=0; i<procList.Length;i++)
            {
                strList = procList.ElementAt(i);
                strList = strList.Trim();
                //strList = Regex.Replace(strList, @"^\'", "");
                //strList = Regex.Replace(strList, @"^\[\'", "");
                //strList = Regex.Replace(strList, "^\"", "");
                //strList = Regex.Replace(strList, @"^\'", "");
                //strList = Regex.Replace(strList, @"^\[\'", "");
                //strList = Regex.Replace(strList, "^\"", "");
                //strList = Regex.Replace(strList, @"^\'", "");
                //strList = Regex.Replace(strList, @"^\[\'", "");
                //strList = Regex.Replace(strList, "^\"", "");
                //strList = Regex.Replace(strList, @"^\'", "");
                //strList = Regex.Replace(strList, @"^\[\'", "");
                //strList = Regex.Replace(strList, "^\"", "");
                //strList = Regex.Replace(strList, @"^\'", "");
                //strList = Regex.Replace(strList, @"^\[\'", "");
                //strList = Regex.Replace(strList, "^\"", "");
                //strList = Regex.Replace(strList, @"^\'", "");
                //strList = Regex.Replace(strList, @"^\[\'", "");
                //strList = Regex.Replace(strList, "^\"", "");

                //strList = Regex.Replace(strList, @"[\'\]]$", "");
                //strList = Regex.Replace(strList, "\"$", "");
                //strList = Regex.Replace(strList, @"[\'\]]$", "");
                //strList = Regex.Replace(strList, "\"$", "");
                //strList = Regex.Replace(strList, @"[\'\]]$", "");
                //strList = Regex.Replace(strList, "\"$", "");
                //strList = Regex.Replace(strList, @"[\'\]]$", "");
                //strList = Regex.Replace(strList, "\"$", "");
                //strList = Regex.Replace(strList, @"[\'\]]$", "");
                //strList = Regex.Replace(strList, "\"$", "");
                //strList = Regex.Replace(strList, @"[\'\]]$", "");
                //strList = Regex.Replace(strList, "\"$", "");

                procList.SetValue(strList, i);
            }

            if (Wordlen!=procList.Length)
            {
                String errProc = "Error found " + procList.Length.ToString() + " words but should be " + Wordlen.ToString();
                List<String> errProcList = new List<string>();
                errProcList.Add(errProc);
                return errProcList.ToArray();
            }

            return procList;
        }

    }

    
}
