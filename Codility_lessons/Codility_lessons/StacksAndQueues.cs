namespace Codility_lessons;

public class StacksAndQueues
{
    public static int Brackets(string s)
    {
        if (s.Length % 2 != 0)
            return 0;

        Stack<char> openBrackets = new Stack<char>();

        foreach (char c in s)
        {
            if (c == '(' || c == '{' || c == '[')
            {
                openBrackets.Push(c);
            }
            else
            {
                if (openBrackets.Count == 0)
                    return 0;

                switch (c)
                {
                    case ')':
                        if (openBrackets.Peek() == '(')
                            openBrackets.Pop();
                        else
                            return 0;
                        break;

                    case '}':
                        if (openBrackets.Peek() == '{')
                            openBrackets.Pop();
                        else
                            return 0;
                        break;

                    case ']':
                        if (openBrackets.Peek() == '[')
                            openBrackets.Pop();
                        else
                            return 0;
                        break;
                }
            }
        }

        if (openBrackets.Count == 0)
            return 1;

        return 0;
    }
}