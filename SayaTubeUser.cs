using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_103022300114
{
    class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        private String username;

        public SayaTubeUser(string username)
        {
            //Contract.Requires(username.Length <= 200 && username != null);
            //Debug.Assert(username.Length <= 100 && username != null, "Username tidak boleh melebihi 100 karakter atau null");
            this.username = username;
            uploadedVideos = new List<SayaTubeVideo>();
        }

        public int GetTotalVideoPlayCount()
        {
            int res = 0;
            for (int i = 0; i < uploadedVideos.Count; i++)
            {
                res += uploadedVideos[i].GetPlayCount();
            }
            return res;
        }

        public void AddVideo(SayaTubeVideo vid)
        {
            //Contract.Requires(vid.GetPlayCount() > 250000000 && vid != null);
            //Debug.Assert(vid.GetPlayCount() < 250000000 && vid != null, "Username tidak boleh melebihi 100 karakter atau null");
            uploadedVideos.Add(vid);
        }

        public void PrintAllVideoPlayCount()
        {
            Console.WriteLine("User: " + username);
            for (int i = 0; i < uploadedVideos.Count; i++)
            {
                Console.WriteLine("Video " + i + 1 + " judul: " + uploadedVideos[i].GetTitle() + " Views: " + uploadedVideos[i].GetPlayCount());
            }
            //Contract.Ensures(uploadedVideos.Count <= 8);
        }
    }
}