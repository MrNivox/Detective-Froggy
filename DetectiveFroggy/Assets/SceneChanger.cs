using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    
    
        void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    
      public void SceneChange1()
        {
         SceneManager.LoadScene("SampleScene");
        }
      public void SceneChange2() 
      {
       SceneManager.LoadScene("");
      }
       public void SceneChange3() 
      {
       SceneManager.LoadScene("");
      }
      
      
     

}

