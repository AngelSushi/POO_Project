using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour {
    


    
    public void ChangeSlotContent(string param) { // slotId;goNext
        string[] parameters = param.Split(',');

        int slotId = int.Parse(parameters[0]);
        bool goNext = parameters[1] == "1"; // 0 false ; 1 true



    }

}
