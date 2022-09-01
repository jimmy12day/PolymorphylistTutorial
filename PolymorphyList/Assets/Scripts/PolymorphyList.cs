using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "PolymorphyList")]
public class PolymorphyList : ScriptableObject {
    [SerializeReference]
    public List<FarmAnimal> farmAnimals = new List<FarmAnimal>();

    public void AddCow(){
        farmAnimals.Add(new Cow("Big Cow"));
    }
    public void AddSheep(){
        farmAnimals.Add(new Sheep("Small Sheep"));
    }
    public void AddPig(){
        farmAnimals.Add(new Pig("Fat Pig"));
    }
}
