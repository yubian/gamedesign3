using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class KeepItem : MonoBehaviour {
    bool _ondrag = false;
    GameObject other;
    MixItem mixitem;
    public int _id;
    public bool Ondrag
    {
        get
        {
            return _ondrag;
        }

        set
        {
            _ondrag = value;
        }
    }
    void Start()
    {
        mixitem = GameObject.Find("Canvas").GetComponent<MixItem>();
    }
    void Update()
    {
        
    }
    void OnMouseDrag()
    {
        Ondrag = true;
           Vector2 move;
        move = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = move;
        GetComponent<SpriteRenderer>().sortingOrder = 1;
    }
    void OnMouseUp()
    {
        Ondrag = false;
        GetComponent<SpriteRenderer>().sortingOrder = 0;
    // GetComponent<SpriteRenderer>().sortingLayerName = "back_layer";
        }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "item")
        {
            other = GameObject.Find(col.name);
            Debug.Log("mix");

                    mixitem.Iditem.Add(_id);

            
        }
    }
    void OnTriggerExit2D(Collider2D col)
    {
        if (col.tag == "item")
        {
            foreach(var mixed in mixitem.Iditem)
            {
                if (_id == mixed)
                {
                    Debug.Log("out");
                    mixitem.Iditem.Clear();
                }
            }
        }
    }
    void OnTriggerStay2D(Collider2D col)
    {
        if (col.tag == "item" && Ondrag == false && other.GetComponent<KeepItem>()._ondrag == false)
        {
            mixitem.Mixnow = true;
        }
    }
}
