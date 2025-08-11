using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace StarCrew.Models;

[Table("posts")]
public class Post
{
    [Column("id")]
    public int Id { get; set; }

    [Column("user_id")]
    public int User_id { get; set; }
    // public User? User { get; set; } // Navigation property

    [Column("content")]
    public string? Content { get; set; }

    [Column("image_url")]
    public string? Image_url { get; set; }

    [Column("created_at")]
    public DateTime Created_at { get; set; }
}
