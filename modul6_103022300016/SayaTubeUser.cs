using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_103022300016
{
    class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        public String username;
        Random random = new Random(); // untuk random id

        public SayaTubeUser(String username)
        // Constructor meminta input username dan menginisialisasi id dan uploadedVideos 
        {
            this.id = random.Next(10000, 99999); // id diinisialisasi dengan random number
            this.username = username; // username diinisialisasi dengan input
            this.uploadedVideos = new List<SayaTubeVideo>(); // uploadedVideos diinisialisasi dengan list kosong
        }

        public int getTotalVideoPlayCount()
        // method untuk mendapatkan totalPlayCount seluruh video
        {
            int jumlah = 0; // inisialisasi jumlah dengan 0 untuk menjumlahkan playcount
            for (int i = 0; i < uploadedVideos.Count; i++)
            // perulangan untuk menjumlahkan playcount
            {
                jumlah += uploadedVideos[i].getPlayCount();
            }
            return jumlah;
        }

        public void AddVideo(SayaTubeVideo video)
        // method untuk menambahkan video ke uploadedVideos
        {
            uploadedVideos.Add(video);
        }

        public void PrintAllPlayCount()
        // method untuk print seluruh video
        {
            Console.WriteLine($"User: {this.username}");
            int j = 1;
            for (int i = 0; i < uploadedVideos.Count; i++)
            {
                Console.WriteLine($"Video {j} judul: {uploadedVideos[i].getTitle()}");
                j++;
            }
        }
    }
}
