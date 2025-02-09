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
    public class RemoveEntityTut : SyncScript
    {

        public Entity EntityToClone;
        private Entity clone1;
        private Entity clone2;

        // Declared public member fields and properties will show in the game studio

        public override void Start()
        {
            // Initialization of the script.

            clone1 = EntityToClone.Clone();
            clone1.Name = "Clone1";
            clone1.Transform.Position += new Vector3(0, 0, 0.5f);
            clone1.Transform.Scale = new Vector3(0.6f);
            Entity.Scene.Entities.Add(clone1);

            clone2 = EntityToClone.Clone();
            clone2.Name = "Clone2";
            clone2.Transform.Position = new Vector3(0, 0, -1f);
            clone2.Transform.Scale = new Vector3(0.1f);
            Entity.AddChild(clone2);
        }

        public override void Update()
        {
            // Do stuff every new frame


            if(clone1 != null)
            {

                Entity.Scene.Entities.Remove(clone1);
                Entity.Scene.Entities.Remove(clone2); // doesn't work because clone 2 is a child, not on the same layer

                // both ways work
                // Entity.RemoveChild(clone2);
                clone2.Transform.Parent = null; 

            }


            

            if(clone1 != null)
            {
                clone1 = null;
                clone2 = null;
            }

            

            
        }
    }
}
