using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MixItem : MonoBehaviour {
    List<int> iditem;
    bool mixnow=false;
    public List<int> Iditem
    {
        get
        {
            return iditem;
        }

        set
        {
            iditem = value;
        }
    }

    public bool Mixnow
    {
        get
        {
            return mixnow;
        }

        set
        {
            mixnow = value;
        }
    }

    // Use this for initialization
    void Start () {
        Iditem = new List<int>();
	}
	
	// Update is called once per frame
	void Update () {
        if(Iditem!=null)
        foreach(var cc in iditem)
        {
            Debug.Log(cc);
        }
        Debug.Log("slot1"+iditem[0]);
        Debug.Log("slot2"+iditem[1]);
        if (iditem.Count >= 2)
        {
            Debug.Log("inmix");
            mixfuction();
        }
        
	}
    void mixfuction()
    {
        if (iditem[0] == 2 && iditem[1] ==1)
        {
            Debug.Log("spaw3");
        }
        if (iditem[0] ==3 && iditem[1] == 1)
        {
            Debug.Log("spaw4");
        }
    }
}
