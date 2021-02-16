
namespace IssueRepro30147.Models
{
    public interface IUniqueResource
    {
        public long Id { get; }
    }

    public class BaseItem : IUniqueResource
    {
        public long Id { get; set; }
    }

    public class Item : BaseItem
    {
        public long Id { get; set; } // <==== This shouldn't be here, but it shouldn't cause the issue
    }
}
