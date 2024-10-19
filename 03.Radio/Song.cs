using System;

public class Song
{
	string artistName;
	string songName;
	int minutes;
	int seconds;

	public Song()
	{
       
    }
	public Song(string songName, string artistName, int minutes, int seconds)
	{
		SongName = songName;
		ArtistName = artistName;
		Minutes = minutes;
		Seconds = seconds;
        Console.WriteLine("Song added");
    }
	protected string ArtistName
	{
		get
		{ return artistName; }
		set
		{
			if (value.Length < 3 && value.Length > 20)
				throw new InvalidArtistNameException();
			artistName = value;
		}
	}
	protected string SongName
	{
		get { return songName; }
		set
		{
			if (value.Length < 3 && value.Length > 30)
				throw new InvalidSongNameException();
			songName = value;
		}
	}
	public int Minutes
	{
		get { return minutes; }
		set
		{
			if (value < 0 && value > 14)
				throw new InvalidSongMinutesException();
			minutes = value;
		}
	}
	public int Seconds
	{
		get { return seconds; }
		set
		{
			if (value < 0 && value > 14)
				throw new InvalidSongSecondsException();
			seconds = value;
		}
	}
}
