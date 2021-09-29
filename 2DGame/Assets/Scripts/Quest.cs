using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct Quest
{
    private List<QuestObject> _questObjects;

    private string _questText;
    private bool _isQuestWithObjects;


    public Quest(List<QuestObject> questObjects, string questText)
    {
        this._questObjects = questObjects;
        this._questText = questText;
        _isQuestWithObjects = true;
    }

    public Quest(string questText)
    {
        this._questText = questText;
        _isQuestWithObjects = false;
        _questObjects = null;
    }


    /**
     * returns -1 if nothing in the Quest changes
     * returns n if one Object gets completed
     * return  0 if all Objects are completed
     */
    public int CheckQuestStatus()
    {
        if (_isQuestWithObjects)
        {
            int n = 0;
            bool allCompleted = true;
            List<QuestObject> toRemove = new List<QuestObject>();
            foreach (var q in _questObjects)
            {
                if (q.GetInactive())
                {
                    n++;
                    toRemove.Add(q);
                }
                else
                {
                    allCompleted = false;
                }
            }

            foreach (var q in toRemove)
            {
                _questObjects.Remove(q);
            }
            
            
            if (n>0)
            {
                if (allCompleted)
                {
                    return 0;
                }
                return n;
            }
        }

        return -1;
    }



    public string GetQuestText()
    {
        return _questText;
    }

}
