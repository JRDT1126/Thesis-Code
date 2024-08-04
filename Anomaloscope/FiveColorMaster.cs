using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

//a five-color variant of the ColorMaster class
public class FiveColorMaster : MonoBehaviour
{
    [SerializeField] GameObject Color1, Color2, Color3,Color4,Color5, Static1, Static2, Static3,Static4,Static5;
    [SerializeField] Canvas canvas, canvas2;
    [SerializeField] GameObject progressBar;
    float c1, c2, c3,c4,c5, s1, s2, s3,s4,s5;
    float pt1, pt2, pt3;
    bool bool1, bool2, bool3, bool4, bool5;


    // Start is called before the first frame update

    public void Checker()
    {
        bool1 = false;
        bool2 = false;
        bool3 = false;
        bool4 = false;
        bool5 = false;
        Vector3 initialPosition = progressBar.transform.localPosition;
        Quaternion initialRotation = progressBar.transform.rotation;
        Vector3 basePosition = new(262.2f, initialPosition.y, initialPosition.z);
        pt1 = 0.33f;
        pt2 = 0.33f;
        pt3 = 0.33f;



        c1 = Color1.GetComponent<ColorManipulator>().getCurrentBlue();
        s1 = Static1.GetComponent<ColorGenerator>().getBlue();

        c2 = Color2.GetComponent<ColorManipulator>().getCurrentBlue();
        s2 = Static2.GetComponent<ColorGenerator>().getBlue();

        c3 = Color3.GetComponent<ColorManipulator>().getCurrentBlue();
        s3 = Static3.GetComponent<ColorGenerator>().getBlue();

        c4 = Color4.GetComponent<ColorManipulator>().getCurrentBlue();
        s4 = Static4.GetComponent<ColorGenerator>().getBlue();

        c5 = Color5.GetComponent<ColorManipulator>().getCurrentBlue();
        s5 = Static5.GetComponent<ColorGenerator>().getBlue();

        if ((s1 - 0.20) <= c1 && c1 <= (s1 + 0.20))
        {
            bool1 = true;
        }

        if ((s2 - 0.20) <= c2 && c2 <= (s2 + 0.20))
        {
            bool2 = true;
        }

        if ((s3 - 0.20) <= c3 && c3 <= (s3 + 0.20))
        {
            bool3 = true;
        }

        if ((s4 - 0.20) <= c4 && c4 <= (s4 + 0.20))
        {
            bool4 = true;
        }

        if ((s5 - 0.20) <= c5 && c5 <= (s5 + 0.20))
        {
            bool5 = true;
        }



        if (bool1 && bool2 && bool3 && bool4 && bool5)
        {
            canvas.gameObject.SetActive(false);
            canvas2.gameObject.SetActive(true);
        }

        if (c1 >= s1)
        {
            pt1 = (1 - c1) / (1 - s1) * pt1;
        }
        else if (c1 < s1)
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
        Vector3 newPosition = new(basePosition.x + 1, basePosition.y, basePosition.z);
        progressBar.transform.SetPositionAndRotation(newPosition, initialRotation);

    }
}
