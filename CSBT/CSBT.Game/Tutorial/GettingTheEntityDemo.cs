using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stride.Core.Mathematics;
using Stride.Input;
using Stride.Engine;
using System.Diagnostics;
using Stride.Graphics;

namespace CSBT.Tutorial
{
    public class GettingTheEntityDemo : SyncScript
    {
        // Declared public member fields and properties will show in the game studio

        private string name = string.Empty;
        private string parentName = string.Empty;
        public override void Start()
        {
            // Initialization of the script.

            name = Entity.Name;

            var parent = Entity.GetParent();

            if(parent != null)
            {
                parentName = parent.Name;
            }
            else
            {
                parentName = "No Parent";
            }

        }

        public override void Update()
        {
            // Do stuff every new frame

            DebugText.Print(parentName, new Int2(580,580));
            DebugText.Print(name, new Int2(580,600));
        }
    }
}
