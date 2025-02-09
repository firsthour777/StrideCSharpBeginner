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

    

    public class KeyboardInputTutorial : SyncScript
    {
        public Entity BlueTeapot = null;
        public Entity GreenTeapot = null;
        public Entity YellowTeapot = null;

        // Declared public member fields and properties will show in the game studio

        public override void Start()
        {
            // Initialization of the script.
        }

        public override void Update()
        {
            // Do stuff every new frame

            if(Input.HasKeyboard){
                if(Input.IsKeyDown(Keys.D1)){
                    BlueTeapot.Transform.Rotation *= Quaternion.RotationY(0.4f * GetDeltaTime());
                }

                if(Input.IsKeyPressed(Keys.Space)){
                    GreenTeapot.Transform.Rotation *= Quaternion.RotationY(-0.4f * GetDeltaTime());
                }

                if(Input.IsKeyReleased(Keys.F10)){
                    YellowTeapot.Transform.Rotation *= Quaternion.RotationY(10f * GetDeltaTime());
                }

            }

            


        }

        public float GetDeltaTime()
        {
            float deltaTime = (float)Game.UpdateTime.Elapsed.TotalSeconds;
            return deltaTime;
        }
    }
}
