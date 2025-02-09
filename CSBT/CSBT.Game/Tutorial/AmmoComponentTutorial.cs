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

    public class AmmoComponentTutorial : StartupScript
    {

        private readonly int maxBullets = 30;
        private readonly int currentBullets = 12;


        // Declared public member fields and properties will show in the game studio

        public override void Start()
        {
            // Initialization of the script.
        }

        public int GetReaminingAmmo()
        {
            return maxBullets - currentBullets;
        }
    }
}
