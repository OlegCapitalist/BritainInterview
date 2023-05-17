namespace BritainInterview.Service
{
    public class BracketValidation : IBracketValidation
    {
        public bool IsValid(string s)
        {
            if (s == null)
                throw new ArgumentNullException("s");

            bool result = true;

            var OpenedChars = new Stack<char>();

            foreach (char c in s)
            {
                if (c == '(')
                {
                    OpenedChars.Push(c);
                }
                else if (c == '[')
                {
                    OpenedChars.Push(c);
                }
                else if (c == '{')
                {
                    OpenedChars.Push(c);
                }
                else if (c == ')')
                {
                    if (!OpenedChars.Any() || OpenedChars.Peek() != '(')
                        return false;

                    OpenedChars.Pop();
                }
                else if (c == ']')
                {
                    if (!OpenedChars.Any() || OpenedChars.Peek() != '[')
                        return false;

                    OpenedChars.Pop();
                }
                else if (c == '}')
                {
                    if (!OpenedChars.Any() || OpenedChars.Peek() != '{')
                        return false;

                    OpenedChars.Pop();
                }
            }

            if (OpenedChars.Any())
                result = false;

            return result;
        }

    }
}