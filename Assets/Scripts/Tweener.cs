using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tweener : MonoBehaviour
{

    private Tween activeTween;
    float t;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (activeTween != null)
        {
            float distance = Vector3.Distance(activeTween.Target.position, activeTween.EndPos);
            if (distance > 0.1f) //if activeTween.Target is futher than 0.1f units away from the activeTween.EndPos,
            {
                //lerp towards the EndPos
                //Debug.Log("Lerping");
                t = ((Time.time - activeTween.StartTime)/activeTween.Duration);
                activeTween.Target.position = Vector3.Lerp(activeTween.StartPos, activeTween.EndPos, t*t*t); /*figure out the value for interpolating between start and end*/

            }
            else if ( distance <= 0.1f)
            {
                //set activeTween.Target.position = activeTween.EndPos
                activeTween.Target.position = activeTween.EndPos;
                //and null the activeTween variable.
                activeTween = null;
            }
        }
    }

    public void AddTween(Transform targetObject, Vector3 startPos, Vector3 endPos, float duration)
    {
        if ((activeTween) == null){
            activeTween = new Tween(targetObject, startPos, endPos, Time.time, duration);
        }
    }
}
