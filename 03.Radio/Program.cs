using System;
class Program
{
    static void Main()
    {
        MenuRadio();
    }

    static void MenuRadio()
    {
        int n;
        string[] info;
        Playlist playlist = new Playlist();
        Console.WriteLine("Enter quantity of songs:");
        n = int.Parse(Console.ReadLine());
        Song song = new Song();
        try
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter info about {i + 1} song:");
                info = Console.ReadLine().Split(" ");
                song = new Song(info[0], info[1], int.Parse(info[2]), int.Parse(info[3]));
                playlist.AddSong(song);
            }
            playlist.ShowTimePlaylist();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

    }
}