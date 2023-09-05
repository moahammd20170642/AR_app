using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selector : MonoBehaviour
{



    // Start is called before the first frame update


    public MeshRenderer star, cat, normal , hat;


    private void Start()
    {
        star.enabled = false;
        cat.enabled = false;
        normal.enabled = false;
        hat.enabled = false;
    }


    private void Update()
    {
        if (select.catglass == true)
        {


            cat.enabled = true;
            star.enabled = false;
            normal.enabled = false;
        }

        if (select.normalglass == true)
        {


            cat.enabled = false;
            star.enabled = false;
            normal.enabled = true;

        }


        if (select.starglass == true)
        {


            cat.enabled = false;
            star.enabled = true;
            normal.enabled = false;

        }


        if (select.HatSelected == true)
        {
            hat.enabled = true;
        }

        if(select.HatSelected==false)
        {
            hat.enabled = false;
        }
    }

}
