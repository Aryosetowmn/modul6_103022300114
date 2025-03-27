// See https://aka.ms/new-console-template for more information

using modul6_103022300114;

class Run
{
    static void Main()
    {
        SayaTubeVideo vid1 = new SayaTubeVideo("Review Film Bruce Almighty oleh Aryoseto");
        SayaTubeVideo vid2 = new SayaTubeVideo("Review Film Truman Show oleh Aryoseto");
        SayaTubeVideo vid3 = new SayaTubeVideo("Review Film Men In Black 1 oleh Aryoseto");
        SayaTubeVideo vid4 = new SayaTubeVideo("Review Film Spiderman 2 (Tobey Maguire) oleh Aryoseto");
        SayaTubeVideo vid5 = new SayaTubeVideo("Review Film Mr.Ron Clark Story (Tobey Maguire) oleh Aryoseto");
        SayaTubeVideo vid6 = new SayaTubeVideo("Review Film Pursuit Of Happyness oleh Aryoseto");
        SayaTubeVideo vid7 = new SayaTubeVideo("Review Film Rush Hour oleh Aryoseto");
        SayaTubeVideo vid8 = new SayaTubeVideo("Review Film Catch Me If You Can oleh Aryoseto");
        SayaTubeVideo vid9 = new SayaTubeVideo("Review Film Rush oleh Aryoseto");
        SayaTubeVideo vid10 = new SayaTubeVideo("Review Film Dead Poets Society oleh Aryoseto");
        //test
        //SayaTubeVideo vid11 = new SayaTubeVideo(null);
        SayaTubeUser user = new SayaTubeUser("Aryoseto");

        user.AddVideo(vid1);
        user.AddVideo(vid2);
        user.AddVideo(vid3);
        user.AddVideo(vid4);
        user.AddVideo(vid5);
        user.AddVideo(vid6);
        user.AddVideo(vid7);
        user.AddVideo(vid8);
        user.AddVideo(vid9);
        user.AddVideo(vid10);
        //user.AddVideo(vid11);

        vid1.IncreasePlayCount(100);
        //vid2.IncreasePlayCount(26000000);


        for (int i = 0; i < 100; i++)
        {
            vid4.IncreasePlayCount(1000000);
        }

        user.PrintAllVideoPlayCount();



    }
}