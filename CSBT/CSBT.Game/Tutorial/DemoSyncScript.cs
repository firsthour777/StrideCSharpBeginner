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
    public class DemoSyncScript : SyncScript
    {
        // Declared public member fields and properties will show in the game studio

        public override void Start()
        {
            // Initialization of the script.
            Log.Info("DemoSyncScript started");    // this is not shown in console because of the log level/ severity level
            Log.Warning("DemoSyncScript started warning");
        }

        public override void Update()
        {
            // Log.Error("DemoSyncScript started error");
            // Do stuff every new frame
        }
    }
}
