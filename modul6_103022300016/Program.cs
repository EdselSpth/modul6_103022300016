using modul6_103022300016;
using System;
namespace modul6_103022300016
{
    class Program
    {
        static void Main(string[] args)
        {
            // Membuat objek video
            SayaTubeVideo video1 = new SayaTubeVideo("Review Film Your Name oleh Edsel Septa Haryanto");
            video1.increasePlayCount(100000000);
            SayaTubeVideo video2 = new SayaTubeVideo("Review Film Weathering With You oleh Edsel Septa Haryanto");
            video2.increasePlayCount(200000000);
            SayaTubeVideo video3 = new SayaTubeVideo("Review Film Bungo Stray Dogs oleh Edsel Septa Haryanto");
            video3.increasePlayCount(300000000);
            SayaTubeVideo video4 = new SayaTubeVideo("Review Film Owari No Seraph oleh Edsel Septa Haryanto");
            video4.increasePlayCount(400000000);
            SayaTubeVideo video5 = new SayaTubeVideo("Review Film Sherlock Holmes oleh Edsel Septa Haryanto");
            video5.increasePlayCount(100);
            SayaTubeVideo video6 = new SayaTubeVideo("Review Film Avangers oleh Edsel Septa Haryanto");
            video6.increasePlayCount(200);
            SayaTubeVideo video7 = new SayaTubeVideo("Review Film Hololive 6th Fes oleh Edsel Septa Haryanto");
            video7.increasePlayCount(700000000);
            SayaTubeVideo video8 = new SayaTubeVideo("Review Film Touche oleh Edsel Septa Haryanto");
            video8.increasePlayCount(300);
            SayaTubeVideo video9 = new SayaTubeVideo("Review Film Interstellar oleh Edsel Septa Haryanto");
            video8.increasePlayCount(1929222);
            SayaTubeVideo video10 = new SayaTubeVideo("Review Film Assasins Creed oleh Edsel Septa Haryanto");
            video8.increasePlayCount(2832);

            // Membuat objek user
            SayaTubeUser user1 = new SayaTubeUser("Edsel Septa Haryanto");

            // Menambahkan video ke user
            user1.AddVideo(video1);
            user1.AddVideo(video2);
            user1.AddVideo(video3);
            user1.AddVideo(video4);
            user1.AddVideo(video5);
            user1.AddVideo(video6);
            user1.AddVideo(video7);
            user1.AddVideo(video8);
            user1.AddVideo(video9);
            user1.AddVideo(video10);

            // Menampilkan total play count
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("User: " + user1.username);
            Console.WriteLine("Total play count seluruh video: " + user1.getTotalVideoPlayCount());
            Console.WriteLine("---------------------------------------------------");

            // Menampilkan judul video
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Daftar Video");
            user1.PrintAllPlayCount();
            Console.WriteLine("----------------------------------------------------");
        }
    }
}