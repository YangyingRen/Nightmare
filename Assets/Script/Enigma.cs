using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enigma : MonoBehaviour
{public Text Dialogue;
 public string newText, oldText;
 private char[] oldT,newT,resultT;
 private int lenO,lenN;
 public bool isDone=false;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        oldText=Dialogue.text;
        if(oldText!=null){
        newText="Prototype"+oldText;
        lenO=oldText.Length;
        lenN=newText.Length;
        oldT=oldText.ToCharArray();
        newT=newText.ToCharArray(); 
         for(int i=0;i<lenO;i++){
            oldT[i]=newT[lenN-i-1];
           string result=string.Join("",oldT);
            Dialogue.text=result;
        } 
        }
        
         
    }

    public void AddCode(){
        
       
    }
}
