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
    public class TransformPositionDemo : SyncScript
    {
        // Declared public member fields and properties will show in the game studio

        public override void Start()
        {
            // Initialization of the script.
        }

        public override void Update()
        {
            // Do stuff every new frame

            var localPosition = Entity.Transform.Position;
            var worldPosition = Entity.Transform.WorldMatrix.TranslationVector;
            DebugText.Print($"Local Position: {localPosition}", new Int2(10, 10), Color.Red);
            DebugText.Print($"World Position: {worldPosition}", new Int2(10, 30), Color.Red);


        }
    }
}
