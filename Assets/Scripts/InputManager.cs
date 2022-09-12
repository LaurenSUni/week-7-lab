using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{

    [SerializeField]
    private GameObject item;

    private Tweener tweener;

    // Start is called before the first frame update
    void Start()
    {
        tweener = gameObject.GetComponent<Tweener>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Vector3 endPos = new Vector3(-2.0f, 0.5f, 0.0f);
            tweener.AddTween(item.transform, item.transform.position, endPos, 1.5f); //(Transform targetObject, Vector3 startPos, Vector3 endPos, float duration)
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            Vector3 endPos = new Vector3(2.0f, 0.5f, 0.0f);
            tweener.AddTween(item.transform, item.transform.position, endPos, 1.5f); //(Transform targetObject, Vector3 startPos, Vector3 endPos, float duration)
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            Vector3 endPos = new Vector3(0.0f, 0.5f, -2.0f);
            tweener.AddTween(item.transform, item.transform.position, endPos, 0.5f); //(Transform targetObject, Vector3 startPos, Vector3 endPos, float duration)
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            Vector3 endPos = new Vector3(0.0f, 0.5f, 2.0f);
            tweener.AddTween(item.transform, item.transform.position, endPos, 0.5f); //(Transform targetObject, Vector3 startPos, Vector3 endPos, float duration)
        }
    }
}
