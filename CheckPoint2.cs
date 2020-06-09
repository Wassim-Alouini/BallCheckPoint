using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CheckPoint2 : MonoBehaviour
{


    
    float sum(float var1, float var2)
    {
        return (var1 + var2);
    }
    float prod(float var1, float var2)
    {
        return (var1 * var2);
    }
    System.Nullable<float> Div(float var1,float var2)
    {
        if (var2 == 0)
        {
            Debug.Log("Cannot divide by 0");
            return null;
        }
        else
        {
            return (var1 / var2);
        }
    }




    

// Start is called before the first frame update
    void Start()
    {
        Debug.Log(sum(1, 2));
        Debug.Log(prod(5, 6));
        Debug.Log(Div(30, 5));
        Debug.Log(Div(6, 0));
    }

    // Update is called once per frame
    void Update()
    {
    }
}
