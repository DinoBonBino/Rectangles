using System.Diagnostics;

namespace Rectangles.Common
{
    public class Logs
    {
        internal void Write(string message)
        {
            Debug.WriteLine(message);
        }
    }
}
