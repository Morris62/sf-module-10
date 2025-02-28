namespace Module_10;

class Program
{
    class FileManager : IWriter, IReader, IMailer
    {
        void IWriter.Write()
        {
            Console.WriteLine("Запись в файл...");
        }

        void IReader.Read()
        {
            Console.WriteLine("Чтение файла...");
        }

        void IMailer.SendEmail()
        {
            Console.WriteLine("Отправка электронной почты..");
        }

        public void Search(string text)
        {
            Console.WriteLine($"Поиск {text}");
        }
    }

    static void Main(string[] args)
    {
        var fileManager = new FileManager();
        IReader reader = new FileManager();
        IWriter writer = new FileManager();
        IMailer mailer = new FileManager();
        
        reader.Read();
        writer.Write();
        mailer.SendEmail();
        fileManager.Search("Найди меня");

        Console.ReadKey();
    }
}