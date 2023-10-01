using DapperWork;

namespace Dapper
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Dapper();
        }

        public static void Dapper()
        {
            var film = DapperRepository.GetInfo(100);
            foreach (var a in film)
            {
                Print(a);
            }
        }
        //public static void Dapper()  - получение фильма с требуемым названием
        //{
        //    var film = DapperRepository.GetInfo("Academy Dinosaur");
        //    foreach(var a in film)
        //    {
        //        Print(a);
        //    }
        //}
        //public static void Dapper() - получение уникальных имен актеров
        //{
        //    var film = DapperRepository.GetInfo();
        //    foreach (var a in film)
        //    {
        //        Print(a);
        //    }
        //}
        //public static void Dapper1() - получение количества фильмов с определенным рейтингом
        //{
        //    var film = DapperRepository.GetInfo1("G");
        //    foreach (var a in film)
        //    {
        //        Print(a);
        //    }
        //}
        public static void Print(Movies movies)
        {
            Console.WriteLine(movies.Title);
        }
    }
}