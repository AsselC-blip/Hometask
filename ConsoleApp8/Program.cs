

using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("Выберите действие:");
        Console.WriteLine("1. Найти слова, содержащие максимальное количество цифр.");
        Console.WriteLine("2. Найти самое длинное слово и определить, сколько раз оно встретилось в тексте.");
        Console.WriteLine("3. Заменить цифры от 0 до 9 на слова «ноль», «один», …, «девять».");
        Console.WriteLine("4. Вывести на экран сначала вопросительные, а затем восклицательные предложения.");
        Console.WriteLine("5. Вывести на экран только предложения, не содержащие запятых.");
        Console.WriteLine("6. Найти слова, начинающиеся и заканчивающиеся на одну и ту же букву.");
        Console.WriteLine("0. Выход.");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                FindWordsWithMaxDigits();
                break;
            case "2":
                FindLongestWord();
                break;
            case "3":
                ReplaceDigitsWithWords();
                break;
            case "4":
                PrintQuestionAndExclamationSentences();
                break;
            case "5":
                PrintSentencesWithoutCommas();
                break;
            case "6":
                FindWordsWithSameFirstAndLastLetter();
                break;
            case "0":
                return;
            default:
                Console.WriteLine("Неверный выбор.");
                break;
        }

        Main();
    }

    static string ReadTextFromConsole()
    {
        Console.WriteLine("Введите текст:");
        return Console.ReadLine();
    }

    static string ReadTextFromFile(string filePath)
    {
        try
        {
            return File.ReadAllText(filePath);
        }
        catch (Exception e)
        {
            Console.WriteLine("Ошибка при чтении файла: " + e.Message);
            return null;
        }
    }

    static void FindWordsWithMaxDigits()
    {
        string text = ReadTextFromConsole();
        
        string[] words = text.Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

        int maxDigitCount = 0;
        foreach (string word in words)
        {
            int digitCount = word.Count(char.IsDigit);
            if (digitCount > maxDigitCount)
            {
                maxDigitCount = digitCount;
            }
        }

        var wordsWithMaxDigits = words.Where(word => word.Count(char.IsDigit) == maxDigitCount);

        Console.WriteLine("Слова, содержащие максимальное количество цифр:");
        foreach (string word in wordsWithMaxDigits)
        {
            Console.WriteLine(word);
        }
    }

    static void FindLongestWord()
    {
        string text = ReadTextFromConsole();
        

        string[] words = text.Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

        string longestWord = "";
        int longestWordCount = 0;

        foreach (string word in words)
        {
            int wordCount = words.Count(w => w == word);
            if (word.Length > longestWord.Length || (word.Length == longestWord.Length && wordCount > longestWordCount))
            {
                longestWord = word;
                longestWordCount = wordCount;
            }
        }

        Console.WriteLine($"Самое длинное слово: {longestWord}");
        Console.WriteLine($"Количество повторений: {longestWordCount}");
    }

    static void ReplaceDigitsWithWords()
    {
        string text = ReadTextFromConsole();
  


        string replacedText = Regex.Replace(text, @"\d", digit =>
        {
            switch (digit.Value)

            {
                case "0":
                    return "ноль";
                case "1":
                    return "один";
                case "2":
                    return "два";
                case "3":
                    return "три";
                case "4":
                    return "четыре";
                case "5":
                    return "пять";
                case "6":
                    return "шесть";
                case "7":
                    return "семь";
                case "8":
                    return "восемь";
                case "9":
                    return "девять";
                default:
                    return digit.Value;
            }
        });

        Console.WriteLine("Текст после замены цифр на слова:");
        Console.WriteLine(replacedText);
    }

    static void PrintQuestionAndExclamationSentences()
    {
        string text = ReadTextFromConsole();
       

        string[] sentences = text.Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

        var questionSentences = sentences.Where(sentence => sentence.Trim().EndsWith("?"));
        var exclamationSentences = sentences.Where(sentence => sentence.Trim().EndsWith("!"));

        Console.WriteLine("Вопросительные предложения:");
        foreach (string sentence in questionSentences)
        {
            Console.WriteLine(sentence);
        }

        Console.WriteLine("Восклицательные предложения:");
        foreach (string sentence in exclamationSentences)
        {
            Console.WriteLine(sentence);
        }
    }

    static void PrintSentencesWithoutCommas()
    {
        string text = ReadTextFromConsole();
        

        string[] sentences = text.Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

        var sentencesWithoutCommas = sentences.Where(sentence => !sentence.Contains(","));

        Console.WriteLine("Предложения без запятых:");
        foreach (string sentence in sentencesWithoutCommas)
        {
            Console.WriteLine(sentence);
        }
    }

    static void FindWordsWithSameFirstAndLastLetter()
    {
        string text = ReadTextFromConsole();
       

        string[] words = text.Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

        var wordsWithSameFirstAndLastLetter = words.Where(word => word.Length > 1 && char.ToLower(word[0]) == char.ToLower(word[word.Length - 1]));

        Console.WriteLine("Слова, начинающиеся и заканчивающиеся на одну и ту же букву:");
        foreach (string word in wordsWithSameFirstAndLastLetter)
        {
            Console.WriteLine(word);
        }
    }
}

