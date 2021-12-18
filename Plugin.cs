using Exiled;
using Exiled.API.Interfaces;
using Exiled.API.Features;

namespace Example
{
    public class Plugin : Plugin<Config>
    {

        public override string Name => "SummonRespawnVehicles";
       
        public override void OnEnabled()
        {
            base.OnEnabled();
        }
    }
}