using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_103022300114
{
    class SayaTubeVideo
    {
        private int id, playCount;
        private String title;
        public SayaTubeVideo(String title)
        {
            Debug.Assert(title.Length <= 200 && title != null, "Judul video tidak boleh melebihi 200 karakter atau null");
            Contract.Requires(title.Length <= 200 && title != null);
            Random rand = new Random();
            this.title = title;
            this.id = rand.Next(10000, 99999);
            this.playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            Contract.Requires(count <= 25000000 && count > 0);
            Debug.Assert(count <= 25000000 && count > 0, "Jumlah count tidak boleh melebihi 250.000.000 dan tidak boleh negatif");
            try
            {
                checked
                {
                    this.playCount += count;
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: overflow!");
            }
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine(id);
            Console.WriteLine(title);
            Console.WriteLine("playCount: " + playCount);
        }

        public int GetPlayCount()
        {
            return this.playCount;
        }

        public String GetTitle()
        {
            return this.title;
        }
    }
}