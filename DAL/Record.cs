public class Record
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Artist { get; set; }
    public string Publisher { get; set; }
    public int TrackCount { get; set; }
    public string Genre { get; set; }
    public int ReleaseYear { get; set; }
    public decimal CostPrice { get; set; }
    public decimal SalePrice { get; set; }
}


public void AddRecord(Record record)
{
    using (var context = new MusicStoreContext())
    {
        context.Records.Add(record);
        context.SaveChanges();
    }
}




public void RemoveRecord(int recordId)
{
    using (var context = new MusicStoreContext())
    {
        var record = context.Records.Find(recordId);
        if (record != null)
        {
            context.Records.Remove(record);
            context.SaveChanges();
        }
    }
}


public void UpdateRecord(Record record)
{
    using (var context = new MusicStoreContext())
    {
        context.Records.Update(record);
        context.SaveChanges();
    }
}


public List<Record> SearchRecords(string searchTerm)
{ 
    using (var context = new MusicStoreContext())
    {
        return context.Records
            .Where(r => r.Title.ToLower().Contains(searchTerm.ToLower()) ||
                         r.Artist.ToLower().Contains(searchTerm.ToLower()) ||
                         r.Genre.ToLower().Contains(searchTerm.ToLower()))
            .ToList();
    }
}

public void DeleteAllREcords(Record record)
{
    using(car context = )
}