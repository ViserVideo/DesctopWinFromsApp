
namespace DesctopApp.db
{
    internal class StorageDBContext
    {
        string ConnectionString { get; set; }
        
        string DatabaseName { get; set; }

        List<string> TableNames { get; set; }

        LinkedList<Object> Tables { get; set; }

        public StorageDBContext()
        {
            
        }

    }
}
