using ConsoleAppProject.Helpers;
using System;


namespace ConsoleAppProject.App04
{
    /// <summary>
    /// Class is user interface, allows user to
    /// post messages and photos
    /// </summary>
    public class PostUI : NewsFeed
    {
        private NewsFeed news = new NewsFeed();

        public void Run()
        {
            SocialMenu();
        }

        public void SocialMenu()
        {
            ConsoleHelper.OutputHeading("App04: A Social Space");

            string[] choices = new string[]
            {
                "Message Post",
                "Photo Post",
                "Display All",
                "Quit"
            };

            bool quit = false;

            while (quit != true)
            {
                int choice = ConsoleHelper.SelectChoice(choices);

                switch (choice)
                {
                    case 1: AddMessage(); break;
                    case 2: AddPhoto(); break;
                    case 3: DisplayAll(); break;
                    case 4: quit = true; break;
                }
            }
        }

        private void DisplayAll()
        {
            news.Display();
        }

        private void AddPhoto()
        {
            string name = GetUserName();

            Console.Write("Please enter filename > ");
            string filename = Console.ReadLine();

            Console.Write("Please enter caption > ");
            string caption = Console.ReadLine();

            PhotoPost post = new PhotoPost(name, filename, caption);
            news.AddPhotoPost(post);
        }

        private void AddMessage()
        {
            string name = GetUserName();

            Console.Write("Please enter message > ");
            string message = Console.ReadLine();

            MessagePost post = new MessagePost(name, message);
            news.AddMessagePost(post);
            //throw new NotImplementedException();
        }

        private string GetUserName()
        {
            Console.Write("Please enter your name > ");
            string name = Console.ReadLine();

            return name;
        }
    }
}
