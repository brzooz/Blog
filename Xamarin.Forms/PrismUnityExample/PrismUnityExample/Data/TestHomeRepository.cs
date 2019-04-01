using System;
namespace PrismUnityExample.Data
{
    public class TestHomeRepository : IHomeRepository
    {
        public string GetTitle()
        {
            return "Hello Unity!";
        }
    }
}
