using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car_change : MonoBehaviour
{
    public GameObject carOne;
    public GameObject carTwo;
    public GameObject carThree;
    public GameObject carFour;
    public GameObject carFive;

    public GameObject panel;
    // Start is called before the first frame update

    public void carOne_1Button()
    {
        carOne.SetActive(true);
        carTwo.SetActive(false);
        carThree.SetActive(false);
        carFour.SetActive(false);
        carFive.SetActive(false);
        panel.SetActive(false);
    }
    public void carTwo_1Button()
    {
        carOne.SetActive(false);
        carTwo.SetActive(true);
        carThree.SetActive(false);
        carFour.SetActive(false);
        carFive.SetActive(false);
        panel.SetActive(false);
    }
    public void carThree_1Button()
    {
        carOne.SetActive(false);
        carTwo.SetActive(false);
        carThree.SetActive(true);
        carFour.SetActive(false);
        carFive.SetActive(false);
        panel.SetActive(false);
    }
    public void carFour_1Button()
    {
        carOne.SetActive(false);
        carTwo.SetActive(false);
        carThree.SetActive(false);
        carFour.SetActive(true);
        carFive.SetActive(false);
        panel.SetActive(false);
    }
    public void carFive_1Button()
    {
        carOne.SetActive(false);
        carTwo.SetActive(false);
        carThree.SetActive(false);
        carFour.SetActive(false);
        carFive.SetActive(true);
        panel.SetActive(false);
    }


    void Start()
    {
        carOne.SetActive(false);
        carTwo.SetActive(false);
        carThree.SetActive(false);
        carFour.SetActive(false);
        carFive.SetActive(false);
        panel.SetActive(true);
    }


    // Update is called once per frame
    void Update()
    {
        
    }

}
