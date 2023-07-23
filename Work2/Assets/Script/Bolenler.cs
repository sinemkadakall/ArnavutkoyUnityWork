using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bolenler : MonoBehaviour
{

    void bolenleriBul(int ilksayi,int ikincisayi)
    {
        string sayilar = "";
        string ikiyeBoluneneler = "";
        string uceBoluneneler = "";
        string dordeBoluneneler = "";
        string beseBoluneneler = "";

        ArrayList listem=new ArrayList();

        for (int i = ilksayi; i <= ikincisayi; i++)
        {
          listem.Add(i);
        }  
        foreach (int sayi in listem)
        {
            sayilar += " " + sayi;
            if (sayi % 2 == 0)
            {
                ikiyeBoluneneler += " "+ sayi;
            }
            if (sayi % 3 == 0)
            {
                uceBoluneneler += " " + sayi;
            }
            if (sayi % 4 == 0)
            {
                dordeBoluneneler += " " + sayi;
            }
            if (sayi % 5 == 0)
            {
                beseBoluneneler += " " + sayi;
            }
        }
        print("Tüm sayilar =>" + sayilar);
        print("İkiye bolunenler =>" + ikiyeBoluneneler);
        print("Uce bolunenler =>" + uceBoluneneler);
        print("Dorde bolunenler =>" + dordeBoluneneler);
        print("Bese bolunenler =>" + beseBoluneneler);
    }

    void Start()
    {
        bolenleriBul(12,20);
    }


    
}
