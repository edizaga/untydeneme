using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ornek : MonoBehaviour
{
    public Text yazý;
    public Button but;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        but.onClick.AddListener(calýs);
    }

    public void calýs()
    {
        Debug.Log(yazý.text = "ÇALIÞTIM");
    }
}
