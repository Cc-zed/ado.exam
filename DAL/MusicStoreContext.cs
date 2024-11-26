protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
{
    try
    {
        optionsBuilder.UseSqlServer("Server=localhost;Database=MusicStoreDb;Integrated Security=True;");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error configuring database: {ex.Message}");
    }
}
