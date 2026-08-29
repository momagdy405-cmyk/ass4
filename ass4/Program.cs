namespace ass4
{



    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //Add a private string password = "secret"; field to a Book class. Try to print it from Main (outside the class). What happens, and why? 

            //class Book()
            //{
            //private string password = "secret";}

            //Book b = new Book();
            //Console.WriteLine(b.password);

            #endregion
            #region Q2
            //Add an internal int copiesInStock = 5; field to Book. Print it from Main. Does it compile? Why? 


            //class Book()
            //{
            //internal int copiesInStock = 5;
            //}
            //Book B = new Book();
            //Console.WriteLine(B.copiesInStock); 
            #endregion
            #region Q3
            //class Book()
            //{
            //public string title = "clean code";
            //}
            //Book b = new Book();
            //Console.WriteLine(b.title);  
            #endregion
            #region Q4
            //Declare an enum Genre { Fiction, NonFiction, Science }. Add a Genre property to Book, assign it Genre.Science, and print it. 

            //class Book()
            //{
            //    public Genre G = Genre.science;
            //}
            //public enum Genre {
            //    unknown,
            //    fiction,
            //    nonfiction,
            //    science

            //}

            //Book bo = new Book();
            //Console.WriteLine(bo.G);

            #endregion
            #region Q5
            //Using the Genre enum above, print the underlying int value of Genre.Fiction, Genre.NonFiction, and Genre.Science by casting each to int. 

            //public enum Genre {
            //    unknown,
            //    fiction,
            //    nonfiction,
            //    science

            //}

            //Genre genre1 = Genre.fiction;
            //Console.WriteLine((int)genre1);
            // Genre genre2 = Genre.nonfiction;
            //Console.WriteLine((int)genre2);
            //Genre genre3 = Genre.science;
            //Console.WriteLine((int)genre3);
            #endregion
            #region Q6
            //Given int genreNumber = 1;, cast it into a Genre value and print the result. 
            //public enum Genre {
            //    unknown,
            //    fiction,
            //    nonfiction,
            //    science

            //}
            //int genrenumber = 1;
            //Genre g = (Genre)genrenumber;
            //Console.WriteLine(g);
            #endregion
            #region Q7
            //Given Genre genre = Genre.Fiction;, convert it into a string using ToString() and print it. 

            //public enum Genre {
            //    unknown,
            //    fiction,
            //    nonfiction,
            //    science

            //}
            //Genre genre = Genre.fiction;
            //string txt = genre.ToString();
            //Console.WriteLine(txt);
            #endregion
            #region Q9
            //Given string genreText = "Science";, convert it into a Genre value using Enum.Parse() and print the result. 

            //public enum Genre {
            //    unknown,
            //    fiction,
            //    nonfiction,
            //    science
            //}
            //string genretext = "sceince";
            //Genre genre = (Genre)Enum.Parse(typeof(Genre),genretext);
            //Console.WriteLine(genretext);
            #endregion
            #region Q10
            //Given string genreText = "Mystery"; (not a valid Genre value), use Enum.TryParse() to attempt the conversion. Print "Unknown genre" if it fails. 

            //public enum Genre {
            //    unknown,
            //    fiction,
            //    nonfiction,
            //    science
            //}

            //string genretext = "science";
            //bool genre = Enum.TryParse(typeof(Genre), genretext, out var res);
            //if (!genre)
            //{
            //    Console.WriteLine("unknown genre");
            //}
            //else
            //{
            //    Console.WriteLine(res);
            //}
            #endregion




        }
    }
}
