//  Дан текст. В тексте нужно все пробелы заменить черточками, 
// маленькие буквы “к” заменить большими “К”, 
// а большие “С” заменить маленькими “с”. Ясна ли задача?
// — Я думаю, — сказал князь, улыбаясь, 
// — что, ежели бы вас послали вместо нашего милого Винценгероде, 
// вы бы взяли приступом согласие прусского короля. 
// Вы так красноречивы. Вы дадите мне чаю?

// string d = "qwerty"
//             012345
// s[3] // r

string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int lenght = text.Length;
    for (int i = 0; i < lenght; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'k', 'K');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'В', 'в');
Console.WriteLine(newText);