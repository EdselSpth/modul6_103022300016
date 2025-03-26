using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            Debug.Assert(title != null, "judul tidak boleh kosong"); // precondition agar title tidak kosong
            Debug.Assert(title.Length <= 200, "judul tidak boleh melebihi 200 kata"); // precondition agar title tidak melebihi 200 kata
            this.id = random.Next(10000, 99999); // id diinisialisasi dengan random number
            this.title = title;
            this.playCount = 0; // play count awal di set 0 
        }

        public void increasePlayCount(int views)
        // Method untuk menambah jumlah view 
        {
            Debug.Assert(views <= 25000000, "views tidak boleh melebihi 25 juta"); // precondition agar sekali nambah views tidak lebih dari 25 juta views
            Debug.Assert(views >= 0, "views tidak boleh negatif"); // precondition agar views tidak negatif
            try // exception handling untuk overflow
            {
                checked
                {
                    if (this.playCount > int.MaxValue - views)
                    {
                        throw new OverflowException(); // exception handling jika play count melebihi batas maksimum
                    }
                    this.playCount += views;
                }
            }
            catch (OverflowException) // exception handling untuk play count melebihi batas maksimum
            {
                Console.WriteLine("ERROR: Play count melebihi batas maksimum");
                this.playCount = int.MaxValue;
            }

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
