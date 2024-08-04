using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//overall checks if the game has been won through the use of functions found in ColorManipulator
//for some iterations of the Anomaloscope type games, they had a progress bar added.
public class ColorMaster : MonoBehaviour
{

    [SerializeField] GameObject Color1, Color2, Color3, Static1, Static2, Static3;
    [SerializeField] Canvas canvas, canvas2;
    [SerializeField] GameObject progressBar,fakeBar;
    float c1, c2, c3,s1, s2, s3;
    float pt1, pt2, pt3;
    bool bool1, bool2, bool3;

    //is called when a button is clicked
    public void Checker()
    {
        bool1 = false;
        bool2 = false;
        bool3 = false;
        Vector3 initialPosition = fakeBar.transform.localPosition;
        Quaternion initialRotation = fakeBar.transform.rotation;
        Vector3 basePosition = new (initialPosition.x,initialPosition.y,initialPosition.z);
        pt1 = 0.33f;
        pt2 = 0.33f;
        pt3 = 0.33f;

        

        c1 = Color1.GetComponent<ColorManipulator>().getCurrentBlue();
        s1 = Static1.GetComponent<ColorGenerator>().getBlue();

        c2 = Color2.GetComponent<ColorManipulator>().getCurrentBlue();
        s2 = Static2.GetComponent<ColorGenerator>().getBlue();

        c3 = Color3.GetComponent<ColorManipulator>().getCurrentBlue();
        s3 = Static3.GetComponent<ColorGenerator>().getBlue();

        

        if((s1 - 0.20) <= c1 && c1 <= (s1 + 0.20))
        {
            bool1 = true;
        }

        if((s2 - 0.20) <= c2 && c2 <= (s2 + 0.20)) 
        { 
            bool2 = true; 
        }  

        if((s3 - 0.20) <= c3 && c3 <= (s3 + 0.20)) 
        { 
            bool3 = true; 
        }

        
        //if all three are true, then the new canvas displaying the Win screen activates
        if(bool1 && bool2 && bool3)
        {
            canvas.gameObject.SetActive(false);
            canvas2.gameObject.SetActive(true);
        }

        if (c1 >= s1)
        {
            pt1 = (1 - c1) / (1 - s1) * pt1;
        }else if(c1 < s1)
        {
            pt1 = ((s1 - c1) / s1) * pt1;
        }

        if (c2 >= s2)
        {
            pt2 = (1 - c2) / (1 - s2) * pt2;
        }
        else if (c2 < s2)
        {
            pt2 = ((s2 - c2) / s2) * pt2;
        }

        if (c3 >= s3)
        {
            pt3 = (1 - c3) / (1 - s3) * pt3;
        }
        else if (c2 < s2)
        {
            pt3 = ((s3 - c3) / s3) * pt3;
        }
        //(pt1+pt2+pt3)*300.0f
        Vector3 newPosition = new(fakeBar.transform.localPosition.x + ((pt1 + pt2 + pt3) * 300.0f), initialPosition.y, initialPosition.z);
        progressBar.transform.SetLocalPositionAndRotation(newPosition,new Quaternion(0,0,0,0));

    }
}
