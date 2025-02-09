using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stride.Core.Mathematics;
using Stride.Input;
using Stride.Engine;
using System.Security.RightsManagement;

namespace CSBT.Tutorial
{
    public class LERPTut : SyncScript
    {
        // Declared public member fields and properties will show in the game studio

        public float AnimationTime = 3;

        private float elapsedTime = 0;

        private Vector3 startPosition;

        private Vector3 endPosition;


        private Random random;

        public override void Start()
        {
            // Initialization of the script.

            startPosition = Entity.Transform.Position;
            endPosition = new Vector3(1, 2, 0);


            random = new Random(Game.UpdateTime.Total.Milliseconds);

        }

        public override void Update()
        {
            // Do stuff every new frame

            elapsedTime += GetDeltaTime();

            float lerpValue = elapsedTime / AnimationTime;

            Entity.Transform.Position = Vector3.Lerp(startPosition, endPosition, lerpValue);

            if(elapsedTime > AnimationTime)
            {
               SetNewTargetPositionAndResetTimer();
            }



        }

        public float GetDeltaTime()
        {
            float deltaTime = (float)Game.UpdateTime.Elapsed.TotalSeconds;
            return deltaTime;
        }

         private void SetNewTargetPositionAndResetTimer()
         {
               elapsedTime = 0;
               startPosition = Entity.Transform.Position;
               endPosition = new Vector3(random.Next(-2,-2), random.Next(-2, 2), random.Next(-2, 2));
               
         }
    }
}
