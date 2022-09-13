using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tweener : MonoBehaviour
{

    //private Tween activeTween;
    private List<Tween> activeTweens = new List<Tween>();

    float t;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        for (int i=0; i < activeTweens.Count; i++)
        {
            float distance = Vector3.Distance(activeTweens[i].Target.position, activeTweens[i].EndPos);
            if (distance > 0.1f) //if activeTween.Target is futher than 0.1f units away from the activeTween.EndPos,
            {
                //lerp towards the EndPos
                //Debug.Log("Lerping");
                t = ((Time.time - activeTweens[i].StartTime)/activeTweens[i].Duration);
                activeTweens[i].Target.position = Vector3.Lerp(activeTweens[i].StartPos, activeTweens[i].EndPos, t*t*t); /*figure out the value for interpolating between start and end*/

            }
            else if ( distance <= 0.1f)
            {
                //set activeTween.Target.position = activeTween.EndPos
                activeTweens[i].Target.position = activeTweens[i].EndPos;
                //and null the activeTween variable.
                //activeTween = null;
                activeTweens.RemoveAt(i);
            }
        }
    }

    public bool TweenExists(Transform target){
      //if activeTweens list contains target, return true, otherwise return false
      for (int i=0; i < activeTweens.Count; i++){
        if (activeTweens[i].Target == target){
          return true;
        }
      }
      return false;
    }

    public bool AddTween(Transform targetObject, Vector3 startPos, Vector3 endPos, float duration)
    {
        if (TweenExists(targetObject) == false){
            activeTweens.Add(new Tween(targetObject, startPos, endPos, Time.time, duration));
            return true;
        }
        return false;
    }
}
