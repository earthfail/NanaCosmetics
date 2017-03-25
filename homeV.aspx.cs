using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class homeV : System.Web.UI.Page
{
    static double ans;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button_Click(object b, EventArgs e)
    {
        if (screen.Text.CompareTo("0") == 0)
            screen.Text = ((Button)b).Text;
        else if (((Button)b).Text.CompareTo("C") == 0)
        {
            screen.Text = "0";
            ans = 0;
        }
        else if (((Button)b).Text.CompareTo("=") == 0)
        {
            ans = sentence(screen.Text);
            screen.Text = ans.ToString();
        }
        else screen.Text += ((Button)b).Text;

    }
    static double str_to_d(string s, ref int i)
    {
        int sign = 1, dec = 1;
        double output = 0;

        for (; i < s.Length; (i)++)
        {
            if ((s[i] < '0' || s[i] > '9') && s[i] != '-') { sign = 1; continue; }
            if (s[i] == '-') { sign *= -1; continue; }
            while (i < s.Length && s[i] >= '0' && s[i] <= '9')
                output = output * 10 + s[i++] - '0';
            if (i == s.Length) break;
            if (s[i] == '.')
            {
                (i)++;
                while (i < s.Length && s[i] >= '0' && s[i] <= '9')
                {
                    output = output * 10 + s[(i)++] - '0';
                    dec *= 10;
                }
                output = output / dec;
            }
            break;
        }
        return output * sign;
    }

    static double do_operation(double a, char oper, double b)
    {
        switch (oper)
        {
            case '+': return a + b; break;
            case '-': return a - b; break;
            case '*': return a * b; break;
            case '/': return a / b; break;
            default: Console.WriteLine("not okay oper='{0}'\n", oper); return -1;
        }
    }

    static double sentence(string s)
    {
        double output = 0;//num0 is for the series of multiplication
        int i = 0, tmp;//operation before series of operation and operation before bracket
        output = multiply(s, ref i);

        while (i < s.Length)
        {
            tmp = i++;
            output = do_operation(output, s[tmp], multiply(s, ref i));
        }
        return output;
    }

    static double brackets(string s, ref int i)
    {
        int first, substringlen = 0, sign = 1;

        while (is_bracket(s[i]) != 1)
        {
            if (s[i] == '-') sign *= -1;
            else sign = 1;
            (i)++;
        }
           (i)++;
        first = (i);
        while (is_bracket(s[i + substringlen]) != 2)
            substringlen++;
        i += substringlen + 1;
        return sentence(s.Substring(first, substringlen)) * sign;
    }

    static int is_bracket(char c)
    {
        if (c == '{' || c == '(' || c == '[') return 1;
        if (c == '}' || c == ')' || c == ']') return 2;
        return 0;
    }

    static double multiply(string s, ref int i)
    {
        double num0 = 0;
        int tmp;

        if (i < s.Length)
        {
            if (is_bracket(s[i]) == 1 || (i < s.Length - 1 && is_bracket(s[i + 1]) == 1))
            { num0 = brackets(s, ref i); }
            else
            { num0 = str_to_d(s, ref i); }
            while (i < s.Length && (s[i] == '*' || s[i] == '/' || is_bracket(s[i]) == 1))
            {
                tmp = (i);
                if (is_bracket(s[i]) == 1)
                    num0 = do_operation(num0, '*', brackets(s, ref i));
                else if (is_bracket(s[i + 1]) == 1)
                    num0 = do_operation(num0, s[tmp], brackets(s, ref i));
                else
                    num0 = do_operation(num0, s[tmp], str_to_d(s, ref i));
            }
        }
        return num0;
    }
}