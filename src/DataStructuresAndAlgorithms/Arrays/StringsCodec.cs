using System.Text;

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
                //5#Hello5#World
                var currentIndex = 0;
                var result = new List<string>();
                while (currentIndex < s.Length)
                {                
                    var delimiterIndex = s.IndexOf('#', currentIndex);
                var whatisthis = s.Substring(currentIndex, delimiterIndex - currentIndex);
                    var length = int.Parse(s.Substring(currentIndex, delimiterIndex - currentIndex));
                    currentIndex = delimiterIndex + 1; // Move past '#'
                    result.Add(s.Substring(currentIndex, length));
                    currentIndex += length; // Move to the start of the next encoded string
                }
                return result;
            }
    }
}
