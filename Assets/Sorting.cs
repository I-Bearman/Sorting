using UnityEngine;
using System;
using Random = System.Random;

public class Sorting : MonoBehaviour
{
    void Start()
    {
        int[] array = SetArray(100);
        WriteArray(array);
        Debug.Log("-----------Sorting-----------");

        float startTime = Time.realtimeSinceStartup;
        //BubbleSort(array);
        ChoiceSort(array);
        WriteArray(array);
        Debug.Log($"Sorting time is {(Time.realtimeSinceStartup - startTime).ToString("F8")} seconds");
    }

    private int[] SetArray(int length)
    {
        int[] arr = new int[length];
        Random rnd = new Random();

        for (int i = 0; i < length; i++)
        {
            arr[i] = rnd.Next(-100, 101);
        }

        return arr;
    }

    private void WriteArray(int[] arr)
    {
        foreach (int a in arr)
        {
            Debug.Log(a);
        }
    }

    private void BubbleSort(int[] arr)
    {
        int temp;
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr.Length - i - 1; j++)
            {
                if (arr[j] > arr[j+1])
                {
                    temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    private void ChoiceSort(int[] arr)
    {
        for (int i = 0; i < arr.Length-1; i++)
        {
            int min = arr[i];
            int minN = i;
            int temp;

            for (int j = i; j < arr.Length; j++)
            {
                if (arr[j] < min)
                {
                    minN = j;
                    min = arr[j];
                }
            }
            temp = arr[i];
            arr[i] = arr[minN];
            arr[minN] = temp;
        }
    }
}