using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_103022300016
{
    class SayaTubeVideo
    {
        private int id;
        private String title;
        private int playCount;
        Random random = new Random();

        public SayaTubeVideo(String title)
        // Constructor meminta input title dan menginisialisasi id dan playCount 
        {
            this.id = random.Next(10000, 99999); // id diinisialisasi dengan random number
            this.title = title;
            this.playCount = 0; // play count awal di set 0 
        }

        public void increasePlayCount(int views)
        // Method untuk menambah jumlah view 
        {
            this.playCount += views;
        }

        public void printVideoDetail()
        // Method untuk menampilkan detail video 
        {
            Console.WriteLine("ID Video: " + this.id);
            Console.WriteLine("Judul Video: " + this.title);
            Console.WriteLine("Jumlah View: " + this.playCount);
        }

        public int getPlayCount()
        // getter untuk mendapatkan play count
        {
            return this.playCount;
        }

        public String getTitle()
        // getter untuk mendapatkan title 
        {
            return this.title;
        }
    }
}
