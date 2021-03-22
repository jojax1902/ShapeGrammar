using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rule : MonoBehaviour
{

    public GameObject rule;

    void Start() //At the generation of this layer generate the next layer
    {
        if (rule != null) //If there is no next layer 
        {
            GameObject obj = nextRule(rule);                       //
            if (obj != null)                                       //
            {                                                      //
                GameObject next = Instantiate(obj) as GameObject;  //
                next.transform.parent = transform;                 //
                resetTransform(next);                              //
            }                                                      //
        }                                                          //
    }                                                              //


    public GameObject nextRule(GameObject rule)                    //Determines the layer to generate next at random
    {                                                              //
        List<GameObject> rules = new List<GameObject>();           //
        foreach (Transform t in rule.transform)                    // The options for the next layer are sorted by their transform components
        {                                                          //
            rules.Add(t.gameObject);                               //
        }                                                          //
        if (rules.Count > 0)                                       //
        {                                                          //
            return rules[Random.Range(0, rules.Count)];            //Returns a randomly selected layer from the list of next layer
        }                                                          //
        return null;                                               //If there are no more rules to add instantiate nothing  
    }

    public void resetTransform(GameObject obj)
    {
        obj.transform.localPosition = Vector3.zero;
        obj.transform.localRotation = Quaternion.identity;
        obj.transform.localScale = Vector3.one;
    }
}
