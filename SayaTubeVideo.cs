using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TPMOD6
{
    internal class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string judul_video)
        {
            Random random = new Random();
            
            Debug.Assert(!string.IsNullOrEmpty(judul_video), "Judul tidak boleh kosong");
            Debug.Assert(judul_video.Length <= 100, "Panjang judul tidak boleh melebihi 100 karakter");
            this.title = judul_video;
            this.id =  random.Next(10000,99999);
            this.playCount = 0;
        }

        public void IncreasePlayCount(int playCount)
        {
            Debug.Assert(playCount <= 10000000,"maksimum penambahan play count adalah 10.000.000 untuk setiap panggilan");
            try
            {
                int tes = checked(this.playCount + playCount);
                this.playCount = tes;
            }catch(Exception overFlow)
            {
                Console.WriteLine(overFlow.Message);
            }
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("Video id : " + id);
            Console.WriteLine("Video title : " + title);
            Console.WriteLine("Video play count : " + playCount);
        }
    }
}
