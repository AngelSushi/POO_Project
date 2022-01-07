using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum FoodType {
    BREAD,
    SALAD,
    DOUGH,
    SALMON,
    BEACON,
    MUSHROOM,
    CHEESE,
    RICE,
    SEAWEED,
    TOMATO,
    CUCUMBER,
    STEAK
}


[CreateAssetMenu(fileName = "Food", menuName = "POO_Project/Food", order = 0)]
public class Food : Item {

    public FoodType type;
    public bool needCook;
    public int cookTime;
} 
