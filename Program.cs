static class Program
{
    //Вывод сообщения из файла
    //Вывод сообщения введите свое ФИО
    //Считывание ФИО
    //В файл дополняешь фио

    static void Main()
    {
         string UserName = Console.ReadLine();
        string path = "C:\\Users\\user\\LoremIpsum\\text.txt";      
        try 
        {
            var sr = new StreamReader(path);
            Console.WriteLine(sr.ReadToEnd());   
        }       
        catch (Exception e)
        {
           Console.WriteLine("The file could not be read:"  + e.Message);
        }       
    }
}
