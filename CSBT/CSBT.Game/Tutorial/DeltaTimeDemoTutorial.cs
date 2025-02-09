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
    public class DeltaTimeDemoTutorial : SyncScript
    {
        // Declared public member fields and properties will show in the game studio


        public float RotationSpeed = 0.05f;

        private float rotationTime = 5.9f;

        private float timer = 0f;

        public override void Start()
        {
            // Initialization of the script.
        }

        public override void Update()
        {

            

            // need to have a new extended method that is called by the update function called call update - failure not possible

            // Log.Info("DeltaTime: " + GetDeltaTime());

            timer += GetDeltaTime();
            if(timer >= rotationTime)
            {
                timer = 0f;
                RotationSpeed *= -1;
            }


            // UpdatePerDeltaTime()


            Entity.Transform.Rotation *= Quaternion.RotationY(RotationSpeed * GetDeltaTime());

            
        }





        public float GetDeltaTime()
        {
            float deltaTime = (float)Game.UpdateTime.Elapsed.TotalSeconds;
            return deltaTime;
        }



        // float deltaTime = (float)Game.UpdateTime.Elapsed.TotalSeconds; // how you get it, but strange there is no automatic delta time caller
        // need to have a new extended method that is called by the update function called call update




    }
}
