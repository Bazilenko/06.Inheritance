using System;

public class Playlist
{
    List<Song> songs = new List<Song>();
	public Playlist()
	{

    }
	public void AddSong(Song song)
	{
		songs.Add(song);
	}
	public void ShowTimePlaylist()
	{
		int minute = 0;
		int second = 0;
		int hour = 0;

		for (int i = 0; i < songs.Count; i++)
		{
			second += songs[i].Seconds;
			if (second > 59)
			{
				minute += second / 60;
				second = second % 60;
			}
			minute += songs[i].Minutes;
			if (minute > 59)
			{
				hour += minute / 60;
				minute = minute % 60;
			}
		}
		Console.WriteLine($"Length of playlist: {hour}h {minute}m {second}s");
	}
}
