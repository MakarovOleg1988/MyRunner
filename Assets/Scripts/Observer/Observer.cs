using System;
using System.IO;
using UnityEngine;

namespace MyRunner
{
    public class Observer : MonoBehaviour, IEventManager
{
    string _action = "";

    private void Start()
    {
        IEventManager._onSetButton += OnCreateFile;
    }

    private void OnCreateFile()
    {
        _action = "Start Game" + " " + DateTime.Now;
    }

    public void SaveStartGame()
    {
        var action = _action;
        var _file = Environment.CurrentDirectory + "//LogFile.txt";
        using (var _stream = File.Create(_file))
        {
            using (var _writer = new StreamWriter(_stream))
            {
                _writer.WriteLine(action);
            }
            _stream.Close();
        }
    }
}
}
