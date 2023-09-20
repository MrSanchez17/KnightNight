using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DoorController : MonoBehaviour
{
    private Animator doorAnim;
    public GameObject objectCoins;
    public Transform nextLevel;
    public Transform startPlay;
    public UnityEvent DoorOpen;
    private int i; 
    private bool coinsDesactivated;
    public UnityEvent OnTouchDoor;
    private GameObject door2;
    private GameObject door3;

    

    // Start is called before the first frame update
    void Start()
    {
        doorAnim = GetComponent<Animator>();
        door2 = GameObject.Find("Coins 2");

        i = 0;
        coinsDesactivated =true;
    }

    // Update is called once per frame
    void Update()
    {
       
        while (i < objectCoins.transform.childCount && coinsDesactivated==true)
        {
            if (objectCoins.transform.GetChild(i).gameObject.activeInHierarchy)
            {
                coinsDesactivated = false;
            }
            i++;
          
        }

        if (coinsDesactivated)
        {
            doorAnim.SetInteger("state", 1);
            DoorOpen.Invoke();
            Debug.Log("puerta abierta");
        }
        else
        {
            coinsDesactivated = true;
            i=0;
        }
        
    }

    public void Resetcoins(GameObject objectCoins)
    {
        for(int i = 0; i < objectCoins.transform.childCount;i++)
        {
            GameObject son = objectCoins.transform.GetChild(i).gameObject;

            if(!son.activeSelf)
            {
                son.SetActive(true);
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        Camera.main.transform.SetPositionAndRotation(nextLevel.transform.position, nextLevel.transform.rotation);
        GameObject player = GameObject.Find("Hollow");
        player.transform.SetPositionAndRotation(startPlay.transform.position, startPlay.transform.rotation);
        OnTouchDoor.Invoke();
    }

    public void RestartDoor()
    {
        doorAnim.SetInteger("state",0);
        coinsDesactivated = false;
        i=0;

    }

    public void OpenDoor()
    {
        doorAnim.SetInteger("state",1);

    }


}
