using AutomationFramework.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace AutomationFramework.Utilities
{
    public class DataAccess
    {
        #region constructor
        public DataAccess(string currentTestMethodName)
        {
            StreamReader sr = new StreamReader(@"DataDriven.csv");
            TestCasesInformation = new List<DataDrivenStringObject>();
            int x = 0;
            while (!sr.EndOfStream)
            {
                x++;
                string strline = sr.ReadLine();
                string[] values = strline.Split(';');
                if (values.Length >= 3 && values[0].Trim().Length > 0 && values[0] == currentTestMethodName)
                {
                    TestCasesInformation.Add(new DataDrivenStringObject(values[0], values[1], values[2]));
                }
            }
            sr.Close();
        }
        #endregion
        #region properties
        public List<DataDrivenStringObject> TestCasesInformation { get; set; }
        #endregion

        #region methods
        public string getParameterValue(string parameterName)
        {
            return TestCasesInformation.Where(x => x.Keyword == parameterName).FirstOrDefault().Value.ToString();
        }
        #endregion


    }
}
