using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshChange : MonoBehaviour
{
    public MeshFilter meshFilter;

    public Mesh meshBun;

    public GameObject bun;

    // Start is called before the first frame update
    void Start()
    {
        meshFilter = GetComponent<MeshFilter>();
         

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.J))
        {

            meshFilter.mesh =meshBun;
            transform.rotation = Quaternion.Euler(-90.0f, 0.0f, 160.0f);
             Vector3 scaleChange =new Vector3(100f, 100f, 100f);
           transform.localScale = scaleChange;
        }
    }
}
