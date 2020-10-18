using AutomationFramework.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace AutomationFramework.Utilities
{
    public class DataAccess
    {
        public DataAccess(string currentTestMethodName)
        {
            StreamReader sr = new StreamReader(@"DataDriven.csv");
            var TestCasesInformation = new List<DataDrivenStringObject>();
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
        #region properties

        #endregion

        #region methods

        #endregion


    }
}
