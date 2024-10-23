using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Overloading : MonoBehaviour
{
    [SerializeField]
    private int timePassed;
    private int age = 0;
    private void Start()
    {
        ChangeYear(ref age);
        Debug.Log(age);
        ChangeYear(ref age,timePassed);
        Debug.Log(age);
    }
    public void ChangeYear(ref int currentAge)
    {
        
        currentAge = currentAge + 1; //du kan også vælge at skrive currentAge++; i stedet for 
    }

    public void ChangeYear(ref int currentAge,int change)
    {
        currentAge += change;
    }
}
