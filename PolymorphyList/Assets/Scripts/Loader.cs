using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Loader : MonoBehaviour
{
    [SerializeField]
    PolymorphyList polyList;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        if(!polyList){
            Debug.Log("Missing reference of PolymorphyList, please assign it to the gameobject of:\" "+this.gameObject.name+"\"");
        }else{
            foreach (FarmAnimal item in polyList.farmAnimals)
            {
                Debug.Log("name:"+item.name+"\n age"+item.age+"\n value"+item.value+"\n");
                yield return new WaitForSeconds(0.25f);
            }
        }
        
        yield return null;
    } 
}
