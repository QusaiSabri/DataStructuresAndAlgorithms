using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.Arrays
{
    public class StringsCodec
    {
            // Encodes a list of strings to a single string.
            public string Encode(IList<string> strs)
            {
                var sb = new StringBuilder();
                foreach (var str in strs)
                {
                    sb.Append(str.Length + "#" + str);
                }
                return sb.ToString();
            }

            // Decodes a single string to a list of strings.
            public IList<string> Decode(string s)
            {
                var i = 0;
                var result = new List<string>();
                while (i < s.Length)
                {
                    var delimiterIndex = s.IndexOf('#', i);
                    var length = int.Parse(s.Substring(i, delimiterIndex - i));
                    i = delimiterIndex + 1; // Move past '#'
                    result.Add(s.Substring(i, length));
                    i += length; // Move to the start of the next encoded string
                }
                return result;
            }

    }
}
