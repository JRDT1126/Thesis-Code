using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//A library of data that makes up the color gradients that are possible to see in the Hue Test minigames
//Every run is randomized though possible to be changed to another gradient if the player requests for it
public class ColorLibrary : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject g1, g2, g3, g4, g5, g6, g7, g8, g9,g10, g11;
    SpriteRenderer s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11;
    int i;
    void Start()
    {
        i = UnityEngine.Random.Range(1, 10);
        switch (i)
        {
            case 1:
                FirstCase();
                break;
            case 2:
                SecondCase();
                break;
            case 3:
                ThirdCase();
                break;
            case 4:
                FourthCase();
                break;
            case 5:
                FifthCase();
                break;
            case 6:
                SixthCase();
                break;
            case 7:
                SeventhCase();
                break;
            case 8:
                EighthCase();
                break;
            case 9:
                NinthCase();
                break;
            case 10:
                TenthCase();
                break;
        }
        g1.SetActive(true);
        g2.SetActive(true);
        g3.SetActive(true);
        g4.SetActive(true);
        g5.SetActive(true);
        g6.SetActive(true);
        g7.SetActive(true);
        g8.SetActive(true);
        g9.SetActive(true);
        g10.SetActive(true);
        g11.SetActive(true);
    }


    private void FirstCase()
    {
        s1 = g1.GetComponent<SpriteRenderer>();
        s1.color = new Color((float)254.0 / (float)255.0, (float)240.0 / (float)255.0, (float)28.0 / (float)255.0, (float)255.0 / (float)255.0);

        s2 = g2.GetComponent<SpriteRenderer>();
        s2.color = new Color((float)249.0 / (float)255.0, (float)216.0 / (float)255.0, (float)33.0 / (float)255.0, (float)255.0 / (float)255.0);

        s3 = g3.GetComponent<SpriteRenderer>();
        s3.color = new Color((float)242.0 / (float)255.0, (float)195.0 / (float)255.0, (float)38.0 / (float)255.0, (float)255.0 / (float)255.0);

        s4 = g4.GetComponent<SpriteRenderer>();
        s4.color = new Color((float)234.0 / (float)255.0, (float)175.0 / (float)255.0, (float)40.0 / (float)255.0, (float)255.0 / (float)255.0);

        s5 = g5.GetComponent<SpriteRenderer>();
        s5.color = new Color((float)227.0 / (float)255.0, (float)156.0 / (float)255.0, (float)41.0 / (float)255.0, (float)255.0 / (float)255.0);

        s6 = g6.GetComponent<SpriteRenderer>();
        s6.color = new Color((float)220.0 / (float)255.0, (float)137.0 / (float)255.0, (float)41.0 / (float)255.0, (float)255.0 / (float)255.0);

        s7 = g7.GetComponent<SpriteRenderer>();
        s7.color = new Color((float)212.0 / (float)255.0, (float)119.0 / (float)255.0, (float)40.0 / (float)255.0, (float)255.0 / (float)255.0);

        s8 = g8.GetComponent<SpriteRenderer>();
        s8.color = new Color((float)206.0 / (float)255.0, (float)100.0 / (float)255.0, (float)40.0 / (float)255.0, (float)255.0 / (float)255.0);

        s9 = g9.GetComponent<SpriteRenderer>();
        s9.color = new Color((float)200.0 / (float)255.0, (float)81.0 / (float)255.0, (float)38.0 / (float)255.0, (float)255.0 / (float)255.0);

        s10 = g10.GetComponent<SpriteRenderer>();
        s10.color = new Color((float)195.0 / (float)255.0, (float)57.0 / (float)255.0, (float)38.0 / (float)255.0, (float)255.0 / (float)255.0);

        s11 = g11.GetComponent<SpriteRenderer>();
        s11.color = new Color((float)190.0 / (float)255.0, (float)32.0 / (float)255.0, (float)36.0 / (float)255.0, (float)255.0 / (float)255.0);

    }

    private void SecondCase()
    {
        s1 = g1.GetComponent<SpriteRenderer>();
        s1.color = new Color((float)236.0 / (float)255.0, (float)29.0 / (float)255.0, (float)36.0 / (float)255.0, (float)255.0 / (float)255.0);

        s2 = g2.GetComponent<SpriteRenderer>();
        s2.color = new Color((float)216.0 / (float)255.0, (float)32.0 / (float)255.0, (float)48.0 / (float)255.0, (float)255.0 / (float)255.0);

        s3 = g3.GetComponent<SpriteRenderer>();
        s3.color = new Color((float)199.0 / (float)255.0, (float)36.0 / (float)255.0, (float)61.0 / (float)255.0, (float)255.0 / (float)255.0);

        s4 = g4.GetComponent<SpriteRenderer>();
        s4.color = new Color((float)181.0 / (float)255.0, (float)39.0 / (float)255.0, (float)73.0 / (float)255.0, (float)255.0 / (float)255.0);

        s5 = g5.GetComponent<SpriteRenderer>();
        s5.color = new Color((float)164.0 / (float)255.0, (float)42.0 / (float)255.0, (float)85.0 / (float)255.0, (float)255.0 / (float)255.0);

        s6 = g6.GetComponent<SpriteRenderer>();
        s6.color = new Color((float)147.0 / (float)255.0, (float)44.0 / (float)255.0, (float)94.0 / (float)255.0, (float)255.0 / (float)255.0);

        s7 = g7.GetComponent<SpriteRenderer>();
        s7.color = new Color((float)130.0 / (float)255.0, (float)46.0 / (float)255.0, (float)104.0 / (float)255.0, (float)255.0 / (float)255.0);

        s8 = g8.GetComponent<SpriteRenderer>();
        s8.color = new Color((float)113.0 / (float)255.0, (float)46.0 / (float)255.0, (float)114.0 / (float)255.0, (float)255.0 / (float)255.0);

        s9 = g9.GetComponent<SpriteRenderer>();
        s9.color = new Color((float)94.0 / (float)255.0, (float)47.0 / (float)255.0, (float)123.0 / (float)255.0, (float)255.0 / (float)255.0);

        s10 = g10.GetComponent<SpriteRenderer>();
        s10.color = new Color((float)72.0 / (float)255.0, (float)48.0 / (float)255.0, (float)132.0 / (float)255.0, (float)255.0 / (float)255.0);

        s11 = g11.GetComponent<SpriteRenderer>();
        s11.color = new Color((float)48.0 / (float)255.0, (float)49.0 / (float)255.0, (float)143.0 / (float)255.0, (float)255.0 / (float)255.0);
    }

    private void ThirdCase()
    {
        s1 = g1.GetComponent<SpriteRenderer>();
        s1.color = new Color((float)229.0 / (float)255.0, (float)229.0 / (float)255.0, (float)230.0 / (float)255.0, (float)255.0 / (float)255.0);

        s2 = g2.GetComponent<SpriteRenderer>();
        s2.color = new Color((float)210.0 / (float)255.0, (float)211.0 / (float)255.0, (float)212.0 / (float)255.0, (float)255.0 / (float)255.0);

        s3 = g3.GetComponent<SpriteRenderer>();
        s3.color = new Color((float)191.0 / (float)255.0, (float)193.0 / (float)255.0, (float)194.0 / (float)255.0, (float)255.0 / (float)255.0);

        s4 = g4.GetComponent<SpriteRenderer>();
        s4.color = new Color((float)171.0 / (float)255.0, (float)174.0 / (float)255.0, (float)176.0 / (float)255.0, (float)255.0 / (float)255.0);

        s5 = g5.GetComponent<SpriteRenderer>();
        s5.color = new Color((float)153.0 / (float)255.0, (float)156.0 / (float)255.0, (float)158.0 / (float)255.0, (float)255.0 / (float)255.0);

        s6 = g6.GetComponent<SpriteRenderer>();
        s6.color = new Color((float)136.0 / (float)255.0, (float)139.0 / (float)255.0, (float)141.0 / (float)255.0, (float)255.0 / (float)255.0);

        s7 = g7.GetComponent<SpriteRenderer>();
        s7.color = new Color((float)119.0 / (float)255.0, (float)121.0 / (float)255.0, (float)123.0 / (float)255.0, (float)255.0 / (float)255.0);

        s8 = g8.GetComponent<SpriteRenderer>();
        s8.color = new Color((float)101.0 / (float)255.0, (float)102.0 / (float)255.0, (float)105.0 / (float)255.0, (float)255.0 / (float)255.0);

        s9 = g9.GetComponent<SpriteRenderer>();
        s9.color = new Color((float)81.0 / (float)255.0, (float)82.0 / (float)255.0, (float)84.0 / (float)255.0, (float)255.0 / (float)255.0);

        s10 = g10.GetComponent<SpriteRenderer>();
        s10.color = new Color((float)49.0 / (float)255.0, (float)49.0 / (float)255.0, (float)51.0 / (float)255.0, (float)255.0 / (float)255.0);

        s11 = g11.GetComponent<SpriteRenderer>();
        s11.color = new Color((float)0.0 / (float)255.0, (float)0.0 / (float)255.0, (float)0.0 / (float)255.0, (float)255.0 / (float)255.0);
    }

    private void FourthCase()
    {
        s1 = g1.GetComponent<SpriteRenderer>();
        s1.color = new Color((float)51.0 / (float)255.0, (float)178.0 / (float)255.0, (float)78.0 / (float)255.0, (float)255.0 / (float)255.0);


        s2 = g2.GetComponent<SpriteRenderer>();
        s2.color = new Color((float)49.0 / (float)255.0, (float)164.0 / (float)255.0, (float)88.0 / (float)255.0, (float)255.0 / (float)255.0);


        s3 = g3.GetComponent<SpriteRenderer>();
        s3.color = new Color((float)41.0 / (float)255.0, (float)151.0 / (float)255.0, (float)100.0 / (float)255.0, (float)255.0 / (float)255.0);


        s4 = g4.GetComponent<SpriteRenderer>();
        s4.color = new Color((float)38.0 / (float)255.0, (float)138.0 / (float)255.0, (float)110.0 / (float)255.0, (float)255.0 / (float)255.0);


        s5 = g5.GetComponent<SpriteRenderer>();
        s5.color = new Color((float)37.0 / (float)255.0, (float)126.0 / (float)255.0, (float)118.0 / (float)255.0, (float)255.0 / (float)255.0);


        s6 = g6.GetComponent<SpriteRenderer>();
        s6.color = new Color((float)42.0 / (float)255.0, (float)114.0 / (float)255.0, (float)124.0 / (float)255.0, (float)255.0 / (float)255.0);


        s7 = g7.GetComponent<SpriteRenderer>();
        s7.color = new Color((float)40.0 / (float)255.0, (float)102.0 / (float)255.0, (float)130.0 / (float)255.0, (float)255.0 / (float)255.0);


        s8 = g8.GetComponent<SpriteRenderer>();
        s8.color = new Color((float)38.0 / (float)255.0, (float)90.0 / (float)255.0, (float)134.0 / (float)255.0, (float)255.0 / (float)255.0);


        s9 = g9.GetComponent<SpriteRenderer>();
        s9.color = new Color((float)38.0 / (float)255.0, (float)78.0 / (float)255.0, (float)138.0 / (float)255.0, (float)255.0 / (float)255.0);


        s10 = g10.GetComponent<SpriteRenderer>();
        s10.color = new Color((float)44.0 / (float)255.0, (float)64.0 / (float)255.0, (float)139.0 / (float)255.0, (float)255.0 / (float)255.0);

        s11 = g11.GetComponent<SpriteRenderer>();
        s11.color = new Color((float)48.0 / (float)255.0, (float)49.0 / (float)255.0, (float)143.0 / (float)255.0, (float)255.0 / (float)255.0);
    }

    private void FifthCase()
    {
        s1 = g1.GetComponent<SpriteRenderer>();
        s1.color = new Color((float)44.0 / (float)255.0, (float)47.0 / (float)255.0, (float)115.0 / (float)255.0, (float)255.0 / (float)255.0);


        s2 = g2.GetComponent<SpriteRenderer>();
        s2.color = new Color((float)61.0 / (float)255.0, (float)62.0 / (float)255.0, (float)114.0 / (float)255.0, (float)255.0 / (float)255.0);


        s3 = g3.GetComponent<SpriteRenderer>();
        s3.color = new Color((float)80.0 / (float)255.0, (float)75.0 / (float)255.0, (float)114.0 / (float)255.0, (float)255.0 / (float)255.0);


        s4 = g4.GetComponent<SpriteRenderer>();
        s4.color = new Color((float)98.0 / (float)255.0, (float)90.0 / (float)255.0, (float)112.0 / (float)255.0, (float)255.0 / (float)255.0);


        s5 = g5.GetComponent<SpriteRenderer>();
        s5.color = new Color((float)117.0 / (float)255.0, (float)106.0 / (float)255.0, (float)110.0 / (float)255.0, (float)255.0 / (float)255.0);


        s6 = g6.GetComponent<SpriteRenderer>();
        s6.color = new Color((float)136.0 / (float)255.0, (float)123.0 / (float)255.0, (float)107.0 / (float)255.0, (float)255.0 / (float)255.0);


        s7 = g7.GetComponent<SpriteRenderer>();
        s7.color = new Color((float)157.0 / (float)255.0, (float)141.0 / (float)255.0, (float)101.0 / (float)255.0, (float)255.0 / (float)255.0);


        s8 = g8.GetComponent<SpriteRenderer>();
        s8.color = new Color((float)180.0 / (float)255.0, (float)162.0 / (float)255.0, (float)93.0 / (float)255.0, (float)255.0 / (float)255.0);


        s9 = g9.GetComponent<SpriteRenderer>();
        s9.color = new Color((float)205.0 / (float)255.0, (float)185.0 / (float)255.0, (float)79.0 / (float)255.0, (float)255.0 / (float)255.0);


        s10 = g10.GetComponent<SpriteRenderer>();
        s10.color = new Color((float)230.0 / (float)255.0, (float)210.0 / (float)255.0, (float)60.0 / (float)255.0, (float)255.0 / (float)255.0);


        s11 = g11.GetComponent<SpriteRenderer>();
        s11.color = new Color((float)254.0 / (float)255.0, (float)240.0 / (float)255.0, (float)28.0 / (float)255.0, (float)255.0 / (float)255.0);
    }

    private void SixthCase()
    {
        s1 = g1.GetComponent<SpriteRenderer>();

        s1.color = new Color((float)254.0 / (float)255.0, (float)240.0 / (float)255.0, (float)28.0 / (float)255.0, (float)255.0 / (float)255.0);

        s2 = g2.GetComponent<SpriteRenderer>();
        s2.color = new Color((float)241.0 / (float)255.0, (float)217.0 / (float)255.0, (float)63.0 / (float)255.0, (float)255.0 / (float)255.0);


        s3 = g3.GetComponent<SpriteRenderer>();
        s3.color = new Color((float)235.0 / (float)255.0, (float)196.0 / (float)255.0, (float)8.0 / (float)255.0, (float)255.0 / (float)255.0);


        s4 = g4.GetComponent<SpriteRenderer>();
        s4.color = new Color((float)210.0 / (float)255.0, (float)177.0 / (float)255.0, (float)105.0 / (float)255.0, (float)255.0 / (float)255.0);


        s5 = g5.GetComponent<SpriteRenderer>();
        s5.color = new Color((float)196.0 / (float)255.0, (float)159.0 / (float)255.0, (float)117.0 / (float)255.0, (float)255.0 / (float)255.0);


        s6 = g6.GetComponent<SpriteRenderer>();
        s6.color = new Color((float)182.0 / (float)255.0, (float)142.0 / (float)255.0, (float)126.0 / (float)255.0, (float)255.0 / (float)255.0);


        s7 = g7.GetComponent<SpriteRenderer>();
        s7.color = new Color((float)169.0 / (float)255.0, (float)126.0 / (float)255.0, (float)132.0 / (float)255.0, (float)255.0 / (float)255.0);


        s8 = g8.GetComponent<SpriteRenderer>();
        s8.color = new Color((float)158.0 / (float)255.0, (float)111.0 / (float)255.0, (float)137.0 / (float)255.0, (float)255.0 / (float)255.0);


        s9 = g9.GetComponent<SpriteRenderer>();
        s9.color = new Color((float)146.0 / (float)255.0, (float)96.0 / (float)255.0, (float)142.0 / (float)255.0, (float)255.0 / (float)255.0);


        s10 = g10.GetComponent<SpriteRenderer>();
        s10.color = new Color((float)136.0 / (float)255.0, (float)79.0 / (float)255.0, (float)145.0 / (float)255.0, (float)255.0 / (float)255.0);


        s11 = g11.GetComponent<SpriteRenderer>();
        s11.color = new Color((float)126.0 / (float)255.0, (float)62.0 / (float)255.0, (float)148.0 / (float)255.0, (float)255.0 / (float)255.0);
    }

    private void SeventhCase()
    {
        s1 = g1.GetComponent<SpriteRenderer>();
        s1.color = new Color((float)245.0 / (float) 255.0, (float)146 / (float)255.0, (float)38.0 / (float)255.0, (float)255.0 / (float)255.0);


        s2 = g2.GetComponent<SpriteRenderer>();
        s2.color = new Color((float)233.0 / (float)255.0, (float)133.0 / (float)255.0, (float)58.0 / (float)255.0, (float)255.0 / (float)255.0);


        s3 = g3.GetComponent<SpriteRenderer>();
        s3.color = new Color((float)203.0 / (float)255.0, (float)122.0 / (float)255.0, (float)75.0 / (float)255.0, (float)255.0 / (float)255.0);


        s4 = g4.GetComponent<SpriteRenderer>();
        s4.color = new Color((float)183.0 / (float)255.0, (float)111.0 / (float)255.0, (float)89.0 / (float)255.0, (float)255.0 / (float)255.0);


        s5 = g5.GetComponent<SpriteRenderer>();
        s5.color = new Color((float)163.0 / (float)255.0, (float)100.0 / (float)255.0, (float)99.0 / (float)255.0, (float)255.0 / (float)255.0);


        s6 = g6.GetComponent<SpriteRenderer>();
        s6.color = new Color((float)145.0 / (float)255.0, (float)91.0 / (float)255.0, (float)108.0 / (float)255.0, (float)255.0 / (float)255.0);


        s7 = g7.GetComponent<SpriteRenderer>();
        s7.color = new Color((float)126.0 / (float)255.0, (float)82.0 / (float)255.0, (float)116.0 / (float)255.0, (float)255.0 / (float)255.0);


        s8 = g8.GetComponent<SpriteRenderer>();
        s8.color = new Color((float)109.0 / (float)255.0, (float)73.0 / (float)255.0, (float)123.0 / (float)255.0, (float)255.0 / (float)255.0);


        s9 = g9.GetComponent<SpriteRenderer>();
        s9.color = new Color((float)90.0 / (float)255.0, (float)64.0 / (float)255.0, (float)130.0 / (float)255.0, (float)255.0 / (float)255.0);


        s10 = g10.GetComponent<SpriteRenderer>();
        s10.color = new Color((float)68.0 / (float)255.0, (float)56.0 / (float)255.0, (float)135.0 / (float)255.0, (float)255.0 / (float)255.0);


        s11 = g11.GetComponent<SpriteRenderer>();
        s11.color = new Color((float)48.0 / (float)255.0, (float)49.0 / (float)255.0, (float)143.0 / (float)255.0, (float)255.0 / (float)255.0);
    }

    private void EighthCase()
    {
        s1 = g1.GetComponent<SpriteRenderer>();
        s1.color = new Color((float)9.0 / (float)255.0, (float)173.0 / (float)255.0, (float)236.0 / (float)255.0, (float)255.0 / (float)255.0);


        s2 = g2.GetComponent<SpriteRenderer>();
        s2.color = new Color((float)5.0 / (float)255.0, (float)177.0 / (float)255.0, (float)219.0 / (float)255.0, (float)255.0 / (float)255.0);


        s3 = g3.GetComponent<SpriteRenderer>();
        s3.color = new Color((float)3.0 / (float)255.0, (float)182.0 / (float)255.0, (float)204.0 / (float)255.0, (float)255.0 / (float)255.0);


        s4 = g4.GetComponent<SpriteRenderer>();
        s4.color = new Color((float)30.0 / (float)255.0, (float)187.0 / (float)255.0, (float)188.0 / (float)255.0, (float)255.0 / (float)255.0);


        s5 = g5.GetComponent<SpriteRenderer>();
        s5.color = new Color((float)92.0 / (float)255.0, (float)193.0 / (float)255.0, (float)173.0 / (float)255.0, (float)255.0 / (float)255.0);


        s6 = g6.GetComponent<SpriteRenderer>();
        s6.color = new Color((float)127.0 / (float)255.0, (float)200.0 / (float)255.0, (float)156.0 / (float)255.0, (float)255.0 / (float)255.0);


        s7 = g7.GetComponent<SpriteRenderer>();
        s7.color = new Color((float)157.0 / (float)255.0, (float)207.0 / (float)255.0, (float)139.0 / (float)255.0, (float)255.0 / (float)255.0);


        s8 = g8.GetComponent<SpriteRenderer>();
        s8.color = new Color((float)184.0 / (float)255.0, (float)214.0 / (float)255.0, (float)119.0 / (float)255.0, (float)255.0 / (float)255.0);


        s9 = g9.GetComponent<SpriteRenderer>();
        s9.color = new Color((float)210.0 / (float)255.0, (float)222.0 / (float)255.0, (float)96.0 / (float)255.0, (float)255.0 / (float)255.0);


        s10 = g10.GetComponent<SpriteRenderer>();
        s10.color = new Color((float)234.0 / (float)255.0, (float)230.0 / (float)255.0, (float)66.0 / (float)255.0, (float)255.0 / (float)255.0);


        s11 = g11.GetComponent<SpriteRenderer>();
        s11.color = new Color((float)254.0 / (float)255.0, (float)240.0 / (float)255.0, (float)28.0 / (float)255.0, (float)255.0 / (float)255.0);
    }

    private void NinthCase()
    {
        s1 = g1.GetComponent<SpriteRenderer>();
        s1.color = new Color((float)235.0 / (float)255.0, (float)9.0 / (float)255.0, (float)136.0 / (float)255.0, (float)255.0 / (float)255.0);


        s2 = g2.GetComponent<SpriteRenderer>();
        s2.color = new Color((float)215.0 / (float)255.0, (float)59.0 / (float)255.0, (float)146.0 / (float)255.0, (float)255.0 / (float)255.0);


        s3 = g3.GetComponent<SpriteRenderer>();
        s3.color = new Color((float)196.0 / (float)255.0, (float)86.0 / (float)255.0, (float)158.0 / (float)255.0, (float)255.0 / (float)255.0);


        s4 = g4.GetComponent<SpriteRenderer>();
        s4.color = new Color((float)178.0 / (float)255.0, (float)104.0 / (float)255.0, (float)168.0 / (float)255.0, (float)255.0 / (float)255.0);


        s5 = g5.GetComponent<SpriteRenderer>();
        s5.color = new Color((float)158.0 / (float)255.0, (float)118.0 / (float)255.0, (float)178.0 / (float)255.0, (float)255.0 / (float)255.0);


        s6 = g6.GetComponent<SpriteRenderer>();
        s6.color = new Color((float)135.0 / (float)255.0, (float)129.0 / (float)255.0, (float)187.0 / (float)255.0, (float)255.0 / (float)255.0);


        s7 = g7.GetComponent<SpriteRenderer>();
        s7.color = new Color((float)107.0 / (float)255.0, (float)140.0 / (float)255.0, (float)197.0 / (float)255.0, (float)255.0 / (float)255.0);


        s8 = g8.GetComponent<SpriteRenderer>();
        s8.color = new Color((float)63.0 / (float)255.0, (float)148.0 / (float)255.0, (float)207.0 / (float)255.0, (float)255.0 / (float)255.0);


        s9 = g9.GetComponent<SpriteRenderer>();
        s9.color = new Color((float)16.0 / (float)255.0, (float)157.0 / (float)255.0, (float)217.0 / (float)255.0, (float)255.0 / (float)255.0);


        s10 = g10.GetComponent<SpriteRenderer>();
        s10.color = new Color((float)8.0 / (float)255.0, (float)165.0 / (float)255.0, (float)225.0 / (float)255.0, (float)255.0 / (float)255.0);


        s11 = g11.GetComponent<SpriteRenderer>();
        s11.color = new Color((float)9.0 / (float)255.0, (float)173.0 / (float)255.0, (float)236.0 / (float)255.0, (float)255.0 / (float)255.0);
    }

    private void TenthCase()
    {
        s1 = g1.GetComponent<SpriteRenderer>();
        s1.color = new Color((float)189.0 / (float)255.0, (float)30.0 / (float)255.0, (float)43.0 / (float)255.0, (float)255.0 / (float)255.0);


        s2 = g2.GetComponent<SpriteRenderer>();
        s2.color = new Color((float)190.0 / (float)255.0, (float)51.0 / (float)255.0, (float)51.0 / (float)255.0,  (float)255.0 / (float)255.0);



        s3 = g3.GetComponent<SpriteRenderer>();
        s3.color = new Color((float)191.0 / (float)255.0, (float)69.0 / (float)255.0, (float)61.0 / (float)255.0, (float)255.0 / (float)255.0);


        s4 = g4.GetComponent<SpriteRenderer>();
        s4.color = new Color((float)191.0 / (float)255.0, (float)85.0 / (float)255.0, (float)70.0 / (float)255.0,  (float)255.0 / (float)255.0);



        s5 = g5.GetComponent<SpriteRenderer>();
        s5.color = new Color((float)193.0 / (float)255.0, (float)99.0 / (float)255.0, (float)80.0 / (float)255.0, (float)255.0 / (float)255.0);



        s6 = g6.GetComponent<SpriteRenderer>();
        s6.color = new Color((float)193.0 / (float)255.0, (float)113.0 / (float)255.0, (float)91.0 / (float)255.0, (float)255.0 / (float)255.0);



        s7 = g7.GetComponent<SpriteRenderer>();
        s7.color = new Color((float)193.0 / (float)255.0, (float)126.0 / (float)255.0, (float)103.0 / (float)255.0,  (float)255.0 / (float)255.0);



        s8 = g8.GetComponent<SpriteRenderer>();
        s8.color = new Color((float)193.0 / (float)255.0, (float)138.0 / (float)255.0, (float)114.0 / (float)255.0,  (float)255.0 / (float)255.0);



        s9 = g9.GetComponent<SpriteRenderer>();
        s9.color = new Color((float)193.0 / (float)255.0, (float)151.0 / (float)255.0, (float)127.0 / (float)255.0, (float)255.0 / (float)255.0);



        s10 = g10.GetComponent<SpriteRenderer>();
        s10.color = new Color((float)193.0 / (float)255.0, (float)165.0 / (float)255.0, (float)140.0 / (float)255.0, (float)255.0 / (float)255.0);



        s11 = g11.GetComponent<SpriteRenderer>();
        s11.color = new Color((float)192.0 / (float)255.0, (float)179.0 / (float)255.0, (float)155.0 / (float)255.0, (float)255.0 / (float)255.0);
    }

    public void ColorChange()
    {
        i++;
        if (i <= 10)
        {
            switch (i)
            {
                case 1:
                    FirstCase();
                    break;
                case 2:
                    SecondCase();
                    break;
                case 3:
                    ThirdCase();
                    break;
                case 4:
                    FourthCase();
                    break;
                case 5:
                    FifthCase();
                    break;
                case 6:
                    SixthCase();
                    break;
                case 7:
                    SeventhCase();
                    break;
                case 8:
                    EighthCase();
                    break;
                case 9:
                    NinthCase();
                    break;
                case 10:
                    TenthCase();
                    break;
            }
        }
        else
        {
            i = 1;
            FirstCase();
            
        }
    }
}
