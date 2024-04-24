using System.Collections.ObjectModel;
namespace Heqa.Model
{
    public class NetInterface
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<string> Addresses { get; set; } = new List<string>();
    }
}