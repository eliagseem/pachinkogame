using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalScript : MonoBehaviour {

    public GameObject ScoreKeeping;

    void OnCollisionEnter(Collision col)
    {
        var gameObjectTag = gameObject.tag;
        if (col.collider.tag.Equals("PachinkoBall"))
        {
            var score = 0;
            if (gameObjectTag.Equals("GoalOne"))
                score++;
            else if (gameObjectTag.Equals("GoalTwo"))
                score += 2;
            else if (gameObjectTag.Equals("GoalThree")) //I know I could just have an else here but maybe more slots would be added so check anyway
                score += 3;

            ScoreKeeping.GetComponent<ScoreKeeping>().Score += score;
            Destroy(col.collider.gameObject);
        }
    }
}
