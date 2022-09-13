using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{

    [SerializeField]
    private GameObject item;

    private Tweener tweener;

    private List<GameObject> itemList = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        tweener = gameObject.GetComponent<Tweener>();
        itemList.Add(item);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
            //clone the "item" game object and put the clone at (0,0.5,0) and add clone to the itemList
            itemList.Add(Instantiate(item, new Vector3(0f, 0.5f, 0f), Quaternion.identity));
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            Vector3 endPos = new Vector3(-2.0f, 0.5f, 0.0f);
            //tweener.AddTween(item.transform, item.transform.position, endPos, 1.5f); //(Transform targetObject, Vector3 startPos, Vector3 endPos, float duration)
            for (int i=0; i < itemList.Count; i++){
            //loop through the itemList and attempt to add a new tween
              //if AddTween() returns true, break out of the loop
              if (tweener.AddTween(itemList[i].transform, itemList[i].transform.position, endPos, 1.5f) == true){
                //break out of loop
                break;
              }
              //if AddTween() returns false for all items then do nothing
            }
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            Vector3 endPos = new Vector3(2.0f, 0.5f, 0.0f);
             //(Transform targetObject, Vector3 startPos, Vector3 endPos, float duration)
            for (int i=0; i < itemList.Count; i++){
            //loop through the itemList and attempt to add a new tween
              //if AddTween() returns true, break out of the loop
              if (tweener.AddTween(itemList[i].transform, itemList[i].transform.position, endPos, 1.5f) == true){
                //break out of loop
                break;
              }
              //if AddTween() returns false for all items then do nothing
            }
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            Vector3 endPos = new Vector3(0.0f, 0.5f, -2.0f);
            for (int i=0; i < itemList.Count; i++){
            //loop through the itemList and attempt to add a new tween
              //if AddTween() returns true, break out of the loop
              if (tweener.AddTween(itemList[i].transform, itemList[i].transform.position, endPos, 0.5f) == true){
                //break out of loop
                break;
              }
              //if AddTween() returns false for all items then do nothing
            }
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            Vector3 endPos = new Vector3(0.0f, 0.5f, 2.0f);
            for (int i=0; i < itemList.Count; i++){
            //loop through the itemList and attempt to add a new tween
              //if AddTween() returns true, break out of the loop
              if (tweener.AddTween(itemList[i].transform, itemList[i].transform.position, endPos, 0.5f) == true){
                //break out of loop
                break;
              }
              //if AddTween() returns false for all items then do nothing
            }
        }
    }
}
