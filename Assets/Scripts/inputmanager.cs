using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inputmanager : MonoBehaviour
{
    public InputField ifusername;
    public Text txtusermanager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UserGreetings ()
    {
        Debug.Log(int.Parse(txtusermanager.text) * 2);
    }
}
