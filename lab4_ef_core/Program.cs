// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using Model;
using var db = new BlogContext();
Console.WriteLine($"資料庫的路徑是:{db.DbPath}");
if (db.Blogs!.Count() == 0)
{
    db.Add(new Blog { Uri = "http://www.uuu.com.tw/" });
    db.Add(new Blog { Uri = "http://www.tibame.com/" });
    db.Add(new Blog { Uri = "http://hahow.in/" });
}
else
{
    Console.WriteLine("修改一下資料");
    var blog = db.Blogs!.OrderBy(b => b.BlogId).Last();
    blog.Uri = "https://www.cwb.gov.tw";
    if (db.Blogs!.Count() == 0)
    {
        blog.Posts.Add(new Post { Title = "urgent", Content = "Type is coming" });
        blog.Posts.Add(new Post { Title = "urgent", Content = "Earthquake last night" });
    }

}

db.SaveChanges();
Console.WriteLine("將資料讀回");
var blogs = db.Blogs!.OrderBy(b => b.BlogId);
foreach (var b in blogs)
{
    Console.WriteLine($"{b.BlogId},{b.Uri}");
    var posts = db.Posts!.Where(p => b.BlogId == p.BlogId);
    foreach (var p in posts)
    {
        Console.WriteLine($"..{p.Title}/{p.Content}");
    }
}