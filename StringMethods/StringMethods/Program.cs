#region ClassTasks

//1. Sinifde yazdiqlarimin hamisini yazib praktika etmek.

//using System.Text;

//StringBuilder sb = new StringBuilder("salam");
//sb.Append("sagol");

//string surname = "test";
//Console.WriteLine(surname.Length);


//string str1 = "salam";
//string str2 = "necesiz";
//string result=string.Concat(str1, str2);
//Console.WriteLine(result);

//string result = "";
//string result2=string.Empty;
//var result3 = result2 + "salam";

//string text ="   ";
//if (string.IsNullOrEmpty(text))
//{
//    Console.WriteLine("empty");
//}
//else 
//{
//    Console.WriteLine("fill"); ; 
//}    

//string text = "   ";
//if (string.IsNullOrWhiteSpace(text))

//    {
//        Console.WriteLine("empty");
//    }
//    else
//    {
//        Console.WriteLine("fill"); ;
//    }


//string text = "SaLAM";
//Console.WriteLine(text.ToUpper());
//string text = "SaLAM";
//Console.WriteLine(text.ToLower());

//string str1 = "  Apple";
//string str2 = "apple";
//Console.WriteLine(str1.Trim().ToLower()==str2.Trim().ToLower());

//string str1 = "  Apple";
//string str2 = "apple";
//Console.WriteLine(str1.Equals(str2));

//string str1 = "  Apple";
//string str2 = "apple";
//string CheckStr(string str)
//{
//    return str.Trim().ToLower();
//}
//Console.WriteLine(CheckStr(str1).Equals(CheckStr(str2)));




//string str = "This is the \"salam\"clas";

//string message = $"Welcometo {str}";
//Console.WriteLine(message);


//string text = "Azerbaycan";
//Console.WriteLine(string.Format(text));



//string authors = "Mahesh Chand, Henry he, Chris Love, Raj Beniwal";
//string[] authorsList= authors.Split(", ");

//foreach (string author in authorsList )
//{
//    Console.WriteLine(author);
//}



//string text = "Salam Azerbaycan";
//Console.WriteLine(text.Replace("Salam","sagol"));


//string text = "Salam Azerbaycan shjbdbjbjsbcjbjsbcjbcjbbc0";


//string result = text.Substring(0,5)+"...";
//Console.WriteLine(result);


//string text = "Salam Azerbaycan";
//Console.WriteLine(text.Contains("Az"));



//bool CheckCharInStr(string text, char letter)
//{
//    return text.Trim().Contains(letter.ToString().ToLower());  
//}

//Console.WriteLine( CheckCharInStr("Baku", 'B'));




//bool CheckCharInStr(string text, string letter)
//{
//    return text.Trim().Contains(letter.Trim().ToLower());
//}

//Console.WriteLine(CheckCharInStr("Baku", "B"));

#endregion



#region Home Tasks

//2. Parametr olaraq string qebul eden metod yazmalisiz. Hemin metod qebul etdiyi stringi tersine formada ekranda gostersin. (Cavid gelirse , ekranda divaC gorsensin).

string ReverseMethod(string word)
{
    char[] arr = word.ToCharArray();
    string reversedword = "";  //string.Empty de yazmaq olardi
    for (int i = arr.Length - 1; i >= 0; i--)
    {
        reversedword+= arr[i];
    }
    return reversedword;
}
//string word = "Cavid";
//Console.WriteLine(ReverseMethod(word));

#endregion





























