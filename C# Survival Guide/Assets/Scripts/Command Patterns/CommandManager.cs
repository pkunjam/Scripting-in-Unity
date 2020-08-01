using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CommandManager : MonoBehaviour {

    private static CommandManager _instance;

    public static CommandManager Instance
    {
        get
        {
            if (_instance == null)
            {
                Debug.LogError("Command Manager is NULL");
            }

            return _instance;
        }
    }

    private List<ICommand> _commandBuffer = new List<ICommand>();

	void Awake ()
    {
        _instance = this;
	}

    public void AddCommand(ICommand command)
    {
        _commandBuffer.Add(command);
    }

    public void Play()
    {
        StartCoroutine(PlayRoutine());
    }

    IEnumerator PlayRoutine()
    {
        foreach (var command in _commandBuffer)
        {
            command.Execute();
            yield return new WaitForSeconds(1);
        }
    }

    public void Rewind()
    {
        StartCoroutine(RewindRoutine());
    }

    IEnumerator RewindRoutine()
    {
        foreach (var command in Enumerable.Reverse(_commandBuffer))
        {
            command.Undo();
            yield return new WaitForSeconds(1);
        }
    }

    public void Done()
    {
        var cubes = GameObject.FindGameObjectsWithTag("Cube");

        foreach (var cube in cubes)
        {
            cube.GetComponent<MeshRenderer>().material.color = Color.white;
        }
    }

    public void Reset()
    {
        _commandBuffer.Clear();
    }
}
