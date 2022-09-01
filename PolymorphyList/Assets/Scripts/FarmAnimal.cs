using UnityEngine;

[System.Serializable]
public class FarmAnimal{
    public string name;
    public int age;
    public float value; 
}

//Derived classes
[System.Serializable]
public class Sheep: FarmAnimal{
    public bool canSheered;
    public Sheep(string _name){
        name=_name;
    }
}

[System.Serializable]
public class Cow: FarmAnimal{
    public bool canProduceMilk;
    public Cow(string _name){
        name=_name;
    }
}

[System.Serializable]
public class Pig: FarmAnimal{
    [Range(0,1)]
    public float greediness;
    public Pig(string _name){
        name=_name;
    }
}