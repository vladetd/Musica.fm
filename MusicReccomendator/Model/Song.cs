//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MusicReccomendator.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Song
    {
        public int SongId { get; set; }
        public string SongTitle { get; set; }
        public int ArtistId { get; set; }
        public int AuthorId { get; set; }
        public int GenreId { get; set; }
        public System.DateTime Timestamp { get; set; }
        public Nullable<double> Duration { get; set; }
    
        public virtual Artist Artist { get; set; }
        public virtual Author Author { get; set; }
        public virtual Genre Genre { get; set; }
    }
}
