using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stride.Core.Mathematics;
using Stride.Input;
using Stride.Engine;
using Stride.Rendering;

namespace CSBT.Tutorial
{
   public class LoadContentTut : SyncScript
   {
      // Declared public member fields and properties will show in the game studio


      private Model loadedModel;

      private Random random = new Random();

      public override void Start()
      {
         // Initialization of the script.
      }

      public override void Update()
      {
         // Do stuff every new frame


         if (Input.IsKeyPressed(Keys.L))
         {
            // loadedModel = (Model)Content.Load(typeof(Model), "Models/mannequinModel");
            loadedModel = Content.Load<Model>("Models/mannequinModel");


    

         }


         if (Input.IsKeyPressed(Keys.K))
         {
            if(loadedModel != null) 
            {
               Content.Unload(loadedModel);
               loadedModel = null;
               // Entities are still there however.
            }
            
         }


         if(Input.IsKeyPressed(Keys.S))
         {
            CreateNewModel();
         }
      }




      public void CreateNewModel()
      {
         if(loadedModel != null)
         {

            ModelComponent modelComponent = new ModelComponent(loadedModel);
            Vector3 randomPosition = new Vector3(random.Next(-3, 3), 1, random.Next(-3, 3));

            Entity newEntity = new Entity("NewModel", randomPosition);
            newEntity.Add(modelComponent);

            Entity.Scene.Entities.Add(newEntity);
            
         }

      }
   }
}
