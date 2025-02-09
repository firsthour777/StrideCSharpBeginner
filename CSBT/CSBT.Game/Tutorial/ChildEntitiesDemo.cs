using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stride.Core.Mathematics;
using Stride.Input;
using Stride.Engine;
using SharpFont.MultipleMasters;

namespace CSBT.Tutorial
{
    public class ChildEntitiesDemo : SyncScript
    {
        // Declared public member fields and properties will show in the game studio


        IReadOnlyList<Entity> children = null;

        public override void Start()
        {
            // Initialization of the script.

            Entity child0 = Entity.GetChild(0);
            Entity child1 = Entity.GetChild(1);

            // fails as there is no 3rd child
            // var child2 = Entity.GetChild(2);
            // var child3 = Entity.GetChild(3);


            children = Entity.GetChildren().ToList();





        }

        public override void Update()
        {
            // Do stuff every new frame

            int drawX = 400;
            int drawY = 200;
            int increment = 50; 

            DebugText.Print(Entity.Name, new Int2(drawX, drawY));
                        

            for (int i = 0; i < children.Count(); i++)
            {
                Entity child = children[i];

                drawY += increment;

                DebugText.Print(child.Name, new Int2(drawX + increment, drawY));


                IReadOnlyList<Entity> subChildren = child.GetChildren().ToList();

                for (int j = 0; j < subChildren.Count(); j++) {
                    Entity grandChild = subChildren[j];

                    drawY += increment;

                    DebugText.Print(grandChild.Name, new Int2(drawX + increment * 2, drawY));



                }


            }


        }
    }
}
