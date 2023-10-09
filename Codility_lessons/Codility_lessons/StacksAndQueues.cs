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

    public static int Fish(int[] a, int[] b)
    {
        if (a.Length == 0)
            return 0;

        int aliveFishes = a.Length;
        
        Stack<int> downstreamFishes = new Stack<int>();

        for (int i = 0; i < a.Length; i++)
        {
            if (b[i] == 1)
            {
                downstreamFishes.Push(a[i]);
            }
            else
            {
                while (downstreamFishes.Count != 0)
                {
                    if (downstreamFishes.Peek() > a[i])
                    {
                        aliveFishes--;
                        break;
                    }
                    else
                    {
                        aliveFishes--;
                        downstreamFishes.Pop();
                    }
                }
            }
        }

        return aliveFishes;
    }

    public static int Nesting(string s)
    {
        if (s.Length % 2 != 0)
            return 0;

        Stack<char> openBrackets = new Stack<char>();

        foreach (char c in s)
        {
            if (c == '(')
            {
                openBrackets.Push(c);
            }
            else
            {
                if (openBrackets.Count == 0)
                    return 0;

                openBrackets.Pop();
            }
        }

        if (openBrackets.Count != 0)
            return 0;

        return 1;
    }
}