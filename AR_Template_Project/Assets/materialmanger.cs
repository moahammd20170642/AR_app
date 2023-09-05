using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class materialmanger : MonoBehaviour
{

    public MeshRenderer mesh;

    private void Update()
    {
        if (select.red == true)
        {
            Red();
        }

        if (select.green == true)
        {
            green();
        }

        if(select.blue == true)
        {
            blue(); 
        }
    }

    

    private void Start()
    {
        //mesh = GetComponent<MeshRenderer>();
       
    }


    public void Red()
    {
        mesh.material.SetColor("_BaseColor", Color.red);

    }


    public void green()
    {
        mesh.material.SetColor("_BaseColor", Color.green);

    }



    public void blue()
    {
        mesh.material.SetColor("_BaseColor", Color.blue);

    }
}

