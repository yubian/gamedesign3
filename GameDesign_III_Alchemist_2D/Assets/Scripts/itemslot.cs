using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class itemslot : MonoBehaviour {
    List<int> itemid;
    public Canvas canvas;
   public GameObject slotprefab;
    public Transform pos;
    float coutpos=0;
    // Use this for initialization
    void Start () {
        itemid = new List<int>();
        for (int i = 0; i < 5; i++)
        {
            itemid.Add(i);
        }
        foreach (var item in itemid)
        {
            spawslot();
        }
    }
    void spawslot()
    {

        GameObject cloneterrain = Instantiate(slotprefab, new Vector3(pos.transform.position.x, pos.transform.position.y+coutpos), Quaternion.Euler(new Vector3(0, 0, 0))) as GameObject;
        cloneterrain.transform.SetParent(canvas.transform);
        coutpos += 30.0f;
    }

    // Update is called once per frame
    void Update () {

	}
}
