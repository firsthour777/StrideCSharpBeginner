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
   public class InstantiatePrefabTut : SyncScript
   {


      public Prefab pileOfBoxesPrefab = null;



      public override void Start()
      {
         List<Entity> instance = pileOfBoxesPrefab.Instantiate();

         Entity.Scene.Entities.AddRange(instance);



         Prefab prefabContentLoadedViaPath = Content.Load<Prefab>("Prefabs/Pile of boxes");

         List<Entity> prefabBoxesLoadedViaPath = prefabContentLoadedViaPath.Instantiate();

         Entity pileOfBoxesEntity = new Entity("Prefab Entity", new Vector3(0, 0, -2));

         for (int i = 0; i < prefabBoxesLoadedViaPath.Count; i++)
         {
            pileOfBoxesEntity.AddChild(prefabBoxesLoadedViaPath[i]);
         }


         Entity.Scene.Entities.Add(pileOfBoxesEntity);
         

      }

      public override void Update()
      {

         







      }
   }
}
