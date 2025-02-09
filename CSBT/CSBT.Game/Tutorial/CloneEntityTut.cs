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
   public class CloneEntityTut : SyncScript
   {

      public Entity MasterSword;
      // Declared public member fields and properties will show in the game studio

      public override void Start()
      {


         // Initialization of the script.

         Entity clone0 = MasterSword.Clone();    // this is a clone not a reference
         clone0.Transform.Scale = new Vector3(0.9f);
         clone0.Transform.Position = new Vector3(1, 1, 0);
         Entity.Scene.Entities.Add(clone0);  // adds to its scene root, not the scene root/parent



         Entity clone1 = MasterSword.Clone();
         clone1.Transform.Scale = new Vector3(0.5f);
         clone1.Transform.Position = new Vector3(-2, 1, 0);
         Entity.AddChild(clone1);

         Entity clone2 = MasterSword.Clone();
         clone2.Transform.Scale = new Vector3(0.2f);
         clone2.Transform.Position = new Vector3(1, 1, -0.5f);
         clone2.Transform.Parent = Entity.Transform;




      }

      public override void Update()
      {
         // Do stuff every new frame
      }
   }
}
