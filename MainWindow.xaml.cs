using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HelloWorldDemoApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }
        public static int Addition(int a, int b)
        {
            return a + b;
        }

        private void Decoder(object sender, RoutedEventArgs e)
        {
            Dictionary<String, Char> morseCode = new Dictionary<String, Char>();
            String[] morseWords = new String[10];
            String code = "";
            String space = " ";

            morseCode.Add(".-", 'A'); morseCode.Add("..", 'I');
            morseCode.Add("-...", 'B'); morseCode.Add(".---", 'J');
            morseCode.Add("-.-.", 'C'); morseCode.Add("-.-", 'K');
            morseCode.Add("-..", 'D'); morseCode.Add(".-..", 'L');
            morseCode.Add(".", 'E'); morseCode.Add("--", 'M');
            morseCode.Add("..-.", 'F'); morseCode.Add("-.", 'N');
            morseCode.Add("--.", 'G'); morseCode.Add("---", 'O');
            morseCode.Add("....", 'H'); morseCode.Add(" ", ' ');
            morseCode.Add(".--.", 'P');
            morseCode.Add("--.-", 'Q');
            morseCode.Add(".-.", 'R');
            morseCode.Add("...", 'S');
            morseCode.Add("-", 'T');
            morseCode.Add("..-", 'U');
            morseCode.Add("...-", 'V');
            morseCode.Add(".--", 'W');
            morseCode.Add("-..-", 'X');
            morseCode.Add("-.--", 'Y');
            morseCode.Add("--..", 'Z');

            List<string> morseWordsListBefore = new List<string>();
            List<string> morseWordsListAfter = new List<string>();


            //code = getCode.Text;
            
            morseWordsListBefore.Add(getCode.Text);
            

            int listLen = morseWordsListBefore.Capacity;
            morseWords = morseWordsListBefore.ToArray();
            //Char ch = morseCode[value];
            Char[] valArray = new Char[100];
            //input = Console.ReadLine();
            //for (int i = 0; i < morseWords.Length; i++)
            //{
            //    getText.Text += morseWords[i];

            //}
            //Console.WriteLine(morseWords.Length);
            List<char> valList = new List<char>();
            List<string> keyList = new List<string>();
            foreach (KeyValuePair<String, Char> keyVal in morseCode)
            {
                keyList.Add(keyVal.Key);
                valList.Add(keyVal.Value);
            }
            string[] getString = keyList.ToArray();
            char[] getChar = valList.ToArray();

            for (int i = 0; i < morseWords.Length; i++)
            {
                for (int j = 0; j < getString.Length; j++)
                {
                    if (morseWords[i] == getString[j])
                    {
                        morseWordsListAfter.Add(Convert.ToString(getChar[j]) + " ");

                    }

                }
            }
            string[] decodedString = new string[100];
            decodedString = morseWordsListAfter.ToArray();
            int lenString = decodedString.Length;
            for (int x = 0; x < lenString; x++)
            {
                getText.Text += decodedString[x];
            }
        }
    }
}
