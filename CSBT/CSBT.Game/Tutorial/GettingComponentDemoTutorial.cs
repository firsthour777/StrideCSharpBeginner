using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stride.Core.Mathematics;
using Stride.Input;
using Stride.Engine;

namespace CSBT.Tutorial
{
    public class GettingComponentDemoTutorial : SyncScript
    {
        // Declared public member fields and properties will show in the game studio

        AmmoComponentTutorial ammoComponentScript = null;
        List<AmmoComponentTutorial> ammoComponentList = null;

        public override void Start()
        {
            ammoComponentScript = Entity.Get<AmmoComponentTutorial>();

            ammoComponentList = Entity.GetAll<AmmoComponentTutorial>().ToList();

            Entity.Remove(ammoComponentScript);


            Entity.Remove<AmmoComponentTutorial>(); // removes only the first one that it comes across
            Entity.RemoveAll<AmmoComponentTutorial>(); // removes all of them


            // Initialization of the script.
        }

        public override void Update()
        {
            // Do stuff every new frame

            DebugText.Print($"Current Ammo: {ammoComponentScript.GetReaminingAmmo()}", new Int2(10, 10), Color.Red);


        }
    }
}
