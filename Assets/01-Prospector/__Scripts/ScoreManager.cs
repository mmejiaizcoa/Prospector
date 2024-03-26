using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// An enum to handle all the possible scoring events
public enum eScoreEvent
{
    draw,
    mine,
    mineGold,
    gameWin,
    gameLoss
}
// ScoreManager handles all of the scoring
public class ScoreManager : MonoBehaviour
{ // a
    static private ScoreManager S; // b
    static public int SCORE_FROM_PREV_ROUND = 0;
    static public int HIGH_SCORE = 0;
    [Header("Set Dynamically")]
    // Fields to track score info
    public int chain = 0;
    public int scoreRun = 0;
    public int score = 0;
    v
    PlayerPrefs.SetInt("ProspectorHighScore", score);
} else
{
    print("Your final score for the game was: " + score);
}
break;
default:
print("score: " + score + " scoreRun:" + scoreRun + " chain:" + chain);
break;
}
}
static public int CHAIN { get { return S.chain; } } // e
static public int SCORE { get { return S.score; } }
static public int SCORE_RUN { get { return S.scoreRun; } }
}
