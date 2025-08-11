using System.ComponentModel.DataAnnotations.Schema;

namespace StarCrew.Models;

[Table("users")]
public class User
{
    [Column("id")]
    public int Id { get; set; }
    [Column("username")]
    public string? Username { get; set; }
    [Column("email")]
    public string? Email { get; set; }
    [Column("password_hash")]
    public string? Password_hash { get; set; }
    [Column("bio")]
    public string? Bio { get; set; }
    [Column("avatar_url")]
    public string? Avatar_url { get; set; }
    [Column("created_at")]
    public DateTime Created_at { get; set; }
    [Column("is_superadmin")]
    public bool Is_superadmin { get; set; }
    [Column("public_name")]
    public string? Public_name { get; set; }
}

