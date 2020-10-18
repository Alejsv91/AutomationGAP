using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationFramework.Classes
{
    public class DataDrivenStringObject
    {
        public DataDrivenStringObject(string tcName, string keyword, string value)
        {
            TcName = tcName;
            Keyword = keyword;
            Value = value;
        }
        string TcName { get; }
        string Keyword { get; }
        string Value { get;  }
    }
}
