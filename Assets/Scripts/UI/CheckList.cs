using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckList : MonoBehaviour
{
    [SerializeField]
    Player player = null;

    [SerializeField]
    List<ItemAndState> todos = null;

    List<CheckListBox> boxes = new List<CheckListBox>();

    [SerializeField]
    CheckListBox boxPrefab = null;

    [SerializeField]
    GameEvent allDoneEvent = null;

    [SerializeField]
    GameEvent notAllDoneEvent = null;

    // Start is called before the first frame update
    void Start()
    {
        PopulateBoxes();
    }


    public void RunChecks()
    {
        int numChecks = todos.Count;

        for (int i = 0; i < numChecks; i++)
        {
            var todo = todos[i];
            if (todo.NewState == null)
            {
                boxes[i].IsDone = player.HasItem(todo.Item);
            }
            else
            {
                boxes[i].IsDone = player.IsItemInState(todo.Item, todo.NewState);
            }
        }

        foreach (var box in boxes)
        {
            if (!box.IsDone)
            {
                notAllDoneEvent.Invoke();
                return;
            }
        }

        allDoneEvent.Invoke();
    }

    public bool AreAllDone()
    {
        foreach (var box in boxes)
        {
            if (!box.IsDone)
            {
                return false;
            }
        }
        return true;
    }

    void PopulateBoxes()
    {
        foreach (var todo in todos)
        {
            var newBox = (CheckListBox)Instantiate(boxPrefab, transform);
            newBox.IsDone = false;
            newBox.SetText(todo);
            boxes.Add(newBox);
        }
    }
}
