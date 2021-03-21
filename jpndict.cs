using System;
using System.Collections.Generic;
using System.Text;

namespace japanese_dict
{
    public class jpndict
    {
        public static string JsonConvert { get; private set; }

        public static string main_Dict(string x)
        {
            //Below is the dictionary for all the current words in the program/list.
            string fill = "System.Windows.Controls.ListBoxItem: ";
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add(fill + "hello", "Hiragana: こんにちは \nRomaji: Kon-ni-chi-wa" );
            dict.Add(fill + "goodbye", "Hiragana: さよなら \nRomaji: Sa-yo-na-ra");
            dict.Add(fill + "good night", "Hiragana: おやすみなさい \nRomaji: O-ya-su-mi-na-sai");
            dict.Add(fill + "good morning", "Hiragana: おはようございます \nRomaji: O-ha-you-go-sai-ma-su");
            dict.Add(fill + "thank you for the meal", "Hiragana: いただきます \nRomaji: I-ta-da-ki-ma-su");
            dict.Add(fill + "good evening", "Hiragana: こんばんは \nRomaji: Kon-ban-wa");

            //Simple if/else statement to check if highlighted word in list is in the dictionary(all words highlighted should be in dict.
            if (dict.ContainsKey(x))
            {
                return dict[x];
            }
            else
            {
                return "What are you doing?";
            }
        }
    }
}
