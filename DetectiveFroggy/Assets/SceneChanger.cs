using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    
    
        void Start()
    {
       
    }

    // Update is called once per frame
    
      public void SceneChange1()
      {
       SceneManager.LoadScene("LevelMenu");
      }
      public void SceneChange2() 
      {
       SceneManager.LoadScene("SampleScene");
      }
       public void SceneChange3() 
      {
       SceneManager.LoadScene("");
      }
      
      
     

}

