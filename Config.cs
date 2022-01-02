using Exiled;
using Exiled.API.Interfaces;

namespace Example
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
    }
}