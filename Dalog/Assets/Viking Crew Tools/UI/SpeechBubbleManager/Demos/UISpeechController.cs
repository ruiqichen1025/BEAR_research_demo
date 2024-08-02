using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using VikingCrewTools.UI;
using System.Linq;
using UnityEngine.Windows;
using UnityEngine.TextCore.Text;


namespace VikingCrewDevelopment.Demos {
    public class UISpeechController : MonoBehaviour {

        public InputField txtMessage;
        public SayRandomThingsBehaviour talkBehaviour;
        public ToggleGroup toggles;
    


      

        public void OnTalk()
        {

            string input = txtMessage.text;
            string[] parts = input.Split('#');

            if (parts.Length == 2)
            {
                string animator1 = parts[0];
             

                string[] aniText1 = animator1.Split('+');
                if (aniText1.Length == 2)
                {
                    string animatorsubtext = aniText1[1];
                    Debug.Log("A");
                    talkBehaviour.SaySomething(animatorsubtext, (SpeechBubbleManager.SpeechbubbleType)toggles.ActiveToggles().First<Toggle>().transform.GetSiblingIndex());
                }


             

            }
            else
            {

               
            }








               
              
               
            
           
           
        }
       

       
    }
}