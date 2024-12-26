namespace P4_1_714230044;

public class Book_714230044 : Product_714230044
{
    protected string pageCount;

    public Book_714230044(string type, string title, string pageCount) : base(type, title)
    {
        this.pageCount = pageCount;
    }

    public string PageCount
    {
        get { return pageCount; }
        set { pageCount = value; }
    }

    public override void DisplayInfo()
    {
        Console.WriteLine("Product is a {0} called \"{1}\"and has {2} pages", MyType, MyTitle, PageCount);
    }
}