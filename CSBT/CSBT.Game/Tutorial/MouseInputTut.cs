using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stride.Core.Mathematics;
using Stride.Input;
using Stride.Engine;
using System.Diagnostics;


namespace CSBT.Tutorial
{
    public class MouseInputTut : SyncScript
    {

        public Entity BlueTeapot;
        public Entity RedTeapot;
        public Entity GreenTeapot;
        public Entity YellowTeapot;

        private float scrollIndex = 0;


        // Declared public member fields and properties will show in the game studio

        public override void Start()
        {
            // Initialization of the script.
        }

        public override void Update()
        {
            
            if(Input.HasMouse){ // check for mouse

                // check for left mouse button
                if (Input.IsMouseButtonDown(MouseButton.Left)){
                    BlueTeapot.Transform.Rotation *= Quaternion.RotationY(0.4f * GetDeltaTime());
                }

                if (Input.IsMouseButtonPressed(MouseButton.Right)){
                    YellowTeapot.Transform.Rotation *= Quaternion.RotationY(0.4f);
                }

                if (Input.IsMouseButtonReleased(MouseButton.Middle)){
                    GreenTeapot.Transform.Rotation *= Quaternion.RotationY(-0.4f);
                }

                // up = 1 down = -1
                scrollIndex += Input.MouseWheelDelta;
                DebugText.Print($"Scroll Index: {scrollIndex}", new Int2(100, 100), Color.Red);
                RedTeapot.Transform.Rotation = Quaternion.RotationX(-0.02f * scrollIndex);

                Vector2 mousePosition = Input.MousePosition;    // gives values between 0 and 1, which is 0% and 100% of the screen, can be somewhat useful
                DebugText.Print($"Mouse Position: {mousePosition}", new Int2(100, 200), Color.Green);

                Vector2 absoluteMousePosition = Input.AbsoluteMousePosition;    // Position on game screen in raw pixels, so if game screen is 400x400 then it gives the pixel position.
                DebugText.Print($"Absolute Mouse Position: {absoluteMousePosition}", new Int2(absoluteMousePosition), Color.Blue); // this can follow the mouse

                // Positive X is right, starts at 0
                // Positive Y is down, starts at 0



            }
        }



        public float GetDeltaTime()
        {
            float deltaTime = (float)Game.UpdateTime.Elapsed.TotalSeconds;
            return deltaTime;
        }
    }
}
