using System;
using System.Collections.Generic;
using System.Text;

namespace RecordsLib.Model
{
    public class Records
    {
        private int _id;
        private string _title;
        private string _artist;
        private int _songDuration;

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public string Title
        {
            get => _title;
            set => _title = value;
        }

        public string Artist
        {
            get => _artist;
            set => _artist = value;
        }

        public int SongDuration
        {
            get => _songDuration;
            set => _songDuration = value;
        }

        public Records(int id, string title, string artist, int songDuration)
        {
            _id = id;
            _title = title;
            _artist = artist;
            _songDuration = songDuration;
        }
   

        
    }
}
