using System.Collections.Generic;

namespace Collections.LinkedLists
{
    /// <summary>
    /// Linked List demo model
    /// </summary>
    public class LinkedListsDemo
    {
        /// <summary>
        /// Run Linked List Collection demo
        /// </summary>
        public static void Run()
        {
            var song1 = new PlaylistItem("song1");
            var song2 = new PlaylistItem("song2");
            var song3 = new PlaylistItem("song3");
            var song4 = new PlaylistItem("song4");

            // create a LinkedList for playlist
            var playlist = new LinkedList<PlaylistItem>();

            // LinkedList provides 4 different methods to add nodes 
            playlist.AddFirst(song4);
            playlist.AddAfter(playlist.First, song2);
            playlist.AddBefore(playlist.Last, song1);
            playlist.AddLast(song3);

            // LinkedList provides 5 different methods to remove nodes 
            playlist.RemoveFirst();
            playlist.Remove(song2);
            playlist.Remove(playlist.Last);
            playlist.RemoveLast();
            playlist.Clear();

            // check if node exists in LinkedList
            if (playlist.Contains(song3))
            {
                // contains
            }
        }
    }
}
