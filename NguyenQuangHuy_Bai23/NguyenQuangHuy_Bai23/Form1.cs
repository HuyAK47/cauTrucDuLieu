using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenQuangHuy_Bai23
{
    public partial class Form1 : Form
    {
        private string[] infix;
        private string[] postfix;
        private string[] prefix;
        public Form1()
        {
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rbtnInfixBT.Select();
            rbtnInfixCD.Select();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private int testPrecedence(string c)// Kiểm tra độ ưu tiên toán tử
        {
            if (c == "*" || c == "/")
                return 2;
            else if (c == "+" || c == "-")
                return 1;
            else
                return 0;
        }

        private bool testOperand(string s)//kiểm tra xem là toán hạng và toán tử
        {
            if (s == "+" || s == "-" || s == "*" || s == "/")
                return false;
            return true;
                
        }

        private void infix_to_postfix(string str)
        {
            int count = 1;
            char[] str_review = new char[100];
            char[] temp = new char[100];

            temp = str.ToCharArray();// chuyển chuỗi thành mảng kí tự

            //định dạng lại biểu thức ban đầu
            for (int i = 0; i < temp.Length; i++)
            {
                switch (temp[i])
                {
                    case '+':
                    case '-':
                    case '*':
                    case '/':
                    case '(':
                    case ')':
                        if (str_review[count - 1] != ' ')
                        {
                            str_review[count++] = ' ';
                        }
                        str_review[count++] = temp[i];
                        str_review[count++] = ' ';
                        break;
                    case ' ':
                        break;
                    default:
                        str_review[count++] = temp[i];
                        break;

                }
            }

           // gán vào ô textbox txtchuyendoi
            txtChuyenDoi.ResetText();
            for (int i = 0; i < str_review.Length; i++)
            {
                txtChuyenDoi.Text += str_review[i];
            }

            //Biểu thức infix
            infix = new string[100];
            postfix = new string[100];
            infix = txtChuyenDoi.Text.Trim().Split(' ');
            Stack<string> sStack=new Stack<string>();
            string x = "";

            //Duyệt lần lượt các ký tự trong mảng từ trái qua phải

            for (int i = 0; i < infix.Length; i++)
            {
                switch (infix[i])
                {
                    //nếu là toán tử ta đem so sánh với toán tử ở đầu stack
                    //trường hợp stack không rỗng và toán tử ở đỉnh stack có độ ưu tiên lớn hơn hoặc bằng toán tử hiện tại thì lấy toán tử đóa ra ngoài stack và cho vào output
                    //đưa toán tử  hiện tại vào stack
                    case "+":
                    case "-":
                    case "*":
                    case "/":
                        //So sánh độ ưu tiên 
                        //--------------------------------------------
                        
                        
                            while (sStack.Count > 0 && testPrecedence(infix[i]) <= testPrecedence(sStack.Peek()))
                            {
                                postfix[count++] = sStack.Pop();
                                
                                postfix[count++] = " ";
                            }
                        
                        //---------------------------------------------------

                        //đưa toán tử hiện tại vào stack
                        sStack.Push(infix[i]);
                        
                        break;

                    // nếu là dấu '(' thì đưa toán tử vào trong stack
                    case "(":
                        sStack.Push(infix[i]);
                       
                        break;

                    // Nếu là dấu')' đóng ngoặc thì lấy các toán tử trong stack ra và cho vào output cho tới khi gặp dấu mở ngoặc '('
                    // Dấu '(' cũng phải đưa ra khỏi stack
                    case ")":
                        do
                        {
                            //Kiểm tra stack rỗng hay ko
                            if (sStack.Count > 0)
                            {
                                //Lấy từ đỉnh của stack
                                x = sStack.Pop();
                                
                                if (x != "(")
                                {
                                    // Đưa ra output
                                    postfix[count++] = x;
                                    
                                    postfix[count++] = " ";
                                }
                            }
                            // nếu stack rỗng mà không gặp dấu '(' thì thông báo lỗi
                            else
                            {
                                MessageBox.Show("Kiểm tra biểu thức thiếu dấu '('. Nhập lại");
                                return;
                            }
                        } while (x != "(");
                        break;
                    case " ":
                        break;
                    default:
                        postfix[count++] = infix[i];
                        
                        postfix[count++] = " ";
                        break;
                }

                // Sau khi duyệt hết  biểu thức infix, nếu trong stack vẫn còn phần tử thì lấy lần ra lần lượt cho vào output
                
            }
            while (sStack.Count > 0)
            {
                //Nếu trong stack vẫn còn  '(' thì thông báo lỗi 
                if (sStack.Peek() == "(")
                {
                    MessageBox.Show("Kiểm tra biểu thức thừa dấu '('");
                    return;
                }
                //lấy các phần tử còn lại cho ra output
                else
                {                  
                    postfix[count++] = sStack.Pop();                    
                    postfix[count++] = " ";
                }
            }
            txtChuyenDoi.ResetText();

        }


        private void infix_to_prefix(string str)
        {
            int count = 1;
            char[] str_review = new char[100];
            char[] temp = new char[100];
            temp = str.ToCharArray();

            // định dạng lại biểu thức
            for (int i = 0; i < temp.Length; i++)
            {
                switch (temp[i])
                {
                    case '+':
                    case '-':
                    case '*':
                    case '/':
                    case '(':
                    case ')':
                        if (str_review[count - 1] != ' ')
                        {
                            str_review[count++] = ' ';
                        }
                        str_review[count++] = temp[i];
                        str_review[count++] = ' ';
                        break;
                    case ' ':
                        break;
                    default:
                        str_review[count++] = temp[i];
                        break;
                }
            }
            //gán giá ttrij vào ô txtChuyenDoi
            txtChuyenDoi.ResetText();
            for (int i = 0; i < str_review.Length; i++)
            {
                txtChuyenDoi.Text += str_review[i];
            }

            // Biểu thức infix
            infix = new string[100];
            prefix = new string[100];
            infix = txtChuyenDoi.Text.Trim().Split(' ');
            count = 0;
            string x = "";
            Stack<string> sStack=new Stack<string>();

            //duyệt các phần tử của mảng từ phải qua trái
            for (int i = infix.Length - 1; i >= 0; i--)
            {
                switch (infix[i])
                {
                    case "+":
                    case "-":
                    case "*":
                    case "/":
                        //xét độ ưu tiên
                        while (sStack.Count > 0 && testPrecedence(infix[i]) <= testPrecedence(sStack.Peek()))
                        {
                            prefix[count++] = sStack.Pop();
                            prefix[count++] = " ";
                        }
                        sStack.Push(infix[i]);
                        break;
                        //nếu là dấu ')' thì đưa vào trong stack
                    case ")":
                        sStack.Push(infix[i]);
                        break;
                        // nếu là dấu '(' thì lấy toán tử ra cho tới khi gặp ')'
                        // dấu ')' cũng đưa ra ngoài stack
                    case "(":
                        do
                        {
                            //kiểm tra xem stack có rỗng hay ko
                            if (sStack.Count > 0)
                            {
                                x = sStack.Pop();
                                if (x != ")")
                                {
                                    //đưa ra output
                                    prefix[count++] = x;
                                    prefix[count++] = " ";
                                }
                            }

                            //nếu stack rỗng mà không gặp dấu ')' thì thông báo
                            else
                            {
                                MessageBox.Show("Bạn thiếu dấu ')' Kiểm tra lại biểu thức");
                                return;
                            }
                        }
                        while (x != ")");
                        break;
                        
                    case " ":
                        break;
                    default:
                            prefix[count++] = infix[i];
                            prefix[count++] = " ";
                        
                        break;

                }
            }

            //Sau khi duyệt hết biểu thức mà trong stack còn toán tử thì lấy hết ra
            while (sStack.Count > 0)
            {
                //Nếu trong stack vẫn còn ')' thì báo lỗi
                if (sStack.Peek() == ")")
                {
                    MessageBox.Show("Thừa dấu ')' Kiểm tra lại biểu thức");
                    return;
                }
                //lấy các phần tử òn lại đưa ra khỏi stack
                else
                {
                    prefix[count++] = sStack.Pop();
                    prefix[count++] = " ";
                }

            }
            for (int i = 0; i <= prefix.Length / 2; i++)
            {
                string a = prefix[i];
                prefix[i] = prefix[prefix.Length - 1 - i];
                prefix[prefix.Length - 1 - i] = a;
            }
            txtChuyenDoi.ResetText();

        }

        private string postfix_to_infix()
        {
            postfix = new string[100];
            postfix = txtNhap.Text.Trim().Split(' ');
            Stack<string> sStack = new Stack<string>();
            // Duyệt từ trái qua phải của biểu thức
            for (int i = 0; i < postfix.Length; i++)
            {
                // Nếu là toán hạng thì push vào trong stack
                if (testOperand(postfix[i]))
                {
                    sStack.Push(postfix[i]);
                }
                // Nếu là toán tử thì lấy 2 phẩn tử trên đỉnh stack xong thực hiện phép tính tương ứng
                else
                {
                    
                    string b = sStack.Pop();
                    string a = sStack.Pop();
                    string result = "";
                    switch (postfix[i])
                    {
                        case "+":
                            result = "(" + a + " + " + b + ")";
                            break;
                        case "-":
                            result = "(" + a + " - " + b + ")";
                            break;
                        case "*":
                            result = "(" + a + " * " + b + ")";
                            break;
                        case "/":
                            result = "(" + a + " / " + b + ")";
                            break;
                    }
                    sStack.Push(result);
                    
                }
                
            }
            return sStack.Pop();
        }

        private void postfix_to_prefix()
        {
            // chuyển đổi từ postfix sang infix
            string temp = postfix_to_infix();
            // chuyển đổi từ infix sang postfix
            infix_to_prefix(temp);
            
            
        }

        private string prefix_to_infix()
        {
            Stack<string> sStack = new Stack<string>();
            prefix = new string[100];
            prefix = txtNhap.Text.Trim().Split(' ');
            //Duyệt từ phải qua trái của biểu thức
            for (int i = prefix.Length - 1; i >= 0; i--)
            {
                //nếu là toán hạng thì push vào stack
                if (testOperand(prefix[i]))
                {
                    sStack.Push(prefix[i]);
                }
                //nếu là toán tử thì lấy 2 phần tử ở đỉnh stack và thực hiện phếp tính
                else
                {
                    string a = sStack.Pop();
                    string b = sStack.Pop();
                    string result = "";
                    switch (prefix[i])
                    {
                        case "+":
                            result = "(" + a + " + " + b + ")";
                            break;
                        case "-":
                            result = "(" + a + " - " + b + ")";
                            break;
                        case "*":
                            result = "(" + a + " * " + b + ")";
                            break;
                        case "/":
                            result = "(" + a + " / " + b + ")";
                            break;
                    }
                    sStack.Push(result);
                }
                
            }
            return sStack.Pop();
        }

        private void prefix_to_postfix()
        {
            //đưa prefix về infinx
            string temp = prefix_to_infix();
            //string str=ReverseString(temp)
            //đưa infix về postfix
            infix_to_postfix(temp);
        }

        private string result_infix()
        {
            Stack<string> sStack = new Stack<string>();
            infix_to_postfix(txtNhap.Text.Trim());
            for (int i = 0; i < postfix.Length; i++)
            {
                if (postfix[i] == " " || postfix[i] == "" || postfix[i] == null)
                {
                    continue;
                }
                // nếu là toán hạng thì cho vào stack
                if (testOperand(postfix[i]))
                {
                    sStack.Push(postfix[i]);
                }
                //nếu là toán tử thì lấy 2 phần tử ở đỉnh stack ra và thực hiện phép tính
                else
                {
                    double b = Convert.ToDouble(sStack.Pop());
                    double a = Convert.ToDouble(sStack.Pop());
                    double result = 0;
                    switch (postfix[i])
                    {
                        case "+":
                            result = a + b;
                            break;
                        case "-":
                            result = a - b;
                            break;
                        case "*":
                            result = a * b;
                            break;
                        case "/":
                            result = a / b;
                            break;
                    }
                    sStack.Push(result.ToString());
                }
            }
            return sStack.Pop();
        }

        private string result_postfix()
        {
            Stack<string> sStack = new Stack<string>();
            postfix = txtNhap.Text.Trim().Split(' ');
            for (int i = 0; i < postfix.Length; i++)
            {
                if (postfix[i] == " ")
                {
                    continue;
                }
                if (testOperand(postfix[i]))
                {
                    sStack.Push(postfix[i]);
                }
                else
                {
                    double b=Convert.ToDouble(sStack.Pop());
                    double a=Convert.ToDouble(sStack.Pop());
                    double result=0;
                    switch (postfix[i])
                    {
                        case "+":
                            result = a + b;
                            break;
                        case "-":
                            result = a - b;
                            break;
                        case "*":
                            result = a * b;
                            break;
                        case "/":
                            result = a / b;
                            break;
                    }
                    sStack.Push(result.ToString());
                }
            }
            return sStack.Pop();
        }

        private string result_prefix()
        {
            Stack<string> sStack = new Stack<string>();
            prefix = txtNhap.Text.Trim().Split(' ');
            for (int i = prefix.Length - 1; i >= 0; i--)
            {
                // nếu là toán hạng thì cho vào stack
                if (testOperand(prefix[i]))
                {
                    sStack.Push(prefix[i]);
                }
                //nếu là toán tử thì lấy 2 phần tử ở đỉnh stack ra và thực hiện phép tính
                else
                {
                    double a = Convert.ToDouble(sStack.Pop());
                    double b = Convert.ToDouble(sStack.Pop());
                    double result = 0;
                    switch (prefix[i])
                    {
                        case "+":
                            result = a + b;
                            break;
                        case "-":
                            result = a - b;
                            break;
                        case "*":
                            result = a * b;
                            break;
                        case "/":
                            result = a / b;
                            break;
                    }
                    sStack.Push(result.ToString());
                }
            }
            return sStack.Pop();
        }

        private void btnKetQua_Click(object sender, EventArgs e)
        {
            //Infix
            if (rbtnInfixBT.Checked == true)
            {
                txtKetQua.Text = result_infix();
               
                if (rbtnInfixCD.Checked == true)
                {
                    txtChuyenDoi.Text = txtNhap.Text;
                    

                }
                else if (rbtnPostfixCD.Checked == true)
                {
                    infix_to_postfix(txtNhap.Text.Trim());
                    txtChuyenDoi.ResetText();
                    for (int i = 0; i < postfix.Length; i++)
                    {
                        txtChuyenDoi.Text += postfix[i];
                    }
                }
                else
                {
                    
                    infix_to_prefix(txtNhap.Text.Trim());
                    txtChuyenDoi.ResetText();
                    for (int i = 0; i < prefix.Length; i++)
                    {
                        txtChuyenDoi.Text += prefix[i];
                    }
                    //string a = txtChuyenDoi.Text.ToString();
                    //string b = ReverseString(a);
                    //txtChuyenDoi.Text = b;
                    
                }
                
            }

                //Prefix
            else if (rbtnPrefixBT.Checked == true)
            {
                txtKetQua.Text = result_prefix();
                if (rbtnInfixCD.Checked == true)
                {
                    txtChuyenDoi.Text = prefix_to_infix();
                }
                else if (rbtnPrefixCD.Checked == true)
                {
                    txtChuyenDoi.Text = txtNhap.Text;
                }
                else
                {
                    prefix_to_postfix();
                    for (int i = 0; i < postfix.Length; i++)
                    {
                        txtChuyenDoi.Text += postfix[i];
                    }
                }
                
            }

            //Postfix

            else
            {
                txtKetQua.Text = result_postfix();
                if (rbtnInfixCD.Checked == true)
                {
                    txtChuyenDoi.Text = postfix_to_infix();
                }
                else if (rbtnPrefixCD.Checked == true)
                {
                    postfix_to_prefix();
                    for (int i = 0; i < prefix.Length; i++)
                    {
                        txtChuyenDoi.Text += prefix[i];
                    }
                    //string a = txtChuyenDoi.Text.ToString();
                    //string b = ReverseString(a);
                    //txtChuyenDoi.Text = b;
                }
                else
                {
                    txtChuyenDoi.Text = txtNhap.Text;
                }
                
            }
        }

        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray(); // chuỗi thành mảng ký tự
            Array.Reverse(arr); // đảo ngược mảng
            return new string(arr); // trả về chuỗi mới sau khi đảo mảng
        }





    }
}
