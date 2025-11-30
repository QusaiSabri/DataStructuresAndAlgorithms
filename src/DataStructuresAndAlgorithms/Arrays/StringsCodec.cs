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
                sb.Append(str.Length);
                sb.Append('#');
                sb.Append(str);
            }

            return sb.ToString();
        }

        public List<string> Decode(string s)
        {
            // 5#hello5#world"
            // -
            var current = 0;
            var result = new List<string>();

            while (current < s.Length)
            {
                // 1. Find the '#' that ends the length prefix
                int hashIndex = s.IndexOf('#', current);

                // 2. Extract the length 
                string lengthText = s.Substring(current, hashIndex - current);
                int wordLength = int.Parse(lengthText);

                // 3. Extract the word itself
                int wordStart = hashIndex + 1;
                string word = s.Substring(wordStart, wordLength);
                result.Add(word);

                // 4. Move the pointer to the start of the next encoded word
                current = wordStart + wordLength;
            }
            return result;
        }
    }
}
