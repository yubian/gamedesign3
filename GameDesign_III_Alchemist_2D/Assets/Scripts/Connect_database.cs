using UnityEngine;
using System.Collections;

public class Connect_database : MonoBehaviour {

    public int user_id;
    public string username;
    public string password;
    public string url_server = "fdb14.runhosting.com/2260139_data";


   public void startConnection()
    {
        StartCoroutine(connect());
    }

    public IEnumerator connect()
    {
        WWWForm form = new WWWForm();
    }









	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
