using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stride.Core.Mathematics;
using Stride.Input;
using Stride.Engine;
using System.Runtime.Serialization;
using Stride.Core;
using Stride.Core.Annotations;

namespace CSBT.Tutorial
{
    public class PropertiesDemo : SyncScript
    {
        // Declared public member fields and properties will show in the game studio

        public string SomeString = "Hello Stride!";  


        [Stride.Core.DataMember(0)]
        public int SomeInteger = 99;

        [Stride.Core.DataMember(5)]
        public float someFloatB = 0.5f;

        

        [DataMemberRange(0, 100, 0.1, 1, 3)]
        public float someFloatA = 0.7f;


        public Vector2 SomeVector2;
        public Vector3 SomeVector3 = new Vector3(1, 2, 3);
        public Vector4 SomeVector4 = new Vector4(6);

        public Color SomeColor = Color.Red;

        public List<string> stringList = new List<string>();
        public List<Entity> entityList = new List<Entity>();

        [DataMemberIgnore]
        public List<CameraComponent> camList = new List<CameraComponent>();


        public CharacterType characterTypeSelected;


        public enum CharacterType
        {
            Warrior,
            Mage,
            Archer
        }

       

        public override void Update()
        {
            // Do stuff every new frame



        }
    }
}
