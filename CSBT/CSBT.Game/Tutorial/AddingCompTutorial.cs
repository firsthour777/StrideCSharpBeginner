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
    public class AddingCompTutorial : SyncScript
    {
        // Declared public member fields and properties will show in the game studio

        public override void Start()
        {
            // Initialization of the script.
            var ammoComponent1 = new AmmoComponentTutorial();
            Entity.Add(ammoComponent1);

            // This doesn't work, adding twice doesn't work if its the same thing
            // Entity.Add(ammoComponent1);

            // add another like this
            var ammoComponent2 = new AmmoComponentTutorial();
            Entity.Add(ammoComponent2);


            Entity.RemoveAll<AmmoComponentTutorial>();


            var ammoComponent3 = Entity.GetOrCreate<AmmoComponentTutorial>();





        }

        public override void Update()
        {
            // Do stuff every new frame
        }
    }
}
