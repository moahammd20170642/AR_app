using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class select : MonoBehaviour
{
   

    public static bool catglass, starglass, normalglass , red , green ,blue , HatSelected ;

    // Start is called before the first frame update
    void Start()
    {
        catglass = false; starglass = false; normalglass = false; HatSelected = false;
    }

    public static void  Swithchat()
    {
        if (HatSelected == false)
        {
            HatSelected = true;

        }
        else HatSelected = false;

    }

    public static void enablecat()
    {
        normalglass = false;
        starglass = false;
        catglass = true;
    }
    public static void enablestar()
    {
        starglass = true;
        catglass = false;

        normalglass = false;
    }

    public static void enablrnormal()
    {
        starglass = false;
        catglass = false;

        normalglass = true;


    }
    public static void enableRed()
    {
        red = true;
        green = false;

        blue = false;


    }
     public static void enableGreen()
    {
        red = false;
        green = true;

        blue = false;


    }
    public static void enableBlue()
    {
        red = false;
        green = false;

        blue = true;


    }
}
