using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stride.Core.Mathematics;
using Stride.Input;
using Stride.Engine;
using Stride.Core.Diagnostics;

namespace CSBT.Tutorial
{
   public class VirtualButtonsTut : SyncScript
   {
      public Entity BlueTeapot = null;

      // Declared public member fields and properties will show in the game studio

      public override void Start()
      {
         // Initialization of the script.


         Input.VirtualButtonConfigSet = Input.VirtualButtonConfigSet ?? new VirtualButtonConfigSet();

         VirtualButtonBinding ForwardW = new VirtualButtonBinding("Forward", VirtualButton.Keyboard.W);
         VirtualButtonBinding ForwardUp = new VirtualButtonBinding("Forward", VirtualButton.Keyboard.Up);
         VirtualButtonBinding ForwardLeftMouse = new VirtualButtonBinding("Forward", VirtualButton.Mouse.Left);
         VirtualButtonBinding ForwardLeftTriggerGamePad = new VirtualButtonBinding("Forward", VirtualButton.GamePad.LeftTrigger);


         VirtualButtonConfig virtualButtonConfigForward = new VirtualButtonConfig();
         virtualButtonConfigForward.Add(ForwardW);
         virtualButtonConfigForward.Add(ForwardUp);
         virtualButtonConfigForward.Add(ForwardLeftMouse);
         virtualButtonConfigForward.Add(ForwardLeftTriggerGamePad);

         Input.VirtualButtonConfigSet.Add(virtualButtonConfigForward);

         // Virtual Buttons are Commands or Buttons within the Game itself, that correspond to Hardware Buttons




      }

      public override void Update()
      {
         // Do stuff every new frame


         float forward = Input.GetVirtualButtonValue(0, "Forward");  // this is a float because triggers can be between 0 and 1, but most inputs are 0 or 1.

         if(forward > 0){

            BlueTeapot.Transform.Rotation *= Quaternion.RotationY(0.4f * forward * GetDeltaTime());

         }





      }


      public float GetDeltaTime()
      {
         float deltaTime = (float)Game.UpdateTime.Elapsed.TotalSeconds;
         return deltaTime;
      }



   }
}
