using System;

class SongNode {
    public string SongName;
    public string Artist;
    public double Duration; // Duration in minutes
    public SongNode Next;

    public SongNode(string songName, string artist, double duration) {
        SongName = songName;
        Artist = artist;
        Duration = duration;
        Next = this; // Circular linked list (points to itself)
    }
}

class MusicPlaylist {
    private SongNode head = null;
    private SongNode currentSong = null; // To track the currently playing song

    // ✅ Add Song at the Beginning
    public void AddAtBeginning(string songName, string artist, double duration) {
        SongNode newNode = new SongNode(songName, artist, duration);
        if (head == null) {
            head = newNode;
            currentSong = head;
        } else {
            SongNode last = head;
            while (last.Next != head) {
                last = last.Next;
            }
            newNode.Next = head;
            last.Next = newNode;
            head = newNode;
        }
    }

    // ✅ Add Song at the End
    public void AddAtEnd(string songName, string artist, double duration) {
        SongNode newNode = new SongNode(songName, artist, duration);
        if (head == null) {
            head = newNode;
            currentSong = head;
        } else {
            SongNode last = head;
            while (last.Next != head) {
                last = last.Next;
            }
            last.Next = newNode;
            newNode.Next = head;
        }
    }

    // ✅ Delete Song by Name
    public void DeleteSong(string songName) {
        if (head == null) {
            Console.WriteLine("Playlist is empty.");
            return;
        }

        SongNode temp = head, prev = null;

        // If head node itself holds the song to be deleted
        if (temp.SongName == songName) {
            SongNode last = head;
            while (last.Next != head) {
                last = last.Next;
            }

            if (head == head.Next) { // Only one node
                head = null;
                currentSong = null;
            } else {
                head = head.Next;
                last.Next = head;
            }
            Console.WriteLine("Deleted: {0}",songName);
            return;
        }

        // Search for the song to delete
        do {
            prev = temp;
            temp = temp.Next;
        } while (temp != head && temp.SongName != songName);

        if (temp == head) {
            Console.WriteLine("Song not found.");
            return;
        }

        prev.Next = temp.Next;
        Console.WriteLine("Deleted: {0}",songName);
    }

    // ✅ Play Next Song
    public void PlayNext() {
        if (currentSong == null) {
            Console.WriteLine("Playlist is empty.");
            return;
        }
        currentSong = currentSong.Next;
        Console.WriteLine("Now Playing: {0} by {1} ({2} min)",currentSong.SongName,currentSong.Artist,currentSong.Duration);
    }

    // ✅ Display Playlist
    public void DisplayPlaylist() {
        if (head == null) {
            Console.WriteLine("Playlist is empty.");
            return;
        }

        Console.WriteLine("\n Music Playlist:");
        SongNode temp = head;
        do {
            Console.WriteLine(" {0} - {1} ({2} min)",temp.SongName,temp.Artist,temp.Duration);
            temp = temp.Next;
        } while (temp != head);
    }
}

// ✅ Main Program
class Program {
    public static void Main() {
        MusicPlaylist playlist = new MusicPlaylist();

        // Add songs
        playlist.AddAtEnd("Shape of You", "Ed Sheeran", 4.24);
        playlist.AddAtEnd("Blinding Lights", "The Weeknd", 3.50);
        playlist.AddAtBeginning("Bohemian Rhapsody", "Queen", 5.55);

        // Display playlist
        playlist.DisplayPlaylist();

        // Play next song
        Console.WriteLine("\n Playing next song...");
        playlist.PlayNext();

        Console.WriteLine("\n Playing next song...");
        playlist.PlayNext();

        // Delete a song
        Console.WriteLine("\n🗑 Deleting 'Blinding Lights'...");
        playlist.DeleteSong("Blinding Lights");

        // Display updated playlist
        playlist.DisplayPlaylist();
    }
}
