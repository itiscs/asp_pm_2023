using System.Text;

namespace SessionApp
{
    public class Cart
    {
        public string Items { get; set; }

      
        public void Add(string k)
        {
            Items = Items + k;      
        }
        
    }
}
